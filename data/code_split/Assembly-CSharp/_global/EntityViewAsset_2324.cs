// Namespace: 
public class EntityViewAsset : AssetBase, IQuantumPrefabNestedAsset<EntityView>, IQuantumPrefabNestedAsset // TypeDefIndex: 2324
{
	// Fields
	public EntityView Settings; // 0x18
	public EntityView Parent; // 0x20

	// Properties
	[Obsolete("Use View instead")]
	public EntityView Prefab { get; }
	public EntityView View { get; }
	public override AssetObject AssetObject { get; }
	private Component IQuantumPrefabNestedAsset.Parent { get; }
	public virtual EntityViewAssetStatus ViewStatus { get; }

	// Methods

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public EntityView get_Prefab() { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public EntityView get_View() { }

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300 Slot: 11
	private Component IQuantumPrefabNestedAsset.get_Parent() { }

	// RVA: 0x511140 Offset: 0x50F740 VA: 0x180511140 Slot: 9
	public override void Reset() { }

	// RVA: 0x5111B0 Offset: 0x50F7B0 VA: 0x1805111B0 Slot: 12
	public virtual EntityViewAssetStatus get_ViewStatus() { }

	// RVA: 0x5110E0 Offset: 0x50F6E0 VA: 0x1805110E0 Slot: 13
	public virtual void LoadViewPrefab(bool async = False) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
