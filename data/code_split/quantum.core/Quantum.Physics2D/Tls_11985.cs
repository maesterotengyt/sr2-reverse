// Namespace: Quantum.Physics2D
internal struct Tls // TypeDefIndex: 11985
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
	public Entry2D Entry; // 0x160
	public CollisionManifold2D CollisionManifold; // 0x258
	public PhysicsCollider2D Collider; // 0x2D0
	public Transform2D Transform; // 0x320
	public FPVector2* BoxVertices; // 0x338
	public FPVector2* BoxNormals; // 0x340
	public Gjk2D.SimplexData2D SimplexData; // 0x348
	public Gjk2D.SimplexDataPointers2D SimplexPointers; // 0x3F0
}
