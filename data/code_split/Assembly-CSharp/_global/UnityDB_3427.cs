// Namespace: 
public static class UnityDB // TypeDefIndex: 3427
{
	// Fields
	private static UnityDB.Context _context; // 0x0

	// Properties
	public static IEnumerable<AssetResource> AssetResources { get; }
	[Obsolete("Use DefaultResourceManager instead")]
	public static ResourceManagerDynamic ResourceManager { get; }
	public static ResourceManagerDynamic DefaultResourceManager { get; }

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private static void .cctor() { }

	// RVA: 0x5E2EB0 Offset: 0x5E14B0 VA: 0x1805E2EB0
	public static IEnumerable<AssetResource> get_AssetResources() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public static ResourceManagerDynamic get_ResourceManager() { }

	// RVA: 0x5E2F00 Offset: 0x5E1500 VA: 0x1805E2F00
	public static ResourceManagerDynamic get_DefaultResourceManager() { }

	// RVA: 0x5E1B70 Offset: 0x5E0170 VA: 0x1805E1B70
	public static List<QTuple<AssetRef, string>> CollectAddressableAssets() { }

	// RVA: 0x5E1BF0 Offset: 0x5E01F0 VA: 0x1805E1BF0
	public static void CollectAddressableAssets(List<QTuple<AssetRef, string>> entries) { }

	// RVA: 0x5E1ED0 Offset: 0x5E04D0 VA: 0x1805E1ED0
	public static void Dispose() { }

	// RVA: -1 Offset: -1
	public static T FindAsset<T>(AssetObject asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC93070 Offset: 0xC91670 VA: 0x180C93070
	|-UnityDB.FindAsset<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAsset<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC92F50 Offset: 0xC91550 VA: 0x180C92F50
	|-UnityDB.FindAsset<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAsset<T>(AssetGuid guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC92FE0 Offset: 0xC915E0 VA: 0x180C92FE0
	|-UnityDB.FindAsset<object>
	*/

	// RVA: 0x5E20D0 Offset: 0x5E06D0 VA: 0x1805E20D0
	public static AssetBase FindAsset(string path) { }

	// RVA: 0x5E2010 Offset: 0x5E0610 VA: 0x1805E2010
	public static AssetBase FindAsset(AssetGuid guid) { }

	// RVA: 0x5E2190 Offset: 0x5E0790 VA: 0x1805E2190
	public static AssetGuid GetAssetGuid(string path) { }

	// RVA: 0x5E2E40 Offset: 0x5E1440 VA: 0x1805E2E40
	public static void Update() { }

	// RVA: 0x5E2230 Offset: 0x5E0830 VA: 0x1805E2230
	private static UnityDB.Context GetOrCreateContext() { }

	// RVA: 0x5E24F0 Offset: 0x5E0AF0 VA: 0x1805E24F0
	private static AssetResourceContainer LoadContainer() { }

	// RVA: 0x5E2480 Offset: 0x5E0A80 VA: 0x1805E2480
	public static AssetResourceContainer LoadAssetResourceContainer(string path) { }
}
