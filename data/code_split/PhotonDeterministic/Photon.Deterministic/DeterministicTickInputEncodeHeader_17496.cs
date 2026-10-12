// Namespace: Photon.Deterministic
public struct DeterministicTickInputEncodeHeader // TypeDefIndex: 17496
{
	// Fields
	public int MaxPing; // 0x0
	public int PlayerCount; // 0x4
	public int InputFixedSize; // 0x8
	public double ServerTime; // 0x10
	public double ServerTimeScale; // 0x18
	public bool InputFixedSizeEnabled; // 0x20

	// Methods

	// RVA: 0x20BDBB0 Offset: 0x20BC1B0 VA: 0x1820BDBB0
	public void Serialize(BitStream stream) { }
}
