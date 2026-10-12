// Namespace: 
public static class MeshCombiner.MeshUtils // TypeDefIndex: 4142
{
	// Fields
	public const int UVChannelCount = 8;

	// Methods

	// RVA: 0x6D5600 Offset: 0x6D3C00 VA: 0x1806D5600
	public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, MeshCombiner.BlendShape[] blendShapes) { }

	// RVA: 0x6D55A0 Offset: 0x6D3BA0 VA: 0x1806D55A0
	public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, MeshCombiner.BlendShape[] blendShapes) { }

	// RVA: 0x6D5660 Offset: 0x6D3C60 VA: 0x1806D5660
	public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, MeshCombiner.BlendShape[] blendShapes) { }

	// RVA: 0x6D5B20 Offset: 0x6D4120 VA: 0x1806D5B20
	public static MeshCombiner.BlendShape[] GetMeshBlendShapes(Mesh mesh) { }

	// RVA: 0x6D5220 Offset: 0x6D3820 VA: 0x1806D5220
	public static void ApplyMeshBlendShapes(Mesh mesh, MeshCombiner.BlendShape[] blendShapes) { }

	// RVA: 0x6D5EE0 Offset: 0x6D44E0 VA: 0x1806D5EE0
	public static List<Vector4>[] GetMeshUVs(Mesh mesh) { }

	// RVA: 0x6D6130 Offset: 0x6D4730 VA: 0x1806D6130
	public static List<Vector4> GetMeshUVs(Mesh mesh, int channel) { }

	// RVA: 0x6D6430 Offset: 0x6D4A30 VA: 0x1806D6430
	public static int GetUsedUVComponents(List<Vector4> uvs) { }

	// RVA: 0x6D53E0 Offset: 0x6D39E0 VA: 0x1806D53E0
	public static Vector2[] ConvertUVsTo2D(List<Vector4> uvs) { }

	// RVA: 0x6D54B0 Offset: 0x6D3AB0 VA: 0x1806D54B0
	public static Vector3[] ConvertUVsTo3D(List<Vector4> uvs) { }

	// RVA: 0x6D62B0 Offset: 0x6D48B0 VA: 0x1806D62B0
	public static Vector2Int[] GetSubMeshIndexMinMax(int[][] indices, out IndexFormat indexFormat) { }

	// RVA: 0x6D5AA0 Offset: 0x6D40A0 VA: 0x1806D5AA0
	private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex) { }
}
