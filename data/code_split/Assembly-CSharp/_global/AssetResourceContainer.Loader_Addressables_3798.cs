// Namespace: 
private class AssetResourceContainer.Loader_Addressables : UnityResourceLoader.LoaderBase<AssetResourceContainer.AssetResourceInfo_Addressables, AsyncOperationHandle<AssetBase>> // TypeDefIndex: 3798
{
	// Fields
	private Dictionary<AssetGuid, AsyncOperationHandle<AssetBase>> _handles; // 0x18

	// Methods

	// RVA: 0x65BB50 Offset: 0x65A150 VA: 0x18065BB50 Slot: 10
	protected override AssetBase GetAssetFromAsyncState(AssetResourceContainer.AssetResourceInfo_Addressables resourceInfo, AsyncOperationHandle<AssetBase> asyncState) { }

	// RVA: 0x65BC20 Offset: 0x65A220 VA: 0x18065BC20 Slot: 11
	protected override bool IsDone(AsyncOperationHandle<AssetBase> asyncState) { }

	// RVA: 0x65BC60 Offset: 0x65A260 VA: 0x18065BC60 Slot: 12
	protected override AsyncOperationHandle<AssetBase> LoadAsync(AssetResourceContainer.AssetResourceInfo_Addressables info) { }

	// RVA: 0x65BD50 Offset: 0x65A350 VA: 0x18065BD50 Slot: 13
	protected override AssetBase LoadSync(AssetResourceContainer.AssetResourceInfo_Addressables info) { }

	// RVA: 0x65C1A0 Offset: 0x65A7A0 VA: 0x18065C1A0 Slot: 14
	protected override void Unload(AssetResourceContainer.AssetResourceInfo_Addressables info, AssetBase asset) { }

	// RVA: 0x65C310 Offset: 0x65A910 VA: 0x18065C310
	public void .ctor() { }
}
