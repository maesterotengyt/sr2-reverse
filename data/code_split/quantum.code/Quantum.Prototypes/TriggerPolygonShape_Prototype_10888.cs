// Namespace: Quantum.Prototypes
[Prototype(typeof(TriggerPolygonShape))]
[Serializable]
public sealed class TriggerPolygonShape_Prototype : ComponentPrototype<TriggerPolygonShape> // TypeDefIndex: 10888
{
	// Fields
	[DynamicCollection]
	public FPVector2[] PolygonVertices; // 0x18
	[HideInInspector]
	public FPVector2 Center; // 0x20

	// Methods

	// RVA: 0x2113C30 Offset: 0x2112230 VA: 0x182113C30 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113F10 Offset: 0x2112510 VA: 0x182113F10
	public void Materialize(Frame frame, ref TriggerPolygonShape result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113E80 Offset: 0x2112480 VA: 0x182113E80 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2114080 Offset: 0x2112680 VA: 0x182114080
	public void .ctor() { }
}
