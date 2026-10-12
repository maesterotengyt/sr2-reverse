import re, os, sys, json, collections

RAW = r"E:\xbox\Speedrunners 2- King of Speed\RE\raw\dump.cs"
OUT = r"E:\xbox\Speedrunners 2- King of Speed\RE\code"
# first-party / game-relevant images (others are Unity/.NET/3rd-party libs)
GAME = {"Assembly-CSharp.dll", "quantum.code.dll", "quantum.core.dll", "PhotonDeterministic.dll",
        "__Generated"}

with open(RAW, encoding="utf-8", errors="replace") as f:
    text = f.read()

lines = text.split("\n")
images = []
i = 0
while lines[i].startswith("// Image "):
    m = re.match(r"// Image (\d+): (.+?) - (\d+)", lines[i])
    images.append((int(m.group(1)), m.group(2), int(m.group(3))))
    i += 1
body = "\n".join(lines[i:])
blocks = re.split(r"\n(?=// Namespace: )", body)

def image_for(idx):
    cur = images[0]
    for im in images:
        if im[2] <= idx:
            cur = im
        else:
            break
    return cur[1]

def safe(s):
    return re.sub(r'[<>:"/\\|?*\x00-\x1f]', "_", s)[:120]

stats = collections.defaultdict(lambda: collections.Counter())
index = collections.defaultdict(list)
for b in blocks:
    b = b.strip("\n")
    if not b.startswith("// Namespace:"):
        continue
    ns = b.split("\n", 1)[0][len("// Namespace:"):].strip()
    m = re.search(r"(class|struct|enum|interface) (\S+)(?: : [^/\n]*?)? // TypeDefIndex: (\d+)", b)
    if not m:
        continue
    kind, name, idx = m.group(1), m.group(2), int(m.group(3))
    img = image_for(idx)
    stats[img][kind] += 1
    index[img].append((idx, ns, kind, name))
    if img in GAME:
        d = os.path.join(OUT, safe(img.replace(".dll", "")), safe(ns or "_global"))
        os.makedirs(d, exist_ok=True)
        fn = os.path.join(d, f"{safe(name)}_{idx}.cs")
        with open(fn, "w", encoding="utf-8") as o:
            o.write(b + "\n")

with open(os.path.join(OUT, "_image_stats.json"), "w") as o:
    json.dump({k: dict(v) for k, v in stats.items()}, o, indent=1)
with open(os.path.join(OUT, "_type_index.tsv"), "w", encoding="utf-8") as o:
    for img in index:
        for idx, ns, kind, name in index[img]:
            o.write(f"{img}\t{idx}\t{ns}\t{kind}\t{name}\n")
for img, c in stats.items():
    if img in GAME:
        print(img, dict(c))
