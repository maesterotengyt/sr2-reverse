// Namespace: Quantum.Prototypes
[Prototype(typeof(MechanicTutorialGameModeManager))]
[Serializable]
public sealed class MechanicTutorialGameModeManager_Prototype : ComponentPrototype<MechanicTutorialGameModeManager> // TypeDefIndex: 10825
{
	// Fields
	public int SectionIndex; // 0x18
	[DynamicCollection]
	public RuntimeMechanicTutorialGoal_Prototype[] Goals; // 0x20
	public FP RemainingTimerFrames; // 0x28
	public FP TotalTimerFrames; // 0x30
	public QBoolean SectionCompleted; // 0x38

	// Methods

	// RVA: 0x2108C00 Offset: 0x2107200 VA: 0x182108C00 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108F10 Offset: 0x2107510 VA: 0x182108F10
	public void Materialize(Frame frame, ref MechanicTutorialGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108E80 Offset: 0x2107480 VA: 0x182108E80 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21090A0 Offset: 0x21076A0 VA: 0x1821090A0
	public void .ctor() { }
}
