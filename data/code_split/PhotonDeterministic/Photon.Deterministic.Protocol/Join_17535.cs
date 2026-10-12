// Namespace: Photon.Deterministic.Protocol
public class Join : Message // TypeDefIndex: 17535
{
	// Fields
	public string Id; // 0x10
	public string ProtocolVersion; // 0x18
	public int InitialTick; // 0x20
	public int PlayerCount; // 0x24
	public int PlayerSlots; // 0x28
	[Obsolete("Not used anymore")]
	public bool Rejoin; // 0x2C

	// Methods

	// RVA: 0x20C37A0 Offset: 0x20C1DA0 VA: 0x1820C37A0 Slot: 4
	public override void Serialize(Serializer serializer, BitStream stream) { }

	// RVA: 0x20C3830 Offset: 0x20C1E30 VA: 0x1820C3830 Slot: 3
	public override string ToString() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
