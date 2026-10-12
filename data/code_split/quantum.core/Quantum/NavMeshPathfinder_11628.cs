// Namespace: Quantum
public struct NavMeshPathfinder : IComponent // TypeDefIndex: 11628
{
	// Fields
	public const int SIZE = 96;
	internal byte _active; // 0x0
	internal byte _waypointIndex; // 0x1
	internal byte _waypointCount; // 0x2
	internal byte _waypointCapacity; // 0x3
	[PtrBuffer(typeof(FPVector3), "_waypointCount", CapacityFieldName = "_waypointCapacity")]
	[PtrBuffer(typeof(byte), "_waypointCount", CapacityFieldName = "_waypointCapacity", Label = "_waypointFlags", Order = 1)]
	[PtrBuffer(typeof(short), "_waypointCount", Label = "_waypointLinks", Order = 2)]
	private Ptr _waypoints; // 0x4
	internal FP _waypointDetectionDistanceSqr; // 0x8
	internal FP _ttl; // 0x10
	internal AssetGuid _configId; // 0x18
	internal AssetGuid _navMeshID; // 0x20
	public NavMeshRegionMask RegionMask; // 0x28
	internal FPVector3 _inputTarget; // 0x30
	internal FPVector3 _internalTarget; // 0x48

	// Properties
	public AssetGuid ConfigId { get; }
	public int WaypointIndex { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public AssetGuid get_ConfigId() { }

	// RVA: 0x118E6C0 Offset: 0x118CCC0 VA: 0x18118E6C0
	public int get_WaypointIndex() { }

	// RVA: 0x21DCD30 Offset: 0x21DB330 VA: 0x1821DCD30
	public static NavMeshPathfinder Create(FrameBase f, EntityRef entity, NavMeshAgentConfig config) { }

	// RVA: 0x21DD030 Offset: 0x21DB630 VA: 0x1821DD030
	public bool IsOnLink(FrameBase f) { }

	// RVA: 0x21DCDF0 Offset: 0x21DB3F0 VA: 0x1821DCDF0
	public bool CurrentWaypointHasFlag(FrameBase f, Navigation.WaypointFlag waypointFlag) { }

	// RVA: 0x21DCF10 Offset: 0x21DB510 VA: 0x1821DCF10
	public FPVector3 GetWaypoint(FrameBase f, int index) { }

	// RVA: 0x21DCE90 Offset: 0x21DB490 VA: 0x1821DCE90
	public Navigation.WaypointFlag GetWaypointFlags(FrameBase f, int index) { }

	// RVA: 0x21DD420 Offset: 0x21DBA20 VA: 0x1821DD420
	public void SetConfig(FrameBase f, EntityRef entity, NavMeshAgentConfig config, bool overwrite = True) { }

	// RVA: 0x21DD600 Offset: 0x21DBC00 VA: 0x1821DD600
	public void SetTarget(FrameBase f, FPVector3 target, NavMesh navMesh) { }

	// RVA: 0x21DD0F0 Offset: 0x21DB6F0 VA: 0x1821DD0F0
	internal void ResetWaypoints(FrameBase f) { }

	// RVA: 0x21DCC10 Offset: 0x21DB210 VA: 0x1821DCC10
	internal void AddWaypoint(FrameBase f, FPVector3 position, Navigation.WaypointFlag flags = 0, int link = -1) { }

	// RVA: 0x21DCCD0 Offset: 0x21DB2D0 VA: 0x1821DCCD0
	internal void Clear(FrameBase f, Navigation.Entry* e) { }

	// RVA: 0x21DCFB0 Offset: 0x21DB5B0 VA: 0x1821DCFB0
	private NavMeshPathfinder.WaypointList GetWaypoints(FrameBase f) { }

	// RVA: 0x21DD930 Offset: 0x21DBF30 VA: 0x1821DD930
	private bool SetWaypointsCapacity(FrameBase f, byte newCapacity) { }

	// RVA: 0x21DD100 Offset: 0x21DB700 VA: 0x1821DD100
	public static void Serialize(void* p, FrameSerializer serializer) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x21DD0D0 Offset: 0x21DB6D0 VA: 0x1821DD0D0
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
