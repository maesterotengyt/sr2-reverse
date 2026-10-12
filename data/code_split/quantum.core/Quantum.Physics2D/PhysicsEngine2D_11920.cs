// Namespace: Quantum.Physics2D
public class PhysicsEngine2D // TypeDefIndex: 11920
{
	// Fields
	internal Scene2D* _scene; // 0x10
	private FrameContext _context; // 0x18
	internal ICollisionCallbacks2D _callbacks; // 0x20

	// Methods

	// RVA: 0x227DBB0 Offset: 0x227C1B0 VA: 0x18227DBB0
	private void SetCallbacks(FrameBase frame, EntityRef entity, CallbackFlags flags) { }

	// RVA: 0x227D680 Offset: 0x227BC80 VA: 0x18227D680
	private void Init(FrameBase frame, AssetRefMap mapRef) { }

	// RVA: 0x227DCB0 Offset: 0x227C2B0 VA: 0x18227DCB0
	private TaskHandle Update(FrameBase frame, ICollisionCallbacks2D callbacks, FP dt, TaskHandle taskHandle) { }

	// RVA: 0x227D690 Offset: 0x227BC90 VA: 0x18227D690
	private HitCollection Linecast(FrameThreadSafe frame, FPVector2* start, FPVector2* end, bool firstHitOnly, int layerMask, QueryOptions options, FP vPos, FP vHeight) { }

	// RVA: 0x227DD30 Offset: 0x227C330 VA: 0x18227DD30
	internal void .ctor(FrameContext context) { }

	// RVA: 0x227D640 Offset: 0x227BC40 VA: 0x18227D640
	internal void Dispose() { }

	// RVA: 0x227D780 Offset: 0x227BD80 VA: 0x18227D780
	internal void OnFrameSimulationBegin(FrameBase f) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal void OnFrameSimulationEnd() { }

	// RVA: 0x227D790 Offset: 0x227BD90 VA: 0x18227D790
	public static void RegisterInternalTypes(Action<Type, int> register) { }
}
