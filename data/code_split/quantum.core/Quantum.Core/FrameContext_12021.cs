// Namespace: Quantum.Core
public class FrameContext : IDisposable // TypeDefIndex: 12021
{
	// Fields
	internal Func<int, bool> _isLocalPlayer; // 0x10
	internal DynamicAssetDB InitialDynamicAssets; // 0x18
	private AssetDB _assetDB; // 0x20
	private FrameContext.CullingArea _cullingArea; // 0x28
	private Heap.Group* _heapGroup; // 0x70
	private DeterministicCommandSerializer _commandSerializer; // 0x78
	private FrameBase.Culling _culling; // 0x80
	internal PhysicsCommon.Config _physicsConfig; // 0x88
	private LayerInfo _layers; // 0x90
	private PhysicsEngine2D _physics2D; // 0x98
	private PhysicsEngine3D _physics3D; // 0xA0
	private Navigation _navigation; // 0xA8
	private TaskContext _taskContext; // 0xB0
	private ProfilerContext _profilerContext; // 0xB8
	private EventBase[] _eventPools; // 0xC0
	private List<FrameContext.TempAllocation> _tempAllocations; // 0xC8
	private EventList _events; // 0xD0
	private Native.Allocator _allocator; // 0xD8
	private IDeterministicPlatformTaskRunner _taskRunner; // 0xE0
	private IAssetSerializer _assetSerializer; // 0xE8
	private FrameSerializer _sharedCheckumSerializer; // 0xF0
	private readonly HeapTrackingMode _heapTrackingMode; // 0xF8
	private readonly IHeapAllocationTracker _heapTracker; // 0x100
	[CompilerGenerated]
	private readonly bool <UseSharedChecksumSerializer>k__BackingField; // 0x108
	[CompilerGenerated]
	private readonly bool <IsServer>k__BackingField; // 0x109

	// Properties
	internal PhysicsEngine2D Physics2D { get; }
	internal PhysicsEngine3D Physics3D { get; }
	internal Navigation Navigation { get; }
	public Native.Allocator Allocator { get; }
	internal IDeterministicPlatformTaskRunner TaskRunner { get; }
	public TaskContext TaskContext { get; }
	public ProfilerContext ProfilerContext { get; }
	public EventList Events { get; }
	public FrameBase.Culling Culling { get; }
	public AssetDB AssetDB { get; }
	public IAssetSerializer AssetSerializer { get; }
	public bool UseSharedChecksumSerializer { get; }
	public FrameSerializer SharedChecksumSerializer { get; }
	public HeapTrackingMode HeapTrackingMode { get; }

	// Methods

	// RVA: 0x54C320 Offset: 0x54A920 VA: 0x18054C320
	internal PhysicsEngine2D get_Physics2D() { }

	// RVA: 0x54C310 Offset: 0x54A910 VA: 0x18054C310
	internal PhysicsEngine3D get_Physics3D() { }

	// RVA: 0x7A80A0 Offset: 0x7A66A0 VA: 0x1807A80A0
	internal Navigation get_Navigation() { }

	// RVA: 0x502330 Offset: 0x500930 VA: 0x180502330
	public Native.Allocator get_Allocator() { }

	// RVA: 0x7A80E0 Offset: 0x7A66E0 VA: 0x1807A80E0
	internal IDeterministicPlatformTaskRunner get_TaskRunner() { }

	// RVA: 0x7A80B0 Offset: 0x7A66B0 VA: 0x1807A80B0
	public TaskContext get_TaskContext() { }

	// RVA: 0x5A9A10 Offset: 0x5A8010 VA: 0x1805A9A10
	public ProfilerContext get_ProfilerContext() { }

	// RVA: 0x6230C0 Offset: 0x6216C0 VA: 0x1806230C0
	public EventList get_Events() { }

	// RVA: 0x54C330 Offset: 0x54A930 VA: 0x18054C330
	public FrameBase.Culling get_Culling() { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public AssetDB get_AssetDB() { }

	// RVA: 0x7A8080 Offset: 0x7A6680 VA: 0x1807A8080
	public IAssetSerializer get_AssetSerializer() { }

	[CompilerGenerated]
	// RVA: 0x220F3E0 Offset: 0x220D9E0 VA: 0x18220F3E0
	public bool get_UseSharedChecksumSerializer() { }

	// RVA: 0x7A80F0 Offset: 0x7A66F0 VA: 0x1807A80F0
	public FrameSerializer get_SharedChecksumSerializer() { }

	// RVA: 0x1CA29D0 Offset: 0x1CA0FD0 VA: 0x181CA29D0
	public HeapTrackingMode get_HeapTrackingMode() { }

	// RVA: 0x220EC00 Offset: 0x220D200 VA: 0x18220EC00
	public void .ctor(FrameContext.Args args) { }

	// RVA: 0x220E730 Offset: 0x220CD30 VA: 0x18220E730
	public void OnSimulationBegin() { }

	// RVA: 0x220E770 Offset: 0x220CD70 VA: 0x18220E770
	public void OnSimulationEnd() { }

	// RVA: 0x220E6A0 Offset: 0x220CCA0 VA: 0x18220E6A0
	public void OnFrameSimulationBegin(FrameBase f) { }

	// RVA: 0x220E6F0 Offset: 0x220CCF0 VA: 0x18220E6F0
	public void OnFrameSimulationEnd() { }

	// RVA: 0x220EA80 Offset: 0x220D080 VA: 0x18220EA80
	public void* TempAllocate(int size, int alignment = 8) { }

	// RVA: 0x220E910 Offset: 0x220CF10 VA: 0x18220E910
	public void* TempAllocateAndClear(int size, int alignment = 8) { }

	// RVA: 0x220DFF0 Offset: 0x220C5F0 VA: 0x18220DFF0 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220E8B0 Offset: 0x220CEB0 VA: 0x18220E8B0
	internal void ReleaseHeap(Heap* heap) { }

	// RVA: 0x220E8C0 Offset: 0x220CEC0 VA: 0x18220E8C0
	internal Heap* ReserveHeap() { }

	// RVA: -1 Offset: -1
	public T AcquireEvent<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB53110 Offset: 0xB51710 VA: 0x180B53110
	|-FrameContext.AcquireEvent<object>
	*/

	// RVA: 0x220E7A0 Offset: 0x220CDA0 VA: 0x18220E7A0
	public void ReleaseEvent(EventBase evnt) { }

	// RVA: 0x220E8D0 Offset: 0x220CED0 VA: 0x18220E8D0
	public void SetPredictionArea(FPVector3 center, FP radius) { }

	// RVA: 0x220E610 Offset: 0x220CC10 VA: 0x18220E610 Slot: 6
	public virtual bool InPredictionArea(DeterministicFrame frame, FPVector3 position) { }

	// RVA: 0x220E5B0 Offset: 0x220CBB0 VA: 0x18220E5B0
	public bool InPredictionArea(DeterministicFrame frame, FPVector2 position) { }

	// RVA: 0x220E370 Offset: 0x220C970 VA: 0x18220E370
	private void FreeTempAllocations() { }

	// RVA: 0x220E580 Offset: 0x220CB80 VA: 0x18220E580
	public void HookHeapAllocTrackerToFrame(FrameBase f) { }
}
