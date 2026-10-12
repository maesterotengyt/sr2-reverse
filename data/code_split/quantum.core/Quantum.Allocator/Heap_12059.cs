// Namespace: Quantum.Allocator
public struct Heap : IFrameHeap // TypeDefIndex: 12059
{
	// Fields
	public const int FIELD_SIZE = 4;
	public const int DE_BRUIJN_TABLE_COUNT = 32;
	public const int DE_BRUIJN_TABLE_BYTE_SIZE = 32;
	public const int LOB_TABLE_DEFAULT_CAPACITY = 16;
	public const int WORD_SIZE = 8;
	public const int PAGE_BIN_COUNT = 49;
	public const int PAGE_BIN_MIN = 0;
	public const int PAGE_BIN_INVALID = -1;
	internal const int PAGE_BIN_MAX_ALLOC = 65536;
	public const int ALLOC_BIN_EXPANSION = 4;
	private Heap.Config _config; // 0x0
	private Heap.Offsets _offsets; // 0x20
	private byte _reserved; // 0x38
	private byte* _memory; // 0x40
	private Heap.Data* _data; // 0x48
	private Heap.Bin* _bins; // 0x50
	private Heap.Bin* _binsFull; // 0x58
	private int* _binsSmall; // 0x60
	private Heap.Page* _pages; // 0x68
	private byte* _debruijnTable; // 0x70
	private DisabledHeapAllocTrackerStruct _disabledTracker; // 0x78
	private const int PTR_CHECK_MIN = 0;
	private const int PTR_CHECK_MAX = 0;
	private const string ENCODE_WRONG_POINTER = "Trying to convert a native pointer that lies outside of the heap.";
	private const string DECODE_WRONG_POINTER = "Trying to resolve a Ptr that lies outside of the valid range";
	private const string DECODE_WRONG_POINTER_SMALL = "Trying to resolve a Ptr that lies outside of the valid range, offset is smaller than valid.";
	private const string DECODE_WRONG_POINTER_LARGE = "Trying to resolve a Ptr that lies outside of the valid range, offset is larger than valid.";

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public Ptr AllocateAndClearPtr<T>(int size, T allocTracker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB612C0 Offset: 0xB5F8C0 VA: 0x180B612C0
	|-Heap.AllocateAndClearPtr<DisabledHeapAllocTrackerStruct>
	|
	|-RVA: 0xB61420 Offset: 0xB5FA20 VA: 0x180B61420
	|-Heap.AllocateAndClearPtr<object>
	|
	|-RVA: 0xB61320 Offset: 0xB5F920 VA: 0x180B61320
	|-Heap.AllocateAndClearPtr<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void* AllocateAndClear<T>(int size, T allocTracker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61480 Offset: 0xB5FA80 VA: 0x180B61480
	|-Heap.AllocateAndClear<DisabledHeapAllocTrackerStruct>
	|
	|-RVA: 0xB61650 Offset: 0xB5FC50 VA: 0x180B61650
	|-Heap.AllocateAndClear<object>
	|
	|-RVA: 0xB61520 Offset: 0xB5FB20 VA: 0x180B61520
	|-Heap.AllocateAndClear<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public T* ExpandArray<T, TTracker>(T* buffer, int currentSize, int newSize, TTracker allocTracker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61B70 Offset: 0xB60170 VA: 0x180B61B70
	|-Heap.ExpandArray<Ptr, object>
	|
	|-RVA: 0xB61990 Offset: 0xB5FF90 VA: 0x180B61990
	|-Heap.ExpandArray<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xB618A0 Offset: 0xB5FEA0 VA: 0x180B618A0
	|-Heap.ExpandArray<PhysicsCommon.CollisionCallbackInfo, object>
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void* Allocate<T>(int size, T allocTracker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB616F0 Offset: 0xB5FCF0 VA: 0x180B616F0
	|-Heap.Allocate<DisabledHeapAllocTrackerStruct>
	|-Heap.Allocate<object>
	|-Heap.Allocate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x220FFD0 Offset: 0x220E5D0 VA: 0x18220FFD0
	private void* AllocateSlow(Heap.Bin* b, Heap.Page* p, int size, int bin, int tries) { }

	// RVA: 0x220FF80 Offset: 0x220E580 VA: 0x18220FF80 Slot: 4
	public void* AllocateAndClear(int size) { }

	// RVA: 0x220FF30 Offset: 0x220E530 VA: 0x18220FF30 Slot: 5
	public Ptr AllocateAndClearPtr(int size) { }

	// RVA: 0x2210250 Offset: 0x220E850 VA: 0x182210250
	private void BinInsertFirst(Heap.Bin* b, Heap.Page* p) { }

	// RVA: 0x22102B0 Offset: 0x220E8B0 VA: 0x1822102B0
	private void BinInsertLast(Heap.Bin* b, Heap.Page* p) { }

	// RVA: 0x2210310 Offset: 0x220E910 VA: 0x182210310
	private void BinRemove(Heap.Bin* b, Heap.Page* p) { }

	// RVA: 0x2210680 Offset: 0x220EC80 VA: 0x182210680
	public static Heap.Stats GetStats(Heap* heap) { }

	// RVA: 0x2210450 Offset: 0x220EA50 VA: 0x182210450
	public static void Copy(Native.Allocator allocator, Heap* to, Heap* from) { }

	// RVA: 0x22110E0 Offset: 0x220F6E0 VA: 0x1822110E0
	public static void Print(Heap* heap, FramePrinter printer) { }

	// RVA: 0x22115D0 Offset: 0x220FBD0 VA: 0x1822115D0
	public static void RegisterInternalTypes(Action<Type, int> register) { }

	// RVA: 0x2210750 Offset: 0x220ED50 VA: 0x182210750
	private static Heap Initialize(byte* memory, byte* debruijnTable, Heap.Config config, Heap.Offsets offsets, Heap.Bin[] defaultBins) { }

	// RVA: -1 Offset: -1 Slot: 15
	public void Free<T>(Ptr ptr, T allocTracker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61C60 Offset: 0xB60260 VA: 0x180B61C60
	|-Heap.Free<DisabledHeapAllocTrackerStruct>
	|-Heap.Free<object>
	|
	|-RVA: 0xB61D40 Offset: 0xB60340 VA: 0x180B61D40
	|-Heap.Free<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void Free<T>(void* ptr, T allocTracker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61CE0 Offset: 0xB602E0 VA: 0x180B61CE0
	|-Heap.Free<DisabledHeapAllocTrackerStruct>
	|-Heap.Free<object>
	|-Heap.Free<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2210630 Offset: 0x220EC30 VA: 0x182210630 Slot: 6
	public void Free(void* ptr) { }

	// RVA: 0x22105E0 Offset: 0x220EBE0 VA: 0x1822105E0 Slot: 7
	public void Free(Ptr ptr) { }

	// RVA: 0x22110A0 Offset: 0x220F6A0 VA: 0x1822110A0
	private Heap.Block* PageNextBlock(Heap.Page* p, int size, bool allowFull) { }

	// RVA: 0x22110A0 Offset: 0x220F6A0 VA: 0x1822110A0
	private Heap.Block* PageNextBlockMustSucceed(Heap.Page* p, int size, bool allowFull) { }

	// RVA: 0x2210D30 Offset: 0x220F330 VA: 0x182210D30
	private void PageForceFree() { }

	// RVA: 0x2210AE0 Offset: 0x220F0E0 VA: 0x182210AE0
	private Heap.Page* PageAllocate(int bin) { }

	// RVA: 0x2210EC0 Offset: 0x220F4C0 VA: 0x182210EC0
	private byte* PageMemoryStart(int index) { }

	// RVA: 0x2210CA0 Offset: 0x220F2A0 VA: 0x182210CA0
	private void PageExpand(Heap.Page* p) { }

	// RVA: 0x2210FB0 Offset: 0x220F5B0 VA: 0x182210FB0
	private void PageMoveToFullBin(Heap.Page* p, int bin) { }

	// RVA: 0x2210ED0 Offset: 0x220F4D0 VA: 0x182210ED0
	private void PageMoveToAvailableBin(Heap.Page* p, int bin) { }

	// RVA: 0x2210DB0 Offset: 0x220F3B0 VA: 0x182210DB0
	private void PageFree(Heap.Page* p) { }

	// RVA: 0x2211770 Offset: 0x220FD70 VA: 0x182211770 Slot: 8
	public Ptr Void(void* ptr) { }

	// RVA: 0xB61E10 Offset: 0xB60410 VA: 0x180B61E10 Slot: 9
	public void* Void(Ptr p) { }

	// RVA: -1 Offset: -1 Slot: 10
	public T* Void<T>(Ptr p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB61E10 Offset: 0xB60410 VA: 0x180B61E10
	|-Heap.Void<QHashCollection>
	|-Heap.Void<ulong>
	|-Heap.Void<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0xB61E10 Offset: 0xB60410 VA: 0x180B61E10
	internal void* VoidUnchecked(Ptr p) { }

	// RVA: 0x2211770 Offset: 0x220FD70 VA: 0x182211770
	internal Ptr VoidUnchecked(void* ptr) { }

	// RVA: 0x22103D0 Offset: 0x220E9D0 VA: 0x1822103D0
	private int CalculateBin(int size) { }

	// RVA: 0x2210440 Offset: 0x220EA40 VA: 0x182210440
	private static int CalculateWordSize(int size) { }

	// RVA: 0x2210390 Offset: 0x220E990 VA: 0x182210390
	private static int BitScanReverse(uint v, byte* debruijnTable) { }
}
