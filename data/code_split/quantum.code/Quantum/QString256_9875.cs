// Namespace: Quantum
[Serializable]
public struct QString256 : IQString, IEquatable<QString256> // TypeDefIndex: 9875
{
	// Fields
	public ushort ByteCount; // 0x0
	[FixedBuffer(typeof(byte), 254)]
	[FixedBufferDynamicLength("ByteCount")]
	public QString256.<Bytes>e__FixedBuffer Bytes; // 0x2

	// Methods

	// RVA: 0x20D0EA0 Offset: 0x20CF4A0 VA: 0x1820D0EA0
	public void .ctor(string str) { }

	// RVA: 0x20D0E40 Offset: 0x20CF440 VA: 0x1820D0E40 Slot: 3
	public override string ToString() { }

	// RVA: 0x20D0D40 Offset: 0x20CF340 VA: 0x1820D0D40 Slot: 4
	private int Quantum.IQString.CompareOrdinal(byte* bytes, ushort byteCount) { }

	// RVA: 0x20D0EF0 Offset: 0x20CF4F0 VA: 0x1820D0EF0
	public static QString256 op_Implicit(string str) { }

	// RVA: 0x20D0E40 Offset: 0x20CF440 VA: 0x1820D0E40
	public static string op_Implicit(QString256 str) { }

	// RVA: 0x20D0C90 Offset: 0x20CF290 VA: 0x1820D0C90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20D0BC0 Offset: 0x20CF1C0 VA: 0x1820D0BC0 Slot: 5
	public bool Equals(QString256 str) { }

	// RVA: 0x20D0CE0 Offset: 0x20CF2E0 VA: 0x1820D0CE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D0DA0 Offset: 0x20CF3A0 VA: 0x1820D0DA0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
