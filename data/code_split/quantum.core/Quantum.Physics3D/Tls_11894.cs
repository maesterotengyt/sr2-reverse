// Namespace: Quantum.Physics3D
internal struct Tls // TypeDefIndex: 11894
{
	// Fields
	public PhysicsCommon.ActiveEntryList QueryAll; // 0x0
	public PhysicsCommon.ActiveEntryList QueryDynamic; // 0x20
	public PhysicsCommon.ActiveEntryList QueryKinematic; // 0x40
	public PhysicsCommon.ActiveEntryList QueryKinematicTrigger; // 0x60
	public PhysicsCommon.ActiveEntryList QueryStatic; // 0x80
	public PhysicsCommon.ActiveEntryList QueryStaticTrigger; // 0xA0
	public PhysicsCommon.ActiveEntryList Dynamic; // 0xC0
	public PhysicsCommon.ActiveEntryList Kinematic; // 0xE0
	public PhysicsCommon.ActiveEntryList KinematicTrigger; // 0x100
	public PhysicsCommon.ActiveEntryList Static; // 0x120
	public PhysicsCommon.ActiveEntryList StaticTrigger; // 0x140
	public Entry3D Entry; // 0x160
	public CollisionManifold3D Manifold; // 0xA30
	public PhysicsCollider3D Collider3D; // 0xAF8
	public Transform3D Transform3D; // 0xB68
	public Gjk3D.SimplexData3D SimplexData; // 0xBA0
	public Gjk3D.SimplexDataPointers3D SimplexPointers; // 0xCE0
	public ulong OverlapSequence; // 0xD18
	private ulong* _trianglesMailboxes; // 0xD20
	private int _trianglesMailboxesCapacity; // 0xD28

	// Methods

	// RVA: 0x2276BC0 Offset: 0x22751C0 VA: 0x182276BC0
	public void Free(Native.Allocator allocator) { }

	// RVA: 0x2276C20 Offset: 0x2275220 VA: 0x182276C20
	public ulong* GetTrianglesMailboxes(Native.Allocator allocator, int ensureCapacity) { }

	// RVA: 0x2276B20 Offset: 0x2275120 VA: 0x182276B20
	public void EnsureMailboxesCapacity(Native.Allocator allocator, int capacity) { }
}
