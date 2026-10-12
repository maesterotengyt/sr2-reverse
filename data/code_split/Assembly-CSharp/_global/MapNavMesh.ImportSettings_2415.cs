// Namespace: 
[Serializable]
public class MapNavMesh.ImportSettings // TypeDefIndex: 2415
{
	// Fields
	[Tooltip("The Unity NavMesh is a collection of non - connected triangles, this option is very important and combines shared vertices.")]
	public bool WeldIdenticalVertices; // 0x10
	[Tooltip("Don't make the epsilon too small, vertices to fuse are missed, also don't make the value too big as it will deform your navmesh.")]
	public float WeldVertexEpsilon; // 0x14
	[Tooltip("Post processes imported Unity navmesh with a Delaunay triangulation to reduce long triangles.")]
	public bool DelaunayTriangulation; // 0x18
	[Tooltip("In 3D the triangulation can deform the navmesh on slopes, check this option to restrict the triangulation to triangles that lie in the same plane.")]
	public bool DelaunayTriangulationRestrictToPlanes; // 0x19
	[Tooltip("Sometimes vertices are lying on other triangle edges, this will lead to unwanted borders being detected, this option splits those vertices.")]
	public bool FixTrianglesOnEdges; // 0x1A
	[Tooltip("Larger scaled navmeshes may require to increase this value (e.g. 0.001) when false-positive borders are detected.")]
	public float FixTrianglesOnEdgesEpsilon; // 0x1C
	[Tooltip("Make the height offset considerably larger than FixTrianglesOnEdgesEpsilon to better detect degenerate triangles. Is the navmesh becomes deformed chose a smaller epsilon. Default is 0.05")]
	public float FixTrianglesOnEdgesHeightEpsilon; // 0x20
	[Tooltip("Automatically correct navmesh link position to the closest triangle (default is off).")]
	public bool LinkErrorCorrection; // 0x24
	[Tooltip("SpiralOut will be considerably faster but fallback triangles can be null.")]
	public MapNavMesh.FindClosestTriangleCalculation ClosestTriangleCalculation; // 0x28
	[Tooltip("Number of cells to search triangles in neighbors.")]
	public int ClosestTriangleCalculationDepth; // 0x2C
	[Tooltip("Activate this and the navmesh baking will flip Y and Z to support navmeshes generated in the XY plane.")]
	public bool EnableQuantum_XY; // 0x30
	[Tooltip("The agent radius that the navmesh is build for. The value is retrieved from Unity settings when baking in Editor.")]
	public FP MinAgentRadius; // 0x38
	[Tooltip("Toggle the Quantum region import.")]
	public bool ImportRegions; // 0x40
	[Tooltip("The artificial margin is necessary because the Unity NavMesh does not fit the source size very well. The value is added to the navmesh area and checked against all Quantum Region scripts to select the correct region id.")]
	public float RegionDetectionMargin; // 0x44
	public List<int> RegionAreaIds; // 0x48

	// Methods

	// RVA: 0x520550 Offset: 0x51EB50 VA: 0x180520550
	public void .ctor() { }
}
