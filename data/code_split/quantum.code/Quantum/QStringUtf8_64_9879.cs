// Namespace: Quantum
[Serializable]
public struct QStringUtf8_64 : IQStringUtf8, IEquatable<QStringUtf8_64> // TypeDefIndex: 9879
{
	// Fields
	public const int SIZE = 64;
	public const int ALIGNMENT = 4;
	public ushort ByteCount; // 0x0
	[FixedBuffer(typeof(byte), 62)]
	[FixedBufferDynamicLength("ByteCount")]
	public QStringUtf8_64.<Bytes>e__FixedBuffer Bytes; // 0x2
	public const int MaxByteCount = 62;

	// Methods

	// RVA: 0x20D1510 Offset: 0x20CFB10 VA: 0x1820D1510
	public void .ctor(string str) { }

	// RVA: 0x20D1490 Offset: 0x20CFA90 VA: 0x1820D1490 Slot: 3
	public override string ToString() { }

	// RVA: 0x20D1390 Offset: 0x20CF990 VA: 0x1820D1390 Slot: 4
	private int Quantum.IQStringUtf8.CompareOrdinal(byte* bytes, ushort byteCount) { }

	// RVA: 0x20D15E0 Offset: 0x20CFBE0 VA: 0x1820D15E0
	public static QStringUtf8_64 op_Implicit(string str) { }

	// RVA: 0x20D1560 Offset: 0x20CFB60 VA: 0x1820D1560
	public static string op_Implicit(QStringUtf8_64 str) { }

	// RVA: 0x20D1280 Offset: 0x20CF880 VA: 0x1820D1280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20D12D0 Offset: 0x20CF8D0 VA: 0x1820D12D0 Slot: 5
	public bool Equals(QStringUtf8_64 str) { }

	// RVA: 0x20D1330 Offset: 0x20CF930 VA: 0x1820D1330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D13F0 Offset: 0x20CF9F0 VA: 0x1820D13F0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
