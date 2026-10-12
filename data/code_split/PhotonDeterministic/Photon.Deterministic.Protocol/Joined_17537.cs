// Namespace: Photon.Deterministic.Protocol
public class Joined : Message // TypeDefIndex: 17537
{
	// Fields
	public JoinStatus Status; // 0x10
	public bool Confirmed; // 0x14
	public int[] PlayerSlots; // 0x18

	// Properties
	public bool IsConfirmed { get; }

	// Methods

	// RVA: 0x20C3B20 Offset: 0x20C2120 VA: 0x1820C3B20
	public bool get_IsConfirmed() { }

	// RVA: 0x20C38A0 Offset: 0x20C1EA0 VA: 0x1820C38A0 Slot: 4
	public override void Serialize(Serializer serializer, BitStream stream) { }

	// RVA: 0x20C3930 Offset: 0x20C1F30 VA: 0x1820C3930 Slot: 3
	public override string ToString() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
