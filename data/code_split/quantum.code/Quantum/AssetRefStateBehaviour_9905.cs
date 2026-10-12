// Namespace: Quantum
[AssetRef(typeof(StateBehaviour))]
[Serializable]
public struct AssetRefStateBehaviour : IEquatable<AssetRefStateBehaviour>, IAssetRef<StateBehaviour> // TypeDefIndex: 9905
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7E10 Offset: 0x20C6410 VA: 0x1820C7E10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefStateBehaviour other) { }

	// RVA: 0x20C7EA0 Offset: 0x20C64A0 VA: 0x1820C7EA0 Slot: 2
	public override int GetHashCode() { }
}
