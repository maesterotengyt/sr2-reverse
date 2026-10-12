// Namespace: Quantum
public struct BreakableGlass : IComponent // TypeDefIndex: 9956
{
	// Fields
	public int FramesToRestore; // 0x0
	public QString64 GoalOnBreak; // 0x10
	public QBoolean IsRestorable; // 0x4
	public FP VelocityToBreak; // 0x8

	// Methods

	// RVA: 0x20C8950 Offset: 0x20C6F50 VA: 0x1820C8950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C89E0 Offset: 0x20C6FE0 VA: 0x1820C89E0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
