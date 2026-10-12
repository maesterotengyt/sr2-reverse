// Namespace: Quantum
[AssetRef(typeof(State))]
[Serializable]
public struct AssetRefState : IEquatable<AssetRefState>, IAssetRef<State> // TypeDefIndex: 9904
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7F80 Offset: 0x20C6580 VA: 0x1820C7F80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefState other) { }

	// RVA: 0x20C8010 Offset: 0x20C6610 VA: 0x1820C8010 Slot: 2
	public override int GetHashCode() { }
}
