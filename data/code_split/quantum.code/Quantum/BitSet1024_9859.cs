// Namespace: Quantum
public struct BitSet1024 // TypeDefIndex: 9859
{
	// Fields
	public const int SIZE = 128;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 16)]
	private BitSet1024.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 1024;

	// Methods

	// RVA: 0x20C8360 Offset: 0x20C6960 VA: 0x1820C8360
	public void Set(int bit) { }

	// RVA: 0x20C82C0 Offset: 0x20C68C0 VA: 0x1820C82C0
	public bool IsSet(int bit) { }

	// RVA: 0x20C8270 Offset: 0x20C6870 VA: 0x1820C8270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C82F0 Offset: 0x20C68F0 VA: 0x1820C82F0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
