// Namespace: Quantum
public class AssetResourceContainer : ScriptableObject // TypeDefIndex: 3807
{
	// Fields
	private List<AssetResourceInfoGroup> _groups; // 0x18
	public AssetResourceContainer.AssetResourceInfoGroup_Addressables AddressablesGroup; // 0x20
	public AssetResourceContainer.AssetResourceInfoGroup_AssetBundle AssetBundlesGroup; // 0x28
	public AssetResourceContainer.AssetResourceInfoGroup_Resources ResourcesGroup; // 0x30

	// Properties
	public int AssetCount { get; }
	public IReadOnlyList<AssetResourceInfoGroup> Groups { get; }

	// Methods

	// RVA: 0x6565C0 Offset: 0x654BC0 VA: 0x1806565C0
	public int get_AssetCount() { }

	// RVA: 0x6559E0 Offset: 0x653FE0 VA: 0x1806559E0
	public UnityResourceLoader CreateLoader() { }

	// RVA: 0x655C00 Offset: 0x654200 VA: 0x180655C00
	public List<AssetResource> CreateResourceWrappers() { }

	// RVA: 0x6566F0 Offset: 0x654CF0 VA: 0x1806566F0
	public IReadOnlyList<AssetResourceInfoGroup> get_Groups() { }

	// RVA: 0x655FF0 Offset: 0x6545F0 VA: 0x180655FF0
	public AssetResourceInfo FindResourceInfo(AssetGuid guid) { }

	// RVA: 0x6561F0 Offset: 0x6547F0 VA: 0x1806561F0
	private void InitGroups() { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6564A0 Offset: 0x654AA0 VA: 0x1806564A0
	private AssetResourceInfoGroup <InitGroups>b__8_1(FieldInfo x) { }
}
