// Namespace: BrainFailProductions.PolyFew.AsImpL
public class DataSet // TypeDefIndex: 4073
{
	// Fields
	public List<DataSet.ObjectData> objectList; // 0x10
	public List<Vector3> vertList; // 0x18
	public List<Vector2> uvList; // 0x20
	public List<Vector3> normalList; // 0x28
	public List<Color> colorList; // 0x30
	private int unnamedGroupIndex; // 0x38
	private DataSet.ObjectData currObjData; // 0x40
	private DataSet.FaceGroupData currGroup; // 0x48
	private bool noFaceDefined; // 0x50

	// Properties
	public string CurrGroupName { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x6A80C0 Offset: 0x6A66C0 VA: 0x1806A80C0
	public string get_CurrGroupName() { }

	// RVA: 0x6A8110 Offset: 0x6A6710 VA: 0x1806A8110
	public bool get_IsEmpty() { }

	// RVA: 0x6A7500 Offset: 0x6A5B00 VA: 0x1806A7500
	public static string GetFaceIndicesKey(DataSet.FaceIndices fi) { }

	// RVA: 0x6A7400 Offset: 0x6A5A00 VA: 0x1806A7400
	public static string FixMaterialName(string mtlName) { }

	// RVA: 0x6A7D80 Offset: 0x6A6380 VA: 0x1806A7D80
	public void .ctor() { }

	// RVA: 0x6A7000 Offset: 0x6A5600 VA: 0x1806A7000
	public void AddObject(string objectName) { }

	// RVA: 0x6A6C40 Offset: 0x6A5240 VA: 0x1806A6C40
	public void AddGroup(string groupName) { }

	// RVA: 0x6A6E60 Offset: 0x6A5460 VA: 0x1806A6E60
	public void AddMaterialName(string matName) { }

	// RVA: 0x6A7340 Offset: 0x6A5940 VA: 0x1806A7340
	public void AddVertex(Vector3 vertex) { }

	// RVA: 0x6A7280 Offset: 0x6A5880 VA: 0x1806A7280
	public void AddUV(Vector2 uv) { }

	// RVA: 0x6A6F40 Offset: 0x6A5540 VA: 0x1806A6F40
	public void AddNormal(Vector3 normal) { }

	// RVA: 0x6A6A10 Offset: 0x6A5010 VA: 0x1806A6A10
	public void AddColor(Color color) { }

	// RVA: 0x6A6AD0 Offset: 0x6A50D0 VA: 0x1806A6AD0
	public void AddFaceIndices(DataSet.FaceIndices faceIdx) { }

	// RVA: 0x6A7620 Offset: 0x6A5C20 VA: 0x1806A7620
	public void PrintSummary() { }
}
