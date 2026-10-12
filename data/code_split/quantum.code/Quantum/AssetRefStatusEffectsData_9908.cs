// Namespace: Quantum
[AssetRef(typeof(StatusEffectsData))]
[Serializable]
public struct AssetRefStatusEffectsData : IEquatable<AssetRefStatusEffectsData>, IAssetRef<StatusEffectsData> // TypeDefIndex: 9908
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C80E0 Offset: 0x20C66E0 VA: 0x1820C80E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefStatusEffectsData other) { }

	// RVA: 0x20C8170 Offset: 0x20C6770 VA: 0x1820C8170 Slot: 2
	public override int GetHashCode() { }
}
