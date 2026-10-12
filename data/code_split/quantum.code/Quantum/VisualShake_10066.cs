// Namespace: Quantum
public struct VisualShake : IComponent // TypeDefIndex: 10066
{
	// Fields
	public EntityRef Entity; // 0x8
	public FP ShakeFrames; // 0x10
	public QBoolean ShakeHorizontally; // 0x0
	public FP ShakePower; // 0x18
	public QBoolean ShakeVertically; // 0x4

	// Methods

	// RVA: 0x214E570 Offset: 0x214CB70 VA: 0x18214E570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214E5D0 Offset: 0x214CBD0 VA: 0x18214E5D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
