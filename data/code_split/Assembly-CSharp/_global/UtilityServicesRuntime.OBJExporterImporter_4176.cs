// Namespace: 
public class UtilityServicesRuntime.OBJExporterImporter // TypeDefIndex: 4176
{
	// Fields
	private bool applyPosition; // 0x10
	private bool applyRotation; // 0x11
	private bool applyScale; // 0x12
	private bool generateMaterials; // 0x13
	private bool exportTextures; // 0x14
	private string exportPath; // 0x18
	private MeshFilter meshFilter; // 0x20
	private Mesh meshToExport; // 0x28
	private MeshRenderer meshRenderer; // 0x30

	// Methods

	// RVA: 0x6E8730 Offset: 0x6E6D30 VA: 0x1806E8730
	public void .ctor() { }

	// RVA: 0x6E7880 Offset: 0x6E5E80 VA: 0x1806E7880
	private void InitializeExporter(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions) { }

	// RVA: 0x6E7CF0 Offset: 0x6E62F0 VA: 0x1806E7CF0
	private void InitializeExporter(Mesh toExport, string exportPath) { }

	// RVA: 0x6E8590 Offset: 0x6E6B90 VA: 0x1806E8590
	private Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle) { }

	// RVA: 0x6E8550 Offset: 0x6E6B50 VA: 0x1806E8550
	private Vector3 MultiplyVec3s(Vector3 v1, Vector3 v2) { }

	// RVA: 0x6E6050 Offset: 0x6E4650 VA: 0x1806E6050
	public void ExportGameObjectToOBJ(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions, Action OnSuccess) { }

	[AsyncStateMachine(typeof(UtilityServicesRuntime.OBJExporterImporter.<ExportMeshToOBJ>d__15))]
	// RVA: 0x6E70E0 Offset: 0x6E56E0 VA: 0x1806E70E0
	public Task ExportMeshToOBJ(Mesh mesh, string exportPath) { }

	// RVA: 0x6E8640 Offset: 0x6E6C40 VA: 0x1806E8640
	private string TryExportTexture(string propertyName, Material m, string exportPath) { }

	// RVA: 0x6E7220 Offset: 0x6E5820 VA: 0x1806E7220
	private string ExportTexture(Texture2D t, string exportPath) { }

	// RVA: 0x6E5F50 Offset: 0x6E4550 VA: 0x1806E5F50
	private string ConstructOBJString(int index) { }

	// RVA: 0x6E7F40 Offset: 0x6E6540 VA: 0x1806E7F40
	private string MaterialToString(Material m) { }

	[AsyncStateMachine(typeof(UtilityServicesRuntime.OBJExporterImporter.<ImportFromLocalFileSystem>d__20))]
	// RVA: 0x6E7470 Offset: 0x6E5A70 VA: 0x1806E7470
	public Task ImportFromLocalFileSystem(string objPath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> Callback, PolyfewRuntime.OBJImportOptions importOptions) { }

	[AsyncStateMachine(typeof(UtilityServicesRuntime.OBJExporterImporter.<ImportFromNetwork>d__21))]
	// RVA: 0x6E7700 Offset: 0x6E5D00 VA: 0x1806E7700
	public void ImportFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, PolyfewRuntime.OBJImportOptions importOptions) { }

	[AsyncStateMachine(typeof(UtilityServicesRuntime.OBJExporterImporter.<ImportFromNetworkWebGL>d__22))]
	// RVA: 0x6E7590 Offset: 0x6E5B90 VA: 0x1806E7590
	public void ImportFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, PolyfewRuntime.OBJImportOptions importOptions) { }
}
