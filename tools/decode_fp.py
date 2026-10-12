import os, re

SRC = r"E:\xbox\Speedrunners 2- King of Speed\RE\assets_export\ExportedProject\Assets\QuantumDB"
DST = r"E:\xbox\Speedrunners 2- King of Speed\RE\decoded_quantumdb"
SKIP_KEYS = ("m_ObjectHideFlags", "m_CorrespondingSourceObject", "m_PrefabInstance", "m_PrefabAsset",
             "m_GameObject", "m_Enabled", "m_EditorHideFlags", "m_EditorClassIdentifier", "m_Script")
pat = re.compile(r"^(\s*)RawValue: (-?\d+)\s*$")
n = 0
for root, _, files in os.walk(SRC):
    for fn in files:
        if not fn.endswith(".asset"):
            continue
        p = os.path.join(root, fn)
        rel = os.path.relpath(p, SRC)
        out = os.path.join(DST, rel[:-6] + ".txt")
        os.makedirs(os.path.dirname(out), exist_ok=True)
        try:
            lines = open(p, encoding="utf-8", errors="replace").read().split("\n")
        except Exception:
            continue
        res = []
        for i, l in enumerate(lines):
            if l.lstrip().startswith(SKIP_KEYS):
                continue
            m = pat.match(l)
            if m and res:
                v = int(m.group(2)) / 65536.0
                # fold the value onto the previous key line:  Gravity: 32.5
                prev = res[-1]
                if prev.rstrip().endswith(":"):
                    res[-1] = f"{prev} {v:.5g}"
                    continue
                res.append(f"{m.group(1)}RawValue: {m.group(2)} (={v:.5g})")
                continue
            res.append(l)
        with open(out, "w", encoding="utf-8") as o:
            o.write("\n".join(res))
        n += 1
print("decoded", n)
