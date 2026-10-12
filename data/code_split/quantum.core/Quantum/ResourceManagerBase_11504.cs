// Namespace: Quantum
public abstract class ResourceManagerBase : IResourceManager, IDisposable // TypeDefIndex: 11504
{
	// Fields
	protected readonly Dictionary<AssetGuid, AssetResource> _byGuid; // 0x10
	protected readonly Dictionary<string, AssetResource> _byPath; // 0x18

	// Methods

	// RVA: 0x21D8BB0 Offset: 0x21D71B0 VA: 0x1821D8BB0 Slot: 12
	public virtual AssetDB CreateAssetDatabase() { }

	// RVA: 0x21D8C10 Offset: 0x21D7210 VA: 0x1821D8C10 Slot: 13
	public virtual void DiposeAssetDatabase(AssetDB db) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Dispose();

	// RVA: 0x21D8C50 Offset: 0x21D7250 VA: 0x1821D8C50 Slot: 6
	public bool DisposeAsset(AssetGuid guid) { }

	// RVA: 0x21D95A0 Offset: 0x21D7BA0 VA: 0x1821D95A0
	public bool TryGetAssetResource(AssetGuid guid, out AssetResource resource) { }

	// RVA: 0x21D9610 Offset: 0x21D7C10 VA: 0x1821D9610
	public bool TryGetAssetResource(string path, out AssetResource resource) { }

	// RVA: 0x21D8D70 Offset: 0x21D7370 VA: 0x1821D8D70 Slot: 7
	public AssetObject GetAsset(AssetGuid guid, bool mainThread) { }

	[IteratorStateMachine(typeof(ResourceManagerBase.<LoadAllAssets>d__11))]
	// RVA: 0x21D9510 Offset: 0x21D7B10 VA: 0x1821D9510 Slot: 8
	public IEnumerable<AssetObject> LoadAllAssets(bool mainThread) { }

	// RVA: 0x21D8CE0 Offset: 0x21D72E0 VA: 0x1821D8CE0
	public AssetGuid GetAssetGuid(string path) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 15
	public virtual void MainThreadSimulationEnded() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 16
	public virtual void MainThreadUpdate(Profiler profiler) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void DisposeAsset(AssetResource resource);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract AssetObject LoadResource(AssetResource resource, bool mainThread);

	// RVA: 0x21D8EB0 Offset: 0x21D74B0 VA: 0x1821D8EB0
	protected void Init(IEnumerable<AssetResource> resources) { }

	// RVA: -1 Offset: -1
	private static bool TryAdd<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue value, out TValue existing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC28DB0 Offset: 0xC273B0 VA: 0x180C28DB0
	|-ResourceManagerBase.TryAdd<AssetGuid, object>
	|
	|-RVA: 0xC29000 Offset: 0xC27600 VA: 0x180C29000
	|-ResourceManagerBase.TryAdd<object, object>
	|
	|-RVA: 0xC28E30 Offset: 0xC27430 VA: 0x180C28E30
	|-ResourceManagerBase.TryAdd<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21D9680 Offset: 0x21D7C80 VA: 0x1821D9680
	protected void .ctor() { }
}
