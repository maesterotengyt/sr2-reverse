// Namespace: BrainFailProductions.PolyFewRuntime
public static class MeshCombiner // TypeDefIndex: 4144
{
	// Fields
	private static MeshRenderer[] unityCombinedMeshRenderers; // 0x0
	private static Material[] unityCombinedMeshesMats; // 0x8
	private static bool didUseUnityCombine; // 0x10
	public static bool generateUV2; // 0x11

	// Methods

	// RVA: 0x6D4440 Offset: 0x6D2A40 VA: 0x1806D4440
	public static MeshCombiner.StaticRenderer[] GetStaticRenderers(MeshRenderer[] renderers) { }

	// RVA: 0x6D41A0 Offset: 0x6D27A0 VA: 0x1806D41A0
	public static MeshCombiner.SkinnedRenderer[] GetSkinnedRenderers(SkinnedMeshRenderer[] renderers) { }

	// RVA: 0x6D35D0 Offset: 0x6D1BD0 VA: 0x1806D35D0
	public static MeshCombiner.StaticRenderer[] CombineStaticMeshes(Transform transform, int levelIndex, MeshRenderer[] renderers, bool autoName = True, string combinedBaseName = "") { }

	// RVA: 0x6D2E70 Offset: 0x6D1470 VA: 0x1806D2E70
	public static MeshCombiner.SkinnedRenderer[] CombineSkinnedMeshes(Transform transform, int levelIndex, SkinnedMeshRenderer[] renderers, ref SkinnedMeshRenderer[] renderersActuallyCombined, bool autoName = True, string combinedBaseName = "") { }

	// RVA: 0x6D2300 Offset: 0x6D0900 VA: 0x1806D2300
	public static Mesh CombineMeshes(Transform rootTransform, MeshRenderer[] renderers, out Material[] resultMaterials, Dictionary<Transform, Transform> topLevelParents, Dictionary<string, MeshCombiner.BlendShapeFrame> blendShapes) { }

	// RVA: 0x6CFA40 Offset: 0x6CE040 VA: 0x1806CFA40
	public static Mesh CombineMeshes(Transform rootTransform, SkinnedMeshRenderer[] renderers, out Material[] resultMaterials, out Transform[] resultBones) { }

	// RVA: 0x6D2D40 Offset: 0x6D1340 VA: 0x1806D2D40
	public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, out Material[] resultMaterials, Dictionary<string, MeshCombiner.BlendShapeFrame> blendShapes) { }

	// RVA: 0x6D08F0 Offset: 0x6CEEF0 VA: 0x1806D08F0
	public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, Transform[][] bones, out Material[] resultMaterials, out Transform[] resultBones, Dictionary<string, MeshCombiner.BlendShapeFrame> blendShapes) { }

	// RVA: 0x6D48C0 Offset: 0x6D2EC0 VA: 0x1806D48C0
	private static void ParentAndResetTransform(Transform transform, Transform parentTransform) { }

	// RVA: 0x6D47E0 Offset: 0x6D2DE0 VA: 0x1806D47E0
	private static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform) { }

	// RVA: 0x6D3D10 Offset: 0x6D2310 VA: 0x1806D3D10
	private static Transform FindBestRootBone(Transform transform, SkinnedMeshRenderer[] skinnedMeshRenderers) { }

	// RVA: 0x6D3F30 Offset: 0x6D2530 VA: 0x1806D3F30
	private static Transform FindBestRootBone(Dictionary<Transform, Transform> topLevelParents, SkinnedMeshRenderer[] skinnedMeshRenderers) { }

	// RVA: 0x6D4740 Offset: 0x6D2D40 VA: 0x1806D4740
	private static Transform GetTopLevelParent(Transform forObject) { }

	// RVA: 0x6D3C00 Offset: 0x6D2200 VA: 0x1806D3C00
	private static void CopyVertexPositions(List<Vector3> list, Vector3[] arr) { }

	// RVA: -1 Offset: -1
	private static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAA280 Offset: 0xBA8880 VA: 0x180BAA280
	|-MeshCombiner.CopyVertexAttributes<BoneWeight>
	|
	|-RVA: 0xBAA4C0 Offset: 0xBA8AC0 VA: 0x180BAA4C0
	|-MeshCombiner.CopyVertexAttributes<Color>
	|
	|-RVA: 0xBAA910 Offset: 0xBA8F10 VA: 0x180BAA910
	|-MeshCombiner.CopyVertexAttributes<Vector3>
	|
	|-RVA: 0xBAAB40 Offset: 0xBA9140 VA: 0x180BAAB40
	|-MeshCombiner.CopyVertexAttributes<Vector4>
	|
	|-RVA: 0xBAA6D0 Offset: 0xBA8CD0 VA: 0x180BAA6D0
	|-MeshCombiner.CopyVertexAttributes<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static T[] MergeArrays<T>(T[] arr1, T[] arr2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBAAD50 Offset: 0xBA9350 VA: 0x180BAAD50
	|-MeshCombiner.MergeArrays<int>
	|-MeshCombiner.MergeArrays<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6D50A0 Offset: 0x6D36A0 VA: 0x1806D50A0
	private static void TransformVertices(Vector3[] vertices, ref Matrix4x4 transform) { }

	// RVA: 0x6D4CD0 Offset: 0x6D32D0 VA: 0x1806D4CD0
	private static void TransformNormals(Vector3[] normals, ref Tuple<Matrix4x4, bool> transform) { }

	// RVA: 0x6D4F40 Offset: 0x6D3540 VA: 0x1806D4F40
	private static void TransformTangents(Vector4[] tangents, ref Tuple<Matrix4x4, bool> transform) { }

	// RVA: 0x6D49C0 Offset: 0x6D2FC0 VA: 0x1806D49C0
	private static void RemapBones(BoneWeight[] boneWeights, int[] boneIndices) { }

	// RVA: 0x6D4C00 Offset: 0x6D3200 VA: 0x1806D4C00
	private static Matrix4x4 ScaleMatrix(ref Matrix4x4 matrix, float scale) { }

	// RVA: 0x6CEC50 Offset: 0x6CD250 VA: 0x1806CEC50
	private static void CombineMeshesUnity(Transform parentTransform, MeshFilter[] meshFilters) { }
}
