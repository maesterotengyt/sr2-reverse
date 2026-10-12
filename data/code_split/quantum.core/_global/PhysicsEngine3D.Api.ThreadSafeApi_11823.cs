// Namespace: 
public struct PhysicsEngine3D.Api.ThreadSafeApi // TypeDefIndex: 11823
{
	// Fields
	internal FrameThreadSafe Frame; // 0x0
	internal PhysicsEngine3D Physics3D; // 0x10

	// Methods

	// RVA: 0x2240FA0 Offset: 0x223F5A0 VA: 0x182240FA0
	public bool TryGetQueryHits(int index, out HitCollection3D queryHits) { }

	// RVA: 0x2240CB0 Offset: 0x223F2B0 VA: 0x182240CB0
	public Nullable<Hit3D> Raycast(FPVector3 origin, FPVector3 direction, FP distance, int layerMask = -1, QueryOptions options = 15) { }

	// RVA: 0x2240B80 Offset: 0x223F180 VA: 0x182240B80
	public HitCollection3D OverlapShape(FPVector3 position, FPQuaternion rotation, Shape3D shape, int layerMask = -1, QueryOptions options = 15) { }
}
