// Namespace: Quantum.Allocator
public class FrameHeap : IFrameHeap // TypeDefIndex: 12065
{
	// Fields
	private readonly Heap* _heap; // 0x10
	private readonly IHeapAllocationTracker _tracker; // 0x18

	// Properties
	public IHeapAllocationTracker Tracker { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public IHeapAllocationTracker get_Tracker() { }

	// RVA: 0x2215360 Offset: 0x2213960 VA: 0x182215360
	public void .ctor(Heap* heap, IHeapAllocationTracker tracker) { }

	// RVA: 0x2215120 Offset: 0x2213720 VA: 0x182215120 Slot: 4
	public void* AllocateAndClear(int size) { }

	// RVA: 0x22150D0 Offset: 0x22136D0 VA: 0x1822150D0 Slot: 5
	public Ptr AllocateAndClearPtr(int size) { }

	// RVA: -1 Offset: -1 Slot: 11
	public TArray* ExpandArray<TArray>(TArray* buffer, int currentSize, int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB533C0 Offset: 0xB519C0 VA: 0x180B533C0
	|-FrameHeap.ExpandArray<Ptr>
	|
	|-RVA: 0xB53300 Offset: 0xB51900 VA: 0x180B53300
	|-FrameHeap.ExpandArray<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xB53290 Offset: 0xB51890 VA: 0x180B53290
	|-FrameHeap.ExpandArray<PhysicsCommon.CollisionCallbackInfo>
	*/

	// RVA: 0x22151C0 Offset: 0x22137C0 VA: 0x1822151C0 Slot: 7
	public void Free(Ptr ptr) { }

	// RVA: 0x2215170 Offset: 0x2213770 VA: 0x182215170 Slot: 6
	public void Free(void* ptr) { }

	// RVA: 0x2215340 Offset: 0x2213940 VA: 0x182215340 Slot: 8
	public Ptr Void(void* ptr) { }

	// RVA: 0x2215350 Offset: 0x2213950 VA: 0x182215350 Slot: 9
	public void* Void(Ptr p) { }

	// RVA: -1 Offset: -1 Slot: 10
	public TPtr* Void<TPtr>(Ptr p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB53480 Offset: 0xB51A80 VA: 0x180B53480
	|-FrameHeap.Void<QHashCollection>
	|-FrameHeap.Void<ulong>
	|
	|-RVA: 0xB53430 Offset: 0xB51A30 VA: 0x180B53430
	|-FrameHeap.Void<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2215210 Offset: 0x2213810 VA: 0x182215210
	public static IHeapAllocationTracker GetAllocationTrackerForMode(HeapTrackingMode mode) { }
}
