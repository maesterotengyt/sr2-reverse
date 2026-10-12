// Namespace: 
private class Navigation.Updater : IDisposable // TypeDefIndex: 11642
{
	// Fields
	public const int DEFAULT_ENTRY_CAPACITY = 128;
	public const int DEFAULT_ENDPOINT_CAPACITY = 256;
	public const int DEFAULT_PAIR_CAPACITY = 1024;
	private Radix.EndPoint* _radixEndPoint; // 0x10
	private Radix.EndPoint* _radixEndPointTemp; // 0x18
	private int _radixEndPointCount; // 0x20
	private int _radixEndPointCapacity; // 0x24
	private Radix.ActiveEndPointList _radixActiveEndPointList; // 0x28
	private int* _radixPref; // 0x40
	private int* _radixCount; // 0x48
	internal FrameContext _context; // 0x50
	internal readonly Navigation.ThreadLocal[] ThreadLocals; // 0x58
	private Navigation.Config _config; // 0x60
	private FP _deltaTime; // 0x68
	private INavigationCallbacks _navigationCallbacks; // 0x70
	private Navigation.Entry* _entries; // 0x78
	private int _entriesCount; // 0x80
	private int _entriesCapacity; // 0x84
	private Navigation.EntryPair* _pairs; // 0x88
	private int _pairsCount; // 0x90
	private int _pairsCapacity; // 0x94
	private TaskDelegateHandle _taskCreateEntries; // 0x98
	private TaskDelegateHandle _taskPreUpdateAgent; // 0x9C
	private TaskDelegateHandle _taskBroadphase; // 0xA0
	private TaskDelegateHandle _taskCreateAvoidanceData; // 0xA4
	private TaskDelegateHandle _taskIntegrateAvoidanceData; // 0xA8
	private TaskDelegateHandle _taskUpdateAgent; // 0xAC
	private TaskDelegateHandle _taskMoveAgentCallbacks; // 0xB0
	private AtomicInt _createAvoidanceDataIndex; // 0xB4
	private AtomicInt _preUpdateBuckets; // 0xB8
	private AtomicInt _updateBuckets; // 0xBC

	// Methods

	// RVA: 0x21E8550 Offset: 0x21E6B50 VA: 0x1821E8550
	private static void Task_MoveAgentCallbacks(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x21E83E0 Offset: 0x21E69E0 VA: 0x1821E83E0
	private void Task_CreateEntries(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x21E6F10 Offset: 0x21E5510 VA: 0x1821E6F10
	private void CreateEntries(FrameBase f, Navigation.Config navigationConfig) { }

	// RVA: 0x21E9900 Offset: 0x21E7F00 VA: 0x1821E9900
	internal void .ctor(Navigation.Config config, FrameContext context) { }

	// RVA: 0x21E7C80 Offset: 0x21E6280 VA: 0x1821E7C80 Slot: 4
	public void Dispose() { }

	// RVA: 0x21E8E00 Offset: 0x21E7400 VA: 0x1821E8E00
	public TaskHandle Update(FrameBase frame, FP deltaTime, INavigationCallbacks callbacks, TaskHandle taskHandle) { }

	// RVA: 0x21E7EC0 Offset: 0x21E64C0 VA: 0x1821E7EC0
	private Navigation.Entry* GetNextEntry(FrameBase frame) { }

	// RVA: 0x21E8090 Offset: 0x21E6690 VA: 0x1821E8090
	private Radix.EndPoint* GetNextRadixEndPoint(FrameBase frame) { }

	// RVA: 0x21E7FA0 Offset: 0x21E65A0 VA: 0x1821E7FA0
	private Navigation.EntryPair* GetNextPair(FrameBase frame) { }

	// RVA: 0x21E8460 Offset: 0x21E6A60 VA: 0x1821E8460
	private static void Task_IntegrateAvoidanceData(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x21E81A0 Offset: 0x21E67A0 VA: 0x1821E81A0
	private static void Task_Broadphase(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x21E6B50 Offset: 0x21E5150 VA: 0x1821E6B50
	private static void AvoidanceBroadphase(FrameBase f, Navigation.Updater updater, Navigation.Config navigationConfig) { }

	// RVA: 0x21E9040 Offset: 0x21E7640 VA: 0x1821E9040
	private static void WaypointReachedDetection(FrameThreadSafe f, Navigation.Updater updater) { }

	// RVA: 0x21E89D0 Offset: 0x21E6FD0 VA: 0x1821E89D0
	private static void Task_UpdateAgents(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x21E8220 Offset: 0x21E6820 VA: 0x1821E8220
	private static void Task_CreateAvoidanceData(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x21E8730 Offset: 0x21E6D30 VA: 0x1821E8730
	private static void Task_PreUpdateAgents(FrameThreadSafe f, int start, int count, void* arg) { }
}
