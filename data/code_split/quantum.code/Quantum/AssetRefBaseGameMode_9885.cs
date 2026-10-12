// Namespace: Quantum
[AssetRef(typeof(BaseGameMode))]
[Serializable]
public struct AssetRefBaseGameMode : IEquatable<AssetRefBaseGameMode>, IAssetRef<BaseGameMode> // TypeDefIndex: 9885
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7100 Offset: 0x20C5700 VA: 0x1820C7100 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefBaseGameMode other) { }

	// RVA: 0x20C7190 Offset: 0x20C5790 VA: 0x1820C7190 Slot: 2
	public override int GetHashCode() { }
}
