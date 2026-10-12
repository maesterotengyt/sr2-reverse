// Namespace: Photon.Deterministic.Protocol
public abstract class Message // TypeDefIndex: 17539
{
	// Methods

	// RVA: 0x20C3B40 Offset: 0x20C2140 VA: 0x1820C3B40
	internal Message Clone() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Serialize(Serializer serializer, BitStream stream);

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
