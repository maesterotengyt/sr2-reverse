// Namespace: Quantum
public struct Input // TypeDefIndex: 9928
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 4;
	public InputFlag InputFlag; // 0x4
	public sbyte LeftStickX; // 0x0
	public sbyte LeftStickY; // 0x1
	public const int MAX_COUNT = 12;

	// Methods

	// RVA: 0x20D0420 Offset: 0x20CEA20 VA: 0x1820D0420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D0460 Offset: 0x20CEA60 VA: 0x1820D0460
	public static Input Read(FrameSerializer serializer) { }

	// RVA: 0x20D05B0 Offset: 0x20CEBB0 VA: 0x1820D05B0
	public static void Write(FrameSerializer serializer, Input i) { }

	// RVA: 0x20D0510 Offset: 0x20CEB10 VA: 0x1820D0510
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
