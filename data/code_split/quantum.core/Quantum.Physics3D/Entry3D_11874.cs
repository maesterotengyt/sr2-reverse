// Namespace: Quantum.Physics3D
internal struct Entry3D // TypeDefIndex: 11874
{
	// Fields
	public int Index; // 0x0
	public EntityRef Ref; // 0x8
	public bool Ignore; // 0x10
	public PhysicsCollider3D* Collider3D; // 0x18
	public Shape3D* Shape; // 0x20
	public PhysicsBody3D* Body3D; // 0x28
	public Transform3D* Transform3D; // 0x30
	public PhysicsJoints3D* Joints; // 0x38
	public int JointSolverDataIndex; // 0x40
	public PhysicsCallbacks3D* Callbacks; // 0x48
	public bool HasStaticTriggerCallbacks; // 0x50
	public bool HasDynamicTriggerCallbacks; // 0x51
	public Island3D* Island; // 0x58
	public bool ShouldIntegrateVelocity; // 0x60
	public bool HasDynamicBody; // 0x61
	public bool _useCCD; // 0x62
	public FP _firstTimeOfImpact; // 0x68
	private int _compoundRootIndexPlusOne; // 0x70
	private Entry3D* _compoundRoot; // 0x78
	public IntAABB AABB; // 0x80
	public int BucketStart; // 0x98
	public int BucketEnd; // 0x9C
	public int BucketIncrement; // 0xA0
	public int StaticColliderIndex; // 0xA4
	public bool UseSmoothSphereMeshCollision; // 0xA8
	public NarrowData3D Narrow; // 0xB0
	public FPVector3 RotatedCenterOfMass; // 0x850
	public FPMatrix3x3 WorldInertiaTensorInverse; // 0x868
	public FPVector3 AccumulatedCorrection; // 0x8B0
	internal long SolverImpulsesAdr; // 0x8C8

	// Properties
	public bool IsDynamic { get; }
	public bool UsesCcd { get; }
	public int CompoundRootIndex { get; set; }
	public Entry3D* CompoundRoot { get; set; }

	// Methods

	// RVA: 0x22733D0 Offset: 0x22719D0 VA: 0x1822733D0
	public bool get_IsDynamic() { }

	// RVA: 0x22733E0 Offset: 0x22719E0 VA: 0x1822733E0
	public bool get_UsesCcd() { }

	// RVA: 0x22733C0 Offset: 0x22719C0 VA: 0x1822733C0
	public int get_CompoundRootIndex() { }

	// RVA: 0x2273410 Offset: 0x2271A10 VA: 0x182273410
	public void set_CompoundRootIndex(int value) { }

	// RVA: 0x5DC7F0 Offset: 0x5DADF0 VA: 0x1805DC7F0
	public Entry3D* get_CompoundRoot() { }

	// RVA: 0x2273420 Offset: 0x2271A20 VA: 0x182273420
	public void set_CompoundRoot(Entry3D* value) { }

	// RVA: 0x2272F20 Offset: 0x2271520 VA: 0x182272F20
	public void Init(Scene3D* scene) { }

	// RVA: 0x2272440 Offset: 0x2270A40 VA: 0x182272440
	public static void GetSupportOffset(Entry3D* entry, FPVector3 worldDir, out FPVector3 supportOffset, Nullable<FP> deltaTime, int dtShift = 0) { }

	// RVA: 0x2271EC0 Offset: 0x22704C0 VA: 0x182271EC0
	public static void CalculateWorldBodySettings(Entry3D* entry, Nullable<FPQuaternion> rotation) { }

	// RVA: 0x2272F40 Offset: 0x2271540 VA: 0x182272F40
	public void IntegrateVelocity(FP dt, PhysicsSceneSettings* settings, bool applyMinVelThreshold = True, bool integrateAngVel = True) { }

	// RVA: 0x2241860 Offset: 0x223FE60 VA: 0x182241860
	private void ApplyMinVelocityIntegration(PhysicsSceneSettings* settings) { }

	// RVA: 0x226FB70 Offset: 0x226E170 VA: 0x18226FB70
	private static void ComputeEntryAabb(Shape3D* shape, NarrowData3D* narrow, IntAABB* aabb) { }

	// RVA: 0x2272DF0 Offset: 0x22713F0 VA: 0x182272DF0
	public static void InitNarrowData(Entry3D* entry, FPVector3* pos, FPQuaternion* rot) { }

	// RVA: 0x2272C30 Offset: 0x2271230 VA: 0x182272C30
	public static void InitBroadAabb(Entry3D* entry, FPVector3* pos, FPQuaternion* rot, Nullable<FP> deltaTime) { }
}
