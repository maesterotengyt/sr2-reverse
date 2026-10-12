// Namespace: 
public class LaunchPreloader : MonoBehaviour // TypeDefIndex: 2567
{
	// Fields
	public InitManager InitManager; // 0x20
	private bool prefabsReady; // 0x28
	private bool quantumAssetsReady; // 0x29

	// Methods

	// RVA: 0x6FC5B0 Offset: 0x6FABB0 VA: 0x1806FC5B0
	public void Preload() { }

	// RVA: 0x6FC570 Offset: 0x6FAB70 VA: 0x1806FC570
	private void PrefabsLoaded(AsyncOperationHandle<IList<GameObject>> handle) { }

	// RVA: 0x6FC760 Offset: 0x6FAD60 VA: 0x1806FC760
	private void QuantumAssetsOnAssetsLoaded(AsyncOperationHandle<IList<AssetBase>> handle) { }

	// RVA: 0x6FC530 Offset: 0x6FAB30 VA: 0x1806FC530
	private void CheckLoading() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
