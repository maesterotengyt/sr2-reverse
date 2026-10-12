// Namespace: Quantum.Prototypes
[Prototype(typeof(EntityReferencesHandler))]
[Serializable]
public sealed class EntityReferencesHandler_Prototype : ComponentPrototype<EntityReferencesHandler> // TypeDefIndex: 10796
{
	// Fields
	[DynamicCollection]
	public GameEntityReference_Prototype[] Entities; // 0x18

	// Methods

	// RVA: 0x2104680 Offset: 0x2102C80 VA: 0x182104680 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21047F0 Offset: 0x2102DF0 VA: 0x1821047F0
	public void Materialize(Frame frame, ref EntityReferencesHandler result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2104760 Offset: 0x2102D60 VA: 0x182104760 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2104A10 Offset: 0x2103010 VA: 0x182104A10
	public void .ctor() { }
}
