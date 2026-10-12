// Namespace: Quantum
public struct Movable : IComponent // TypeDefIndex: 10011
{
	// Fields
	public FPVector2 PreviousPosition; // 0x8
	public QBoolean Teleported; // 0x0
	public QBoolean TeleportedFlag; // 0x4

	// Methods

	// RVA: 0x2120EA0 Offset: 0x211F4A0 VA: 0x182120EA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2120ED0 Offset: 0x211F4D0 VA: 0x182120ED0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
