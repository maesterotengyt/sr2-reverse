// Namespace: Quantum
public struct ButtonTimersContainer // TypeDefIndex: 9914
{
	// Fields
	[FixedBuffer(typeof(byte), 48)]
	[FixedArray(typeof(InputTimer), 6)]
	private ButtonTimersContainer.<_InputButtonTimers_>e__FixedBuffer _InputButtonTimers_; // 0x0
	[FixedBuffer(typeof(byte), 32)]
	[FixedArray(typeof(InputTimer), 4)]
	private ButtonTimersContainer.<_InputDirectionTimers_>e__FixedBuffer _InputDirectionTimers_; // 0x30

	// Properties
	public FixedArray<InputTimer> InputButtonTimers { get; }
	public FixedArray<InputTimer> InputDirectionTimers { get; }

	// Methods

	// RVA: 0x20C8EB0 Offset: 0x20C74B0 VA: 0x1820C8EB0
	public FixedArray<InputTimer> get_InputButtonTimers() { }

	// RVA: 0x20C8F20 Offset: 0x20C7520 VA: 0x1820C8F20
	public FixedArray<InputTimer> get_InputDirectionTimers() { }

	// RVA: 0x20C8AF0 Offset: 0x20C70F0 VA: 0x1820C8AF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C8CD0 Offset: 0x20C72D0 VA: 0x1820C8CD0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
