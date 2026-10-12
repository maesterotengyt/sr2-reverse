// Namespace: Quantum
public interface IResourceLoader // TypeDefIndex: 11508
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_LoadCompleted(ResourceLoaded value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_LoadCompleted(ResourceLoaded value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_LoadFailed(ResourceLoadFailed value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_LoadFailed(ResourceLoadFailed value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void LoadResourceAsync(AssetResource resource);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LoadResource(AssetResource resource);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void DisposeResource(AssetResource resource);
}
