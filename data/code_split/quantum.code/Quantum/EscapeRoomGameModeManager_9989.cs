// Namespace: Quantum
public struct EscapeRoomGameModeManager : IComponent // TypeDefIndex: 9989
{
	// Fields
	public QBoolean CourseCompleted; // 0x0
	public FP CurrentCountdown; // 0x10
	public QString64 CurrentCourseID; // 0x38
	public FP CurrentMatchTimer; // 0x18
	public RaceState CurrentState; // 0x8
	public QBoolean HasDialogue; // 0x4
	public FP InitialDelayFrames; // 0x20
	public FP RemainingTimerFrames; // 0x28
	public FP TotalTimerFrames; // 0x30

	// Methods

	// RVA: 0x20E2780 Offset: 0x20E0D80 VA: 0x1820E2780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E2810 Offset: 0x20E0E10 VA: 0x1820E2810
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
