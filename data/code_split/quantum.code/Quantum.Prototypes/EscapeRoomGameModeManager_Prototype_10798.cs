// Namespace: Quantum.Prototypes
[Prototype(typeof(EscapeRoomGameModeManager))]
[Serializable]
public sealed class EscapeRoomGameModeManager_Prototype : ComponentPrototype<EscapeRoomGameModeManager> // TypeDefIndex: 10798
{
	// Fields
	public RaceState_Prototype CurrentState; // 0x18
	public FP CurrentCountdown; // 0x20
	public FP CurrentMatchTimer; // 0x28
	public QString64 CurrentCourseID; // 0x30
	public FP RemainingTimerFrames; // 0x70
	public FP TotalTimerFrames; // 0x78
	public QBoolean CourseCompleted; // 0x80
	public QBoolean HasDialogue; // 0x84
	public FP InitialDelayFrames; // 0x88

	// Methods

	// RVA: 0x2104B90 Offset: 0x2103190 VA: 0x182104B90 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2104DD0 Offset: 0x21033D0 VA: 0x182104DD0
	public void Materialize(Frame frame, ref EscapeRoomGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2104D40 Offset: 0x2103340 VA: 0x182104D40 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2104E40 Offset: 0x2103440 VA: 0x182104E40
	public void .ctor() { }
}
