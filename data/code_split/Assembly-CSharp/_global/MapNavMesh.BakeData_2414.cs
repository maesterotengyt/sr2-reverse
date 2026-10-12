// Namespace: 
[Serializable]
public class MapNavMesh.BakeData // TypeDefIndex: 2414
{
	// Fields
	public string Name; // 0x10
	public Vector3 Position; // 0x18
	public FP AgentRadius; // 0x28
	public List<string> Regions; // 0x30
	public MapNavMeshVertex[] Vertices; // 0x38
	public MapNavMeshTriangle[] Triangles; // 0x40
	public MapNavMeshLink[] Links; // 0x48
	public MapNavMesh.FindClosestTriangleCalculation ClosestTriangleCalculation; // 0x50
	public int ClosestTriangleCalculationDepth; // 0x54
	public bool EnableQuantum_XY; // 0x58
	public bool LinkErrorCorrection; // 0x59

	// Methods

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
