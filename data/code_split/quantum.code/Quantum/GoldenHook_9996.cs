// Namespace: Quantum
public struct GoldenHook : IComponent // TypeDefIndex: 9996
{
	// Fields
	public EntityRef Entity; // 0x8
	public FP FramesWithoutTarget; // 0x18
	public QBoolean Hooked; // 0x0
	public FPVector2 LastDirection; // 0x28
	public FP PullFramesCountdown; // 0x20
	public EntityRef TargetEntity; // 0x10

	// Methods

	// RVA: 0x211A850 Offset: 0x2118E50 VA: 0x18211A850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E2B60 Offset: 0x20E1160 VA: 0x1820E2B60
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
