// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(ItemAutoTrigger))]
[Serializable]
public class ItemAutoTrigger_Prototype : PrototypeAdapter<ItemAutoTrigger_Prototype> // TypeDefIndex: 3904
{
	// Fields
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QString64 ItemToUse; // 0x18
	public int UseFramesInterval; // 0x58
	[HideInInspector]
	public FP RemainingFramesToUseItem; // 0x60

	// Methods

	// RVA: 0x677B10 Offset: 0x676110 VA: 0x180677B10 Slot: 5
	public sealed override ItemAutoTrigger_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677BC0 Offset: 0x6761C0 VA: 0x180677BC0
	public void .ctor() { }
}
