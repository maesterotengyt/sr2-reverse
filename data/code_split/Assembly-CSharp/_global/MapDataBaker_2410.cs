// Namespace: 
public static class MapDataBaker // TypeDefIndex: 2410
{
	// Fields
	public static int NavMeshSerializationBufferSize; // 0x0

	// Methods

	// RVA: 0x5235A0 Offset: 0x521BA0 VA: 0x1805235A0
	public static void BakeMapData(MapData data, bool inEditor, bool bakeColliders = True, bool bakePrototypes = True, QuantumMapDataBakeFlags bakeFlags = 0, MapDataBaker.BuildTrigger buildTrigger = 3) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void BakeMeshes(MapData data, bool inEditor) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private static void RemoveLegacyResourcesBinaryFile(ref string name) { }

	// RVA: 0x5246E0 Offset: 0x522CE0 VA: 0x1805246E0
	private static StaticColliderData GetStaticData(GameObject gameObject, QuantumStaticColliderSettings settings, int colliderId) { }

	// RVA: 0x520760 Offset: 0x51ED60 VA: 0x180520760
	public static void BakeColliders(MapData data, bool inEditor) { }

	// RVA: 0x523790 Offset: 0x521D90 VA: 0x180523790
	public static void BakePrototypes(MapData data) { }

	// RVA: 0x524290 Offset: 0x522890 VA: 0x180524290
	private static IEnumerable<Type> FindCallbackInstances() { }

	// RVA: 0x5252C0 Offset: 0x5238C0 VA: 0x1805252C0
	private static void InvokeCallbacks(string callbackName, MapData data, MapDataBaker.BuildTrigger buildTrigger, QuantumMapDataBakeFlags bakeFlags) { }

	// RVA: 0x524A90 Offset: 0x523090 VA: 0x180524A90
	private static void InvokeCallbacks(string callbackName, MapData data) { }

	// RVA: 0x524FB0 Offset: 0x5235B0 VA: 0x180524FB0
	private static void InvokeCallbacks(string callbackName, MapData data, List<MapNavMesh.BakeData> bakeData) { }

	// RVA: 0x524780 Offset: 0x522D80 VA: 0x180524780
	private static void InvokeCallbacks(string callbackName, MapData data, List<NavMesh> navmeshes) { }

	// RVA: -1 Offset: -1
	private static void SortBySiblingIndex<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA6320 Offset: 0xBA4920 VA: 0x180BA6320
	|-MapDataBaker.SortBySiblingIndex<object>
	*/

	// RVA: 0x524590 Offset: 0x522B90 VA: 0x180524590
	private static List<int> GetSiblingIndexPath(Transform t, List<int> buffer) { }

	// RVA: 0x524160 Offset: 0x522760 VA: 0x180524160
	private static int CompareLists(List<int> left, List<int> right) { }

	// RVA: 0x523C90 Offset: 0x522290 VA: 0x180523C90
	private static bool BakeStaticEdge2D(Transform t, FPVector2 positionOffset, FP rotationOffset, FPVector2 vertexA, FPVector2 vertexB, FP height, QuantumStaticColliderSettings settings, int colliderId, out MapStaticCollider2D bakedCollider) { }

	// RVA: -1 Offset: -1
	public static List<T> FindLocalObjects<T>(Scene scene) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA61C0 Offset: 0xBA47C0 VA: 0x180BA61C0
	|-MapDataBaker.FindLocalObjects<object>
	*/

	// RVA: 0x524460 Offset: 0x522A60 VA: 0x180524460
	public static List<Component> FindLocalObjects(Scene scene, Type type) { }

	// RVA: 0x5255F0 Offset: 0x523BF0 VA: 0x1805255F0
	private static void .cctor() { }
}
