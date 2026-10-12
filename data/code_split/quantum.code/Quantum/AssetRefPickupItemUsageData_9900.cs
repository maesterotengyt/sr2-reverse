// Namespace: Quantum
[AssetRef(typeof(PickupItemUsageData))]
[Serializable]
public struct AssetRefPickupItemUsageData : IEquatable<AssetRefPickupItemUsageData>, IAssetRef<PickupItemUsageData> // TypeDefIndex: 9900
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7B50 Offset: 0x20C6150 VA: 0x1820C7B50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefPickupItemUsageData other) { }

	// RVA: 0x20C7BE0 Offset: 0x20C61E0 VA: 0x1820C7BE0 Slot: 2
	public override int GetHashCode() { }
}
