// Namespace: 
private sealed class UnityDB.Context : IDisposable // TypeDefIndex: 3426
{
	// Fields
	public QuantumUnityNativeAllocator Allocator; // 0x10
	public List<AssetResource> AssetResources; // 0x18
	public AssetResourceContainer ResourceContainer; // 0x20
	public UnityResourceLoader ResourceLoader; // 0x28
	public ResourceManagerDynamic ResourceManager; // 0x30

	// Methods

	// RVA: 0x5C7260 Offset: 0x5C5860 VA: 0x1805C7260
	public void .ctor() { }

	// RVA: 0x5C70E0 Offset: 0x5C56E0 VA: 0x1805C70E0
	public ResourceManagerDynamic CreateResourceManager() { }

	// RVA: 0x5C7160 Offset: 0x5C5760 VA: 0x1805C7160 Slot: 4
	public void Dispose() { }
}
