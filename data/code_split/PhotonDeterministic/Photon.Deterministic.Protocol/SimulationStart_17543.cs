// Namespace: Photon.Deterministic.Protocol
public class SimulationStart : Message // TypeDefIndex: 17543
{
	// Fields
	public bool Reconnect; // 0x10
	public double ServerTime; // 0x18
	public byte[] RuntimeConfig; // 0x20
	public DeterministicSessionConfig SessionConfig; // 0x28

	// Methods

	// RVA: 0x20C4E50 Offset: 0x20C3450 VA: 0x1820C4E50 Slot: 4
	public override void Serialize(Serializer serializer, BitStream stream) { }

	// RVA: 0x20C4ED0 Offset: 0x20C34D0 VA: 0x1820C4ED0 Slot: 3
	public override string ToString() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
