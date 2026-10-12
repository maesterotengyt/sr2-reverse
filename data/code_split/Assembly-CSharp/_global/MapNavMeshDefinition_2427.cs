// Namespace: 
public class MapNavMeshDefinition : MonoBehaviour // TypeDefIndex: 2427
{
	// Fields
	public GameObject[] NavMeshSurfaces; // 0x20
	public FP AgentRadius; // 0x28
	public bool WeldIdenticalVertices; // 0x30
	public float WeldVertexEpsilon; // 0x34
	public bool DelaunayTriangulation; // 0x38
	public bool DelaunayTriangulationRestrictToPlanes; // 0x39
	public bool FixTrianglesOnEdges; // 0x3A
	public float FixTrianglesOnEdgesEpsilon; // 0x3C
	public bool ImportRegions; // 0x40
	public float RegionDetectionMargin; // 0x44
	public List<int> RegionAreaIds; // 0x48
	public MapNavMesh.FindClosestTriangleCalculation ClosestTriangleCalculation; // 0x50
	public int ClosestTriangleCalculationDepth; // 0x54
	public bool LinkErrorCorrection; // 0x58
	public bool EnableQuantum_XY; // 0x59
	[QuantumInspector]
	[ReadOnly]
	public MapNavMeshVertex[] Vertices; // 0x60
	[QuantumInspector]
	[ReadOnly]
	public MapNavMeshTriangle[] Triangles; // 0x68
	[QuantumInspector]
	[ReadOnly]
	public List<string> Regions; // 0x70
	[QuantumInspector]
	[ReadOnly]
	public MapNavMeshLink[] Links; // 0x78

	// Methods

	// RVA: 0x525CF0 Offset: 0x5242F0 VA: 0x180525CF0
	public MapNavMeshVertex GetVertex(string id) { }

	// RVA: 0x525C10 Offset: 0x524210 VA: 0x180525C10
	public int GetVertexIndex(string id) { }

	// RVA: 0x525810 Offset: 0x523E10 VA: 0x180525810
	public bool Contains(FPVector2 point) { }

	// RVA: 0x525860 Offset: 0x523E60 VA: 0x180525860
	public bool Contains(Vector3 point) { }

	// RVA: 0x525EB0 Offset: 0x5244B0 VA: 0x180525EB0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x525DC0 Offset: 0x5243C0 VA: 0x180525DC0
	private Vector3 <Contains>b__23_0(string x) { }
}
