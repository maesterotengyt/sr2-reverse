// Namespace: Quantum
public struct MechanicTutorialGameModeManager : IComponent // TypeDefIndex: 10009
{
	// Fields
	[PtrQList(typeof(RuntimeMechanicTutorialGoal))]
	private Ptr GoalsPtr; // 0x8
	public FP RemainingTimerFrames; // 0x10
	public QBoolean SectionCompleted; // 0x4
	public int SectionIndex; // 0x0
	public FP TotalTimerFrames; // 0x18

	// Properties
	public QListPtr<RuntimeMechanicTutorialGoal> Goals { get; set; }

	// Methods

	// RVA: 0x21209C0 Offset: 0x211EFC0 VA: 0x1821209C0
	public QListPtr<RuntimeMechanicTutorialGoal> get_Goals() { }

	// RVA: 0x1ED2130 Offset: 0x1ED0730 VA: 0x181ED2130
	public void set_Goals(QListPtr<RuntimeMechanicTutorialGoal> value) { }

	// RVA: 0x21207E0 Offset: 0x211EDE0 VA: 0x1821207E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21207D0 Offset: 0x211EDD0 VA: 0x1821207D0
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2120840 Offset: 0x211EE40 VA: 0x182120840
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x21208C0 Offset: 0x211EEC0 VA: 0x1821208C0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
