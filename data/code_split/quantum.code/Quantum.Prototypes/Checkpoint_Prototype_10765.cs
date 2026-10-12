// Namespace: Quantum.Prototypes
[Prototype(typeof(Checkpoint))]
[Serializable]
public sealed class Checkpoint_Prototype : ComponentPrototype<Checkpoint> // TypeDefIndex: 10765
{
	// Fields
	public QBoolean Active; // 0x18
	public QBoolean StartPoint; // 0x1C
	public FP DistanceToFinish; // 0x20
	public MapEntityId RespawnPoint; // 0x28

	// Methods

	// RVA: 0x20FE5C0 Offset: 0x20FCBC0 VA: 0x1820FE5C0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FE750 Offset: 0x20FCD50 VA: 0x1820FE750
	public void Materialize(Frame frame, ref Checkpoint result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FE6C0 Offset: 0x20FCCC0 VA: 0x1820FE6C0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FE7A0 Offset: 0x20FCDA0 VA: 0x1820FE7A0
	public void .ctor() { }
}
