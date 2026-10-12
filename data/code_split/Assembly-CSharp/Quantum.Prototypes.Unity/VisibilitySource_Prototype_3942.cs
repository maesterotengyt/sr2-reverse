// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(VisibilitySource))]
[Serializable]
public class VisibilitySource_Prototype : PrototypeAdapter<VisibilitySource_Prototype> // TypeDefIndex: 3942
{
	// Fields
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
	public SimpleAABB_Prototype Bounds; // 0x20

	// Methods

	// RVA: 0x684DD0 Offset: 0x6833D0 VA: 0x180684DD0 Slot: 5
	public sealed override VisibilitySource_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x684E70 Offset: 0x683470 VA: 0x180684E70
	public void .ctor() { }
}
