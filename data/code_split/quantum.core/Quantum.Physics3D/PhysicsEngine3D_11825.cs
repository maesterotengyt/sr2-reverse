// Namespace: Quantum.Physics3D
public class PhysicsEngine3D // TypeDefIndex: 11825
{
	// Fields
	internal Scene3D* _scene3D; // 0x10
	internal TriangleMesh _sceneMesh; // 0x18
	private FrameContext _context; // 0x20
	internal ICollisionCallbacks3D _callbacks; // 0x28

	// Properties
	public TriangleMesh SceneMesh { get; }

	// Methods

	// RVA: 0x223DCF0 Offset: 0x223C2F0 VA: 0x18223DCF0
	private void SetCallbacks(FrameBase frame, EntityRef entity, CallbackFlags flags) { }

	// RVA: 0x223D680 Offset: 0x223BC80 VA: 0x18223D680
	private void Init(FrameBase frame, AssetRefMap mapRef) { }

	// RVA: 0x223DE70 Offset: 0x223C470 VA: 0x18223DE70
	private TaskHandle Update(FrameBase frame, ICollisionCallbacks3D callbacks, FP dt, TaskHandle taskHandle) { }

	// RVA: 0x223DE10 Offset: 0x223C410 VA: 0x18223DE10
	private bool TryGetQueryHits(int index, out HitCollection3D queryHits) { }

	// RVA: 0x223D690 Offset: 0x223BC90 VA: 0x18223D690
	private HitCollection3D Linecast(FrameThreadSafe frame, FPVector3* start, FPVector3* end, bool firstHitOnly, int layerMask, QueryOptions options) { }

	// RVA: 0x223D7E0 Offset: 0x223BDE0 VA: 0x18223D7E0
	private HitCollection3D OverlapShape(FrameThreadSafe frame, FPVector3* pos, FPQuaternion* rot, Shape3D* shape, int layerMask, QueryOptions options) { }

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public TriangleMesh get_SceneMesh() { }

	// RVA: 0x223DEF0 Offset: 0x223C4F0 VA: 0x18223DEF0
	internal void .ctor(FrameContext context) { }

	// RVA: 0x223D630 Offset: 0x223BC30 VA: 0x18223D630
	internal void Dispose() { }

	// RVA: 0x223D760 Offset: 0x223BD60 VA: 0x18223D760
	internal void OnFrameSimulationBegin(FrameBase f) { }

	// RVA: 0x223D7C0 Offset: 0x223BDC0 VA: 0x18223D7C0
	internal void OnFrameSimulationEnd() { }

	// RVA: 0x223D8B0 Offset: 0x223BEB0 VA: 0x18223D8B0
	public static void RegisterInternalTypes(Action<Type, int> register) { }
}
