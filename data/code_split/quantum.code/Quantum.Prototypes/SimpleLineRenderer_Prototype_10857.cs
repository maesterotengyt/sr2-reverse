// Namespace: Quantum.Prototypes
[Prototype(typeof(SimpleLineRenderer))]
[Serializable]
public sealed class SimpleLineRenderer_Prototype : ComponentPrototype<SimpleLineRenderer> // TypeDefIndex: 10857
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Visible; // 0x1C
	public FPVector2 PointA; // 0x20
	public FPVector2 PointB; // 0x30
	public SimpleLineEndRotationMode_Prototype PointARotationMode; // 0x40
	public SimpleLineEndRotationMode_Prototype PointBRotationMode; // 0x44

	// Methods

	// RVA: 0x210E000 Offset: 0x210C600 VA: 0x18210E000 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210E1D0 Offset: 0x210C7D0 VA: 0x18210E1D0
	public void Materialize(Frame frame, ref SimpleLineRenderer result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210E140 Offset: 0x210C740 VA: 0x18210E140 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210E220 Offset: 0x210C820 VA: 0x18210E220
	public void .ctor() { }
}
