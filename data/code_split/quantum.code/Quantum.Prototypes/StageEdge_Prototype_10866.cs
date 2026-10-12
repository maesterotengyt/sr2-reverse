// Namespace: Quantum.Prototypes
[Prototype(typeof(StageEdge))]
[Serializable]
public sealed class StageEdge_Prototype : ComponentPrototype<StageEdge> // TypeDefIndex: 10866
{
	// Fields
	public QBoolean Active; // 0x18
	public EdgeSide_Prototype EdgeSide; // 0x1C
	[HideInInspector]
	public MapEntityId GrabbedEntity; // 0x20

	// Methods

	// RVA: 0x21105E0 Offset: 0x210EBE0 VA: 0x1821105E0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110750 Offset: 0x210ED50 VA: 0x182110750
	public void Materialize(Frame frame, ref StageEdge result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21106C0 Offset: 0x210ECC0 VA: 0x1821106C0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2110770 Offset: 0x210ED70 VA: 0x182110770
	public void .ctor() { }
}
