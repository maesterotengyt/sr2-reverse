// Namespace: 
public static class NarrowChecks.BoxBox // TypeDefIndex: 11866
{
	// Properties
	private static FP allowedDotDiff { get; }
	private static FP extentsExpansionMultiplier { get; }

	// Methods

	// RVA: 0x2263D70 Offset: 0x2262370 VA: 0x182263D70
	private static FP get_allowedDotDiff() { }

	// RVA: 0x2263D80 Offset: 0x2262380 VA: 0x182263D80
	private static FP get_extentsExpansionMultiplier() { }

	// RVA: 0x225CF00 Offset: 0x225B500 VA: 0x18225CF00
	public static bool Check(CollisionManifoldInfo3D* mInfo, bool detailedManifold) { }

	// RVA: 0x2263550 Offset: 0x2261B50 VA: 0x182263550
	private static CustomEdgesBox GetEdgesBox(CustomEdgesBox edges, ref FPVector3 translation) { }

	// RVA: 0x2263A20 Offset: 0x2262020 VA: 0x182263A20
	private static CustomPlanesBox GetPlanesBox(CustomPlanesBox planes, ref FPVector3 translation) { }

	// RVA: 0x2263370 Offset: 0x2261970 VA: 0x182263370
	private static void GetContactPoints(ref CustomPlanesBox planesA, ref CustomPlanesBox planesB, ref CustomEdgesBox edgesA, ref CustomEdgesBox edgesB, Entry3D* boxEntryA, Entry3D* boxEntryB, ref FPVector3 boxAToBoxBOffset, CollisionManifold3D* manifold, bool detailedManifold) { }

	// RVA: 0x225EDF0 Offset: 0x225D3F0 VA: 0x18225EDF0
	private static void GetContactPointPlaneEdge(ref CustomPlanesBox planes, ref CustomEdgesBox edges, Entry3D* boxEntry, ref FPVector3 offset, ref FPVector3 boxAPosition, CollisionManifold3D* manifold, bool detailedManifold) { }

	// RVA: 0x225EC70 Offset: 0x225D270 VA: 0x18225EC70
	private static bool ClipToPlane(ref CustomPlane plane, ref CustomLine line, ref FPVector3 intersection) { }

	// RVA: 0x225CCE0 Offset: 0x225B2E0 VA: 0x18225CCE0
	private static bool BoxInAABB(ref CustomEdgesBox edges, Entry3D* boxEntry, ref FPVector3 offset) { }

	// RVA: 0x2263BE0 Offset: 0x22621E0 VA: 0x182263BE0
	private static bool PointInAABB(FPVector3 point, Entry3D* boxEntry, ref FPVector3 extentsExpanded, ref FPVector3 offset) { }
}
