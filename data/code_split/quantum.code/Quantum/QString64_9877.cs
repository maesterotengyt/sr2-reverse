// Namespace: Quantum
[Serializable]
public struct QString64 : IQString, IEquatable<QString64> // TypeDefIndex: 9877
{
	// Fields
	public const int SIZE = 64;
	public const int ALIGNMENT = 4;
	public ushort ByteCount; // 0x0
	[FixedBuffer(typeof(byte), 62)]
	[FixedBufferDynamicLength("ByteCount")]
	public QString64.<Bytes>e__FixedBuffer Bytes; // 0x2
	public const int MaxByteCount = 62;

	// Methods

	// RVA: 0x20D11C0 Offset: 0x20CF7C0 VA: 0x1820D11C0
	public void .ctor(string str) { }

	// RVA: 0x20D1160 Offset: 0x20CF760 VA: 0x1820D1160 Slot: 3
	public override string ToString() { }

	// RVA: 0x20D1060 Offset: 0x20CF660 VA: 0x1820D1060 Slot: 4
	private int Quantum.IQString.CompareOrdinal(byte* bytes, ushort byteCount) { }

	// RVA: 0x20D1210 Offset: 0x20CF810 VA: 0x1820D1210
	public static QString64 op_Implicit(string str) { }

	// RVA: 0x20D1160 Offset: 0x20CF760 VA: 0x1820D1160
	public static string op_Implicit(QString64 str) { }

	// RVA: 0x20D0F50 Offset: 0x20CF550 VA: 0x1820D0F50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20D0FA0 Offset: 0x20CF5A0 VA: 0x1820D0FA0 Slot: 5
	public bool Equals(QString64 str) { }

	// RVA: 0x20D1000 Offset: 0x20CF600 VA: 0x1820D1000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D10C0 Offset: 0x20CF6C0 VA: 0x1820D10C0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
