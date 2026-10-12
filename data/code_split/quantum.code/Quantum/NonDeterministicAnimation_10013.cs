// Namespace: Quantum
public struct NonDeterministicAnimation : IComponent // TypeDefIndex: 10013
{
	// Fields
	public QString128 AnimationTrigger; // 0x4
	public StageExecutionMode ExecutionMode; // 0x0

	// Methods

	// RVA: 0x2121440 Offset: 0x211FA40 VA: 0x182121440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21214F0 Offset: 0x211FAF0 VA: 0x1821214F0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2121470 Offset: 0x211FA70 VA: 0x182121470
	public void PlayAnimation(Frame frame, EntityRef entityRef) { }
}
