// Namespace: BrainFailProductions.PolyFewRuntime
[AddComponentMenu("")]
public class PolyfewRuntime : MonoBehaviour // TypeDefIndex: 4170
{
	// Fields
	private const int MAX_LOD_COUNT = 8;

	// Methods

	// RVA: 0x6DB8B0 Offset: 0x6D9EB0 VA: 0x1806DB8B0
	public static int SimplifyObjectDeep(GameObject toSimplify, PolyfewRuntime.SimplificationOptions simplificationOptions, Action<GameObject, PolyfewRuntime.MeshRendererPair> OnEachMeshSimplified) { }

	// RVA: 0x6DD670 Offset: 0x6DBC70 VA: 0x1806DD670
	public static PolyfewRuntime.ObjectMeshPairs SimplifyObjectDeep(GameObject toSimplify, PolyfewRuntime.SimplificationOptions simplificationOptions) { }

	// RVA: 0x6DF220 Offset: 0x6DD820 VA: 0x1806DF220
	public static int SimplifyObjectDeep(PolyfewRuntime.ObjectMeshPairs objectMeshPairs, PolyfewRuntime.SimplificationOptions simplificationOptions, Action<GameObject, PolyfewRuntime.MeshRendererPair> OnEachMeshSimplified) { }

	// RVA: 0x6DAB50 Offset: 0x6D9150 VA: 0x1806DAB50
	public static List<Mesh> SimplifyMeshes(List<Mesh> meshesToSimplify, PolyfewRuntime.SimplificationOptions simplificationOptions, Action<Mesh> OnEachMeshSimplified) { }

	// RVA: 0x6DA4E0 Offset: 0x6D8AE0 VA: 0x1806DA4E0
	public static PolyfewRuntime.ObjectMeshPairs GetObjectMeshPairs(GameObject forObject, bool includeInactive) { }

	// RVA: 0x6D7450 Offset: 0x6D5A50 VA: 0x1806D7450
	public static void CombineMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError, PolyfewRuntime.MeshCombineTarget combineTarget = 0) { }

	// RVA: 0x6D6C10 Offset: 0x6D5210 VA: 0x1806D6C10
	public static GameObject CombineMeshesFromRenderers(Transform rootTransform, MeshRenderer[] originalMeshRenderers, SkinnedMeshRenderer[] originalSkinnedMeshRenderers, Action<string, string> OnError) { }

	// RVA: 0x6D8E80 Offset: 0x6D7480 VA: 0x1806D8E80
	public static void ConvertSkinnedMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError) { }

	// RVA: 0x6D8830 Offset: 0x6D6E30 VA: 0x1806D8830
	public static Tuple<SkinnedMeshRenderer, MeshRenderer, Mesh>[] ConvertSkinnedMeshesFromRenderers(SkinnedMeshRenderer[] renderersToConvert, Action<string, string> OnError) { }

	[AsyncStateMachine(typeof(PolyfewRuntime.<ImportOBJFromFileSystem>d__20))]
	// RVA: 0x6DA840 Offset: 0x6D8E40 VA: 0x1806DA840
	public static void ImportOBJFromFileSystem(string objAbsolutePath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> OnSuccess, Action<Exception> OnError, PolyfewRuntime.OBJImportOptions importOptions) { }

	[AsyncStateMachine(typeof(PolyfewRuntime.<ImportOBJFromNetwork>d__21))]
	// RVA: 0x6DA950 Offset: 0x6D8F50 VA: 0x1806DA950
	public static void ImportOBJFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, PolyfewRuntime.OBJImportOptions importOptions) { }

	[AsyncStateMachine(typeof(PolyfewRuntime.<ExportGameObjectToOBJ>d__22))]
	// RVA: 0x6D9DD0 Offset: 0x6D83D0 VA: 0x1806D9DD0
	public static void ExportGameObjectToOBJ(GameObject toExport, string exportPath, Action OnSuccess, Action<Exception> OnError, PolyfewRuntime.OBJExportOptions exportOptions) { }

	// RVA: 0x6D96C0 Offset: 0x6D7CC0 VA: 0x1806D96C0
	public static int CountTriangles(bool countDeep, GameObject forObject) { }

	// RVA: 0x6D9C30 Offset: 0x6D8230 VA: 0x1806D9C30
	public static int CountTriangles(List<Mesh> toCount) { }

	// RVA: 0x6D9EF0 Offset: 0x6D84F0 VA: 0x1806D9EF0
	public static List<PolyfewRuntime.MaterialProperties> GetMaterialsProperties(GameObject forObject) { }

	// RVA: 0x6D6B20 Offset: 0x6D5120 VA: 0x1806D6B20
	public static void ChangeMaterialProperties(PolyfewRuntime.MaterialProperties changeTo, GameObject forObject) { }

	// RVA: 0x6DAAD0 Offset: 0x6D90D0 VA: 0x1806DAAD0
	private static void SetParametersForSimplifier(PolyfewRuntime.SimplificationOptions simplificationOptions, MeshSimplifier meshSimplifier) { }

	// RVA: 0x6D66A0 Offset: 0x6D4CA0 VA: 0x1806D66A0
	private static bool AreAnyFeasibleMeshes(PolyfewRuntime.ObjectMeshPairs objectMeshPairs) { }

	// RVA: 0x6D6980 Offset: 0x6D4F80 VA: 0x1806D6980
	private static void AssignReducedMesh(GameObject gameObject, Mesh originalMesh, Mesh reducedMesh, bool attachedToMeshfilter, bool assignBindposes) { }

	// RVA: 0x6D9A40 Offset: 0x6D8040 VA: 0x1806D9A40
	private static int CountTriangles(PolyfewRuntime.ObjectMeshPairs objectMeshPairs) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
