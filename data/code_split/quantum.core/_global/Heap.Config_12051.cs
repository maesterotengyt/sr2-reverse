// Namespace: 
public struct Heap.Config // TypeDefIndex: 12051
{
	// Fields
	public const int PAGE_SHIFT_SIZE_2KB = 11;
	public const int PAGE_SHIFT_SIZE_4KB = 12;
	public const int PAGE_SHIFT_SIZE_8KB = 13;
	public const int PAGE_SHIFT_SIZE_16KB = 14;
	public const int PAGE_SHIFT_SIZE_32KB = 15;
	public const int PAGE_SHIFT_SIZE_64KB = 16;
	public readonly int PAGE_SHIFT; // 0x0
	public readonly int PAGE_COUNT; // 0x4
	public readonly int PAGE_SIZE; // 0x8
	public readonly int HEAP_SIZE; // 0xC
	public readonly int HEAP_COUNT; // 0x10
	public readonly int SMALL_BIN_SIZE; // 0x14
	public readonly int SMALL_BIN_COUNT; // 0x18
	public readonly int SMALL_BIN_ARRAY_SIZE; // 0x1C

	// Methods

	// RVA: 0x2208290 Offset: 0x2206890 VA: 0x182208290
	public void .ctor(int pageShift, int pageCount, int heapCount) { }

	// RVA: 0x2207B60 Offset: 0x2206160 VA: 0x182207B60
	public bool Equals(Heap.Config other) { }

	// RVA: 0x2207BA0 Offset: 0x22061A0 VA: 0x182207BA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2207C60 Offset: 0x2206260 VA: 0x182207C60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22082E0 Offset: 0x22068E0 VA: 0x1822082E0
	public static bool op_Inequality(Heap.Config a, Heap.Config b) { }

	// RVA: 0x2207CA0 Offset: 0x22062A0 VA: 0x182207CA0 Slot: 3
	public override string ToString() { }
}
