// Namespace: 
public struct PhysicsEngine2D.Api.ThreadSafeApi // TypeDefIndex: 11918
{
	// Fields
	internal FrameThreadSafe Frame; // 0x0
	internal PhysicsEngine2D Physics2D; // 0x10

	// Methods

	// RVA: 0x227EC70 Offset: 0x227D270 VA: 0x18227EC70
	public Nullable<Hit> Linecast(FPVector2 start, FPVector2 end, int layerMask = -1, QueryOptions options = 15, FP verticalPosition, FP verticalHeight) { }

	// RVA: 0x227EB30 Offset: 0x227D130 VA: 0x18227EB30
	public HitCollection LinecastAll(FPVector2 start, FPVector2 end, int layerMask = -1, QueryOptions options = 15, FP verticalPosition, FP verticalHeight) { }
}
