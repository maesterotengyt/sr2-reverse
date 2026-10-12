// Namespace: Quantum
[AssetRef(typeof(PlayerSettings))]
[Serializable]
public struct AssetRefPlayerSettings : IEquatable<AssetRefPlayerSettings>, IAssetRef<PlayerSettings> // TypeDefIndex: 9901
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7C00 Offset: 0x20C6200 VA: 0x1820C7C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefPlayerSettings other) { }

	// RVA: 0x20C7C90 Offset: 0x20C6290 VA: 0x1820C7C90 Slot: 2
	public override int GetHashCode() { }
}
