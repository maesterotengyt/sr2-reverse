// Namespace: 
internal struct FrameMetaData.QHashCollectionList // TypeDefIndex: 11572
{
	// Fields
	public const int SIZE = 16;
	private const int DEFAULT_LIST_CAPACITY = 4;
	private const int DEFAULT_ENTRY_CAPACITY = 128;
	private const int DISPOSE_BLOCK_AGE = 30;
	private ushort _qHashListUsedCount; // 0x0
	private ushort _qHashListCapacity; // 0x2
	private int _qHashListAllocatedCount; // 0x4
	private int _qHashListLastBlockAge; // 0x8
	[PtrBuffer(typeof(QHashCollection), "_qHashListUsedCount")]
	private Ptr _qHashListPtr; // 0xC

	// Methods

	// RVA: -1 Offset: -1
	internal void Allocate<T, THeap>(THeap heap, int qHashEntryCapacity = 128, int qHashListCapacity = 4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7E40 Offset: 0xCE6440 VA: 0x180CE7E40
	|-FrameMetaData.QHashCollectionList.Allocate<ComponentReference, object>
	|
	|-RVA: 0xCE7F30 Offset: 0xCE6530 VA: 0x180CE7F30
	|-FrameMetaData.QHashCollectionList.Allocate<EntityRef, object>
	|
	|-RVA: 0xCE8020 Offset: 0xCE6620 VA: 0x180CE8020
	|-FrameMetaData.QHashCollectionList.Allocate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void Dispose<THeap>(THeap heap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE8560 Offset: 0xCE6B60 VA: 0x180CE8560
	|-FrameMetaData.QHashCollectionList.Dispose<object>
	|
	|-RVA: 0xCE8300 Offset: 0xCE6900 VA: 0x180CE8300
	|-FrameMetaData.QHashCollectionList.Dispose<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void Reset<THeap>(THeap heap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE9010 Offset: 0xCE7610 VA: 0x180CE9010
	|-FrameMetaData.QHashCollectionList.Reset<object>
	|
	|-RVA: 0xCE8E50 Offset: 0xCE7450 VA: 0x180CE8E50
	|-FrameMetaData.QHashCollectionList.Reset<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void GetQHashCollections<THeap>(THeap heap, out QHashCollection* qHash, out int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE8DF0 Offset: 0xCE73F0 VA: 0x180CE8DF0
	|-FrameMetaData.QHashCollectionList.GetQHashCollections<object>
	|
	|-RVA: 0xCE8CE0 Offset: 0xCE72E0 VA: 0x180CE8CE0
	|-FrameMetaData.QHashCollectionList.GetQHashCollections<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal QHashCollection* GetCurrentQHashCollection<T, THeap>(THeap heap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE86B0 Offset: 0xCE6CB0 VA: 0x180CE86B0
	|-FrameMetaData.QHashCollectionList.GetCurrentQHashCollection<ComponentReference, object>
	|
	|-RVA: 0xCE8760 Offset: 0xCE6D60 VA: 0x180CE8760
	|-FrameMetaData.QHashCollectionList.GetCurrentQHashCollection<EntityRef, object>
	|
	|-RVA: 0xCE8810 Offset: 0xCE6E10 VA: 0x180CE8810
	|-FrameMetaData.QHashCollectionList.GetCurrentQHashCollection<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private QHashCollection* GetNextQHashCollection<T, THeap>(THeap heap, int entriesCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE89E0 Offset: 0xCE6FE0 VA: 0x180CE89E0
	|-FrameMetaData.QHashCollectionList.GetNextQHashCollection<ComponentReference, object>
	|
	|-RVA: 0xCE8B60 Offset: 0xCE7160 VA: 0x180CE8B60
	|-FrameMetaData.QHashCollectionList.GetNextQHashCollection<EntityRef, object>
	|
	|-RVA: 0xCE27E0 Offset: 0xCE0DE0 VA: 0x180CE27E0
	|-FrameMetaData.QHashCollectionList.GetNextQHashCollection<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Serialize<T>(void* ptr, FrameSerializer serializer, FrameSerializer.Delegate keySerializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE90B0 Offset: 0xCE76B0 VA: 0x180CE90B0
	|-FrameMetaData.QHashCollectionList.Serialize<ComponentReference>
	|
	|-RVA: 0xCE9220 Offset: 0xCE7820 VA: 0x180CE9220
	|-FrameMetaData.QHashCollectionList.Serialize<EntityRef>
	|
	|-RVA: 0xCE9390 Offset: 0xCE7990 VA: 0x180CE9390
	|-FrameMetaData.QHashCollectionList.Serialize<__Il2CppFullySharedGenericStructType>
	*/
}
