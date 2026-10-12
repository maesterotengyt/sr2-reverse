// Namespace: BrainFailProductions.PolyFew.AsImpL
public class LoaderObj : Loader // TypeDefIndex: 4112
{
	// Fields
	private string mtlLib; // 0x90
	private string loadedText; // 0x98

	// Properties
	protected override bool HasMaterialLibrary { get; }

	// Methods

	// RVA: 0x6BD010 Offset: 0x6BB610 VA: 0x1806BD010 Slot: 5
	public override string[] ParseTexturePaths(string absolutePath) { }

	[AsyncStateMachine(typeof(LoaderObj.<LoadModelFile>d__3))]
	// RVA: 0x6BAAF0 Offset: 0x6B90F0 VA: 0x1806BAAF0 Slot: 6
	protected override Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "") { }

	[AsyncStateMachine(typeof(LoaderObj.<LoadModelFileNetworked>d__4))]
	// RVA: 0x6BA9F0 Offset: 0x6B8FF0 VA: 0x1806BA9F0 Slot: 7
	protected override Task LoadModelFileNetworked(string objURL) { }

	[IteratorStateMachine(typeof(LoaderObj.<LoadModelFileNetworkedWebGL>d__5))]
	// RVA: 0x6BA960 Offset: 0x6B8F60 VA: 0x1806BA960 Slot: 8
	protected override IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError) { }

	[AsyncStateMachine(typeof(LoaderObj.<LoadMaterialLibrary>d__6))]
	// RVA: 0x6BA740 Offset: 0x6B8D40 VA: 0x1806BA740 Slot: 9
	protected override Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "") { }

	[AsyncStateMachine(typeof(LoaderObj.<LoadMaterialLibrary>d__7))]
	// RVA: 0x6BA860 Offset: 0x6B8E60 VA: 0x1806BA860 Slot: 10
	protected override Task LoadMaterialLibrary(string materialURL) { }

	[IteratorStateMachine(typeof(LoaderObj.<LoadMaterialLibraryWebGL>d__8))]
	// RVA: 0x6BA6B0 Offset: 0x6B8CB0 VA: 0x1806BA6B0 Slot: 11
	protected override IEnumerator LoadMaterialLibraryWebGL(string materialURL) { }

	// RVA: 0x6BA360 Offset: 0x6B8960 VA: 0x1806BA360
	private void GetFaceIndicesByOneFaceLine(DataSet.FaceIndices[] faces, string[] p, bool isFaceIndexPlus) { }

	// RVA: 0x6BA280 Offset: 0x6B8880 VA: 0x1806BA280
	private Vector3 ConvertVec3(float x, float y, float z) { }

	// RVA: 0x6BB690 Offset: 0x6B9C90 VA: 0x1806BB690
	private float ParseFloat(string floatString) { }

	// RVA: 0x6BB710 Offset: 0x6B9D10 VA: 0x1806BB710
	protected void ParseGeometryData(string objDataText) { }

	// RVA: 0x6BCEF0 Offset: 0x6BB4F0 VA: 0x1806BCEF0
	private string ParseMaterialLibName(string path) { }

	// RVA: 0x6BD4F0 Offset: 0x6BBAF0 VA: 0x1806BD4F0 Slot: 4
	protected override bool get_HasMaterialLibrary() { }

	// RVA: 0x6BCDF0 Offset: 0x6BB3F0 VA: 0x1806BCDF0
	private void ParseMaterialData(string data) { }

	// RVA: 0x6BC090 Offset: 0x6BA690 VA: 0x1806BC090
	private void ParseMaterialData(string[] lines, List<MaterialData> mtlData) { }

	// RVA: 0x6BAC70 Offset: 0x6B9270 VA: 0x1806BAC70
	private void ParseBumpParameters(string[] param, MaterialData mtlData) { }

	// RVA: 0x6BD3F0 Offset: 0x6BB9F0 VA: 0x1806BD3F0
	private Color StringsToColor(string[] p) { }

	[IteratorStateMachine(typeof(LoaderObj.<LoadOrDownloadText>d__20))]
	// RVA: 0x6BABF0 Offset: 0x6B91F0 VA: 0x1806BABF0
	private IEnumerator LoadOrDownloadText(string url, bool notifyErrors = True) { }

	// RVA: 0x6BD4A0 Offset: 0x6BBAA0 VA: 0x1806BD4A0
	public void .ctor() { }
}
