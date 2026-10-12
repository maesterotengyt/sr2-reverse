// Namespace: Quantum.Prototypes
[Prototype(typeof(LayoutManager))]
[Serializable]
public sealed class LayoutManager_Prototype : ComponentPrototype<LayoutManager> // TypeDefIndex: 10823
{
	// Fields
	[DynamicCollection]
	public StageEntity_Prototype[] StageEntities; // 0x18

	// Methods

	// RVA: 0x21085A0 Offset: 0x2106BA0 VA: 0x1821085A0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108710 Offset: 0x2106D10 VA: 0x182108710
	public void Materialize(Frame frame, ref LayoutManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108680 Offset: 0x2106C80 VA: 0x182108680 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21089E0 Offset: 0x2106FE0 VA: 0x1821089E0
	public void .ctor() { }
}
