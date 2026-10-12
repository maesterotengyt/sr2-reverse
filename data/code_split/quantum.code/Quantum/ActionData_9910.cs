// Namespace: Quantum
public struct ActionData // TypeDefIndex: 9910
{
	// Fields
	public InputFlag Flag; // 0x0
	public FP FrameDelay; // 0x8
	public FP Frames; // 0x10
	public QBoolean Overriden; // 0x4

	// Methods

	// RVA: 0x20C6BA0 Offset: 0x20C51A0 VA: 0x1820C6BA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C6BF0 Offset: 0x20C51F0 VA: 0x1820C6BF0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
