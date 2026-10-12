// Namespace: BrainFailProductions.PolyFew.AsImpL
public class MultiObjectImporter : ObjectImporter // TypeDefIndex: 4118
{
	// Fields
	[Tooltip("Load models in the list on start")]
	public bool autoLoadOnStart; // 0x68
	[Tooltip("Models to load on startup")]
	public List<ModelImportInfo> objectsList; // 0x70
	[Tooltip("Default import options")]
	public ImportOptions defaultImportOptions; // 0x78
	[SerializeField]
	private PathSettings pathSettings; // 0x80

	// Properties
	public string RootPath { get; }

	// Methods

	// RVA: 0x6BDD70 Offset: 0x6BC370 VA: 0x1806BDD70
	public string get_RootPath() { }

	// RVA: 0x6BD920 Offset: 0x6BBF20 VA: 0x1806BD920
	public void ImportModelListAsync(ModelImportInfo[] modelsInfo) { }

	// RVA: 0x6BDB80 Offset: 0x6BC180 VA: 0x1806BDB80 Slot: 10
	protected virtual void Start() { }

	// RVA: 0x6BDBE0 Offset: 0x6BC1E0 VA: 0x1806BDBE0
	public void .ctor() { }
}
