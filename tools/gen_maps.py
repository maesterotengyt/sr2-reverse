import os, re, glob, collections, json, sys

REPO = r"E:\xbox\Speedrunners 2- King of Speed\sr2-reverse"
EXP = r"E:\xbox\Speedrunners 2- King of Speed\RE\assets_export\ExportedProject\Assets"
DEC = r"E:\xbox\Speedrunners 2- King of Speed\RE\decoded_quantumdb"
OUT = os.path.join(REPO, "docs", "maps")
os.makedirs(OUT, exist_ok=True)

# guid -> script class name
guid2cls = {}
for m in glob.glob(os.path.join(EXP, "Scripts", "**", "*.cs.meta"), recursive=True):
    t = open(m, encoding="utf-8", errors="replace").read()
    g = re.search(r"guid: (\w+)", t)
    if g:
        guid2cls[g.group(1)] = os.path.basename(m)[:-8]
# prefab guid -> name (for PrefabInstance sources)
guid2asset = {}
for m in glob.glob(os.path.join(EXP, "**", "*.prefab.meta"), recursive=True):
    t = open(m, encoding="utf-8", errors="replace").read()
    g = re.search(r"guid: (\w+)", t)
    if g:
        guid2asset[g.group(1)] = os.path.basename(m)[:-12]

def scene_stats(path):
    txt = open(path, encoding="utf-8", errors="replace").read()
    docs = re.split(r"\n--- !u!", txt)
    names = collections.Counter()
    scripts = collections.Counter()
    prefabs = collections.Counter()
    nobj = 0
    ncomp = collections.Counter()
    for d in docs:
        head = d.split("\n", 1)[0]
        cid = head.split(" ")[0] if head else ""
        ncomp[cid] += 1
        if cid.startswith("1 ") or cid == "1":
            pass
        if re.match(r"^1 &", d) or d.startswith("1 &"):
            nobj += 1
            m = re.search(r"\n  m_Name: (.*)", d)
            if m:
                names[re.sub(r"[ _]*\(?\d+\)?$", "", m.group(1)).strip() or "(unnamed)"] += 1
        if re.match(r"^114 &", d):
            g = re.search(r"m_Script: \{fileID: \d+, guid: (\w+)", d)
            if g:
                scripts[guid2cls.get(g.group(1), "?" + g.group(1)[:8])] += 1
        if re.match(r"^1001 &", d):
            g = re.search(r"m_SourcePrefab: \{fileID: \d+, guid: (\w+)", d)
            if g:
                prefabs[guid2asset.get(g.group(1), "?" + g.group(1)[:8])] += 1
    return dict(gameobjects=nobj, names=names, scripts=scripts, prefabs=prefabs, size=len(txt))

def map_stats(path):
    t = open(path, encoding="utf-8", errors="replace").read()
    ws = re.search(r"WorldSize: (\d+)", t)
    cols = re.findall(r"^    - Rotation: .*?\n      Position:\n        X: (-?[\d.e-]+)\n        Y: (-?[\d.e-]+)\n.*?      Layer: (\d+)\n      ShapeType: (\d+)", t, re.M | re.S)
    names = re.findall(r"        Name: (.*)", t)
    xs = [float(c[0]) for c in cols]
    ys = [float(c[1]) for c in cols]
    layers = collections.Counter(c[2] for c in cols)
    shapes = collections.Counter(c[3] for c in cols)
    nm = collections.Counter(re.sub(r"[ _]*\(?\d+\)?$", "", n) for n in names)
    return dict(world=ws.group(1) if ws else "?", n=len(cols),
                xr=(min(xs), max(xs)) if xs else None, yr=(min(ys), max(ys)) if ys else None,
                layers=layers, shapes=shapes, names=nm)

LAYERS = {0: "Default", 1: "TransparentFX", 2: "Ignore Raycast", 3: "Character", 4: "Water", 5: "UI", 6: "Stage",
          7: "ThinPlatform", 8: "Wall", 9: "Ceiling", 10: "TrapDoor", 11: "UINoPost"}
SHAPES = {0: "circle", 1: "box", 2: "polygon", 3: "edge"}

def top(c, n=25):
    return ", ".join(f"{k} x{v}" for k, v in c.most_common(n))

index_rows = []
for sdir in sorted(os.listdir(os.path.join(EXP, "Stages"))):
    p = os.path.join(EXP, "Stages", sdir)
    if not os.path.isdir(p):
        continue
    md = [f"# Stage: {sdir}\n"]
    sd = glob.glob(os.path.join(p, "*StageData.asset"))
    layouts = []
    if sd:
        t = open(sd[0], encoding="utf-8", errors="replace").read()
        g = lambda k: (re.search(rf"^  {k}: (.*)$", t, re.M) or [None, "?"])[1]
        md.append(f"- StageID: `{re.search(r'StageID:\n    Value: (.*)', t).group(1) if re.search(r'StageID:\n    Value: (.*)', t) else sdir}`")
        md.append(f"- Type: {g('Type')}  (StageType enum)")
        md.append(f"- Music: {g('MusicID')}   Locked by default: {g('Locked')}")
        layouts = re.findall(r"LayoutID: (\S+)", t)
        md.append(f"- Layouts: {', '.join(layouts)} ({len(layouts)})")
        md.append(f"- BlacklistedFromRandom flags: {re.findall(r'BlacklistedFromRandom: (\\d)', t)}")
        md.append("")
    scenes = sorted(glob.glob(os.path.join(p, "Scenes", "*.unity")))
    md.append(f"## Scenes ({len(scenes)})\n")
    total_go = 0
    for sc in scenes:
        st = scene_stats(sc)
        total_go += st["gameobjects"]
        md.append(f"### {os.path.basename(sc)}  ({st['gameobjects']} GameObjects, {st['size']//1024} KB)")
        if st["scripts"]:
            md.append("**Scripts/components in scene:** " + top(st["scripts"], 40))
        if st["prefabs"]:
            md.append("\n**Prefab instances:** " + top(st["prefabs"], 40))
        md.append("\n**Most common object names:** " + top(st["names"], 30) + "\n")
    # quantum map data
    mdir = os.path.join(DEC, "Stages", sdir, "MapAssets")
    cdir = os.path.join(DEC, "Stages", sdir, "Camera")
    maprows = []
    if os.path.isdir(mdir):
        md.append("## Quantum map data (static collision)\n")
        for mf in sorted(glob.glob(os.path.join(mdir, "*_MapData.txt"))):
            ms = map_stats(mf)
            md.append(f"### {os.path.basename(mf)}")
            md.append(f"- World size: {ms['world']}   static 2D colliders: **{ms['n']}**")
            if ms["xr"]:
                md.append(f"- Collider position range: X {ms['xr'][0]:.1f}..{ms['xr'][1]:.1f}  (span {ms['xr'][1]-ms['xr'][0]:.1f}),  Y {ms['yr'][0]:.1f}..{ms['yr'][1]:.1f}  (span {ms['yr'][1]-ms['yr'][0]:.1f})")
            md.append("- Physics layers: " + ", ".join(f"{LAYERS.get(int(k), k)} x{v}" for k, v in ms["layers"].most_common()))
            md.append("- Shapes: " + ", ".join(f"{SHAPES.get(int(k), k)} x{v}" for k, v in ms["shapes"].most_common()))
            md.append("- Collider kinds: " + top(ms["names"], 30) + "\n")
            maprows.append((os.path.basename(mf), ms))
    if os.path.isdir(cdir):
        md.append("## Camera data files: " + ", ".join(os.listdir(cdir)) + "\n")
    # other folders summary
    sub = {d: sum(len(f) for _, _, f in os.walk(os.path.join(p, d))) for d in os.listdir(p) if os.path.isdir(os.path.join(p, d))}
    md.append("## Asset folders (file counts incl. .meta)\n" + ", ".join(f"{k}: {v}" for k, v in sub.items()) + "\n")
    with open(os.path.join(OUT, f"{sdir}.md"), "w", encoding="utf-8") as f:
        f.write("\n".join(md))
    index_rows.append((sdir, len(layouts), len(scenes), total_go, sum(m[1]["n"] for m in maprows)))

with open(os.path.join(OUT, "README.md"), "w", encoding="utf-8") as f:
    f.write("# Maps / stages overview\n\nGenerated from the exported Unity project + Quantum map data.\n\n")
    f.write("| Stage | Layouts | Scenes | GameObjects (all scenes) | Static 2D colliders |\n|---|---|---|---|---|\n")
    for r in index_rows:
        f.write(f"| [{r[0]}]({r[0]}.md) | {r[1]} | {r[2]} | {r[3]} | {r[4]} |\n")
print(index_rows)
