// Namespace: Quantum
public struct Shockwave : IComponent // TypeDefIndex: 10032
{
	// Fields
	public EntityRef Entity; // 0x0
	public FPVector2 InitialPosition; // 0x10
	public FP Power; // 0x8
	public FPVector2 TargetPosition; // 0x20

	// Methods

	// RVA: 0x212B6B0 Offset: 0x2129CB0 VA: 0x18212B6B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212B710 Offset: 0x2129D10 VA: 0x18212B710
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
