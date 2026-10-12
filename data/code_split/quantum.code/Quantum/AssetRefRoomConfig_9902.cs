// Namespace: Quantum
[AssetRef(typeof(RoomConfig))]
[Serializable]
public struct AssetRefRoomConfig : IEquatable<AssetRefRoomConfig>, IAssetRef<RoomConfig> // TypeDefIndex: 9902
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7CB0 Offset: 0x20C62B0 VA: 0x1820C7CB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefRoomConfig other) { }

	// RVA: 0x20C7D40 Offset: 0x20C6340 VA: 0x1820C7D40 Slot: 2
	public override int GetHashCode() { }
}
