// Namespace: 
[Flags]
[Serializable]
public enum QuantumMapDataBakeFlags // TypeDefIndex: 3416
{
	// Fields
	public int value__; // 0x0
	public const QuantumMapDataBakeFlags None = 0;
	[Obsolete("Use BakeMapData instead")]
	public const QuantumMapDataBakeFlags Obsolete_BakeMapData = 1;
	public const QuantumMapDataBakeFlags BakeMapData = 96;
	public const QuantumMapDataBakeFlags BakeMapPrototypes = 32;
	public const QuantumMapDataBakeFlags BakeMapColliders = 64;
	public const QuantumMapDataBakeFlags BakeUnityNavMesh = 8;
	public const QuantumMapDataBakeFlags ImportUnityNavMesh = 4;
	public const QuantumMapDataBakeFlags BakeNavMesh = 2;
	public const QuantumMapDataBakeFlags ClearUnityNavMesh = 256;
	public const QuantumMapDataBakeFlags GenerateAssetDB = 16;
	public const QuantumMapDataBakeFlags SaveUnityAssets = 128;
}
