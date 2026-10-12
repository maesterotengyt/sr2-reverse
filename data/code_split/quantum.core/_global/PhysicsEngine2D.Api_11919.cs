// Namespace: 
public class PhysicsEngine2D.Api // TypeDefIndex: 11919
{
	// Fields
	private PhysicsEngine2D.Api.ThreadSafeApi _mainThread; // 0x10
	internal PhysicsEngine2D.Api.ThreadSafeApi[] ThreadSafe; // 0x28

	// Methods

	// RVA: 0x2278480 Offset: 0x2276A80 VA: 0x182278480
	public void SetCallbacks(EntityRef entity, CallbackFlags flags) { }

	// RVA: 0x2278560 Offset: 0x2276B60 VA: 0x182278560
	public void .ctor(FrameBase frame, int threadCount) { }

	// RVA: 0x22781F0 Offset: 0x22767F0 VA: 0x1822781F0
	public void Init() { }

	// RVA: 0x2278250 Offset: 0x2276850 VA: 0x182278250
	public void Init(AssetRefMap mapRef) { }

	// RVA: 0x22784C0 Offset: 0x2276AC0 VA: 0x1822784C0
	public TaskHandle Update(ICollisionCallbacks2D callbacks, FP dt, TaskHandle taskHandle) { }

	// RVA: 0x22783D0 Offset: 0x22769D0 VA: 0x1822783D0
	public Nullable<Hit> Linecast(FPVector2 start, FPVector2 end, int layerMask = -1, QueryOptions options = 15, FP verticalPosition, FP verticalHeight) { }

	// RVA: 0x2278270 Offset: 0x2276870 VA: 0x182278270
	public HitCollection LinecastAll(FPVector2 start, FPVector2 end, int layerMask = -1, QueryOptions options = 15, FP verticalPosition, FP verticalHeight) { }
}
