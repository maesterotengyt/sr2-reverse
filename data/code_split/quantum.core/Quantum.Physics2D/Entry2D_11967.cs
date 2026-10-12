// Namespace: Quantum.Physics2D
internal struct Entry2D // TypeDefIndex: 11967
{
	// Fields
	public int Index; // 0x0
	public bool Ignore; // 0x4
	public EntityRef Ref; // 0x8
	public PhysicsCollider2D* Collider; // 0x10
	public Shape2D* Shape; // 0x18
	public PhysicsBody2D* Body; // 0x20
	public Transform2D* Transform2D; // 0x28
	public Transform2DVertical* Transform2DVertical; // 0x30
	public PhysicsJoints2D* Joints; // 0x38
	public int JointSolverDataIndex; // 0x40
	public PhysicsCallbacks2D* Callbacks; // 0x48
	public bool HasStaticTriggerCallbacks; // 0x50
	public bool HasDynamicTriggerCallbacks; // 0x51
	public bool ShouldIntegrateVelocity; // 0x52
	public bool HasDynamicBody; // 0x53
	internal bool _useCCD; // 0x54
	internal FP _firstTimeOfImpact; // 0x58
	private int _compoundRootIndexPlusOne; // 0x60
	private Entry2D* _compoundRoot; // 0x68
	public Island2D* Island; // 0x70
	public Entry2D.PolygonData Polygon; // 0x78
	public NarrowData2D Narrow; // 0x90
	public IntAABB AABB; // 0xB0
	public int BucketStart; // 0xC0
	public int BucketEnd; // 0xC4
	public int BucketIncrement; // 0xC8
	public int StaticColliderIndex; // 0xCC
	public FPVector2 AccumulatedCorrection; // 0xD0
	public FPVector2 RotatedCenterOfMass; // 0xE0
	internal long SolverImpulsesAdr; // 0xF0

	// Properties
	public bool IsDynamic { get; }
	public bool UseCCD { get; }
	public int CompoundRootIndex { get; set; }
	public Entry2D* CompoundRoot { get; set; }

	// Methods

	// RVA: 0x2209F40 Offset: 0x2208540 VA: 0x182209F40
	public bool get_IsDynamic() { }

	// RVA: 0x2209F50 Offset: 0x2208550 VA: 0x182209F50
	public bool get_UseCCD() { }

	// RVA: 0x2209F30 Offset: 0x2208530 VA: 0x182209F30
	public int get_CompoundRootIndex() { }

	// RVA: 0x2209F80 Offset: 0x2208580 VA: 0x182209F80
	public void set_CompoundRootIndex(int value) { }

	// RVA: 0x5A5150 Offset: 0x5A3750 VA: 0x1805A5150
	public Entry2D* get_CompoundRoot() { }

	// RVA: 0x16D9840 Offset: 0x16D7E40 VA: 0x1816D9840
	public void set_CompoundRoot(Entry2D* value) { }

	// RVA: 0x2209C30 Offset: 0x2208230 VA: 0x182209C30
	public void Init(Scene2D* scene) { }

	// RVA: 0x22091F0 Offset: 0x22077F0 VA: 0x1822091F0
	public static void GetSupportOffset(Entry2D* entry, FPVector2 worldDir, out FPVector2 supportOffset, Nullable<FP> deltaTime, int dtShift = 0) { }

	// RVA: 0x2208FD0 Offset: 0x22075D0 VA: 0x182208FD0
	private void ComputeLocalDirectionAndCentroidOffset(ref FPVector2 worldDir, ref long sinRaw, ref long cosRaw, out FPVector2 localDir, out FPVector2 centroidOffset, Nullable<FP> deltaTime, int dtShift = 0) { }

	// RVA: 0x2208E40 Offset: 0x2207440 VA: 0x182208E40
	public static void CalculateRotatedCenterOfMass(Entry2D* entry, Nullable<FP> overrideRot) { }

	// RVA: 0x2209C50 Offset: 0x2208250 VA: 0x182209C50
	public void IntegrateVelocity(FP dt, PhysicsSceneSettings* settings, bool applyMinVelThreshold = True, bool integrateAngVel = True) { }

	// RVA: 0x21EA0C0 Offset: 0x21E86C0 VA: 0x1821EA0C0
	private void ApplyMinVelocityIntegration(PhysicsSceneSettings* settings) { }

	// RVA: 0x2205BA0 Offset: 0x22041A0 VA: 0x182205BA0
	private static void ComputeEntryAabb(Shape2D* shape, NarrowData2D* narrow, IntAABB* aabb, bool optimizePolyAabb = False, PolygonCollider polyCollider) { }

	// RVA: 0x22098C0 Offset: 0x2207EC0 VA: 0x1822098C0
	public static void InitNarrowData(FrameThreadSafe f, Map map, Entry2D* entry, FPVector2* pos, FP rot) { }

	// RVA: 0x2209660 Offset: 0x2207C60 VA: 0x182209660
	public static void InitBroadAabb(Entry2D* entry, FPVector2* pos, FP rot, Nullable<FP> deltaTime, bool optimizePolyAabb = False, PolygonCollider polyCollider) { }
}
