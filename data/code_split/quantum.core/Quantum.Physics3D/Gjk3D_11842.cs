// Namespace: Quantum.Physics3D
internal static class Gjk3D // TypeDefIndex: 11842
{
	// Methods

	// RVA: 0x2235BE0 Offset: 0x22341E0 VA: 0x182235BE0
	public static void ComputeDistance(Gjk3D.SimplexDataPointers3D* ptrs, Entry3D* entryA, Entry3D* entryB, TriangleCCW* tri, out FP distance, out FPVector3 separationAxis, int iterations = 16, Nullable<FP> deltaTime, int dtShift = 0) { }

	// RVA: 0x2236580 Offset: 0x2234B80 VA: 0x182236580
	public static void GetSimplexVertex(Entry3D* entryA, Entry3D* entryB, TriangleCCW* tri, FPVector3 worldDir, Gjk3D.SimplexVertex3D* vertex, int bitShift = 0, Nullable<FP> deltaTime, int dtShift = 0) { }

	// RVA: 0x2236FE0 Offset: 0x22355E0 VA: 0x182236FE0
	public static void GetWitnessPoints(Gjk3D.SimplexDataPointers3D* ptrs, out FPVector3 pointA, out FPVector3 pointB) { }

	// RVA: 0x2236820 Offset: 0x2234E20 VA: 0x182236820
	public static void GetWitnessPointA(Gjk3D.SimplexDataPointers3D* ptrs, out FPVector3 pointA) { }

	// RVA: 0x2236C00 Offset: 0x2235200 VA: 0x182236C00
	public static void GetWitnessPointB(Gjk3D.SimplexDataPointers3D* ptrs, out FPVector3 pointB) { }

	// RVA: 0x2237670 Offset: 0x2235C70 VA: 0x182237670
	public static bool IsAffinelyDependent(Gjk3D.SimplexDataPointers3D* ptrs) { }

	// RVA: 0x22358F0 Offset: 0x2233EF0 VA: 0x1822358F0
	public static void ComputeClosestPoint(Gjk3D.SimplexDataPointers3D* ptrs, int curBitShift, out FPVector3 closestPoint, out bool isDegenerate) { }

	// RVA: 0x2238350 Offset: 0x2236950 VA: 0x182238350
	public static void SolveLine(Gjk3D.SimplexDataPointers3D* ptrs, FP* lambdas, out FPVector3 closestPoint) { }

	// RVA: 0x2238C60 Offset: 0x2237260 VA: 0x182238C60
	public static void SolveTriangle(Gjk3D.SimplexDataPointers3D* ptrs, FP* lambdas, int curBitShift, out FPVector3 closestPoint) { }

	// RVA: 0x2238550 Offset: 0x2236B50 VA: 0x182238550
	private static void SolveTetrahedron(Gjk3D.SimplexDataPointers3D* ptrs, FP* lambdas, int curBitShift, out FPVector3 closestPoint, out bool isDegenerate) { }

	// RVA: 0x22378F0 Offset: 0x2235EF0 VA: 0x1822378F0
	private static bool IsOriginOutsidePlane(ref FPVector3 vA, ref FPVector3 vB, ref FPVector3 vC, ref FPVector3 oppositeV, ref bool isDegenerate, out FP oppositeBarycentricCoord) { }

	// RVA: 0x2236050 Offset: 0x2234650 VA: 0x182236050
	public static Gjk3D.TimeOfImpactResult ComputeTimeOfImpact(Tls* tls, CollisionManifoldInfo3D* mInfo, CCDSettings* settings, bool detailedInfo, FP deltaTime, out FP timeOfImpact) { }

	// RVA: 0x2232100 Offset: 0x2230700 VA: 0x182232100
	private static Gjk3D.TimeOfImpactResult ComputeTimeOfImpactDetailedInfo(Gjk3D.SimplexDataPointers3D* ptrs, CollisionManifold3D* m, Entry3D* entryA, Entry3D* entryB, TriangleCCW* tri, FP distance) { }

	// RVA: 0x2237A20 Offset: 0x2236020 VA: 0x182237A20
	public static bool ShapeCastManifold(Tls* tls, Entry3D* entryA, Entry3D* entryB, TriangleCCW* tri, GJKSettings* settings, FPVector3 castDistance, bool computeDetailedInfo, out Hit3D hit) { }
}
