import sys, json, struct, pefile, capstone, re

DLL = r"E:\xbox\Speedrunners 2- King of Speed\RE\raw\GameAssembly.dll"  # copy kept in scratch input
SCRIPT = r"E:\xbox\Speedrunners 2- King of Speed\RE\raw\script.json"
import os
if not os.path.exists(DLL):
    DLL = r"C:\Users\emman\AppData\Local\Temp\claude\E--xbox-Speedrunners-2--King-of-Speed\6e29ec5d-f2a6-4596-9049-05e6a309743a\scratchpad\input\GameAssembly.dll"

pe = pefile.PE(DLL, fast_load=True)
data = pe.get_memory_mapped_image()  # RVA-indexed
base = pe.OPTIONAL_HEADER.ImageBase
names = {}
sm = json.load(open(SCRIPT, encoding="utf-8"))["ScriptMethod"]
for m in sm:
    names.setdefault(m["Address"], m["Name"])
md = capstone.Cs(capstone.CS_ARCH_X86, capstone.CS_MODE_64)
md.detail = False

def rd64(rva):
    return struct.unpack_from("<q", data, rva)[0]

def dis(rva, maxlen=1800):
    code = data[rva:rva + maxlen]
    out = []
    for ins in md.disasm(bytes(code), base + rva):
        r = ins.address - base
        txt = f"{r:#x}: {ins.mnemonic} {ins.op_str}"
        # call targets
        if ins.mnemonic in ("call", "jmp") and ins.op_str.startswith("0x"):
            t = int(ins.op_str, 16) - base
            if t in names:
                txt += f"    ; {names[t]}"
        # rip-relative loads: resolve 8-byte value / float
        m = re.search(r"\[rip ([+-]) (0x[0-9a-f]+)\]", ins.op_str)
        if m:
            tgt = ins.address + ins.size + (int(m.group(2), 16) * (1 if m.group(1) == "+" else -1)) - base
            try:
                q = rd64(tgt)
                f = struct.unpack_from("<f", data, tgt)[0]
                d = struct.unpack_from("<d", data, tgt)[0]
                txt += f"    ; [{tgt:#x}] q={q} (fp={q/65536:.5g}) f32={f:.5g} f64={d:.5g}"
            except Exception:
                pass
        out.append(txt)
        if ins.mnemonic == "ret" and len(out) > 8:
            # stop at ret followed by int3 padding / next function
            nxt = data[ins.address + ins.size - base: ins.address + ins.size - base + 1]
            if nxt in (b"\xcc", b"\x00"):
                break
    return out

if __name__ == "__main__":
    for arg in sys.argv[1:]:
        rva = int(arg, 16)
        print(f"===== {arg}  {names.get(rva,'')}")
        print("\n".join(dis(rva)))
