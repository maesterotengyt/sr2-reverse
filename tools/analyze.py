import re, os, glob, collections

ROOT = r"E:\xbox\Speedrunners 2- King of Speed\RE"
DOCS = os.path.join(ROOT, "docs")
os.makedirs(DOCS, exist_ok=True)

hdr_re = re.compile(r"^(?P<attrs>(?:\[.*\]\n)*)(?P<mods>(?:public |internal |private |protected |static |sealed |abstract |readonly |unsafe |partial )*)(?P<kind>class|struct|enum|interface) (?P<name>\S+)(?: : (?P<bases>[^/\n]*?))? // TypeDefIndex: (?P<idx>\d+)", re.M)

def load(img):
    out = []
    for fn in glob.glob(os.path.join(ROOT, "code", img, "*", "*.cs")):
        t = open(fn, encoding="utf-8").read()
        ns = t.split("\n", 1)[0][len("// Namespace:"):].strip()
        rest = t.split("\n", 1)[1]
        m = hdr_re.search(rest)
        if not m:
            continue
        out.append(dict(ns=ns, kind=m["kind"], name=m["name"], bases=[b.strip() for b in (m["bases"] or "").split(",") if b.strip()],
                        idx=int(m["idx"]), text=rest, file=fn))
    return sorted(out, key=lambda x: x["idx"])

def fields(t):
    return re.findall(r"^\t(?:\[.*\]\n\t)*((?:public|internal|private|protected)(?: static| const| readonly)* [^\n(]*?;) // (0x[0-9A-F]+|Const)?", t["text"], re.M)

def methods(t):
    return re.findall(r"// RVA: (0x[0-9A-F]+) Offset: 0x[0-9A-F]+ VA: 0x([0-9A-F]+)\n\t(?:\[.*\]\n\t)*([^\n]*\) \{[^\n]*\})", t["text"])

def enum_members(t):
    return re.findall(r"^\tpublic const \S+ (\w+) = (-?\w+);", t["text"], re.M)

def w(name, s):
    with open(os.path.join(DOCS, name), "w", encoding="utf-8") as f:
        f.write(s)

def summarize_images(img, title):
    ts = load(img)
    md = [f"# {title}\n", f"{len(ts)} types.\n"]
    byns = collections.defaultdict(list)
    for t in ts:
        byns[t["ns"] or "(global)"].append(t)
    md.append("## Namespaces\n")
    for ns, lst in sorted(byns.items()):
        c = collections.Counter(x["kind"] for x in lst)
        md.append(f"- `{ns}`: " + ", ".join(f"{v} {k}" for k, v in c.items()))
    md.append("")
    return ts, byns, md

# ---------- quantum.code (deterministic gameplay simulation) ----------
ts, byns, md = summarize_images("quantum.code", "quantum.code.dll - deterministic gameplay simulation")
enums = [t for t in ts if t["kind"] == "enum"]
md.append("\n## Enums (full value lists)\n")
for t in enums:
    mem = enum_members(t)
    md.append(f"### {t['ns']+'.' if t['ns'] else ''}{t['name']}\n" + ", ".join(f"{a}={b}" for a, b in mem) + "\n")

# classify by base
def has_base(t, *names):
    return any(any(n in b for n in names) for b in t["bases"])
comps = [t for t in ts if t["kind"] == "struct" and has_base(t, "IComponent")]
systems = [t for t in ts if t["kind"] == "class" and has_base(t, "SystemBase", "SystemMainThread", "SystemSignalsOnly", "SystemThreadedFilter", "SystemMainThreadFilter", "SystemMainThreadGroup")]
assets = [t for t in ts if t["kind"] == "class" and has_base(t, "AssetObject", "AssetBase")]
events = [t for t in ts if t["kind"] == "class" and has_base(t, "EventBase")]
cmds = [t for t in ts if t["kind"] == "class" and has_base(t, "DeterministicCommand")]
def section(title, lst, full=True):
    md.append(f"\n## {title} ({len(lst)})\n")
    for t in lst:
        md.append(f"### {t['ns']+'.' if t['ns'] else ''}{t['name']}  (bases: {', '.join(t['bases'])}; TypeDefIndex {t['idx']})")
        fl = fields(t)
        if fl:
            md.append("Fields:\n```\n" + "\n".join(f"{f[0]}  // {f[1]}" for f in fl) + "\n```")
        ms = methods(t)
        if ms and full:
            md.append("Methods:\n```\n" + "\n".join(f"{m[2].replace(' { }','')}   // RVA {m[0]}" for m in ms) + "\n```")
        md.append("")
section("ECS Components", comps)
section("Systems", systems)
section("Assets (config/data objects)", assets)
section("Events", events)
section("Commands", cmds)
others = [t for t in ts if t not in enums + comps + systems + assets + events + cmds and t["ns"] != "System.Runtime.CompilerServices" and t["ns"] != "Microsoft.CodeAnalysis" and "FixedBuffer" not in t["name"]]
section("Everything else (structs, classes, interfaces)", others)
w("quantum_code.md", "\n".join(md))

# ---------- Assembly-CSharp (Unity client/UI/glue) ----------
ts2, byns2, md2 = summarize_images("Assembly-CSharp", "Assembly-CSharp.dll - Unity client code")
for ns, lst in sorted(byns2.items(), key=lambda kv: -len(kv[1])):
    md2.append(f"\n## {ns} ({len(lst)} types)\n")
    for t in sorted(lst, key=lambda x: x["name"]):
        base = f" : {', '.join(t['bases'])}" if t["bases"] else ""
        if t["kind"] == "enum":
            md2.append(f"- enum **{t['name']}**: " + ", ".join(f"{a}={b}" for a, b in enum_members(t)))
        else:
            nf, nm = len(fields(t)), len(methods(t))
            md2.append(f"- {t['kind']} **{t['name']}**{base} — {nf} fields, {nm} methods")
w("assembly_csharp_index.md", "\n".join(md2))

# ---------- quantum.core / PhotonDeterministic indexes ----------
for img, title, fn in (("quantum.core", "quantum.core.dll - Quantum engine core", "quantum_core_index.md"),
                       ("PhotonDeterministic", "PhotonDeterministic.dll - deterministic math/net", "photon_deterministic_index.md")):
    t3, b3, m3 = summarize_images(img, title)
    for t in t3:
        if t["kind"] == "enum":
            m3.append(f"- enum {t['ns']}.{t['name']}: " + ", ".join(f"{a}={b}" for a, b in enum_members(t)))
        else:
            m3.append(f"- {t['kind']} {t['ns']}.{t['name']} : {', '.join(t['bases'])} ({len(fields(t))}f/{len(methods(t))}m)")
    w(fn, "\n".join(m3))

print("components", len(comps), "systems", len(systems), "assets", len(assets), "events", len(events), "cmds", len(cmds), "others", len(others))
