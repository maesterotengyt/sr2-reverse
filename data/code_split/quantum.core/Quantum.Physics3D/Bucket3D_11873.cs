// Namespace: Quantum.Physics3D
internal struct Bucket3D // TypeDefIndex: 11873
{
	// Fields
	public int Min; // 0x0
	public int Max; // 0x4
	public int* RadixPref; // 0x8
	public int* RadixCount; // 0x10
	public int Index; // 0x18
	public Radix.EndPoint* EndPoints; // 0x20
	public Radix.EndPoint* EndPointsSortTemp; // 0x28
	public int EndPointsCount; // 0x30
	public int EndPointsCapacity; // 0x34
	public Radix.EndPoint* EndPointsStatic; // 0x38
	public int EndPointsStaticCount; // 0x40
	public int EndPointsStaticCapacity; // 0x44
	public PhysicsCommon.StabbingList StaticsStabbingList; // 0x48
	public PhysicsCommon.StabbingList DynamicsStabbingList; // 0x68
	public CollisionManifold3D* CollisionManifolds; // 0x88
	public int CollisionManifoldsCount; // 0x90
	public int CollisionManifoldsCapacity; // 0x94
	public int CollisionManifoldsProcessCount; // 0x98
	public CollisionManifold3D* MeshCollisionManifolds; // 0xA0
	public int MeshCollisionManifoldsCount; // 0xA8
	public int MeshCollisionManifoldsCapacity; // 0xAC
	public int MeshCollisionManifoldsProcessCount; // 0xB0
	public CollisionManifold3D** SolverManifolds; // 0xB8
	public int SolverManifoldsCount; // 0xC0
	public int SolverManifoldsCapacity; // 0xC4
	public CollisionManifold3D* TriangleCollisionManifolds; // 0xC8
	public int TriangleCollisionManifoldsCount; // 0xD0
	public int TriangleCollisionManifoldsCapacity; // 0xD4
	public int TriangleCollisionManifoldsProcessCount; // 0xD8
	public PhysicsCommon.UnsafeBuffer TriggerManifoldsBuffer; // 0xE0
	public int TriggerManifoldsProcessCount; // 0xF8
	public PhysicsCommon.UnsafeBuffer TriangleTriggerManifoldsBuffer; // 0x100
	public QueryManifold3D* QueryManifolds; // 0x118
	public int QueryManifoldsCount; // 0x120
	public int QueryManifoldsCapacity; // 0x124

	// Methods

	// RVA: 0x2271470 Offset: 0x226FA70 VA: 0x182271470
	public void EnsureEndPointsCapacity(Native.Allocator allocator, int entryCapacity, int queryCapacity) { }

	// RVA: 0x2271550 Offset: 0x226FB50 VA: 0x182271550
	public void EnsureEndPointsStaticCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x22719F0 Offset: 0x226FFF0 VA: 0x1822719F0
	public void InsertEndPoints(Radix.EndPoint min, Radix.EndPoint max) { }

	// RVA: 0x22719C0 Offset: 0x226FFC0 VA: 0x1822719C0
	public void InsertEndPointsStatic(Radix.EndPoint min, Radix.EndPoint max) { }

	// RVA: 0x2271600 Offset: 0x226FC00 VA: 0x182271600
	public CollisionManifold3D* GetNextCollisionManifold(Native.Allocator allocator) { }

	// RVA: 0x22716D0 Offset: 0x226FCD0 VA: 0x1822716D0
	public CollisionManifold3D* GetNextMeshCollisionManifold(Native.Allocator allocator, out int index) { }

	// RVA: 0x22718A0 Offset: 0x226FEA0 VA: 0x1822718A0
	public CollisionManifold3D* GetNextTriangleCollisionManifold(Native.Allocator allocator, out int index) { }

	// RVA: 0x22717D0 Offset: 0x226FDD0 VA: 0x1822717D0
	public QueryManifold3D* GetNextQueryManifold(Native.Allocator allocator, out int index) { }

	// RVA: 0x22715E0 Offset: 0x226FBE0 VA: 0x1822715E0
	public int GetNextCollisionManifoldToProcess() { }

	// RVA: 0x22717B0 Offset: 0x226FDB0 VA: 0x1822717B0
	public int GetNextMeshManifoldToProcess() { }

	// RVA: 0x2271980 Offset: 0x226FF80 VA: 0x182271980
	public int GetNextTriangleManifoldToProcess() { }

	// RVA: 0x22719A0 Offset: 0x226FFA0 VA: 0x1822719A0
	public int GetNextTriggerManifoldToProcess() { }
}
