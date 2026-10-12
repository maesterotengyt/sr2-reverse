// Namespace: BrainFailProductions.PolyFew.AsImpL
public class ObjectImporter : MonoBehaviour // TypeDefIndex: 4122
{
	// Fields
	public static PolyfewRuntime.ReferencedNumeric<float> downloadProgress; // 0x0
	public static int activeDownloads; // 0x8
	private static float objDownloadProgress; // 0xC
	private static float textureDownloadProgress; // 0x10
	private static float materialDownloadProgress; // 0x14
	public static bool isException; // 0x18
	protected int numTotalImports; // 0x20
	protected bool allLoaded; // 0x24
	protected ImportOptions buildOptions; // 0x28
	protected List<Loader> loaderList; // 0x30
	private ObjectImporter.ImportPhase importPhase; // 0x38
	[CompilerGenerated]
	private Action ImportingStart; // 0x40
	[CompilerGenerated]
	private Action ImportingComplete; // 0x48
	[CompilerGenerated]
	private Action<GameObject, string> CreatedModel; // 0x50
	[CompilerGenerated]
	private Action<GameObject, string> ImportedModel; // 0x58
	[CompilerGenerated]
	private Action<string> ImportError; // 0x60

	// Properties
	public int NumImportRequests { get; }

	// Methods

	// RVA: 0x6BF890 Offset: 0x6BDE90 VA: 0x1806BF890
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6BFC40 Offset: 0x6BE240 VA: 0x1806BFC40
	public void add_ImportingStart(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6BFF90 Offset: 0x6BE590 VA: 0x1806BFF90
	public void remove_ImportingStart(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6BFBA0 Offset: 0x6BE1A0 VA: 0x1806BFBA0
	public void add_ImportingComplete(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6BFEF0 Offset: 0x6BE4F0 VA: 0x1806BFEF0
	public void remove_ImportingComplete(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6BF990 Offset: 0x6BDF90 VA: 0x1806BF990
	public void add_CreatedModel(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE2E0 VA: 0x1806BFCE0
	public void remove_CreatedModel(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6BFAF0 Offset: 0x6BE0F0 VA: 0x1806BFAF0
	public void add_ImportedModel(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6BFE40 Offset: 0x6BE440 VA: 0x1806BFE40
	public void remove_ImportedModel(Action<GameObject, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6BFA40 Offset: 0x6BE040 VA: 0x1806BFA40
	public void add_ImportError(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD90 Offset: 0x6BE390 VA: 0x1806BFD90
	public void remove_ImportError(Action<string> value) { }

	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_NumImportRequests() { }

	// RVA: 0x6BECC0 Offset: 0x6BD2C0 VA: 0x1806BECC0
	private Loader CreateLoader(string absolutePath, bool isNetwork = False) { }

	[AsyncStateMachine(typeof(ObjectImporter.<ImportModelAsync>d__31))]
	// RVA: 0x6BEFD0 Offset: 0x6BD5D0 VA: 0x1806BEFD0
	public Task<GameObject> ImportModelAsync(string objName, string filePath, Transform parentObj, ImportOptions options, string texturesFolderPath = "", string materialsFolderPath = "") { }

	[AsyncStateMachine(typeof(ObjectImporter.<ImportModelFromNetwork>d__32))]
	// RVA: 0x6BF450 Offset: 0x6BDA50 VA: 0x1806BF450
	public Task<GameObject> ImportModelFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options) { }

	// RVA: 0x6BF140 Offset: 0x6BD740 VA: 0x1806BF140
	public void ImportModelFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options, Action<GameObject> OnSuccess, Action<Exception> OnError) { }

	// RVA: 0x6BF680 Offset: 0x6BDC80 VA: 0x1806BF680 Slot: 4
	public virtual void UpdateStatus() { }

	// RVA: 0x5BD2E0 Offset: 0x5BB8E0 VA: 0x1805BD2E0 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x6BF640 Offset: 0x6BDC40 VA: 0x1806BF640 Slot: 6
	protected virtual void OnImportingComplete() { }

	// RVA: 0x6BF660 Offset: 0x6BDC60 VA: 0x1806BF660 Slot: 7
	protected virtual void OnModelCreated(GameObject obj, string absolutePath) { }

	// RVA: 0x6BF620 Offset: 0x6BDC20 VA: 0x1806BF620 Slot: 8
	protected virtual void OnImported(GameObject obj, string absolutePath) { }

	// RVA: 0x6BF600 Offset: 0x6BDC00 VA: 0x1806BF600 Slot: 9
	protected virtual void OnImportError(string absolutePath) { }
}
