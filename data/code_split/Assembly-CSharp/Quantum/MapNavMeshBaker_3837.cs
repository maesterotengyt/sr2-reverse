// Namespace: Quantum
public static class MapNavMeshBaker // TypeDefIndex: 3837
{
	// Fields
	private static FP TriangleCheckEpsilon; // 0x0
	private static readonly int MaxCandidates; // 0x8
	private static List<MapNavMeshBaker.TriangleCenterGrid.Pair> Candidates; // 0x10

	// Methods

	// RVA: 0x65CB00 Offset: 0x65B100 VA: 0x18065CB00
	public static NavMesh BakeNavMesh(MapData data, MapNavMesh.BakeData navmeshBakeData) { }

	// RVA: 0x65CB80 Offset: 0x65B180 VA: 0x18065CB80
	public static NavMesh BakeNavMesh(Map map, MapNavMesh.BakeData navmeshBakeData) { }

	// RVA: 0x662130 Offset: 0x660730 VA: 0x180662130
	private static NavMeshTriangleNode[] GenerateTriangleGrid(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x660710 Offset: 0x65ED10 VA: 0x180660710
	private static List<NavMeshBorder> GenerateBorders(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x664460 Offset: 0x662A60 VA: 0x180664460
	private static void ProcessBorder(NavMesh navmesh, int t, int v0, int v1, List<NavMeshBorder> borders) { }

	// RVA: 0x6640A0 Offset: 0x6626A0 VA: 0x1806640A0
	private static bool IsBorderEdge(NavMeshTriangle[] triangles, int tri, int v0, int v1, out NavMeshRegionMask otherRegion, NavMeshVertex[] vertices) { }

	// RVA: 0x65F260 Offset: 0x65D860 VA: 0x18065F260
	private static int FindBorderTriangle(NavMeshTriangle[] triangles, int tri, int v0, int v1) { }

	// RVA: 0x664C40 Offset: 0x663240 VA: 0x180664C40
	private static bool TriangleContains(NavMeshTriangle[] ts, NavMeshVertex[] vs, FPVector3 point, NavMeshRegionMask regions) { }

	// RVA: 0x65FC10 Offset: 0x65E210 VA: 0x18065FC10
	private static NavMeshBorderNode[] GenerateBorderGrid(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x65EDB0 Offset: 0x65D3B0 VA: 0x18065EDB0
	private static FP CalculateCellTriangleHeuristic(FPVector3 cellCenter, FP cellSize, NavMesh navmesh, int triangle) { }

	// RVA: 0x65E990 Offset: 0x65CF90 VA: 0x18065E990
	private static void CalculateCellTriangleHeuristic(NavMesh navmesh, int triangleIndex, FPVector3 cellCenter, int regionIndex) { }

	// RVA: 0x65F310 Offset: 0x65D910 VA: 0x18065F310
	private static bool FindClosestTriangle(NavMesh navmesh, int cellIndex, FPVector3 cellCenter, int regionIndex, MapNavMesh.FindClosestTriangleCalculation triangleCalc, int triangleCalcDepth, ref MapNavMeshBaker.TriangleCenterGrid.Pair heuristic) { }

	// RVA: 0x661860 Offset: 0x65FE60 VA: 0x180661860
	private static NavMeshTriangleCenterGridNode[] GenerateTriangleCenterGrid(NavMesh navmesh, MapNavMesh.FindClosestTriangleCalculation triangleCalc, int triangleCalcDepth, List<string> regionsList, Action<float> reporter) { }

	// RVA: 0x663600 Offset: 0x661C00 VA: 0x180663600
	private static void GenerateTriangleNeighbors(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x664230 Offset: 0x662830 VA: 0x180664230
	public static bool LocateGridCells(ref int xMin, ref int xMax, ref int yMin, ref int yMax, FPVector2 worldOffset, int gridNodeSize, int gridSizeX, int gridSizeY, FPVector2[] positions) { }

	// RVA: 0x6608F0 Offset: 0x65EEF0 VA: 0x1806608F0
	private static void GenerateNavMeshLinks(NavMesh navmesh, MapNavMeshLink[] links, string[] regions, bool errorCorrection, bool enableQuantumXY, Action<float> reporter) { }

	// RVA: 0x664EF0 Offset: 0x6634F0 VA: 0x180664EF0
	private static void .cctor() { }
}
