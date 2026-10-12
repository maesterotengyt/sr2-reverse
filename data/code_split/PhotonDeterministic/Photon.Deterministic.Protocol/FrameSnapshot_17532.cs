// Namespace: Photon.Deterministic.Protocol
public class FrameSnapshot : Message // TypeDefIndex: 17532
{
	// Fields
	public int Tick; // 0x10
	public int TotalSize; // 0x14
	public bool Last; // 0x18
	public byte[] Data; // 0x20

	// Methods

	// RVA: 0x20C35D0 Offset: 0x20C1BD0 VA: 0x1820C35D0 Slot: 4
	public override void Serialize(Serializer serializer, BitStream stream) { }

	// RVA: 0x20C3640 Offset: 0x20C1C40 VA: 0x1820C3640 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C3430 Offset: 0x20C1A30 VA: 0x1820C3430
	public static FrameSnapshot[] Encode(int tick, byte[] data) { }

	// RVA: 0x20C3310 Offset: 0x20C1910 VA: 0x1820C3310
	public static void Decode(FrameSnapshot[] snapshots, ref byte[] data, ref int tick) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
