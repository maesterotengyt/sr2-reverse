// Namespace: BrainFailProductions.PolyFew.AsImpL.MathUtil
public static class Triangulation // TypeDefIndex: 4129
{
	// Methods

	// RVA: 0x6C4120 Offset: 0x6C2720 VA: 0x1806C4120
	public static List<Triangle> TriangulateConvexPolygon(List<Vertex> vertices, bool preserveOriginalVertices = True) { }

	// RVA: 0x6C3960 Offset: 0x6C1F60 VA: 0x1806C3960
	public static List<Triangle> TriangulateByEarClipping(List<Vertex> origVertices, Vector3 planeNormal, string meshName, bool preserveOriginalVertices = True) { }

	// RVA: 0x6C31E0 Offset: 0x6C17E0 VA: 0x1806C31E0
	public static Triangle ClipTriangle(Vertex vertex, List<Vertex> vertices) { }

	// RVA: 0x6C3090 Offset: 0x6C1690 VA: 0x1806C3090
	private static Triangle ClipEar(Vertex earVertex, List<Vertex> earVertices, List<Vertex> vertices, Vector3 planeNormal) { }

	// RVA: 0x6C3410 Offset: 0x6C1A10 VA: 0x1806C3410
	private static Vertex FindMaxAreaEarVertex(List<Vertex> earVertices) { }

	// RVA: 0x6C3300 Offset: 0x6C1900 VA: 0x1806C3300
	private static List<Vertex> FindEarVertices(List<Vertex> vertices, Vector3 planeNormal) { }

	// RVA: 0x6C3830 Offset: 0x6C1E30 VA: 0x1806C3830
	private static bool IsVertexReflex(Vertex v, Vector3 vNormal) { }

	// RVA: 0x6C35A0 Offset: 0x6C1BA0 VA: 0x1806C35A0
	private static bool IsVertexEar(Vertex v, List<Vertex> vertices, Vector3 planeNormal) { }
}
