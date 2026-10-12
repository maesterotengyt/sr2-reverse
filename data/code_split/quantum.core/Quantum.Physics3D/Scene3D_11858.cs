// Namespace: Quantum.Physics3D
internal struct Scene3D // TypeDefIndex: 11858
{
	// Fields
	private const int MIN_STATIC_CAPACITY = 64;
	private const int MIN_ENTRY_CAPACITY = 32;
	private const int MIN_QUERY_CAPACITY = 32;
	private const int MIN_QUERY_ITEM_CAPACITY = 128;
	private const int MIN_ISLAND_CAPACITY = 16;
	private const int MIN_MANIFOLD_CAPACITY = 32;
	private const int MIN_BUCKETS_CAPACITY = 4;
	private const int MIN_JOINTS_CAPACITY = 0;
	private Bucket3D* _buckets; // 0x0
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
	private Island3D* _islands; // 0x58
	private int _islandsCount; // 0x60
	private int _islandsCapacity; // 0x64
	private int _islandsProcessedCorrection; // 0x68
	private int _islandsProcessedSleepDetection; // 0x6C
	private Entry3D* _entries; // 0x70
	private int _entriesCount; // 0x78
	private int _meshEntriesCount; // 0x7C
	private int _entriesCapacity; // 0x80
	private Query3D* _queries; // 0x88
	private int _queriesCount; // 0x90
	private int _queriesCapacity; // 0x94
	private int _queriesProcessed; // 0x98
	private int* _queriesPerBucketManifolds; // 0xA0
	private int _queriesPerBucketManifoldsCapacity; // 0xA8
	private int* _meshPerBucketManifolds; // 0xB0
	private int _meshEntriesCapacity; // 0xB8
	internal HitCollection3D* HitCollections; // 0xC0
	internal int HitCollectionsCount; // 0xC8
	private int _hitCollectionsCapacity; // 0xCC
	private StaticComponents3D* _staticComponents; // 0xD0
	private int _staticComponentsCount; // 0xD8
	private int _staticComponentsCapacity; // 0xDC
	private FP _deltaTime; // 0xE0
	internal PhysicsSceneSettings CachedSettings; // 0xE8
	private ComponentSet _minComponentSet; // 0x210
	private Scene3D.TaskManagementData _taskData; // 0x230
	private PhysicsCommon.UnsafeBuffer _collisionSolverManifolds; // 0x310
	private PhysicsCommon.UnsafeBuffer _collisionSolverData; // 0x328
	private PhysicsCommon.UnsafeBuffer _jointEntries; // 0x340
	private PhysicsCommon.UnsafeBuffer _jointConstraintData; // 0x358
	private Entry3D** _solverEntries; // 0x370
	private int _solverEntriesCount; // 0x378
	private int _solverEntriesCapacity; // 0x37C
	private PhysicsCommon.UnsafeBuffer _ccdManifolds; // 0x380
	private UnsafeHashMap* _dynamicEntityRefToEntryIndex; // 0x398
	private const CallbackFlags StaticTriggerCallbacks = 3584;
	private const CallbackFlags DynamicTriggerCallbacks = 448;

	// Properties
	public Entry3D* DynamicEntries { get; }
	public int DynamicEntriesCount { get; }
	internal AssetRefMap CurrentMap { get; }
	public FP DeltaTime { get; }

	// Methods

	// RVA: 0x224B990 Offset: 0x2249F90 VA: 0x18224B990
	private static void ResolveQuery(FrameThreadSafe frame, Scene3D* scene, HitCollection3D* hits, Query3D* query, Entry3D* qEntry) { }

	// RVA: 0x224B1D0 Offset: 0x22497D0 VA: 0x18224B1D0
	private static void ResolveQueryNarrow(FrameThreadSafe frame, Scene3D* scene, HitCollection3D* hits, Query3D* query, Entry3D* qEntry, Entry3D* entry, TriangleCCW* tri, bool computeDetailedInfo) { }

	// RVA: 0x2249E20 Offset: 0x2248420 VA: 0x182249E20
	public static void Linecast(FrameThreadSafe frame, Scene3D* scene, HitCollection3D* hits, FPVector3* start, FPVector3* end, bool firstHitOnly, int layerMask, QueryOptions options) { }

	// RVA: 0x22498A0 Offset: 0x2247EA0 VA: 0x1822498A0
	private static void InitLinecastEntry(Scene3D* scene, Query3D* query, Entry3D* qEntry) { }

	// RVA: 0x2259FA0 Offset: 0x22585A0 VA: 0x182259FA0
	private static void TraverseSceneMeshLinecast(ref Scene3D.QueryContextInfo3D info, Scene3D.TriTraversalDelegate triDelegate) { }

	// RVA: 0x2249A90 Offset: 0x2248090 VA: 0x182249A90
	private static void InitShapeCastEntry(Scene3D* scene, Query3D* query, Shape3D* queryShape, Entry3D* qEntry) { }

	// RVA: 0x225A6A0 Offset: 0x2258CA0 VA: 0x18225A6A0
	private static void TraverseSceneMeshShapeCast(ref Scene3D.QueryContextInfo3D info, Scene3D.TriTraversalDelegate triDelegate) { }

	// RVA: 0x224A0C0 Offset: 0x22486C0 VA: 0x18224A0C0
	public static void OverlapShape(FrameThreadSafe frame, Scene3D* scene, HitCollection3D* hits, FPVector3* pos, FPQuaternion* rot, Shape3D* shape, int layerMask, QueryOptions options) { }

	// RVA: 0x2249F40 Offset: 0x2248540 VA: 0x182249F40
	private static void OverlapCompoundShape(FrameThreadSafe f, Scene3D* scene, Query3D* query, Entry3D* qEntry, HitCollection3D* hits, Shape3D* rootShape) { }

	// RVA: 0x2249BE0 Offset: 0x22481E0 VA: 0x182249BE0
	private static void InitShapeOverlapEntry(Scene3D* scene, Query3D* query, Shape3D* queryShape, Entry3D* qEntry) { }

	// RVA: 0x225B0E0 Offset: 0x22596E0 VA: 0x18225B0E0
	private static void TraverseSceneMeshShapeOverlap(ref Scene3D.QueryContextInfo3D info, Scene3D.TriTraversalDelegate triDelegate) { }

	// RVA: 0x2252390 Offset: 0x2250990 VA: 0x182252390
	private static void Task_CollisionSolverInitLegacyGS(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x22597C0 Offset: 0x2257DC0 VA: 0x1822597C0
	private static void Task_VelocitySolverLegacyGS(FrameThreadSafe f, int start, int count, void* arg) { }

	// RVA: 0x22442D0 Offset: 0x22428D0 VA: 0x1822442D0
	private static void AccumulateImpulses(Scene3D* scene, ConstraintData* cst, CollisionManifold3D* m, Entry3D* entryA, Entry3D* entryB, bool useRotation, ref Scene3D.AccumulatedImpulseCollection accumulatedImpulses, ref bool solved, Scene3D.AccumulatedImpulseFlags flags) { }

	// RVA: 0x2245AB0 Offset: 0x22440B0 VA: 0x182245AB0
	private static Scene3D.AccumulatedImpulseCollection ComputeImpulse(Scene3D* scene, ConstraintData* cst, CollisionManifold3D* m, Entry3D* entryA, Entry3D* entryB, ref FPVector3 cp, bool useRotation, ref bool solved) { }

	// RVA: 0x22448B0 Offset: 0x2242EB0 VA: 0x1822448B0
	public static Scene3D* Allocate(FrameContext context) { }

	// RVA: 0x2246C50 Offset: 0x2245250 VA: 0x182246C50
	private void EnsureBucketCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x2246CE0 Offset: 0x22452E0 VA: 0x182246CE0
	private static void EnsurePerBucketBuffersCapacity(Native.Allocator allocator, Scene3D* scene) { }

	// RVA: 0x22446C0 Offset: 0x2242CC0 VA: 0x1822446C0
	private static void AllocateBroadphaseBucket(Bucket3D* b, Native.Allocator allocator, int index, int entryCapacity, int queryCapacity, int queryItemCapacity, int manifoldCapacity) { }

	// RVA: 0x2247EB0 Offset: 0x22464B0 VA: 0x182247EB0
	public static void Free(Scene3D* scene, Native.Allocator allocator) { }

	// RVA: 0x2247C40 Offset: 0x2246240 VA: 0x182247C40
	private static void FreeBucket(Native.Allocator allocator, Bucket3D* b) { }

	// RVA: 0x225C6F0 Offset: 0x225ACF0 VA: 0x18225C6F0
	public Entry3D* get_DynamicEntries() { }

	// RVA: 0x225C6D0 Offset: 0x225ACD0 VA: 0x18225C6D0
	public int get_DynamicEntriesCount() { }

	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	internal AssetRefMap get_CurrentMap() { }

	// RVA: 0x224AD30 Offset: 0x2249330 VA: 0x18224AD30
	internal void ResetCurrentMap(FrameBase f, AssetRefMap mapId, int staticCollidersCount = 0) { }

	// RVA: 0x22430A0 Offset: 0x22416A0 VA: 0x1822430A0
	public Entry3D* GetEntry(int index) { }

	// RVA: 0x22485B0 Offset: 0x2246BB0 VA: 0x1822485B0
	public Entry3D* GetEntryUnchecked(int index) { }

	// RVA: 0x22487C0 Offset: 0x2246DC0 VA: 0x1822487C0
	public Tls* GetTLS(int thread) { }

	// RVA: 0x7A80E0 Offset: 0x7A66E0 VA: 0x1807A80E0
	public FP get_DeltaTime() { }

	// RVA: 0x2248780 Offset: 0x2246D80 VA: 0x182248780
	public int GetPointBucket(FPVector3* point) { }

	// RVA: 0x2249C70 Offset: 0x2248270 VA: 0x182249C70
	public void InsertEndPoints(IntAABB aabb, int index, out int minBucket, out int maxBucket) { }

	// RVA: 0x225C600 Offset: 0x225AC00 VA: 0x18225C600
	public TaskHandle Update(FrameBase frame, FP dt, TaskHandle taskHandle) { }

	// RVA: 0x225B4F0 Offset: 0x2259AF0 VA: 0x18225B4F0
	internal void UpdateMap(FrameBase frame, AssetRefMap mapRef) { }

	// RVA: 0x2249A20 Offset: 0x2248020 VA: 0x182249A20
	internal void InitScene(FrameBase frame, AssetRefMap mapRef) { }

	// RVA: 0x224ADC0 Offset: 0x22493C0 VA: 0x18224ADC0
	internal void ResetScene(FrameBase frame) { }

	// RVA: 0x224AB00 Offset: 0x2249100 VA: 0x18224AB00
	private static void ResetBucketsAndTls(Native.Allocator allocator, Scene3D* scene) { }

	// RVA: 0x224A9A0 Offset: 0x2248FA0 VA: 0x18224A9A0
	private static void ResetAndEnsureSolverEntriesCapacity(Native.Allocator allocator, Scene3D* scene) { }

	// RVA: 0x224AA50 Offset: 0x2249050 VA: 0x18224AA50
	private void ResetAndEnsureStaticComponentsCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x22485C0 Offset: 0x2246BC0 VA: 0x1822485C0
	private Entry3D* GetNextEntry(Native.Allocator allocator, out int index) { }

	// RVA: 0x2248680 Offset: 0x2246C80 VA: 0x182248680
	private Island3D* GetNextIsland(Native.Allocator allocator) { }

	// RVA: 0x22538E0 Offset: 0x2251EE0 VA: 0x1822538E0
	private static void Task_CreateEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2246880 Offset: 0x2244E80 VA: 0x182246880
	private static void CreateEntries(FrameThreadSafe frame, Scene3D* scene) { }

	// RVA: 0x2246700 Offset: 0x2244D00 VA: 0x182246700
	private static void CreateCompoundEntries(FrameThreadSafe frame, Scene3D* scene, int rootEntryIdx, Shape3D* compoundShape) { }

	// RVA: 0x2253740 Offset: 0x2251D40 VA: 0x182253740
	private static void Task_CreateEntriesMapping(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2253DD0 Offset: 0x22523D0 VA: 0x182253DD0
	private static void Task_IntegrateForcesFirstHalf(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x224C6F0 Offset: 0x224ACF0 VA: 0x18224C6F0
	private static void Task_BroadPhaseEntryPreStep(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x224CA10 Offset: 0x224B010 VA: 0x18224CA10
	private static void Task_BroadPhaseQueryPreStep(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2244660 Offset: 0x2242C60 VA: 0x182244660
	private static void AddQueryItem(Native.Allocator allocator, Bucket3D* bucket, int* queryBucketManifold, int entryIndex, int triIndex = -1) { }

	// RVA: 0x224A3F0 Offset: 0x22489F0 VA: 0x18224A3F0
	private void QueryCheckEntryList(Native.Allocator allocator, PhysicsCommon.ActiveEntryList* list, int bucket, int epIdx, int* queryBucketManifold) { }

	// RVA: 0x224A5C0 Offset: 0x2248BC0 VA: 0x18224A5C0
	private void QueryCheckTriangles(ref Scene3D.QueryContextInfo3D info) { }

	// RVA: 0x2247260 Offset: 0x2245860 VA: 0x182247260
	private void EntryCheckTriangles(Native.Allocator allocator, FrameContext context, Scene3D* scene, int entryIdx, int bucketIdx, int tlsIdx, bool entryIsTrigger, bool isKinematic) { }

	// RVA: 0x22470A0 Offset: 0x22456A0 VA: 0x1822470A0
	private void EntryCheckQueryList(Native.Allocator allocator, PhysicsCommon.ActiveEntryList* list, int bucket, int epIdx, int* bucketQueryManifolds) { }

	// RVA: 0x2246D90 Offset: 0x2245390 VA: 0x182246D90
	private void EntryCheckEntryList(Native.Allocator allocator, Scene3D* scene, PhysicsCommon.ActiveEntryList* list, int bucket, Entry3D* entry, bool isTriggerManifold, bool isSleeping, bool isKinematic, bool isStatic) { }

	// RVA: 0x224CDE0 Offset: 0x224B3E0 VA: 0x18224CDE0
	private static void Task_BroadPhase(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2255810 Offset: 0x2253E10 VA: 0x182255810
	private static void Task_NarrowPhase(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2255670 Offset: 0x2253C70 VA: 0x182255670
	private static void Task_NarrowPhaseMeshes(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2258AA0 Offset: 0x22570A0 VA: 0x182258AA0
	private static void Task_SortCcdManifolds(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x224A8E0 Offset: 0x2248EE0 VA: 0x18224A8E0
	private static void QuickSortManifoldsByTimeOfImpact(ManifoldData3D** manifolds, int low, int high) { }

	// RVA: 0x2250660 Offset: 0x224EC60 VA: 0x182250660
	private static void Task_CcdCallbacks(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x224FAA0 Offset: 0x224E0A0 VA: 0x18224FAA0
	private static void Task_Callbacks(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x22457C0 Offset: 0x2243DC0 VA: 0x1822457C0
	private static bool CheckIgnoreTriggerManifold(FrameThreadSafe frame, FrameBase frameUnsafe, ComponentSet minComponentSet, int callbacksComponentIdx, ManifoldData3D* m, Entry3D* entryA, Entry3D* entryB) { }

	// RVA: 0x2245260 Offset: 0x2243860 VA: 0x182245260
	private static bool CheckIgnoreCollisionManifold(FrameThreadSafe frame, FrameBase frameUnsafe, ComponentSet minComponentSet, int callbacksComponentIdx, ManifoldData3D* m, Entry3D* entryA, Entry3D* entryB) { }

	// RVA: 0x22455D0 Offset: 0x2243BD0 VA: 0x1822455D0
	private static bool CheckIgnoreMeshCollisionManifold(FrameThreadSafe frame, FrameBase frameUnsafe, ComponentSet minComponentSet, int callbacksComponentIdx, ManifoldData3D* m, Entry3D* entryA) { }

	// RVA: 0x2248C80 Offset: 0x2247280 VA: 0x182248C80
	private static void HandleDynamicTrigger(FrameBase f, ICollisionCallbacks3D callbacks, ManifoldData3D* manifold, Entry3D* entryA, Entry3D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x22495E0 Offset: 0x2247BE0 VA: 0x1822495E0
	private static void HandleStaticTrigger(FrameBase f, ICollisionCallbacks3D callbacks, Map map, ManifoldData3D* manifold, Entry3D* entryA, Entry3D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x22487D0 Offset: 0x2246DD0 VA: 0x1822487D0
	private static void HandleDynamicCollision(FrameBase f, ICollisionCallbacks3D callbacks, CollisionManifold3D* manifold, Entry3D* entryA, Entry3D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x22492F0 Offset: 0x22478F0 VA: 0x1822492F0
	private static void HandleStaticCollision(FrameBase f, ICollisionCallbacks3D callbacks, Map map, CollisionManifold3D* manifold, Entry3D* entryA, Entry3D* entryB, ref bool callbacksCalled) { }

	// RVA: 0x2249020 Offset: 0x2247620 VA: 0x182249020
	private static void HandleMeshCollision(FrameBase f, ICollisionCallbacks3D callbacks, Map map, TriangleMesh sceneMesh, CollisionManifold3D* manifold, Entry3D* entryA, Entry3D* entryB, CollisionManifold3D* triManifolds, ref bool callbacksCalled) { }

	// RVA: 0x22571B0 Offset: 0x22557B0 VA: 0x1822571B0
	private static void Task_PostCallbacksUpdateEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2257550 Offset: 0x2255B50 VA: 0x182257550
	private static void Task_PostCallbacksUpdateManifolds(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x224EFB0 Offset: 0x224D5B0 VA: 0x18224EFB0
	private static void Task_BuildIslands(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x224F580 Offset: 0x224DB80 VA: 0x18224F580
	private static void Task_BuildJointIslands(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x22554C0 Offset: 0x2253AC0 VA: 0x1822554C0
	private static void Task_JointsCacheEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2254D70 Offset: 0x2253370 VA: 0x182254D70
	private static void Task_JointVelocitySolverInit(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2253B30 Offset: 0x2252130 VA: 0x182253B30
	private static void Task_IntegrateFirstTOI(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x22515E0 Offset: 0x224FBE0 VA: 0x1822515E0
	private static void Task_CollisionSolverCacheManifolds(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2252F30 Offset: 0x2251530 VA: 0x182252F30
	private static void Task_CollisionSolverInit(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2251870 Offset: 0x224FE70 VA: 0x182251870
	private static void Task_CollisionSolverCompute(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x2250B90 Offset: 0x224F190 VA: 0x182250B90
	private static void Task_CollisionSolverAggregateContacts(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x2250FC0 Offset: 0x224F5C0 VA: 0x182250FC0
	private static void Task_CollisionSolverAggregateMesh(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x2254AC0 Offset: 0x22530C0 VA: 0x182254AC0
	private static void Task_JointVelocitySolverCompute(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x2258D90 Offset: 0x2257390 VA: 0x182258D90
	private static void Task_VelocitySolverAggregate(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2259190 Offset: 0x2257790 VA: 0x182259190
	private static void Task_VelocitySolverApply(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x22330D0 Offset: 0x22316D0 VA: 0x1822330D0
	internal static long ComputePerceivedMassRaw(Entry3D* entry, ref FPVector3 r, ref FPVector3 dir) { }

	// RVA: 0x2244FC0 Offset: 0x22435C0 VA: 0x182244FC0
	private static void ApplyImpulse(Entry3D* entry, FPVector3 linImpulse, Nullable<FPVector3> angImpulse) { }

	// RVA: 0x2255E50 Offset: 0x2254450 VA: 0x182255E50
	private static void Task_PenetrationCorrection(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2254510 Offset: 0x2252B10 VA: 0x182254510
	private static void Task_IntegrateVelocity(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2242C40 Offset: 0x2241240 VA: 0x182242C40
	private static bool ClampPositionUsableSpace(FPVector3* pos) { }

	// RVA: 0x22582D0 Offset: 0x22568D0 VA: 0x1822582D0
	private static void Task_SleepDetectionEntries(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x22587E0 Offset: 0x2256DE0 VA: 0x1822587E0
	private static void Task_SleepDetectionIslands(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x2256F30 Offset: 0x2255530 VA: 0x182256F30
	private static void Task_PositionSolverCompute(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x2256610 Offset: 0x2254C10 VA: 0x182256610
	private static void Task_PositionSolverAggregate(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: 0x22567A0 Offset: 0x2254DA0 VA: 0x1822567A0
	private static void Task_PositionSolverApply(FrameThreadSafe frame, int start, int count, void* slicesIndexer) { }

	// RVA: 0x2257900 Offset: 0x2255F00 VA: 0x182257900
	private static void Task_QueryResolve(FrameThreadSafe frame, int start, int count, void* arg) { }
}
