// Namespace: 
public class StellarFileLoadingSystem : MonoBehaviour // TypeDefIndex: 3563
{
	// Fields
	public static StellarFileLoadingSystem.OnSpriteLoaded SpriteLoaded; // 0x0
	public static StellarFileLoadingSystem.OnSpriteLoadedWithPath SpriteLoadedWithPath; // 0x8
	public static StellarFileLoadingSystem.OnGameObjectInstantiated GameObjectInstantiated; // 0x10
	private List<AsyncOperationHandle<Sprite>> spritesOperations; // 0x20
	private List<AsyncOperationHandle<GameObject>> gameObjectOperations; // 0x28

	// Methods

	// RVA: 0x5ECFC0 Offset: 0x5EB5C0 VA: 0x1805ECFC0
	public StellarData LoadStellarData() { }

	// RVA: 0x5ECE70 Offset: 0x5EB470 VA: 0x1805ECE70
	public void LoadSprite(string filePath) { }

	// RVA: 0x5ED7D0 Offset: 0x5EBDD0 VA: 0x1805ED7D0
	private void SpriteLoadedWithPathResult(AsyncOperationHandle<Sprite> operation, string filePath) { }

	// RVA: 0x5ECC50 Offset: 0x5EB250 VA: 0x1805ECC50
	public AsyncOperationHandle LoadSprite(AssetReference assetReference) { }

	// RVA: 0x5ED6B0 Offset: 0x5EBCB0 VA: 0x1805ED6B0
	private void SpriteLoadedResult(AsyncOperationHandle<Sprite> operation, AssetReference assetReference) { }

	// RVA: 0x5EC4A0 Offset: 0x5EAAA0 VA: 0x1805EC4A0
	public AsyncOperationHandle InstantiateGameObject(string filePath, bool autoRelease = True) { }

	// RVA: 0x5ECA80 Offset: 0x5EB080 VA: 0x1805ECA80
	public AsyncOperationHandle InstantiateGameObject(string filePath, Transform parent, bool useParentTransformValues = False, bool autoRelease = True) { }

	// RVA: 0x5EC830 Offset: 0x5EAE30 VA: 0x1805EC830
	public GameObject InstantiateGameObject(GameObject prefab, Transform parent, bool useParentTransformValues = False, bool autoRelease = True) { }

	// RVA: 0x5EC8C0 Offset: 0x5EAEC0 VA: 0x1805EC8C0
	public AsyncOperationHandle InstantiateGameObject(AssetReferenceGameObject assetReference, bool autoRelease = True) { }

	// RVA: 0x5EC660 Offset: 0x5EAC60 VA: 0x1805EC660
	public AsyncOperationHandle InstantiateGameObject(AssetReferenceGameObject assetReference, Transform parent, bool useParentTransformValues = False, bool autoRelease = True) { }

	// RVA: 0x5ED4C0 Offset: 0x5EBAC0 VA: 0x1805ED4C0
	private void SetupInstancedObjectTransform(GameObject instancedObject, Transform parent, bool useParentTransformValues) { }

	// RVA: 0x5EC380 Offset: 0x5EA980 VA: 0x1805EC380
	private void GameObjectInstantiatedResult(AsyncOperationHandle<GameObject> operation, string filePath) { }

	// RVA: 0x5ED460 Offset: 0x5EBA60 VA: 0x1805ED460
	public void ReleaseSprite(Sprite sprite) { }

	// RVA: 0x5ED410 Offset: 0x5EBA10 VA: 0x1805ED410
	public void ReleaseGameObject(GameObject gameObject) { }

	// RVA: 0x5ED0B0 Offset: 0x5EB6B0 VA: 0x1805ED0B0
	public void ReleaseAllAssets() { }

	// RVA: 0x5ED8F0 Offset: 0x5EBEF0 VA: 0x1805ED8F0
	public void .ctor() { }
}
