// Namespace: Quantum.Prototypes
[Prototype(typeof(ParentObject))]
[Serializable]
public sealed class ParentObject_Prototype : ComponentPrototype<ParentObject> // TypeDefIndex: 10832
{
	// Fields
	public MapEntityId ParentEntity; // 0x18
	[DynamicCollection]
	public ChildEntity_Prototype[] ChildEntities; // 0x20

	// Methods

	// RVA: 0x2109FF0 Offset: 0x21085F0 VA: 0x182109FF0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210A170 Offset: 0x2108770 VA: 0x18210A170
	public void Materialize(Frame frame, ref ParentObject result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210A0E0 Offset: 0x21086E0 VA: 0x18210A0E0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210A350 Offset: 0x2108950 VA: 0x18210A350
	public void .ctor() { }
}
