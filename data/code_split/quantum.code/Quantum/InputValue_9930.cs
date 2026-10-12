// Namespace: Quantum
public struct InputValue // TypeDefIndex: 9930
{
	// Fields
	public InputFlag IgnoreFlag; // 0x0
	public InputFlag InputFlag; // 0x4
	public FP LeftStickX; // 0x10
	public QBoolean LeftStickXSpent; // 0x8
	public FP LeftStickY; // 0x18
	public QBoolean LeftStickYSpent; // 0xC

	// Methods

	// RVA: 0x20D02F0 Offset: 0x20CE8F0 VA: 0x1820D02F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D0350 Offset: 0x20CE950 VA: 0x1820D0350
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
