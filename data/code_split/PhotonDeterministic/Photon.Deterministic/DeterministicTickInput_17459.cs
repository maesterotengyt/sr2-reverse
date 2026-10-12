// Namespace: Photon.Deterministic
[Serializable]
public class DeterministicTickInput // TypeDefIndex: 17459
{
	// Fields
	public bool Sent; // 0x10
	internal bool Pooled; // 0x11
	internal DeterministicTickInput Next; // 0x18
	public int Tick; // 0x20
	public int PlayerIndex; // 0x24
	public byte[] Rpc; // 0x28
	public byte[] DataArray; // 0x30
	public int DataLength; // 0x38
	public DeterministicInputFlags Flags; // 0x3C

	// Methods

	// RVA: 0x20BDCD0 Offset: 0x20BC2D0 VA: 0x1820BDCD0
	public void CopyToDataArray(byte[] array, int length) { }

	// RVA: 0x20BDD70 Offset: 0x20BC370 VA: 0x1820BDD70
	public void SerializeForDecoder(Serializer serializer, BitStream stream, DeterministicTickInputEncodeHeader header) { }

	// RVA: 0x20BDF70 Offset: 0x20BC570 VA: 0x1820BDF70
	public void SimpleSerialize(Serializer serializer, BitStream stream, bool ignoreRpc = False) { }

	// RVA: 0x20BE0E0 Offset: 0x20BC6E0 VA: 0x1820BE0E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
