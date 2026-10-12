// Namespace: Quantum.Physics2D
internal struct Bucket // TypeDefIndex: 11965
{
	// Fields
	public int Min; // 0x0
	public int Max; // 0x4
	public int* RadixPref; // 0x8
	public int* RadixCount; // 0x10
	public Radix.EndPoint* EndPoints; // 0x18
	public Radix.EndPoint* EndPointsSortTemp; // 0x20
	public int EndPointsCount; // 0x28
	public int EndPointsCapacity; // 0x2C
	public Radix.EndPoint* EndPointsStatic; // 0x30
	public int EndPointsStaticCount; // 0x38
	public int EndPointsStaticCapacity; // 0x3C
	public PhysicsCommon.StabbingList StaticsStabbingList; // 0x40
	public PhysicsCommon.StabbingList DynamicsStabbingList; // 0x60
	public CollisionManifold2D* CollisionManifolds; // 0x80
	public int CollisionManifoldsCount; // 0x88
	public int CollisionManifoldsCapacity; // 0x8C
	public int CollisionManifoldsProcessCount; // 0x90
	public CollisionManifold2D** SolverManifolds; // 0x98
	public int SolverManifoldsCount; // 0xA0
	public int SolverManifoldsCapacity; // 0xA4
	public PhysicsCommon.UnsafeBuffer TriggerManifoldsBuffer; // 0xA8
	public int TriggerManifoldsProcessCount; // 0xC0
	public QueryManifold* QueryManifolds; // 0xC8
	public int QueryManifoldsCount; // 0xD0
	public int QueryManifoldsCapacity; // 0xD4

	// Methods

	// RVA: 0x2207210 Offset: 0x2205810 VA: 0x182207210
	public void EnsureEndPointsCapacity(Native.Allocator allocator, int entryCapacity, int queryCapacity) { }

	// RVA: 0x22072F0 Offset: 0x22058F0 VA: 0x1822072F0
	public void EnsureEndPointsStaticCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x2207600 Offset: 0x2205C00 VA: 0x182207600
	public void InsertEndPoints(Radix.EndPoint min, Radix.EndPoint max) { }

	// RVA: 0x22075D0 Offset: 0x2205BD0 VA: 0x1822075D0
	public void InsertEndPointsStatic(Radix.EndPoint min, Radix.EndPoint max) { }

	// RVA: 0x22073A0 Offset: 0x22059A0 VA: 0x1822073A0
	public CollisionManifold2D* GetNextCollisionManifold(Native.Allocator allocator) { }

	// RVA: 0x2207480 Offset: 0x2205A80 VA: 0x182207480
	public QueryManifold* GetNextQueryManifold(Native.Allocator allocator, out int i) { }

	// RVA: 0x2207570 Offset: 0x2205B70 VA: 0x182207570
	public ManifoldData2D* GetNextTriggerManifold(Native.Allocator allocator) { }

	// RVA: 0x2207380 Offset: 0x2205980 VA: 0x182207380
	public int GetNextCollisionManifoldToProcess() { }

	// RVA: 0x2207550 Offset: 0x2205B50 VA: 0x182207550
	public int GetNextTriggerManifoldToProcess() { }
}
