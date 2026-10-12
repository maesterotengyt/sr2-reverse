// Namespace: Quantum
[AssetRef(typeof(CombatSettingsData))]
[Serializable]
public struct AssetRefCombatSettingsData : IEquatable<AssetRefCombatSettingsData>, IAssetRef<CombatSettingsData> // TypeDefIndex: 9888
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x20C6E20 Offset: 0x20C5420 VA: 0x1820C6E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C7310 Offset: 0x20C5910 VA: 0x1820C7310 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20C6DD0 Offset: 0x20C53D0 VA: 0x1820C6DD0 Slot: 4
	public bool Equals(AssetRefCombatSettingsData other) { }

	// RVA: 0x20C73A0 Offset: 0x20C59A0 VA: 0x1820C73A0 Slot: 2
	public override int GetHashCode() { }
}
