// Namespace: Quantum
[AssetRef(typeof(CombatData))]
[Serializable]
public struct AssetRefCombatData : IEquatable<AssetRefCombatData>, IAssetRef<CombatData> // TypeDefIndex: 9887
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7260 Offset: 0x20C5860 VA: 0x1820C7260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefCombatData other) { }

	// RVA: 0x20C72F0 Offset: 0x20C58F0 VA: 0x1820C72F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6E00 Offset: 0x20C5400 VA: 0x1820C6E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
