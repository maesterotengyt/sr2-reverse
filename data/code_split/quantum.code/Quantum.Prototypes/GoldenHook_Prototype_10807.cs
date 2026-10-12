// Namespace: Quantum.Prototypes
[Prototype(typeof(GoldenHook))]
[Serializable]
public sealed class GoldenHook_Prototype : ComponentPrototype<GoldenHook> // TypeDefIndex: 10807
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Hooked; // 0x1C
	public FPVector2 LastDirection; // 0x20
	public MapEntityId TargetEntity; // 0x30
	public FP FramesWithoutTarget; // 0x38
	public FP PullFramesCountdown; // 0x40

	// Methods

	// RVA: 0x21063B0 Offset: 0x21049B0 VA: 0x1821063B0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21053E0 Offset: 0x21039E0 VA: 0x1821053E0
	public void Materialize(Frame frame, ref GoldenHook result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2106500 Offset: 0x2104B00 VA: 0x182106500 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2106590 Offset: 0x2104B90 VA: 0x182106590
	public void .ctor() { }
}
