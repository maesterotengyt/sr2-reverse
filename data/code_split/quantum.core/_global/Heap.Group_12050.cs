// Namespace: 
internal struct Heap.Group // TypeDefIndex: 12050
{
	// Fields
	private Heap* _heaps; // 0x0
	private int _heapsCount; // 0x8
	private Heap.Config _config; // 0xC
	private Heap.Offsets _offsets; // 0x2C
	private void* _heapsMemory; // 0x48
	private byte* _heapsStart; // 0x50
	private byte* _debrujinTable; // 0x58

	// Methods

	// RVA: 0x220F9E0 Offset: 0x220DFE0 VA: 0x18220F9E0
	public Heap* GetHeap(int index) { }

	// RVA: 0x220FD20 Offset: 0x220E320 VA: 0x18220FD20
	public void Release(Heap* heap) { }

	// RVA: 0x220FE20 Offset: 0x220E420 VA: 0x18220FE20
	public Heap* Reserve() { }

	// RVA: 0x220F8E0 Offset: 0x220DEE0 VA: 0x18220F8E0
	public static void Free(Heap.Group* group, Native.Allocator allocator) { }

	// RVA: 0x220F3F0 Offset: 0x220D9F0 VA: 0x18220F3F0
	public static Heap.Group* Allocate(Heap.Config config, Native.Allocator allocator) { }

	// RVA: 0x220FAE0 Offset: 0x220E0E0 VA: 0x18220FAE0
	private static void InitHeaps(Heap.Group* group, Native.Allocator allocator) { }

	// RVA: 0x220F810 Offset: 0x220DE10 VA: 0x18220F810
	private static Heap.Offsets CalculateMetaOffsets(Heap.Config config) { }

	// RVA: 0x220FA40 Offset: 0x220E040 VA: 0x18220FA40
	private static void InitDeBruijnTable(byte* table) { }
}
