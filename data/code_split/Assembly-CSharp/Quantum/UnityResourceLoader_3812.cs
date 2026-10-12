// Namespace: Quantum
public sealed class UnityResourceLoader : IResourceLoader, IDisposable // TypeDefIndex: 3812
{
	// Fields
	private readonly UnityResourceLoader.ILoader[] _loaders; // 0x10
	private Dictionary<AssetGuid, UnityResourceLoader.UnityAssetResource> _inProgress; // 0x18
	private Action<AssetResourceInfo, AssetBase> _loadedAsync; // 0x20
	[CompilerGenerated]
	private ResourceLoaded LoadCompleted; // 0x28
	[CompilerGenerated]
	private ResourceLoadFailed LoadFailed; // 0x30

	// Methods

	// RVA: 0x66E400 Offset: 0x66CA00 VA: 0x18066E400
	public static AssetResource CreateAssetResource(AssetResourceInfo resouceInfo, int loaderIndex) { }

	// RVA: 0x66E810 Offset: 0x66CE10 VA: 0x18066E810
	public static AssetBase GetWrapperFromResource(AssetResource resource) { }

	// RVA: 0x66F0E0 Offset: 0x66D6E0 VA: 0x18066F0E0
	public void .ctor(UnityResourceLoader.ILoader[] loaders) { }

	[CompilerGenerated]
	// RVA: 0x66F1C0 Offset: 0x66D7C0 VA: 0x18066F1C0 Slot: 4
	public void add_LoadCompleted(ResourceLoaded value) { }

	[CompilerGenerated]
	// RVA: 0x66F300 Offset: 0x66D900 VA: 0x18066F300 Slot: 5
	public void remove_LoadCompleted(ResourceLoaded value) { }

	[CompilerGenerated]
	// RVA: 0x66F260 Offset: 0x66D860 VA: 0x18066F260 Slot: 6
	public void add_LoadFailed(ResourceLoadFailed value) { }

	[CompilerGenerated]
	// RVA: 0x66F3A0 Offset: 0x66D9A0 VA: 0x18066F3A0 Slot: 7
	public void remove_LoadFailed(ResourceLoadFailed value) { }

	// RVA: 0x66E4A0 Offset: 0x66CAA0 VA: 0x18066E4A0 Slot: 11
	public void Dispose() { }

	// RVA: 0x66E880 Offset: 0x66CE80 VA: 0x18066E880 Slot: 10
	private void Quantum.IResourceLoader.DisposeResource(AssetResource resource) { }

	// RVA: 0x66EB70 Offset: 0x66D170 VA: 0x18066EB70 Slot: 9
	private void Quantum.IResourceLoader.LoadResource(AssetResource resource) { }

	// RVA: 0x66E9D0 Offset: 0x66CFD0 VA: 0x18066E9D0 Slot: 8
	private void Quantum.IResourceLoader.LoadResourceAsync(AssetResource resource) { }

	// RVA: 0x66EFC0 Offset: 0x66D5C0 VA: 0x18066EFC0
	public void Update() { }

	// RVA: 0x66E7A0 Offset: 0x66CDA0 VA: 0x18066E7A0
	private void FinishLoading(UnityResourceLoader.UnityAssetResource resource, Exception error) { }

	// RVA: 0x66E5A0 Offset: 0x66CBA0 VA: 0x18066E5A0
	private void FinishLoading(UnityResourceLoader.UnityAssetResource resource, AssetBase asset) { }

	// RVA: 0x66E7D0 Offset: 0x66CDD0 VA: 0x18066E7D0
	private UnityResourceLoader.ILoader GetLoaderForResource(UnityResourceLoader.UnityAssetResource resource) { }

	[CompilerGenerated]
	// RVA: 0x66ED20 Offset: 0x66D320 VA: 0x18066ED20
	private void <.ctor>b__6_0(AssetResourceInfo resourceInfo, AssetBase asset) { }
}
