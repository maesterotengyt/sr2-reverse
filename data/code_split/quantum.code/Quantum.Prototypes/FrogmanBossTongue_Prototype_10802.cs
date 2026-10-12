// Namespace: Quantum.Prototypes
[Prototype(typeof(FrogmanBossTongue))]
[Serializable]
public sealed class FrogmanBossTongue_Prototype : ComponentPrototype<FrogmanBossTongue> // TypeDefIndex: 10802
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Hooked; // 0x1C
	public FPVector2 LastDirection; // 0x20
	public MapEntityId TargetEntity; // 0x30
	public FP FramesWithoutTarget; // 0x38
	public FP PullFramesCountdown; // 0x40

	// Methods

	// RVA: 0x2105200 Offset: 0x2103800 VA: 0x182105200 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21053E0 Offset: 0x21039E0 VA: 0x1821053E0
	public void Materialize(Frame frame, ref FrogmanBossTongue result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2105350 Offset: 0x2103950 VA: 0x182105350 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2105450 Offset: 0x2103A50 VA: 0x182105450
	public void .ctor() { }
}
