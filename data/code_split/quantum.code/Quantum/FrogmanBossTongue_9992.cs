// Namespace: Quantum
public struct FrogmanBossTongue : IComponent // TypeDefIndex: 9992
{
	// Fields
	public EntityRef Entity; // 0x8
	public FP FramesWithoutTarget; // 0x18
	public QBoolean Hooked; // 0x0
	public FPVector2 LastDirection; // 0x28
	public FP PullFramesCountdown; // 0x20
	public EntityRef TargetEntity; // 0x10

	// Methods

	// RVA: 0x20E2AF0 Offset: 0x20E10F0 VA: 0x1820E2AF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E2B60 Offset: 0x20E1160 VA: 0x1820E2B60
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
