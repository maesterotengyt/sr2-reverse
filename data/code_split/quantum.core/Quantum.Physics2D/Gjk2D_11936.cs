// Namespace: Quantum.Physics2D
internal static class Gjk2D // TypeDefIndex: 11936
{
	// Methods

	// RVA: 0x2279170 Offset: 0x2277770 VA: 0x182279170
	public static void ComputeDistance(Gjk2D.SimplexDataPointers2D* ptrs, Entry2D* entryA, Entry2D* entryB, out FP distance, out FPVector2 separationAxis, int iterations = 16, Nullable<FP> deltaTime, int dtShift = 0) { }

	// RVA: 0x227A3E0 Offset: 0x22789E0 VA: 0x18227A3E0
	public static bool ShapeCastManifold(Tls* tls, Entry2D* entryA, Entry2D* entryB, GJKSettings* settings, FPVector2 castDistance, bool computeDetailedInfo, out Hit hit) { }

	// RVA: 0x2279DB0 Offset: 0x22783B0 VA: 0x182279DB0
	public static void GetSimplexVertex(Entry2D* entryA, Entry2D* entryB, FPVector2 worldDir, Gjk2D.SimplexVertex2D* vertex, int bitShift = 0, Nullable<FP> deltaTime, int dtShift = 0) { }

	// RVA: 0x227A080 Offset: 0x2278680 VA: 0x18227A080
	public static void GetWitnessPoints(Gjk2D.SimplexDataPointers2D* ptrs, out FPVector2 pointA, out FPVector2 pointB) { }

	// RVA: 0x2279F10 Offset: 0x2278510 VA: 0x182279F10
	public static void GetWitnessPointA(Gjk2D.SimplexDataPointers2D* ptrs, out FPVector2 pointA) { }

	// RVA: 0x2276E20 Offset: 0x2275420 VA: 0x182276E20
	public static void GetWitnessPointB(Gjk2D.SimplexDataPointers2D* ptrs, out FPVector2 pointB) { }

	// RVA: 0x227A2E0 Offset: 0x22788E0 VA: 0x18227A2E0
	public static bool IsAffinelyDependent(Gjk2D.SimplexDataPointers2D* ptrs) { }

	// RVA: 0x2278FC0 Offset: 0x22775C0 VA: 0x182278FC0
	public static void ComputeClosestPoint(Gjk2D.SimplexDataPointers2D* ptrs, out FPVector2 closestPoint) { }

	// RVA: 0x227ACE0 Offset: 0x22792E0 VA: 0x18227ACE0
	public static void SolveLine(Gjk2D.SimplexDataPointers2D* ptrs, FP* lambdas, out FPVector2 closestPoint) { }

	// RVA: 0x227AE60 Offset: 0x2279460 VA: 0x18227AE60
	public static void SolveTriangle(Gjk2D.SimplexDataPointers2D* ptrs, FP* lambdas, out FPVector2 closestPoint) { }

	// RVA: 0x2279640 Offset: 0x2277C40 VA: 0x182279640
	public static Gjk2D.TimeOfImpactResult ComputeTimeOfImpact(Tls* tls, CollisionManifoldInfo2D* mInfo, CCDSettings* settings, bool detailedInfo, FP deltaTime, out FP timeOfImpact) { }

	// RVA: 0x2276CC0 Offset: 0x22752C0 VA: 0x182276CC0
	private static Gjk2D.TimeOfImpactResult ComputeTimeOfImpactDetailedInfo(Gjk2D.SimplexDataPointers2D* ptrs, CollisionManifold2D* m, Entry2D* entryA, Entry2D* entryB, FP distance) { }
}
