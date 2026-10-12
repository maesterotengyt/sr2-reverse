// Namespace: 
public static class MapNavMesh // TypeDefIndex: 2419
{
	// Fields
	public static float DefaultMinAgentRadius; // 0x0
	private static Dictionary<string, MapNavMesh.GizmoNavmeshData> _navmeshGizmoMap; // 0x8
	private static Lazy<Type> _navMeshSurfaceType; // 0x10
	private static Lazy<Type> _navMeshAssetManagerType; // 0x18

	// Properties
	public static Type NavMeshSurfaceType { get; }
	public static Type NavMeshAssetManagerType { get; }

	// Methods

	// RVA: 0x526770 Offset: 0x524D70 VA: 0x180526770
	public static void InvalidateGizmos() { }

	// RVA: 0x525EF0 Offset: 0x5244F0 VA: 0x180525EF0
	public static void CreateAndDrawGizmoMesh(NavMesh navmesh, NavMeshRegionMask regionMask) { }

	// RVA: 0x525F60 Offset: 0x524560 VA: 0x180525F60
	public static Mesh CreateGizmoMesh(NavMesh navmesh, NavMeshRegionMask regionMask) { }

	// RVA: 0x526510 Offset: 0x524B10 VA: 0x180526510
	public static void DrawGizmoMesh(Mesh mesh) { }

	// RVA: 0x526A40 Offset: 0x525040 VA: 0x180526A40
	public static Type get_NavMeshSurfaceType() { }

	// RVA: 0x5269C0 Offset: 0x524FC0 VA: 0x1805269C0
	public static Type get_NavMeshAssetManagerType() { }

	// RVA: 0x526810 Offset: 0x524E10 VA: 0x180526810
	private static void .cctor() { }
}
