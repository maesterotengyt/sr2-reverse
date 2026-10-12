// Namespace: Quantum.Prototypes
[Prototype(typeof(VisibilitySource))]
[Serializable]
public sealed class VisibilitySource_Prototype : ComponentPrototype<VisibilitySource> // TypeDefIndex: 10891
{
	// Fields
	[HideInInspector]
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	public SimpleAABB_Prototype Bounds; // 0x20

	// Methods

	// RVA: 0x2119290 Offset: 0x2117890 VA: 0x182119290 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2119450 Offset: 0x2117A50 VA: 0x182119450
	public void Materialize(Frame frame, ref VisibilitySource result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21193C0 Offset: 0x21179C0 VA: 0x1821193C0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21194B0 Offset: 0x2117AB0 VA: 0x1821194B0
	public void .ctor() { }
}
