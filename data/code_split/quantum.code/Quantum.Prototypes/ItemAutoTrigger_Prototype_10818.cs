// Namespace: Quantum.Prototypes
[Prototype(typeof(ItemAutoTrigger))]
[Serializable]
public sealed class ItemAutoTrigger_Prototype : ComponentPrototype<ItemAutoTrigger> // TypeDefIndex: 10818
{
	// Fields
	[HideInInspector]
	public MapEntityId Entity; // 0x18
	public QString64 ItemToUse; // 0x1C
	public int UseFramesInterval; // 0x5C
	[HideInInspector]
	public FP RemainingFramesToUseItem; // 0x60

	// Methods

	// RVA: 0x2107B60 Offset: 0x2106160 VA: 0x182107B60 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2107D50 Offset: 0x2106350 VA: 0x182107D50
	public void Materialize(Frame frame, ref ItemAutoTrigger result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2107CC0 Offset: 0x21062C0 VA: 0x182107CC0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2107DB0 Offset: 0x21063B0 VA: 0x182107DB0
	public void .ctor() { }
}
