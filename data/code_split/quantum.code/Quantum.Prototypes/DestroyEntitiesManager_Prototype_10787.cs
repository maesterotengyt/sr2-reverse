// Namespace: Quantum.Prototypes
[Prototype(typeof(DestroyEntitiesManager))]
[Serializable]
public sealed class DestroyEntitiesManager_Prototype : ComponentPrototype<DestroyEntitiesManager> // TypeDefIndex: 10787
{
	// Fields
	[DynamicCollection]
	public MapEntityId[] EntitiesToDestroy; // 0x18

	// Methods

	// RVA: 0x21029A0 Offset: 0x2100FA0 VA: 0x1821029A0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2102C70 Offset: 0x2101270 VA: 0x182102C70
	public void Materialize(Frame frame, ref DestroyEntitiesManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2102BE0 Offset: 0x21011E0 VA: 0x182102BE0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2102E00 Offset: 0x2101400 VA: 0x182102E00
	public void .ctor() { }
}
