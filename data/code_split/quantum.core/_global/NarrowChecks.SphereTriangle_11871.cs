// Namespace: 
public static class NarrowChecks.SphereTriangle // TypeDefIndex: 11871
{
	// Methods

	// RVA: 0x2276670 Offset: 0x2274C70 VA: 0x182276670
	public static bool Check(CollisionManifoldInfo3D* mInfo, bool detailedManifold, bool smoothSphereMeshCollision = False) { }

	// RVA: 0x2276810 Offset: 0x2274E10 VA: 0x182276810
	private static bool GetNearestPoint(TriangleCCW* tri, ref FPVector3 center, long radiusRaw, out FPVector3 nearestPoint, out FPVector3 pointOnPlane) { }

	// RVA: 0x2276470 Offset: 0x2274A70 VA: 0x182276470
	private static Nullable<bool> CheckForVertex(TriangleCCW* tri, ref FPVector3 projected, ref FPVector3 a, ref FPVector3 b, ref FPVector3 direction, FP length, ref FPVector3 p, long radiusSqr, out FPVector3 nearestPoint) { }
}
