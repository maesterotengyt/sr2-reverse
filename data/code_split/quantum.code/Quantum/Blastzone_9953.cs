// Namespace: Quantum
public struct Blastzone : IComponent // TypeDefIndex: 9953
{
	// Fields
	public FPVector2 BottomRight; // 0x8
	public FPVector2 TopLeft; // 0x18
	[HideInInspector]
	public QBoolean TriggerEnabled; // 0x0

	// Methods

	// RVA: 0x20C8620 Offset: 0x20C6C20 VA: 0x1820C8620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C8670 Offset: 0x20C6C70 VA: 0x1820C8670
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20C86C0 Offset: 0x20C6CC0 VA: 0x1820C86C0
	public static bool TryFind(Frame frame, out Blastzone* blastzone) { }
}
