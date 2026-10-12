// Namespace: Quantum
public struct Rocket : IComponent // TypeDefIndex: 10027
{
	// Fields
	public EntityRef Entity; // 0x0
	public FP InterpolationSpeed; // 0x10
	public FP ReCheckTargetFrames; // 0x18
	public EntityRef Target; // 0x8

	// Methods

	// RVA: 0x212B5C0 Offset: 0x2129BC0 VA: 0x18212B5C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212B620 Offset: 0x2129C20 VA: 0x18212B620
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
