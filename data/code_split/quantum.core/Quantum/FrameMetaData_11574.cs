// Namespace: Quantum
public struct FrameMetaData // TypeDefIndex: 11574
{
	// Fields
	public const int SIZE = 40;
	internal FrameMetaData.QHashCollectionList _entityDestroyList; // 0x0
	internal FrameMetaData.QHashCollectionList _componentRemovalList; // 0x10
	private Heap.AllocationTracker _trackedInternal; // 0x20

	// Methods

	// RVA: 0x21CE790 Offset: 0x21CCD90 VA: 0x1821CE790
	internal void TrackAllocationInternal(FrameBase f, Ptr ptr) { }

	// RVA: 0x21CE450 Offset: 0x21CCA50 VA: 0x1821CE450
	internal void FreeAllTrackedInternal(FrameBase f) { }

	// RVA: 0x21CE460 Offset: 0x21CCA60 VA: 0x1821CE460
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
