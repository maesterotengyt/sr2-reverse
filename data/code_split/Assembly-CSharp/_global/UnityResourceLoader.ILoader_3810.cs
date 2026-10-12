// Namespace: 
public interface UnityResourceLoader.ILoader : IDisposable // TypeDefIndex: 3810
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LoadAsync(AssetResourceInfo resourceInfo);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AssetBase LoadSync(AssetResourceInfo resourceInfo);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Unload(AssetResourceInfo resourceInfo, AssetBase asset);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateLoadAsync(Action<AssetResourceInfo, AssetBase> asyncLoadedCallback);
}
