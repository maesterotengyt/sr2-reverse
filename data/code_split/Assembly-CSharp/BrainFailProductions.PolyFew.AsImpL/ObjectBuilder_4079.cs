// Namespace: BrainFailProductions.PolyFew.AsImpL
public class ObjectBuilder // TypeDefIndex: 4079
{
	// Fields
	public ImportOptions buildOptions; // 0x10
	private ObjectBuilder.BuildStatus buildStatus; // 0x18
	private DataSet currDataSet; // 0x20
	private GameObject currParentObj; // 0x28
	private Dictionary<string, Material> currMaterials; // 0x30
	private List<MaterialData> materialData; // 0x38
	private static int MAX_VERTICES_LIMIT_FOR_A_MESH; // 0x0
	private static int MAX_INDICES_LIMIT_FOR_A_MESH; // 0x4
	private static int MAX_VERT_COUNT; // 0x8

	// Properties
	public Dictionary<string, Material> ImportedMaterials { get; }
	public int NumImportedMaterials { get; }

	// Methods

	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public Dictionary<string, Material> get_ImportedMaterials() { }

	// RVA: 0x6AFF90 Offset: 0x6AE590 VA: 0x1806AFF90
	public int get_NumImportedMaterials() { }

	// RVA: 0x6AF200 Offset: 0x6AD800 VA: 0x1806AF200
	public void InitBuildMaterials(List<MaterialData> materialData, bool hasColors) { }

	// RVA: 0x6ACF00 Offset: 0x6AB500 VA: 0x1806ACF00
	public bool BuildMaterials(ObjectBuilder.ProgressInfo info) { }

	// RVA: 0x6AFE20 Offset: 0x6AE420 VA: 0x1806AFE20
	public void StartBuildObjectAsync(DataSet dataSet, GameObject parentObj, Dictionary<string, Material> materials) { }

	// RVA: 0x6ADFF0 Offset: 0x6AC5F0 VA: 0x1806ADFF0
	public bool BuildObjectAsync(ref ObjectBuilder.ProgressInfo info) { }

	// RVA: 0x6AF400 Offset: 0x6ADA00 VA: 0x1806AF400
	public static void Solve(Mesh origMesh) { }

	// RVA: 0x6AD0D0 Offset: 0x6AB6D0 VA: 0x1806AD0D0
	public static void BuildMeshCollider(GameObject targetObject, bool convex = False, bool isTrigger = False, bool inflateMesh = False, float skinWidth = 0.01) { }

	// RVA: 0x6AD220 Offset: 0x6AB820 VA: 0x1806AD220
	protected bool BuildNextObject(GameObject parentObj, Dictionary<string, Material> mats) { }

	// RVA: 0x6AE070 Offset: 0x6AC670 VA: 0x1806AE070
	private GameObject ImportSubObject(GameObject parentObj, DataSet.ObjectData objData, Dictionary<string, Material> mats) { }

	// RVA: 0x6AC210 Offset: 0x6AA810 VA: 0x1806AC210
	private Material BuildMaterial(MaterialData md) { }

	// RVA: 0x6AFE80 Offset: 0x6AE480 VA: 0x1806AFE80
	private bool Using32bitIndices() { }

	// RVA: 0x6AFF20 Offset: 0x6AE520 VA: 0x1806AFF20
	public void .ctor() { }

	// RVA: 0x6AFEA0 Offset: 0x6AE4A0 VA: 0x1806AFEA0
	private static void .cctor() { }
}
