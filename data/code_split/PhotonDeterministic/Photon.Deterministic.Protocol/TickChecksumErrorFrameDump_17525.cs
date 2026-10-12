// Namespace: Photon.Deterministic.Protocol
public class TickChecksumErrorFrameDump : Message // TypeDefIndex: 17525
{
	// Fields
	public int Frame; // 0x10
	public int Block; // 0x14
	public int BlockCount; // 0x18
	public int ActorId; // 0x1C
	public byte[] Data; // 0x20

	// Methods

	// RVA: 0x20C5900 Offset: 0x20C3F00 VA: 0x1820C5900 Slot: 4
	public override void Serialize(Serializer serializer, BitStream stream) { }

	// RVA: 0x20C56C0 Offset: 0x20C3CC0 VA: 0x1820C56C0
	public static TickChecksumErrorFrameDump[] Encode(int tick, byte[] dump) { }

	// RVA: 0x20C5030 Offset: 0x20C3630 VA: 0x1820C5030
	public static QTuple<bool, byte[]> Decode(IEnumerable<TickChecksumErrorFrameDump> blocks) { }

	// RVA: 0x20C4F80 Offset: 0x20C3580 VA: 0x1820C4F80
	private static byte[] CopyBlock(byte[] data, int block, int blockSize) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
