// Namespace: Quantum
public class AssetDB // TypeDefIndex: 11498
{
	// Fields
	internal FrameContext _context; // 0x10
	private IResourceManager _resourceManager; // 0x18
	private AssetDB.AssetDictionary<AssetGuid, AssetObject> _byGuid; // 0x20
	private AssetDB.AssetDictionary<string, AssetObject> _byPath; // 0x28

	// Properties
	public IResourceManager ResourceManager { get; }

	// Methods

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public IResourceManager get_ResourceManager() { }

	// RVA: 0x21C4640 Offset: 0x21C2C40 VA: 0x1821C4640
	public void .ctor(IResourceManager manager) { }

	// RVA: 0x21C43B0 Offset: 0x21C29B0 VA: 0x1821C43B0
	public void Dispose() { }

	// RVA: 0x21C42D0 Offset: 0x21C28D0 VA: 0x1821C42D0
	public void DisposeAsset(AssetGuid guid, bool mainThread) { }

	// RVA: 0x21C44C0 Offset: 0x21C2AC0 VA: 0x1821C44C0
	public AssetObject FindAsset(AssetGuid guid, bool mainThread) { }

	// RVA: -1 Offset: -1
	public T FindAsset<T>(AssetGuid guid, bool mainThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9B2A0 Offset: 0xA998A0 VA: 0x180A9B2A0
	|-AssetDB.FindAsset<object>
	*/

	// RVA: 0x21C43F0 Offset: 0x21C29F0 VA: 0x1821C43F0
	public IEnumerable<AssetObject> FindAllAssets(bool mainThread) { }

	// RVA: 0x21C4220 Offset: 0x21C2820 VA: 0x1821C4220
	private void AddAssetToCollection(AssetObject asset) { }
}
