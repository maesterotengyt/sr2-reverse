// Namespace: Quantum
public struct MechanicTutorialGoalTrigger : IComponent // TypeDefIndex: 10010
{
	// Fields
	public QString64 GoalID; // 0x20
	public FP RequiredHorizontalVelocity; // 0x8
	public QString64 RequiredPreviousState; // 0x60
	public QString64 RequiredState; // 0xA0
	public FP RequiredTotalVelocity; // 0x10
	public FP RequiredVerticalVelocity; // 0x18
	public QBoolean UseAbsoluteHorizontal; // 0x0
	public QBoolean UseAbsoluteVertical; // 0x4

	// Methods

	// RVA: 0x2120A00 Offset: 0x211F000 VA: 0x182120A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2120E00 Offset: 0x211F400 VA: 0x182120E00
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2120A90 Offset: 0x211F090 VA: 0x182120A90
	public void OnBodyEnter(Frame frame, EntityRef otherEntity) { }
}
