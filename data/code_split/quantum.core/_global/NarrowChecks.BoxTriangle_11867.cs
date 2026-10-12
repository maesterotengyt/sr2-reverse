// Namespace: 
public static class NarrowChecks.BoxTriangle // TypeDefIndex: 11867
{
	// Methods

	// RVA: 0x226A570 Offset: 0x2268B70 VA: 0x18226A570
	public static bool Check(CollisionManifoldInfo3D* mInfo, bool detailedManifold) { }

	// RVA: 0x2269F50 Offset: 0x2268550 VA: 0x182269F50
	private static bool AxisTestX01(ref CustomVertexTriangle tri, ref FPVector3 extends, ref FPVector3 edge, FP fa, FP fb, ref long penetrationRaw) { }

	// RVA: 0x226A020 Offset: 0x2268620 VA: 0x18226A020
	private static bool AxisTestX2(ref CustomVertexTriangle tri, ref FPVector3 extends, ref FPVector3 edge, FP fa, FP fb, ref long penetrationRaw) { }

	// RVA: 0x226A0F0 Offset: 0x22686F0 VA: 0x18226A0F0
	private static bool AxisTestY02(ref CustomVertexTriangle tri, ref FPVector3 extends, ref FPVector3 edge, FP fa, FP fb, ref long penetrationRaw) { }

	// RVA: 0x226A1A0 Offset: 0x22687A0 VA: 0x18226A1A0
	private static bool AxisTestY1(ref CustomVertexTriangle tri, ref FPVector3 extends, ref FPVector3 edge, FP fa, FP fb, ref long penetrationRaw) { }

	// RVA: 0x226A310 Offset: 0x2268910 VA: 0x18226A310
	private static bool AxisTestZ12(ref CustomVertexTriangle tri, ref FPVector3 extends, ref FPVector3 edge, FP fa, FP fb, ref long penetrationRaw) { }

	// RVA: 0x226A250 Offset: 0x2268850 VA: 0x18226A250
	private static bool AxisTestZ0(ref CustomVertexTriangle tri, ref FPVector3 extends, ref FPVector3 edge, FP fa, FP fb, ref long penetrationRaw) { }

	// RVA: 0x226ED70 Offset: 0x226D370 VA: 0x18226ED70
	private static bool PlaneBoxOverlaps(ref FPVector3 triInverseNormal, ref CustomVertexTriangle tri, ref FPVector3 extents, bool detailedManifold, out FPVector3 deepestBoxVertex, out FPVector3 deepestBoxVertexProj) { }

	// RVA: 0x226D310 Offset: 0x226B910 VA: 0x18226D310
	private static void ClipTriEdgesOnBoxPlanes(Entry3D* boxEntry, ref CustomVertexTriangle tri, ref FPVector3 boxExtents, CollisionManifold3D* m) { }

	// RVA: 0x226D230 Offset: 0x226B830 VA: 0x18226D230
	private static bool ClipToPlane(ref CustomPlane plane, ref CustomLine line, ref FPVector3 intersection) { }

	// RVA: 0x226EF30 Offset: 0x226D530 VA: 0x18226EF30
	private static bool PointInAabb(ref FPVector3 point, ref FPVector3 extents) { }

	// RVA: 0x226B7B0 Offset: 0x2269DB0 VA: 0x18226B7B0
	private static void ClipBoxEdgesOnTriPlane(Entry3D* boxEntry, ref FPVector3 triNormal, ref CustomVertexTriangle triVertex, CollisionManifold3D* m) { }

	// RVA: 0x226EF80 Offset: 0x226D580 VA: 0x18226EF80
	private static bool PointInTriangle(ref FPVector3 p, ref CustomVertexTriangle tri) { }

	// RVA: 0x226EC40 Offset: 0x226D240 VA: 0x18226EC40
	private static FPVector3 ClosestPointOnTriangle(TriangleCCW* tri, ref FPVector3 pointOnPlane, ref CustomVertexTriangle customTri, ref FPVector3 triInverseNormal, ref Shape3D.BoxShape box, out bool pointIsInsideTri) { }

	// RVA: 0x226A3D0 Offset: 0x22689D0 VA: 0x18226A3D0
	private static bool CheckForEdge(ref FPVector3 pointOnPlane, ref FPVector3 triInverseNormal, ref FPVector3 vertexA, ref FPVector3 vertexB, FP edgeMagnitude, out FPVector3 closestPoint) { }

	// RVA: 0x226F210 Offset: 0x226D810 VA: 0x18226F210
	private static long PointPenetrationRaw(ref FPVector3 point, ref FPVector3 triInvertedNormal, ref FPVector3 boxExtents) { }
}
