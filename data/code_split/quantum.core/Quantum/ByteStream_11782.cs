// Namespace: Quantum
public class ByteStream : IDisposable // TypeDefIndex: 11782
{
	// Fields
	private int _n; // 0x10
	private int _s; // 0x14
	private byte[] _d; // 0x18

	// Methods

	// RVA: 0x2222ED0 Offset: 0x22214D0 VA: 0x182222ED0
	public void .ctor(byte[] data) { }

	// RVA: 0x2222C90 Offset: 0x2221290 VA: 0x182222C90
	public void WriteByte(byte value) { }

	// RVA: 0x2222A40 Offset: 0x2221040 VA: 0x182222A40
	public byte ReadByte() { }

	// RVA: 0x2222CD0 Offset: 0x22212D0 VA: 0x182222CD0
	public void WriteInt(int value) { }

	// RVA: 0x2222A80 Offset: 0x2221080 VA: 0x182222A80
	public int ReadInt() { }

	// RVA: 0x2222D80 Offset: 0x2221380 VA: 0x182222D80
	public void WriteULong(ulong value) { }

	// RVA: 0x2222B30 Offset: 0x2221130 VA: 0x182222B30
	public ulong ReadULong() { }

	// RVA: 0x2222D80 Offset: 0x2221380 VA: 0x182222D80
	public void WriteLong(long value) { }

	// RVA: 0x2222B30 Offset: 0x2221130 VA: 0x182222B30
	public long ReadLong() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public void Dispose() { }
}
