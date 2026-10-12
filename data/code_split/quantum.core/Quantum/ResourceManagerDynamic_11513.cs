// Namespace: Quantum
public class ResourceManagerDynamic : ResourceManagerBase // TypeDefIndex: 11513
{
	// Fields
	private Thread _creatorThread; // 0x20
	private IResourceLoader _loader; // 0x28
	private SynchonizedSet<AssetDB> _assetDBs; // 0x30
	private Stack<ResourceManagerDynamic.ResourceLoadingRequest> _resourcesToLoadList; // 0x38
	private ResourceManagerDynamic.ResourceLoadingQueue _resourcesToLoad; // 0x40
	private SynchronizedQueue<AssetResource> _resourcesToDispose; // 0x48
	private Native.Allocator _allocator; // 0x50

	// Methods

	// RVA: 0x21DA9C0 Offset: 0x21D8FC0 VA: 0x1821DA9C0
	public void .ctor() { }

	// RVA: 0x21DA020 Offset: 0x21D8620 VA: 0x1821DA020
	public void Init(IEnumerable<AssetResource> resources, IResourceLoader loader, Native.Allocator allocator) { }

	// RVA: 0x21D9A50 Offset: 0x21D8050 VA: 0x1821D9A50 Slot: 12
	public override AssetDB CreateAssetDatabase() { }

	// RVA: 0x21D9AD0 Offset: 0x21D80D0 VA: 0x1821D9AD0 Slot: 13
	public override void DiposeAssetDatabase(AssetDB db) { }

	// RVA: 0x21D9DD0 Offset: 0x21D83D0 VA: 0x1821D9DD0 Slot: 14
	public override void Dispose() { }

	// RVA: 0x21DA780 Offset: 0x21D8D80 VA: 0x1821DA780 Slot: 16
	public override void MainThreadUpdate(Profiler profiler) { }

	// RVA: 0x21DA4D0 Offset: 0x21D8AD0 VA: 0x1821DA4D0 Slot: 15
	public override void MainThreadSimulationEnded() { }

	// RVA: 0x21D9D50 Offset: 0x21D8350 VA: 0x1821D9D50 Slot: 17
	protected override void DisposeAsset(AssetResource resource) { }

	// RVA: 0x21DA270 Offset: 0x21D8870 VA: 0x1821DA270 Slot: 18
	public override AssetObject LoadResource(AssetResource resource, bool mainThread) { }

	// RVA: 0x21D9880 Offset: 0x21D7E80 VA: 0x1821D9880
	private void AssetLoaded(IResourceLoader loader, AssetResource resource, AssetObject asset) { }

	// RVA: 0x21D9740 Offset: 0x21D7D40 VA: 0x1821D9740
	private void AssetLoadFailed(IResourceLoader loader, AssetResource resource, Exception error) { }

	// RVA: 0x21D9B50 Offset: 0x21D8150 VA: 0x1821D9B50
	private void DisposeAssetNoChecks(AssetResource resource) { }
}
