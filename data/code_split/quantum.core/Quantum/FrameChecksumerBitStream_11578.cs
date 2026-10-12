// Namespace: Quantum
public class FrameChecksumerBitStream : IBitStream // TypeDefIndex: 11578
{
	// Fields
	private ulong _crc; // 0x10
	[CompilerGenerated]
	private bool <Writing>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <Reading>k__BackingField; // 0x19

	// Properties
	public bool Writing { get; set; }
	public bool Reading { get; set; }
	public ulong Checksum { get; set; }
	public int BytesRequired { get; }
	public byte[] Data { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x676D40 Offset: 0x675340 VA: 0x180676D40 Slot: 6
	public bool get_Writing() { }

	[CompilerGenerated]
	// RVA: 0x676D50 Offset: 0x675350 VA: 0x180676D50 Slot: 7
	public void set_Writing(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7FC190 Offset: 0x7FA790 VA: 0x1807FC190 Slot: 8
	public bool get_Reading() { }

	[CompilerGenerated]
	// RVA: 0x205F260 Offset: 0x205D860 VA: 0x18205F260 Slot: 9
	public void set_Reading(bool value) { }

	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public ulong get_Checksum() { }

	// RVA: 0x880DF0 Offset: 0x87F3F0 VA: 0x180880DF0
	public void set_Checksum(ulong value) { }

	// RVA: 0xC97F70 Offset: 0xC96570 VA: 0x180C97F70 Slot: 4
	public int get_BytesRequired() { }

	// RVA: 0x21CE440 Offset: 0x21CCA40 VA: 0x1821CE440 Slot: 5
	public byte[] get_Data() { }

	// RVA: 0x21CE420 Offset: 0x21CCA20 VA: 0x1821CE420
	public void .ctor() { }

	// RVA: -1 Offset: -1
	private void CRC<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB52960 Offset: 0xB50F60 VA: 0x180B52960
	|-FrameChecksumerBitStream.CRC<byte>
	|
	|-RVA: 0xB52C50 Offset: 0xB51250 VA: 0x180B52C50
	|-FrameChecksumerBitStream.CRC<int>
	|
	|-RVA: 0xB52DC0 Offset: 0xB513C0 VA: 0x180B52DC0
	|-FrameChecksumerBitStream.CRC<long>
	|
	|-RVA: 0xB52FB0 Offset: 0xB515B0 VA: 0x180B52FB0
	|-FrameChecksumerBitStream.CRC<uint>
	|
	|-RVA: 0xB52AE0 Offset: 0xB510E0 VA: 0x180B52AE0
	|-FrameChecksumerBitStream.CRC<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void CRC<T>(T* value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB528E0 Offset: 0xB50EE0 VA: 0x180B528E0
	|-FrameChecksumerBitStream.CRC<byte>
	|
	|-RVA: 0xB52BD0 Offset: 0xB511D0 VA: 0x180B52BD0
	|-FrameChecksumerBitStream.CRC<short>
	|
	|-RVA: 0xB52CC0 Offset: 0xB512C0 VA: 0x180B52CC0
	|-FrameChecksumerBitStream.CRC<int>
	|
	|-RVA: 0xB52D40 Offset: 0xB51340 VA: 0x180B52D40
	|-FrameChecksumerBitStream.CRC<long>
	|
	|-RVA: 0xB52E30 Offset: 0xB51430 VA: 0x180B52E30
	|-FrameChecksumerBitStream.CRC<sbyte>
	|
	|-RVA: 0xB52EB0 Offset: 0xB514B0 VA: 0x180B52EB0
	|-FrameChecksumerBitStream.CRC<ushort>
	|
	|-RVA: 0xB52F30 Offset: 0xB51530 VA: 0x180B52F30
	|-FrameChecksumerBitStream.CRC<uint>
	|
	|-RVA: 0xB53090 Offset: 0xB51690 VA: 0x180B53090
	|-FrameChecksumerBitStream.CRC<ulong>
	|
	|-RVA: 0xB52A60 Offset: 0xB51060 VA: 0x180B52A60
	|-FrameChecksumerBitStream.CRC<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void CRC<T>(T* value, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB52870 Offset: 0xB50E70 VA: 0x180B52870
	|-FrameChecksumerBitStream.CRC<byte>
	|
	|-RVA: 0xB52B60 Offset: 0xB51160 VA: 0x180B52B60
	|-FrameChecksumerBitStream.CRC<short>
	|
	|-RVA: 0xB53020 Offset: 0xB51620 VA: 0x180B53020
	|-FrameChecksumerBitStream.CRC<ulong>
	|
	|-RVA: 0xB529D0 Offset: 0xB50FD0 VA: 0x180B529D0
	|-FrameChecksumerBitStream.CRC<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21CDC40 Offset: 0x21CC240 VA: 0x1821CDC40 Slot: 26
	public bool Condition(bool condition) { }

	// RVA: 0x21CDF70 Offset: 0x21CC570 VA: 0x1821CDF70 Slot: 10
	public void Serialize(ref long value) { }

	// RVA: 0x21CE240 Offset: 0x21CC840 VA: 0x1821CE240 Slot: 11
	public void Serialize(ref uint value) { }

	// RVA: 0x21CE1F0 Offset: 0x21CC7F0 VA: 0x1821CE1F0 Slot: 12
	public void Serialize(ref int value) { }

	// RVA: 0x21CDFC0 Offset: 0x21CC5C0 VA: 0x1821CDFC0 Slot: 13
	public void Serialize(byte* v) { }

	// RVA: 0x21CE1A0 Offset: 0x21CC7A0 VA: 0x1821CE1A0 Slot: 14
	public void Serialize(sbyte* v) { }

	// RVA: 0x21CE290 Offset: 0x21CC890 VA: 0x1821CE290 Slot: 15
	public void Serialize(short* v) { }

	// RVA: 0x21CDF20 Offset: 0x21CC520 VA: 0x1821CDF20 Slot: 16
	public void Serialize(ushort* v) { }

	// RVA: 0x21CE100 Offset: 0x21CC700 VA: 0x1821CE100 Slot: 17
	public void Serialize(int* v) { }

	// RVA: 0x21CDED0 Offset: 0x21CC4D0 VA: 0x1821CDED0 Slot: 18
	public void Serialize(uint* v) { }

	// RVA: 0x21CE060 Offset: 0x21CC660 VA: 0x1821CE060 Slot: 19
	public void Serialize(long* v) { }

	// RVA: 0x21CE150 Offset: 0x21CC750 VA: 0x1821CE150 Slot: 20
	public void Serialize(ulong* v) { }

	// RVA: 0x21CE0B0 Offset: 0x21CC6B0 VA: 0x1821CE0B0 Slot: 22
	public void Serialize(uint* v, int bits) { }

	// RVA: 0x21CE010 Offset: 0x21CC610 VA: 0x1821CE010 Slot: 21
	public void Serialize(int* v, int bits) { }

	// RVA: 0x21CDDB0 Offset: 0x21CC3B0 VA: 0x1821CDDB0 Slot: 23
	public void SerializeBuffer(byte* buffer, int length) { }

	// RVA: 0x21CDE10 Offset: 0x21CC410 VA: 0x1821CDE10 Slot: 24
	public void SerializeBuffer(short* buffer, int length) { }

	// RVA: 0x21CDE70 Offset: 0x21CC470 VA: 0x1821CDE70 Slot: 25
	public void SerializeBuffer(ulong* buffer, int length) { }

	// RVA: 0x21CE320 Offset: 0x21CC920 VA: 0x1821CE320 Slot: 28
	public bool WriteBool(bool v) { }

	// RVA: 0x21CE380 Offset: 0x21CC980 VA: 0x1821CE380 Slot: 30
	public void WriteInt(int v) { }

	// RVA: 0x21CE3D0 Offset: 0x21CC9D0 VA: 0x1821CE3D0 Slot: 31
	public void WriteUInt(uint v) { }

	// RVA: 0x21CDD60 Offset: 0x21CC360 VA: 0x1821CDD60 Slot: 32
	public uint ReadUInt() { }

	// RVA: 0x21CDCE0 Offset: 0x21CC2E0 VA: 0x1821CDCE0 Slot: 27
	public bool ReadBool() { }

	// RVA: 0x21CDD20 Offset: 0x21CC320 VA: 0x1821CDD20 Slot: 29
	public int ReadInt() { }

	// RVA: 0x21CDCA0 Offset: 0x21CC2A0 VA: 0x1821CDCA0 Slot: 33
	public void CopyFromArray(byte[] data) { }

	// RVA: 0x21CE2E0 Offset: 0x21CC8E0 VA: 0x1821CE2E0 Slot: 34
	public byte[] ToArray() { }

	// RVA: 0x21CDDA0 Offset: 0x21CC3A0 VA: 0x1821CDDA0 Slot: 35
	public void Reset() { }
}
