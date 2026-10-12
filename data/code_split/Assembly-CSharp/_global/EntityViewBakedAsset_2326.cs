// Namespace: 
internal class EntityViewBakedAsset : EntityViewAsset, IQuantumPrefabBakedAsset, QuantumPrefabAsset.IListener // TypeDefIndex: 2326
{
	// Fields
	public QuantumPrefabAsset PrefabAsset; // 0x28
	private EntityViewAssetStatus _status; // 0x30

	// Properties
	public override EntityViewAssetStatus ViewStatus { get; }

	// Methods

	// RVA: 0x5114B0 Offset: 0x50FAB0 VA: 0x1805114B0 Slot: 12
	public override EntityViewAssetStatus get_ViewStatus() { }

	// RVA: 0x511270 Offset: 0x50F870 VA: 0x180511270 Slot: 13
	public override void LoadViewPrefab(bool async) { }

	// RVA: 0x503BC0 Offset: 0x5021C0 VA: 0x180503BC0 Slot: 6
	public override void Loaded() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x5113C0 Offset: 0x50F9C0 VA: 0x1805113C0 Slot: 15
	private void QuantumPrefabAsset.IListener.Error(QuantumPrefabAsset source, Exception error) { }

	// RVA: 0x511440 Offset: 0x50FA40 VA: 0x180511440 Slot: 16
	private void QuantumPrefabAsset.IListener.Loaded(QuantumPrefabAsset source, GameObject prefab) { }

	// RVA: 0x5111C0 Offset: 0x50F7C0 VA: 0x1805111C0 Slot: 14
	private void IQuantumPrefabBakedAsset.Import(QuantumPrefabAsset prefab, IQuantumPrefabNestedAsset asset) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
