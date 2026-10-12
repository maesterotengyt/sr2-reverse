// Namespace: BrainFailProductions.PolyFew.AsImpL
public abstract class Loader : MonoBehaviour // TypeDefIndex: 4099
{
	// Fields
	public static LoadingProgress totalProgress; // 0x0
	public ImportOptions buildOptions; // 0x20
	public PolyfewRuntime.ReferencedNumeric<float> individualProgress; // 0x28
	protected static float LOAD_PHASE_PERC; // 0x8
	protected static float TEXTURE_PHASE_PERC; // 0xC
	protected static float MATERIAL_PHASE_PERC; // 0x10
	protected static float BUILD_PHASE_PERC; // 0x14
	protected static Dictionary<string, GameObject> loadedModels; // 0x18
	protected static Dictionary<string, int> instanceCount; // 0x20
	protected DataSet dataSet; // 0x30
	protected ObjectBuilder objectBuilder; // 0x38
	protected List<MaterialData> materialData; // 0x40
	protected SingleLoadingProgress objLoadingProgress; // 0x48
	protected Loader.Stats loadStats; // 0x50
	private Texture2D loadedTexture; // 0x70
	[CompilerGenerated]
	private Action<GameObject, string> ModelCreated; // 0x78
	[CompilerGenerated]
	private Action<GameObject, string> ModelLoaded; // 0x80
	[CompilerGenerated]
	private Action<string> ModelError; // 0x88

	// Properties
	public bool ConvertVertAxis { get; set; }
	public float Scaling { get; set; }
	protected abstract bool HasMaterialLibrary { get; }

	// Methods

	// RVA: 0x6AA030 Offset: 0x6A8630 VA: 0x1806AA030
	public bool get_ConvertVertAxis() { }

	// RVA: 0x6AA280 Offset: 0x6A8880 VA: 0x1806AA280
	public void set_ConvertVertAxis(bool value) { }

	// RVA: 0x6AA050 Offset: 0x6A8650 VA: 0x1806AA050
	public float get_Scaling() { }

	// RVA: 0x6AA310 Offset: 0x6A8910 VA: 0x1806AA310
	public void set_Scaling(float value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool get_HasMaterialLibrary();

	[CompilerGenerated]
	// RVA: 0x6A9E20 Offset: 0x6A8420 VA: 0x1806A9E20
	public void add_ModelCreated(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6AA070 Offset: 0x6A8670 VA: 0x1806AA070
	public void remove_ModelCreated(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A9F80 Offset: 0x6A8580 VA: 0x1806A9F80
	public void add_ModelLoaded(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6AA1D0 Offset: 0x6A87D0 VA: 0x1806AA1D0
	public void remove_ModelLoaded(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A9ED0 Offset: 0x6A84D0 VA: 0x1806A9ED0
	public void add_ModelError(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6AA120 Offset: 0x6A8720 VA: 0x1806AA120
	public void remove_ModelError(Action<string> value) { }

	// RVA: 0x6A8860 Offset: 0x6A6E60 VA: 0x1806A8860
	public static GameObject GetModelByPath(string absolutePath) { }

	[AsyncStateMachine(typeof(Loader.<Load>d__33))]
	// RVA: 0x6A9320 Offset: 0x6A7920 VA: 0x1806A9320
	public Task<GameObject> Load(string objName, string objAbsolutePath, Transform parentObj, string texturesFolderPath = "", string materialsFolderPath = "") { }

	[AsyncStateMachine(typeof(Loader.<LoadFromNetwork>d__34))]
	// RVA: 0x6A8C60 Offset: 0x6A7260 VA: 0x1806A8C60
	public Task<GameObject> LoadFromNetwork(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName) { }

	[IteratorStateMachine(typeof(Loader.<LoadFromNetworkWebGL>d__35))]
	// RVA: 0x6A8B30 Offset: 0x6A7130 VA: 0x1806A8B30
	public IEnumerator LoadFromNetworkWebGL(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName, Action<GameObject> OnSuccess, Action<Exception> OnError) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string[] ParseTexturePaths(string absolutePath);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "");

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract Task LoadModelFileNetworked(string objURL);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "");

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract Task LoadMaterialLibrary(string materialURL);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract IEnumerator LoadMaterialLibraryWebGL(string materialURL);

	[AsyncStateMachine(typeof(Loader.<Build>d__43))]
	// RVA: 0x6A83E0 Offset: 0x6A69E0 VA: 0x1806A83E0
	protected Task Build(string absolutePath, string objName, Transform parentTransform, string texturesFolderPath = "") { }

	[AsyncStateMachine(typeof(Loader.<NetworkedBuild>d__44))]
	// RVA: 0x6A9580 Offset: 0x6A7B80 VA: 0x1806A9580
	protected Task NetworkedBuild(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL) { }

	[IteratorStateMachine(typeof(Loader.<NetworkedBuildWebGL>d__45))]
	// RVA: 0x6A9480 Offset: 0x6A7A80 VA: 0x1806A9480
	protected IEnumerator NetworkedBuildWebGL(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL) { }

	// RVA: 0x6A8760 Offset: 0x6A6D60 VA: 0x1806A8760
	protected string GetDirName(string absolutePath) { }

	// RVA: 0x6A97C0 Offset: 0x6A7DC0 VA: 0x1806A97C0 Slot: 12
	protected virtual void OnLoaded(GameObject obj, string absolutePath) { }

	// RVA: 0x6A96E0 Offset: 0x6A7CE0 VA: 0x1806A96E0 Slot: 13
	protected virtual void OnCreated(GameObject obj, string absolutePath) { }

	// RVA: 0x6A97A0 Offset: 0x6A7DA0 VA: 0x1806A97A0 Slot: 14
	protected virtual void OnLoadFailed(string absolutePath) { }

	// RVA: 0x6A89C0 Offset: 0x6A6FC0 VA: 0x1806A89C0
	private string GetTextureUrl(string basePath, string texturePath) { }

	[AsyncStateMachine(typeof(Loader.<LoadMaterialTexture>d__51))]
	// RVA: 0x6A8E80 Offset: 0x6A7480 VA: 0x1806A8E80
	private Task LoadMaterialTexture(string basePath, string path, string texturesFolderPath = "") { }

	[AsyncStateMachine(typeof(Loader.<LoadMaterialTexture>d__52))]
	// RVA: 0x6A8FB0 Offset: 0x6A75B0 VA: 0x1806A8FB0
	private Task LoadMaterialTexture(string textureURL) { }

	[IteratorStateMachine(typeof(Loader.<LoadMaterialTextureWebGL>d__53))]
	// RVA: 0x6A8DF0 Offset: 0x6A73F0 VA: 0x1806A8DF0
	private IEnumerator LoadMaterialTextureWebGL(string textureURL) { }

	// RVA: 0x6A90B0 Offset: 0x6A76B0 VA: 0x1806A90B0
	private Texture2D LoadTexture(UnityWebRequest loader) { }

	[IteratorStateMachine(typeof(Loader.<DownloadFile>d__57))]
	// RVA: 0x6A85E0 Offset: 0x6A6BE0 VA: 0x1806A85E0
	public IEnumerator DownloadFile(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<byte[]> DownloadComplete, Action<string> OnError) { }

	[IteratorStateMachine(typeof(Loader.<GetProgress>d__58))]
	// RVA: 0x6A8930 Offset: 0x6A6F30 VA: 0x1806A8930
	private IEnumerator GetProgress(UnityWebRequest webrequest, PolyfewRuntime.ReferencedNumeric<float> downloadProgress) { }

	[IteratorStateMachine(typeof(Loader.<DownloadFileWebGL>d__59))]
	// RVA: 0x6A8520 Offset: 0x6A6B20 VA: 0x1806A8520
	public IEnumerator DownloadFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<string> DownloadComplete, Action<string> OnError) { }

	[IteratorStateMachine(typeof(Loader.<DownloadTexFileWebGL>d__60))]
	// RVA: 0x6A86A0 Offset: 0x6A6CA0 VA: 0x1806A86A0
	public IEnumerator DownloadTexFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<Texture2D> DownloadComplete, Action<string> OnError) { }

	// RVA: 0x6A9CB0 Offset: 0x6A82B0 VA: 0x1806A9CB0
	protected void .ctor() { }

	// RVA: 0x6A9B20 Offset: 0x6A8120 VA: 0x1806A9B20
	private static void .cctor() { }
}
