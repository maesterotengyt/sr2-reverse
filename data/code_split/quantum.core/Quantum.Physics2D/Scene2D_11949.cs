// Namespace: Quantum.Physics2D
internal struct Scene2D // TypeDefIndex: 11949
{
	// Fields
	private const CallbackFlags StaticTriggerCallbacks = 3584;
	private const CallbackFlags DynamicTriggerCallbacks = 448;
	private const int MIN_STATIC_CAPACITY = 64;
	private const int MIN_ENTRY_CAPACITY = 32;
	private const int MIN_QUERY_CAPACITY = 32;
	private const int MIN_QUERY_ITEM_CAPACITY = 128;
	private const int MIN_ISLAND_CAPACITY = 16;
	private const int MIN_MANIFOLD_CAPACITY = 32;
	private const int MIN_BUCKETS_CAPACITY = 4;
	private const int MIN_JOINTS_CAPACITY = 0;
	private Bucket* _buckets; // 0x0
	private long _bucketsSizeRaw; // 0x8
	private int _bucketsSubdivisions; // 0x10
	private int _bucketsCount; // 0x14
	private int _bucketsCapacity; // 0x18
	private int _bucketsProcessedBroadPhase; // 0x1C
	private bool _bucketOnX; // 0x20
	private bool _sortOnX; // 0x21
	private bool _callbacksWereCalled; // 0x22
	private Tls* _tls; // 0x28
	private int _tlsCount; // 0x30
	private AssetRefMap _currentMap; // 0x38
	private long _worldSizeRaw; // 0x40
	private long _worldOffsetRaw; // 0x48
	private bool _mapInitialized; // 0x50
	private Island2D* _islands; // 0x58
	private int _islandsCount; // 0x60
	private int _islandsCapacity; // 0x64
	private int _islandsProcessedCorrection; // 0x68
	private int _islandsProcessedSleepDetection; // 0x6C
	private Entry2D* _entries; // 0x70
	private int _entriesCount; // 0x78
	private int _entriesCapacity; // 0x7C
	private Query2D* _queries; // 0x80
	private int _queriesCount; // 0x88
	private int _queriesCapacity; // 0x8C
	private int _queriesProcessed; // 0x90
	private int* _queriesPerBucketManifolds; // 0x98
	private int _queriesPerBucketManifoldsCapacity; // 0xA0
	internal HitCollection* HitCollections; // 0xA8
	internal int HitCollectionsCount; // 0xB0
	private int _hitCollectionsCapacity; // 0xB4
	private StaticComponents* _staticComponents; // 0xB8
	private int _staticComponentsCount; // 0xC0
	private int _staticComponentsCapacity; // 0xC4
	private PhysicsCommon.UnsafeBuffer _collisionSolverManifolds; // 0xC8
	private PhysicsCommon.UnsafeBuffer _collisionSolverData; // 0xE0
	private PhysicsCommon.UnsafeBuffer _jointEntries; // 0xF8
	private PhysicsCommon.UnsafeBuffer _jointConstraintData; // 0x110
	private FP _deltaTime; // 0x128
	private ComponentSet _minComponentSet; // 0x130
	internal PhysicsSceneSettings CachedSettings; // 0x150
	private Scene2D.TaskManagementData _taskData; // 0x278
	private Entry2D** _solverEntries; // 0x348
	private int _solverEntriesCount; // 0x350
	private int _solverEntriesCapacity; // 0x354
	private PhysicsCommon.UnsafeBuffer _ccdManifolds; // 0x358
	private UnsafeHashMap* _dynamicEntityRefToEntryIndex; // 0x370

	// Properties
	public Entry2D* DynamicEntries { get; }
	public int DynamicEntriesCount { get; }
	internal AssetRefMap CurrentMap { get; }
	public FP DeltaTime { get; }

	// Methods

	// RVA: 0x21F1590 Offset: 0x21EFB90 VA: 0x1821F1590
	private static void ResolveQuery(FrameThreadSafe frame, Scene2D* scene, HitCollection* hits, Query2D* query, Entry2D* qEntry) { }

	// RVA: 0x21F0F50 Offset: 0x21EF550 VA: 0x1821F0F50
	private static void ResolveQueryNarrow(FrameThreadSafe frame, Scene2D* scene, HitCollection* hits, Query2D* query, Entry2D* queryEntry, Entry2D* entry, bool computeDetailedInfo) { }

	// RVA: 0x21F0290 Offset: 0x21EE890 VA: 0x1821F0290
	public static void Linecast(FrameThreadSafe frame, Scene2D* scene, HitCollection* hits, FPVector2* start, FPVector2* end, bool firstHitOnly, int layerMask, QueryOptions options, FP vPos, FP vHeight) { }

	// RVA: 0x21EFD60 Offset: 0x21EE360 VA: 0x1821EFD60
	private static void InitLinecastEntry(Scene2D* scene, Query2D* query, Entry2D* qEntry) { }

	// RVA: 0x21EFEE0 Offset: 0x21EE4E0 VA: 0x1821EFEE0
	private static void InitShapeCastEntry(FrameThreadSafe frame, Scene2D* scene, Query2D* query, Shape2D* queryShape, Entry2D* qEntry) { }

	// RVA: 0x21F0020 Offset: 0x21EE620 VA: 0x1821F0020
	private static void InitShapeOverlapEntry(FrameThreadSafe frame, Scene2D* scene, Query2D* query, Shape2D* queryShape, Entry2D* qEntry) { }

	// RVA: 0x21F6FD0 Offset: 0x21F55D0 VA: 0x1821F6FD0
	private static void Task_CreateEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21EDB40 Offset: 0x21EC140 VA: 0x1821EDB40
	private static void CreateEntries(FrameThreadSafe frame, Scene2D* scene) { }

	// RVA: 0x21ED950 Offset: 0x21EBF50 VA: 0x1821ED950
	private static void CreateCompoundEntries(FrameThreadSafe frame, Scene2D* scene, int rootEntryIndex, Shape2D* compoundShape) { }

	// RVA: 0x21F6E30 Offset: 0x21F5430 VA: 0x1821F6E30
	private static void Task_CreateEntriesMapping(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F7520 Offset: 0x21F5B20 VA: 0x1821F7520
	private static void Task_IntegrateForcesFirstHalf(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F1F20 Offset: 0x21F0520 VA: 0x1821F1F20
	private static void Task_BroadPhaseEntryPreStep(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F2240 Offset: 0x21F0840 VA: 0x1821F2240
	private static void Task_BroadPhaseQueryPreStep(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21EC4F0 Offset: 0x21EAAF0 VA: 0x1821EC4F0
	private void AddQueryItem(Native.Allocator allocator, int bucketIndex, int* queryBucketManifold, int entryIndex) { }

	// RVA: 0x21F04B0 Offset: 0x21EEAB0 VA: 0x1821F04B0
	private void QueryCheckEntryList(Native.Allocator allocator, PhysicsCommon.ActiveEntryList* list, int bucket, int epIdx, bool useVertical, int* queryBucketManifold) { }

	// RVA: 0x21EE3F0 Offset: 0x21EC9F0 VA: 0x1821EE3F0
	private void EntryCheckQueryList(Native.Allocator allocator, PhysicsCommon.ActiveEntryList* list, int bucket, int epIdx, bool useVertical, int* bucketQueryManifolds) { }

	// RVA: 0x21EE120 Offset: 0x21EC720 VA: 0x1821EE120
	private void EntryCheckEntryList(Scene2D* scene, Native.Allocator allocator, PhysicsCommon.ActiveEntryList* list, int bucket, Entry2D* entry, bool isTriggerManifold, bool isSleeping, bool isKinematic, bool isStatic, bool useVertical) { }

	// RVA: 0x21F2620 Offset: 0x21F0C20 VA: 0x1821F2620
	private static void Task_BroadPhase(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F8870 Offset: 0x21F6E70 VA: 0x1821F8870
	private static void Task_NarrowPhase(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21FA940 Offset: 0x21F8F40 VA: 0x1821FA940
	private static void Task_SortCcdManifolds(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F06A0 Offset: 0x21EECA0 VA: 0x1821F06A0
	private static void QuickSortManifoldsByTimeOfImpact(ManifoldData2D** manifolds, int low, int high) { }

	// RVA: 0x21F5A40 Offset: 0x21F4040 VA: 0x1821F5A40
	private static void Task_CcdCallbacks(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F4FE0 Offset: 0x21F35E0 VA: 0x1821F4FE0
	private static void Task_Callbacks(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21ED110 Offset: 0x21EB710 VA: 0x1821ED110
	private static bool CheckIgnoreTriggerManifold(FrameThreadSafe frame, FrameBase frameUnsafe, ComponentSet minComponentSet, int callbacksComponentIdx, ManifoldData2D* m, Entry2D* entryA, Entry2D* entryB) { }

	// RVA: 0x21ECDA0 Offset: 0x21EB3A0 VA: 0x1821ECDA0
	private static bool CheckIgnoreCollisionManifold(FrameThreadSafe frame, FrameBase frameUnsafe, ComponentSet minComponentSet, int callbacksComponentIdx, ManifoldData2D* m, Entry2D* entryA, Entry2D* entryB) { }

	// RVA: 0x21EF470 Offset: 0x21EDA70 VA: 0x1821EF470
	private static void HandleDynamicTrigger(FrameBase f, ICollisionCallbacks2D callbacks, ManifoldData2D* manifold, Entry2D* entryA, Entry2D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x21EFAA0 Offset: 0x21EE0A0 VA: 0x1821EFAA0
	private static void HandleStaticTrigger(FrameBase f, ICollisionCallbacks2D callbacks, Map map, ManifoldData2D* manifold, Entry2D* entryA, Entry2D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x21EF090 Offset: 0x21ED690 VA: 0x1821EF090
	private static void HandleDynamicCollision(FrameBase f, ICollisionCallbacks2D callbacks, CollisionManifold2D* manifold, Entry2D* entryA, Entry2D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x21EF810 Offset: 0x21EDE10 VA: 0x1821EF810
	private static void HandleStaticCollision(FrameBase f, ICollisionCallbacks2D callbacks, Map map, CollisionManifold2D* manifold, Entry2D* entryA, Entry2D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x21F9820 Offset: 0x21F7E20 VA: 0x1821F9820
	private static void Task_PostCallbacksUpdateEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F9BC0 Offset: 0x21F81C0 VA: 0x1821F9BC0
	private static void Task_PostCallbacksUpdateManifolds(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F86C0 Offset: 0x21F6CC0 VA: 0x1821F86C0
	private static void Task_JointsCacheEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F8040 Offset: 0x21F6640 VA: 0x1821F8040
	private static void Task_JointVelocitySolverInit(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F45C0 Offset: 0x21F2BC0 VA: 0x1821F45C0
	private static void Task_BuildIslands(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F4AC0 Offset: 0x21F30C0 VA: 0x1821F4AC0
	private static void Task_BuildJointIslands(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F7280 Offset: 0x21F5880 VA: 0x1821F7280
	private static void Task_IntegrateFirstTOI(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F5E70 Offset: 0x21F4470 VA: 0x1821F5E70
	private static void Task_CollisionSolverCacheManifolds(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F6620 Offset: 0x21F4C20 VA: 0x1821F6620
	private static void Task_CollisionSolverInit(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F60C0 Offset: 0x21F46C0 VA: 0x1821F60C0
	private static void Task_CollisionSolverCompute(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x21F7DA0 Offset: 0x21F63A0 VA: 0x1821F7DA0
	private static void Task_JointVelocitySolverCompute(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x21FABE0 Offset: 0x21F91E0 VA: 0x1821FABE0
	private static void Task_VelocitySolverAggregate(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21FB080 Offset: 0x21F9680 VA: 0x1821FB080
	private static void Task_VelocitySolverApply(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x21FB420 Offset: 0x21F9A20 VA: 0x1821FB420
	private static void Task_VelociySolverLegacyGS(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x21ED470 Offset: 0x21EBA70 VA: 0x1821ED470
	private static Scene2D.AccumulatedImpulseCollection ComputeImpulse(Scene2D* scene, ConstraintData* cst, CollisionManifold2D* m, Entry2D* entryA, Entry2D* entryB, ref FPVector2 cp, bool useRotation, ref bool solved) { }

	// RVA: 0x21F8BB0 Offset: 0x21F71B0 VA: 0x1821F8BB0
	private static void Task_PenetrationCorrection(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F7990 Offset: 0x21F5F90 VA: 0x1821F7990
	private static void Task_IntegrateVelocity(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21ED400 Offset: 0x21EBA00 VA: 0x1821ED400
	private static bool ClampPositionUsableSpace(FPVector2* pos) { }

	// RVA: 0x21F95A0 Offset: 0x21F7BA0 VA: 0x1821F95A0
	private static void Task_PositionSolverCompute(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x21F9070 Offset: 0x21F7670 VA: 0x1821F9070
	private static void Task_PositionSolverAggregate(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F9200 Offset: 0x21F7800 VA: 0x1821F9200
	private static void Task_PositionSolverApply(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x21FA330 Offset: 0x21F8930 VA: 0x1821FA330
	private static void Task_SleepDetectionEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21FA690 Offset: 0x21F8C90 VA: 0x1821FA690
	private static void Task_SleepDetectionIslands(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21F9E50 Offset: 0x21F8450 VA: 0x1821F9E50
	private static void Task_QueryResolve(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x21EE7F0 Offset: 0x21ECDF0 VA: 0x1821EE7F0
	public static void Free(Scene2D* scene, Native.Allocator allocator) { }

	// RVA: 0x21EC690 Offset: 0x21EAC90 VA: 0x1821EC690
	public static Scene2D* Allocate(FrameContext context) { }

	// RVA: 0x21EDFC0 Offset: 0x21EC5C0 VA: 0x1821EDFC0
	private void EnsureBucketCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x21EE050 Offset: 0x21EC650 VA: 0x1821EE050
	private static void EnsurePerBucketBuffersCapacity(FrameThreadSafe frame, Scene2D* scene) { }

	// RVA: 0x21EC540 Offset: 0x21EAB40 VA: 0x1821EC540
	private static void AllocateBroadphaseBucket(Bucket* b, Native.Allocator allocator, int entryCapacity, int queryCapacity, int queryItemCapacity, int manifoldCapacity) { }

	// RVA: 0x21EE600 Offset: 0x21ECC00 VA: 0x1821EE600
	private static void FreeBucket(Native.Allocator allocator, Bucket* b) { }

	// RVA: 0x21FCC80 Offset: 0x21FB280 VA: 0x1821FCC80
	public Entry2D* get_DynamicEntries() { }

	// RVA: 0x21FCC60 Offset: 0x21FB260 VA: 0x1821FCC60
	public int get_DynamicEntriesCount() { }

	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	internal AssetRefMap get_CurrentMap() { }

	// RVA: 0x21F0AF0 Offset: 0x21EF0F0 VA: 0x1821F0AF0
	internal void ResetCurrentMap(FrameBase f, AssetRefMap mapId, int staticCollidersCount = 0) { }

	// RVA: 0x21EB260 Offset: 0x21E9860 VA: 0x1821EB260
	public Entry2D* GetEntry(int index) { }

	// RVA: 0x21EEE80 Offset: 0x21ED480 VA: 0x1821EEE80
	public Entry2D* GetEntryUnchecked(int index) { }

	// RVA: 0x21EF080 Offset: 0x21ED680 VA: 0x1821EF080
	public Tls* GetTLS(int thread) { }

	// RVA: 0x7A8090 Offset: 0x7A6690 VA: 0x1807A8090
	public FP get_DeltaTime() { }

	// RVA: 0x21EF040 Offset: 0x21ED640 VA: 0x1821EF040
	public int GetPointBucket(FPVector2* point) { }

	// RVA: 0x21F00E0 Offset: 0x21EE6E0 VA: 0x1821F00E0
	public void InsertEndPoints(IntAABB aabb, int index, out int minBucket, out int maxBucket) { }

	// RVA: 0x21FCB90 Offset: 0x21FB190 VA: 0x1821FCB90
	public TaskHandle Update(FrameBase frame, FP dt, TaskHandle taskHandle) { }

	// RVA: 0x21FBBE0 Offset: 0x21FA1E0 VA: 0x1821FBBE0
	internal void UpdateMap(FrameBase frame, AssetRefMap mapRef) { }

	// RVA: 0x21EFE70 Offset: 0x21EE470 VA: 0x1821EFE70
	internal void InitScene(FrameBase frame, AssetRefMap mapRef) { }

	// RVA: 0x21F0B80 Offset: 0x21EF180 VA: 0x1821F0B80
	internal void ResetScene(FrameBase frame) { }

	// RVA: 0x21F08E0 Offset: 0x21EEEE0 VA: 0x1821F08E0
	private static void ResetBucketsAndTls(FrameThreadSafe frame, Scene2D* scene) { }

	// RVA: 0x21F0760 Offset: 0x21EED60 VA: 0x1821F0760
	private static void ResetAndEnsureSolverEntriesCapacity(FrameThreadSafe frame, Scene2D* scene) { }

	// RVA: 0x21F0850 Offset: 0x21EEE50 VA: 0x1821F0850
	private void ResetAndEnsureStaticComponentsCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x21EEE90 Offset: 0x21ED490 VA: 0x1821EEE90
	private Entry2D* GetNextEntry(Native.Allocator allocator, out int index) { }

	// RVA: 0x21EEF40 Offset: 0x21ED540 VA: 0x1821EEF40
	private Island2D* GetNextIsland(Native.Allocator allocator) { }
}
