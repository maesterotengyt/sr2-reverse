// Namespace: Photon.Deterministic
public class BitStream : IBitStream // TypeDefIndex: 17479
{
	// Fields
	private int _ptr; // 0x10
	private int _maxPtr; // 0x14
	private int _offsetBytes; // 0x18
	private int _capacityBytes; // 0x1C
	private byte[] _data; // 0x20
	private bool _write; // 0x28

	// Properties
	public int Position { get; set; }
	public int BytesRequired { get; }
	public int Capacity { get; }
	public bool Overflowing { get; }
	public bool Writing { get; set; }
	public bool Reading { get; set; }
	public byte[] Data { get; }

	// Methods

	// RVA: 0x20AE300 Offset: 0x20AC900 VA: 0x1820AE300
	public int get_Position() { }

	// RVA: 0x20AE310 Offset: 0x20AC910 VA: 0x1820AE310
	public void set_Position(int value) { }

	// RVA: 0x20AE290 Offset: 0x20AC890 VA: 0x1820AE290 Slot: 4
	public int get_BytesRequired() { }

	// RVA: 0x6678B0 Offset: 0x665EB0 VA: 0x1806678B0
	public int get_Capacity() { }

	// RVA: 0x20AE2F0 Offset: 0x20AC8F0 VA: 0x1820AE2F0
	public bool get_Overflowing() { }

	// RVA: 0x5BA5A0 Offset: 0x5B8BA0 VA: 0x1805BA5A0 Slot: 6
	public bool get_Writing() { }

	// RVA: 0x5BA5B0 Offset: 0x5B8BB0 VA: 0x1805BA5B0 Slot: 7
	public void set_Writing(bool value) { }

	// RVA: 0x829FD0 Offset: 0x8285D0 VA: 0x180829FD0 Slot: 8
	public bool get_Reading() { }

	// RVA: 0x20AE390 Offset: 0x20AC990 VA: 0x1820AE390 Slot: 9
	public void set_Reading(bool value) { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300 Slot: 5
	public byte[] get_Data() { }

	// RVA: 0x20AE200 Offset: 0x20AC800 VA: 0x1820AE200
	public void .ctor() { }

	// RVA: 0x20AE0B0 Offset: 0x20AC6B0 VA: 0x1820AE0B0
	public void .ctor(int size) { }

	// RVA: 0x20AE1A0 Offset: 0x20AC7A0 VA: 0x1820AE1A0
	public void .ctor(byte[] arr) { }

	// RVA: 0x20AE140 Offset: 0x20AC740 VA: 0x1820AE140
	public void .ctor(byte[] arr, int size, int offset) { }

	// RVA: 0x20AD180 Offset: 0x20AB780 VA: 0x1820AD180
	public void SetBuffer(byte[] arr) { }

	// RVA: 0x20AD220 Offset: 0x20AB820 VA: 0x1820AD220
	public void SetBuffer(byte[] arr, int size) { }

	// RVA: 0x20AD1D0 Offset: 0x20AB7D0 VA: 0x1820AD1D0
	public void SetBuffer(byte[] arr, int size, int offset) { }

	// RVA: 0x20AC060 Offset: 0x20AA660 VA: 0x1820AC060
	public int RoundToByte() { }

	// RVA: 0x20AB4E0 Offset: 0x20A9AE0 VA: 0x1820AB4E0
	public bool CanRead(int bits) { }

	// RVA: 0x20AB530 Offset: 0x20A9B30 VA: 0x1820AB530 Slot: 33
	public void CopyFromArray(byte[] array) { }

	// RVA: 0x20ABFC0 Offset: 0x20AA5C0 VA: 0x1820ABFC0 Slot: 35
	public void Reset() { }

	// RVA: 0x20AC010 Offset: 0x20AA610 VA: 0x1820AC010
	public void Reset(int byteSize) { }

	// RVA: 0x20AD260 Offset: 0x20AB860 VA: 0x1820AD260 Slot: 34
	public byte[] ToArray() { }

	// RVA: 0x20AD320 Offset: 0x20AB920 VA: 0x1820AD320 Slot: 28
	public bool WriteBool(bool value) { }

	// RVA: 0x20AD320 Offset: 0x20AB920 VA: 0x1820AD320 Slot: 36
	public bool WriteBoolean(bool value) { }

	// RVA: 0x20AB7D0 Offset: 0x20A9DD0 VA: 0x1820AB7D0 Slot: 27
	public bool ReadBool() { }

	// RVA: 0x20AB7D0 Offset: 0x20A9DD0 VA: 0x1820AB7D0 Slot: 37
	public bool ReadBoolean() { }

	// RVA: 0x20ADA90 Offset: 0x20AC090 VA: 0x1820ADA90
	public void WriteByte(byte value, int bits) { }

	// RVA: 0x20ABA40 Offset: 0x20AA040 VA: 0x1820ABA40
	public byte ReadByte(int bits) { }

	// RVA: 0x20ADA80 Offset: 0x20AC080 VA: 0x1820ADA80 Slot: 38
	public void WriteByte(byte value) { }

	// RVA: 0x20ABA50 Offset: 0x20AA050 VA: 0x1820ABA50 Slot: 39
	public byte ReadByte() { }

	// RVA: 0x20ABA50 Offset: 0x20AA050 VA: 0x1820ABA50
	public sbyte ReadSByte() { }

	// RVA: 0x20ADA80 Offset: 0x20AC080 VA: 0x1820ADA80
	public void WriteSByte(sbyte value) { }

	// RVA: 0x20AE050 Offset: 0x20AC650 VA: 0x1820AE050
	public void WriteUShort(ushort value, int bits) { }

	// RVA: 0x20ABCD0 Offset: 0x20AA2D0 VA: 0x1820ABCD0
	public ushort ReadUShort(int bits) { }

	// RVA: 0x20ADCC0 Offset: 0x20AC2C0 VA: 0x1820ADCC0
	public void WriteUShort(ushort value) { }

	// RVA: 0x20ABC80 Offset: 0x20AA280 VA: 0x1820ABC80
	public ushort ReadUShort() { }

	// RVA: 0x20ADD00 Offset: 0x20AC300 VA: 0x1820ADD00
	public void WriteShort(short value, int bits) { }

	// RVA: 0x20ABCD0 Offset: 0x20AA2D0 VA: 0x1820ABCD0
	public short ReadShort(int bits) { }

	// RVA: 0x20ADCC0 Offset: 0x20AC2C0 VA: 0x1820ADCC0
	public void WriteShort(short value) { }

	// RVA: 0x20ABC80 Offset: 0x20AA280 VA: 0x1820ABC80
	public short ReadShort() { }

	// RVA: 0x20ADEF0 Offset: 0x20AC4F0 VA: 0x1820ADEF0
	public void WriteUInt(uint value, int bits) { }

	// RVA: 0x20ABE90 Offset: 0x20AA490 VA: 0x1820ABE90
	public uint ReadUInt(int bits) { }

	// RVA: 0x20ADC50 Offset: 0x20AC250 VA: 0x1820ADC50 Slot: 31
	public void WriteUInt(uint value) { }

	// RVA: 0x20ABBF0 Offset: 0x20AA1F0 VA: 0x1820ABBF0 Slot: 32
	public uint ReadUInt() { }

	// RVA: 0x20ADC40 Offset: 0x20AC240 VA: 0x1820ADC40
	public void WriteInt(int value, int bits) { }

	// RVA: 0x20ABC00 Offset: 0x20AA200 VA: 0x1820ABC00
	public int ReadInt(int bits) { }

	// RVA: 0x20ADC50 Offset: 0x20AC250 VA: 0x1820ADC50 Slot: 30
	public void WriteInt(int value) { }

	// RVA: 0x20ABBF0 Offset: 0x20AA1F0 VA: 0x1820ABBF0 Slot: 29
	public int ReadInt() { }

	// RVA: 0x20ADFF0 Offset: 0x20AC5F0 VA: 0x1820ADFF0
	public void WriteULong(ulong value, int bits) { }

	// RVA: 0x20ABC10 Offset: 0x20AA210 VA: 0x1820ABC10
	public ulong ReadULong(int bits) { }

	// RVA: 0x20ADC00 Offset: 0x20AC200 VA: 0x1820ADC00 Slot: 40
	public void WriteULong(ulong value) { }

	// RVA: 0x20ABBB0 Offset: 0x20AA1B0 VA: 0x1820ABBB0 Slot: 41
	public ulong ReadULong() { }

	// RVA: 0x20ADC60 Offset: 0x20AC260 VA: 0x1820ADC60
	public void WriteLong(long value, int bits) { }

	// RVA: 0x20ABC10 Offset: 0x20AA210 VA: 0x1820ABC10
	public long ReadLong(int bits) { }

	// RVA: 0x20ADC00 Offset: 0x20AC200 VA: 0x1820ADC00 Slot: 42
	public void WriteLong(long value) { }

	// RVA: 0x20ABBB0 Offset: 0x20AA1B0 VA: 0x1820ABBB0 Slot: 43
	public long ReadLong() { }

	// RVA: 0x20ADAA0 Offset: 0x20AC0A0 VA: 0x1820ADAA0
	public void WriteDouble(double value) { }

	// RVA: 0x20ABA60 Offset: 0x20AA060 VA: 0x1820ABA60
	public double ReadDouble() { }

	// RVA: 0x20AD920 Offset: 0x20ABF20 VA: 0x1820AD920
	public void WriteByteArray(byte[] from) { }

	// RVA: 0x20AD770 Offset: 0x20ABD70 VA: 0x1820AD770
	public void WriteByteArray(byte[] from, int count) { }

	// RVA: 0x20AD790 Offset: 0x20ABD90 VA: 0x1820AD790
	public void WriteByteArray(byte[] from, int offset, int count) { }

	// RVA: 0x20ABA10 Offset: 0x20AA010 VA: 0x1820ABA10
	public void ReadByteArray(byte[] to) { }

	// RVA: 0x20AB8B0 Offset: 0x20A9EB0 VA: 0x1820AB8B0
	public void ReadByteArray(byte[] to, int count) { }

	// RVA: 0x20AB8D0 Offset: 0x20A9ED0 VA: 0x1820AB8D0
	public void ReadByteArray(byte[] to, int offset, int count) { }

	// RVA: 0x20AD560 Offset: 0x20ABB60 VA: 0x1820AD560
	public void WriteByteArrayLengthPrefixed(byte[] array) { }

	// RVA: 0x20AD350 Offset: 0x20AB950 VA: 0x1820AD350
	public void WriteByteArrayLengthPrefixed(byte[] array, int maxLength) { }

	// RVA: 0x20AB7F0 Offset: 0x20A9DF0 VA: 0x1820AB7F0
	public byte[] ReadByteArrayLengthPrefixed() { }

	// RVA: 0x20ADD60 Offset: 0x20AC360 VA: 0x1820ADD60
	public void WriteString(string value, Encoding encoding) { }

	// RVA: 0x20ADE20 Offset: 0x20AC420 VA: 0x1820ADE20
	public void WriteString(string value) { }

	// RVA: 0x20ABD40 Offset: 0x20AA340 VA: 0x1820ABD40
	public string ReadString(Encoding encoding) { }

	// RVA: 0x20ABE60 Offset: 0x20AA460 VA: 0x1820ABE60
	public string ReadString() { }

	// RVA: 0x20AB6B0 Offset: 0x20A9CB0 VA: 0x1820AB6B0
	private void InternalWriteByte(byte value, int bits) { }

	// RVA: 0x20ADC00 Offset: 0x20AC200 VA: 0x1820ADC00 Slot: 44
	public void WriteFP(FP fp) { }

	// RVA: 0x20ABBB0 Offset: 0x20AA1B0 VA: 0x1820ABBB0 Slot: 45
	public FP ReadFP() { }

	// RVA: 0x20ADB80 Offset: 0x20AC180 VA: 0x1820ADB80 Slot: 46
	public void WriteFPVector2(FPVector2 v) { }

	// RVA: 0x20ABB20 Offset: 0x20AA120 VA: 0x1820ABB20 Slot: 47
	public FPVector2 ReadFPVector2() { }

	// RVA: 0x20AD950 Offset: 0x20ABF50 VA: 0x1820AD950
	public static void WriteByteAt(byte[] data, int ptr, int bits, byte value) { }

	// RVA: 0x20AB590 Offset: 0x20A9B90 VA: 0x1820AB590
	private byte InternalReadByte(int bits) { }

	// RVA: 0x20AB4F0 Offset: 0x20A9AF0 VA: 0x1820AB4F0 Slot: 26
	public bool Condition(bool condition) { }

	// RVA: 0x20AC7A0 Offset: 0x20AADA0 VA: 0x1820AC7A0 Slot: 48
	public void Serialize(ref string value) { }

	// RVA: 0x20ACD20 Offset: 0x20AB320 VA: 0x1820ACD20 Slot: 49
	public void Serialize(ref bool value) { }

	// RVA: 0x20AC400 Offset: 0x20AAA00 VA: 0x1820AC400 Slot: 50
	public void Serialize(ref double value) { }

	// RVA: 0x20AC370 Offset: 0x20AA970 VA: 0x1820AC370 Slot: 10
	public void Serialize(ref long value) { }

	// RVA: 0x20AC370 Offset: 0x20AA970 VA: 0x1820AC370 Slot: 51
	public void Serialize(ref ulong value) { }

	// RVA: 0x20AC370 Offset: 0x20AA970 VA: 0x1820AC370 Slot: 52
	public void Serialize(ref FP value) { }

	// RVA: 0x20ACBF0 Offset: 0x20AB1F0 VA: 0x1820ACBF0 Slot: 53
	public void Serialize(ref FPVector2 value) { }

	// RVA: 0x20AC2F0 Offset: 0x20AA8F0 VA: 0x1820AC2F0 Slot: 54
	public void Serialize(ref byte value) { }

	// RVA: 0x20ACF60 Offset: 0x20AB560 VA: 0x1820ACF60 Slot: 11
	public void Serialize(ref uint value) { }

	// RVA: 0x20AC330 Offset: 0x20AA930 VA: 0x1820AC330 Slot: 55
	public void Serialize(ref uint value, int bits) { }

	// RVA: 0x20ACD70 Offset: 0x20AB370 VA: 0x1820ACD70 Slot: 56
	public void Serialize(ref ulong value, int bits) { }

	// RVA: 0x20ACF60 Offset: 0x20AB560 VA: 0x1820ACF60 Slot: 12
	public void Serialize(ref int value) { }

	// RVA: 0x20AC330 Offset: 0x20AA930 VA: 0x1820AC330 Slot: 57
	public void Serialize(ref int value, int bits) { }

	// RVA: 0x20AC5E0 Offset: 0x20AABE0 VA: 0x1820AC5E0 Slot: 58
	public void Serialize(ref int[] value) { }

	// RVA: 0x20AC8A0 Offset: 0x20AAEA0 VA: 0x1820AC8A0 Slot: 59
	public void Serialize(ref byte[] value) { }

	// RVA: 0x20ACE10 Offset: 0x20AB410 VA: 0x1820ACE10 Slot: 60
	public void Serialize(ref byte[] array, ref int length) { }

	// RVA: 0x20AD040 Offset: 0x20AB640 VA: 0x1820AD040 Slot: 61
	public void Serialize(ref byte[] array, ref int length, int fixedSize) { }

	// RVA: -1 Offset: -1 Slot: 62
	public void SerializeArrayLength<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFF50 Offset: 0xACE550 VA: 0x180ACFF50
	|-BitStream.SerializeArrayLength<__Il2CppFullySharedGenericType>
	|-BitStream.SerializeArrayLength<InputMissing.TickMissing>
	*/

	// RVA: 0x20AC2F0 Offset: 0x20AA8F0 VA: 0x1820AC2F0 Slot: 13
	public void Serialize(byte* v) { }

	// RVA: 0x20AC2F0 Offset: 0x20AA8F0 VA: 0x1820AC2F0 Slot: 14
	public void Serialize(sbyte* v) { }

	// RVA: 0x20ACFA0 Offset: 0x20AB5A0 VA: 0x1820ACFA0 Slot: 15
	public void Serialize(short* v) { }

	// RVA: 0x20ACFA0 Offset: 0x20AB5A0 VA: 0x1820ACFA0 Slot: 16
	public void Serialize(ushort* v) { }

	// RVA: 0x20ACF60 Offset: 0x20AB560 VA: 0x1820ACF60 Slot: 17
	public void Serialize(int* v) { }

	// RVA: 0x20ACF60 Offset: 0x20AB560 VA: 0x1820ACF60 Slot: 18
	public void Serialize(uint* v) { }

	// RVA: 0x20AC370 Offset: 0x20AA970 VA: 0x1820AC370 Slot: 19
	public void Serialize(long* v) { }

	// RVA: 0x20AC370 Offset: 0x20AA970 VA: 0x1820AC370 Slot: 20
	public void Serialize(ulong* v) { }

	// RVA: 0x20AC330 Offset: 0x20AA930 VA: 0x1820AC330 Slot: 22
	public void Serialize(uint* v, int bits) { }

	// RVA: 0x20AC330 Offset: 0x20AA930 VA: 0x1820AC330 Slot: 21
	public void Serialize(int* v, int bits) { }

	// RVA: 0x20AC270 Offset: 0x20AA870 VA: 0x1820AC270 Slot: 23
	public void SerializeBuffer(byte* buffer, int length) { }

	// RVA: 0x20AC0C0 Offset: 0x20AA6C0 VA: 0x1820AC0C0 Slot: 24
	public void SerializeBuffer(short* buffer, int length) { }

	// RVA: 0x20AC190 Offset: 0x20AA790 VA: 0x1820AC190 Slot: 25
	public void SerializeBuffer(ulong* buffer, int length) { }
}
