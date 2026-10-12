// Namespace: Quantum
public sealed class DynamicAssetDB : IResourceManager, IDisposable // TypeDefIndex: 11501
{
	// Fields
	[CompilerGenerated]
	private IResourceManager <StaticResourceManager>k__BackingField; // 0x10
	private DynamicAssetDB.Head _head; // 0x18
	private long _lastGuid; // 0x20
	private const int FormatVersion = 1;

	// Properties
	internal IResourceManager StaticResourceManager { get; set; }
	public bool IsEmpty { get; }
	public AssetGuid NextGuid { get; }
	public IEnumerable<AssetObject> Assets { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	internal void set_StaticResourceManager(IResourceManager value) { }

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	internal IResourceManager get_StaticResourceManager() { }

	// RVA: 0x21CC870 Offset: 0x21CAE70 VA: 0x1821CC870
	public void .ctor() { }

	// RVA: 0x21CC930 Offset: 0x21CAF30 VA: 0x1821CC930
	public bool get_IsEmpty() { }

	// RVA: 0x21CC980 Offset: 0x21CAF80 VA: 0x1821CC980
	public AssetGuid get_NextGuid() { }

	// RVA: 0x21CBA50 Offset: 0x21CA050 VA: 0x1821CBA50
	public void AddAssetWithValidDynamicGuid(AssetObject asset) { }

	// RVA: 0x21CBCC0 Offset: 0x21CA2C0 VA: 0x1821CBCC0
	public void CopyFrom(DynamicAssetDB other) { }

	// RVA: 0x21CBCF0 Offset: 0x21CA2F0 VA: 0x1821CBCF0
	public IEnumerable<AssetObject> Deserialize(byte[] bytes, IAssetSerializer assetSerializer) { }

	// RVA: 0x21CC460 Offset: 0x21CAA60 VA: 0x1821CC460
	public byte[] Serialize(IAssetSerializer serializer) { }

	// RVA: 0x21CC680 Offset: 0x21CAC80 VA: 0x1821CC680
	public void Serialize(IAssetSerializer serializer, out byte[] header, out byte[] assets) { }

	// RVA: 0x21CBFD0 Offset: 0x21CA5D0 VA: 0x1821CBFD0 Slot: 6
	public bool DisposeAsset(AssetGuid guid) { }

	// RVA: 0x21CC8E0 Offset: 0x21CAEE0 VA: 0x1821CC8E0
	public IEnumerable<AssetObject> get_Assets() { }

	// RVA: -1 Offset: -1
	public T FindAsset<T>(AssetGuid guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB10850 Offset: 0xB0EE50 VA: 0x180B10850
	|-DynamicAssetDB.FindAsset<object>
	*/

	// RVA: 0x21CC210 Offset: 0x21CA810 VA: 0x1821CC210
	public AssetObject FindAsset(AssetGuid guid) { }

	// RVA: 0x21CC7E0 Offset: 0x21CADE0 VA: 0x1821CC7E0
	private static long StripDynamicFlag(AssetGuid guid) { }

	// RVA: 0x21CC260 Offset: 0x21CA860 VA: 0x1821CC260 Slot: 4
	private AssetDB Quantum.IResourceManager.CreateAssetDatabase() { }

	// RVA: 0x21CC2A0 Offset: 0x21CA8A0 VA: 0x1821CC2A0 Slot: 5
	private void Quantum.IResourceManager.DiposeAssetDatabase(AssetDB db) { }

	// RVA: 0x21CC2E0 Offset: 0x21CA8E0 VA: 0x1821CC2E0 Slot: 7
	private AssetObject Quantum.IResourceManager.GetAsset(AssetGuid guid, bool mainThread) { }

	// RVA: 0x21CC3A0 Offset: 0x21CA9A0 VA: 0x1821CC3A0 Slot: 8
	private IEnumerable<AssetObject> Quantum.IResourceManager.LoadAllAssets(bool mainThread) { }

	// RVA: 0x21CC3E0 Offset: 0x21CA9E0 VA: 0x1821CC3E0 Slot: 9
	private void Quantum.IResourceManager.MainThreadSimulationEnded() { }

	// RVA: 0x21CC420 Offset: 0x21CAA20 VA: 0x1821CC420 Slot: 10
	private void Quantum.IResourceManager.MainThreadUpdate(Profiler profiler) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 11
	private void System.IDisposable.Dispose() { }
}
