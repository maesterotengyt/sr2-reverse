import os, re, glob, collections

REPO = r"E:\xbox\Speedrunners 2- King of Speed\sr2-reverse"
DEC = r"E:\xbox\Speedrunners 2- King of Speed\RE\decoded_quantumdb"
D = os.path.join(REPO, "docs")
for sub in ("characters", "items", "states", "modes"):
    os.makedirs(os.path.join(D, sub), exist_ok=True)

def rd(p):
    return open(p, encoding="utf-8", errors="replace").read()

NOISE = re.compile(r"^\s*(%YAML|%TAG|---|MonoBehaviour:|m_Name|Identifier:|Path:|Guid:|Hash:)")

# guid -> (relpath) for every asset, from "Value:" right after Guid:
id2name = {}
for p in glob.glob(os.path.join(DEC, "**", "*.txt"), recursive=True):
    t = rd(p)
    m = re.search(r"Identifier:\n\s+Path: (.*)\n\s+Guid:\n\s+Value: (-?\d+)", t)
    if m:
        id2name[m.group(2)] = m.group(1).split("/")[-1]

def flat(path):
    """settings -> {dotted.key: value}"""
    out = {}
    stack = []
    for l in rd(path).split("\n"):
        if NOISE.match(l) or not l.strip():
            continue
        ind = len(l) - len(l.lstrip())
        s = l.strip()
        while stack and stack[-1][0] >= ind:
            stack.pop()
        if s.startswith("- "):
            s = s[2:]
        if ":" in s:
            k, _, v = s.partition(":")
            v = v.strip()
            if v == "":
                stack.append((ind, k))
            else:
                out[".".join(x[1] for x in stack) + ("." if stack else "") + k] = v
    return out

# ---------------- characters ----------------
base_dir = os.path.join(DEC, "BaseEntities", "CharacterBase", "DataFiles")
KINDS = ["Physics Data", "Combat Data", "Game Entity Data", "Moveset Limiter Data", "State Machine Data"]
base = {k: flat(os.path.join(base_dir, f"CharacterBase {k}.txt")) for k in KINDS}

chars = sorted(os.listdir(os.path.join(DEC, "Characters")))
idx = ["# Characters\n", "Each character overrides CharacterBase data. Diffs below are vs CharacterBase (decoded decimals).\n",
       "| Character | Costumes | Own state folders | Physics diffs | Combat diffs | Entity diffs | Moveset diffs |", "|---|---|---|---|---|---|---|"]
for c in chars:
    cdir = os.path.join(DEC, "Characters", c)
    ddir = os.path.join(cdir, "DataFiles")
    costumes = len(glob.glob(os.path.join(cdir, "Costumes", "*PrefabEntityPrototype.txt")))
    states = sorted(os.listdir(os.path.join(ddir, "States"))) if os.path.isdir(os.path.join(ddir, "States")) else []
    md = [f"# Character: {c}\n", f"- Costume prototypes: {costumes}", f"- Overridden/own states ({len(states)}): {', '.join(states) or 'none'}"]
    anims = sorted(glob.glob(os.path.join(ddir, "Animations", "*.txt")))
    md.append(f"- Animation clip data files: {len(anims)}: " + ", ".join(os.path.basename(a)[:-4] for a in anims) + "\n")
    counts = []
    for k in KINDS:
        f = os.path.join(ddir, f"{c} {k}.txt")
        if not os.path.exists(f):
            counts.append("-")
            md.append(f"## {k}: (no file)\n")
            continue
        mine = flat(f)
        diffs = []
        for key in sorted(set(mine) | set(base[k])):
            if key.startswith("Identifier") or "Guid" in key:
                continue
            a, b = base[k].get(key), mine.get(key)
            if a != b:
                diffs.append((key, a, b))
        counts.append(str(len(diffs)))
        md.append(f"## {k}: {len(diffs)} differences vs CharacterBase\n")
        if diffs:
            md.append("| field | CharacterBase | " + c + " |\n|---|---|---|")
            for key, a, b in diffs[:400]:
                md.append(f"| `{key}` | {a} | {b} |")
        md.append("")
    with open(os.path.join(D, "characters", f"{c}.md"), "w", encoding="utf-8") as f:
        f.write("\n".join(md))
    idx.append(f"| [{c}]({c}.md) | {costumes} | {len(states)} | " + " | ".join(counts[:4]) + " |")
open(os.path.join(D, "characters", "README.md"), "w", encoding="utf-8").write("\n".join(idx))

# ---------------- state machine ----------------
def beh_name(i):
    return id2name.get(i, f"?{i}")

def state_doc(sdir):
    out = []
    for sp in sorted(glob.glob(os.path.join(sdir, "*", "* State.txt")) + glob.glob(os.path.join(sdir, "*", "*State*.txt"))):
        pass
    return out

state_root = os.path.join(base_dir, "States")
md = ["# CharacterBase state machine\n",
      "Each folder is a state. A state has default behaviours (run every frame of the state) and inherited groups (event-driven condition -> behaviour lists).\n"]
for st in sorted(os.listdir(state_root)):
    sd = os.path.join(state_root, st)
    files = [f for f in glob.glob(os.path.join(sd, "*.txt"))]
    behs = sorted(os.listdir(os.path.join(sd, "Behaviours"))) if os.path.isdir(os.path.join(sd, "Behaviours")) else []
    md.append(f"## {st}")
    for f in files:
        t = rd(f)
        name = re.search(r"Name:\n\s+Value: (.*)", t)
        md.append(f"- state asset: `{os.path.basename(f)}` (name: {name.group(1) if name else '?'})")
        defaults = re.search(r"DefaultBehaviours:\n((?:\s+- Id:\n\s+Value: -?\d+\n)+)", t)
        if defaults:
            ids = re.findall(r"Value: (-?\d+)", defaults.group(1))
            md.append(f"  - default behaviours ({len(ids)}): " + ", ".join(f"`{beh_name(i)}`" for i in ids))
        groups = re.findall(r"- Name:\n\s+Value: (.*)\n\s+EventToReact: (\d+)", t)
        if groups:
            md.append("  - event groups: " + ", ".join(f"{g[0]}(event {g[1]})" for g in groups))
    md.append(f"- behaviour files ({len(behs)}): " + ", ".join(b[:-4] for b in behs))
    md.append("")
open(os.path.join(D, "states", "CharacterBase_states.md"), "w", encoding="utf-8").write("\n".join(md))

# ---------------- items ----------------
idx = ["# Items & hazards\n", "## Pickup usage data (DataFiles/PickupItems)\n"]
for p in sorted(glob.glob(os.path.join(DEC, "DataFiles", "PickupItems", "*.txt"))):
    name = os.path.basename(p)[:-4]
    fl = flat(p)
    keep = {k: v for k, v in fl.items() if v not in ("0", "", "[]") and "Guid" not in k}
    out = [f"# {name}\n", f"{len(fl)} fields ({len(keep)} non-default)\n", "```"]
    out += [f"{k} = {v}" for k, v in list(keep.items())[:600]]
    out.append("```")
    open(os.path.join(D, "items", f"{name}.md"), "w", encoding="utf-8").write("\n".join(out))
    idx.append(f"- [{name}]({name}.md): {len(keep)} non-default fields")
idx.append("\n## Item entity folders (QuantumDB/Items)\n")
for it in sorted(os.listdir(os.path.join(DEC, "Items"))):
    n = sum(len(f) for _, _, f in os.walk(os.path.join(DEC, "Items", it)))
    idx.append(f"- {it}: {n} data files")
open(os.path.join(D, "items", "README.md"), "w", encoding="utf-8").write("\n".join(idx))

# ---------------- game modes ----------------
idx = ["# Game modes & global data\n"]
gm_dir = os.path.join(DEC, "DataFiles")
for p in sorted(glob.glob(os.path.join(gm_dir, "GameModes", "**", "*.txt"), recursive=True)) + \
        [os.path.join(gm_dir, x) for x in ("SpeedRunnersSettingsData.txt", "CombatSettingsData.txt", "GameplayInputSettingsData.txt",
                                          "SimulationConfig.txt", "DeterministicConfig.txt", "NPCSettingsData.txt", "TrainingSimulationConfig.txt")]:
    if not os.path.exists(p):
        continue
    rel = os.path.relpath(p, gm_dir)[:-4].replace("\\", "__").replace("/", "__")
    fl = flat(p)
    keep = {k: v for k, v in fl.items() if "Guid" not in k and not k.endswith("Hash") and not k.endswith(".Id.Value")}
    out = [f"# {rel}\n", "```"] + [f"{k} = {v}" for k, v in list(keep.items())[:2500]] + ["```"]
    open(os.path.join(D, "modes", rel + ".md"), "w", encoding="utf-8").write("\n".join(out))
    idx.append(f"- [{rel}]({rel}.md): {len(keep)} fields")
open(os.path.join(D, "modes", "README.md"), "w", encoding="utf-8").write("\n".join(idx))
print("done", len(chars), "characters")
