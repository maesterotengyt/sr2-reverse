// Namespace: 
public class EntityPrototypeAsset : AssetBase, IQuantumPrefabNestedAsset<EntityPrototype>, IQuantumPrefabNestedAsset // TypeDefIndex: 2321
{
	// Fields
	protected static readonly List<ComponentPrototype> prototypeBuffer; // 0x0
	private static readonly List<EntityComponentBase> behaviourBuffer; // 0x8
	private static readonly EntityPrototypeAsset.Visitor cache; // 0x10
	public EntityPrototype Settings; // 0x18
	public EntityPrototype Parent; // 0x20

	// Properties
	public override AssetObject AssetObject { get; }
	private Component IQuantumPrefabNestedAsset.Parent { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300 Slot: 11
	private Component IQuantumPrefabNestedAsset.get_Parent() { }

	// RVA: 0x503BC0 Offset: 0x5021C0 VA: 0x180503BC0 Slot: 6
	public override void Loaded() { }

	// RVA: 0x510480 Offset: 0x50EA80 VA: 0x180510480 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x510C10 Offset: 0x50F210 VA: 0x180510C10 Slot: 9
	public override void Reset() { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }

	// RVA: 0x510CC0 Offset: 0x50F2C0 VA: 0x180510CC0
	private static void .cctor() { }
}
