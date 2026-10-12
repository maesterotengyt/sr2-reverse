// Namespace: Quantum.Prototypes
[Prototype(typeof(InitialWaitTimer))]
[Serializable]
public sealed class InitialWaitTimer_Prototype : ComponentPrototype<InitialWaitTimer> // TypeDefIndex: 10814
{
	// Fields
	public InitialWaitTimerState_Prototype State; // 0x18
	public FP RemainingTimerFrames; // 0x20

	// Methods

	// RVA: 0x2107420 Offset: 0x2105A20 VA: 0x182107420 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21051B0 Offset: 0x21037B0 VA: 0x1821051B0
	public void Materialize(Frame frame, ref InitialWaitTimer result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21074F0 Offset: 0x2105AF0 VA: 0x1821074F0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2107580 Offset: 0x2105B80 VA: 0x182107580
	public void .ctor() { }
}
