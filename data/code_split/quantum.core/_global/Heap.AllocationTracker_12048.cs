// Namespace: 
internal struct Heap.AllocationTracker // TypeDefIndex: 12048
{
	// Fields
	public const int SIZE = 8;
	private const int DefaultCapacity = 8;
	private ushort _trackAllocCount; // 0x0
	private ushort _trackAllocCapacity; // 0x2
	[PtrBuffer(typeof(Ptr), "_trackAllocCount")]
	private Ptr _trackAllocPtr; // 0x4

	// Methods

	// RVA: 0x2206740 Offset: 0x2204D40 VA: 0x182206740
	public void TrackAllocation(FrameBase f, Ptr ptr) { }

	// RVA: 0x22064B0 Offset: 0x2204AB0 VA: 0x1822064B0
	public void FreeAllTracked(FrameBase f) { }

	// RVA: 0x2206320 Offset: 0x2204920 VA: 0x182206320
	private Ptr* EnsureBufferCapacity(FrameBase f) { }

	// RVA: 0x2206590 Offset: 0x2204B90 VA: 0x182206590
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
