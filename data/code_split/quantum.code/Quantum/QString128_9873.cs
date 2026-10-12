// Namespace: Quantum
[Serializable]
public struct QString128 : IQString, IEquatable<QString128> // TypeDefIndex: 9873
{
	// Fields
	public ushort ByteCount; // 0x0
	[FixedBuffer(typeof(byte), 126)]
	[FixedBufferDynamicLength("ByteCount")]
	public QString128.<Bytes>e__FixedBuffer Bytes; // 0x2

	// Methods

	// RVA: 0x20D0AF0 Offset: 0x20CF0F0 VA: 0x1820D0AF0
	public void .ctor(string str) { }

	// RVA: 0x20D0A90 Offset: 0x20CF090 VA: 0x1820D0A90 Slot: 3
	public override string ToString() { }

	// RVA: 0x20D0990 Offset: 0x20CEF90 VA: 0x1820D0990 Slot: 4
	private int Quantum.IQString.CompareOrdinal(byte* bytes, ushort byteCount) { }

	// RVA: 0x20D0B40 Offset: 0x20CF140 VA: 0x1820D0B40
	public static QString128 op_Implicit(string str) { }

	// RVA: 0x20D0A90 Offset: 0x20CF090 VA: 0x1820D0A90
	public static string op_Implicit(QString128 str) { }

	// RVA: 0x20D08E0 Offset: 0x20CEEE0 VA: 0x1820D08E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20D0880 Offset: 0x20CEE80 VA: 0x1820D0880 Slot: 5
	public bool Equals(QString128 str) { }

	// RVA: 0x20D0930 Offset: 0x20CEF30 VA: 0x1820D0930 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D09F0 Offset: 0x20CEFF0 VA: 0x1820D09F0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
