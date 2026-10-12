// Namespace: Quantum
[Serializable]
public class ItemsData : AssetObject // TypeDefIndex: 10188
{
	// Fields
	public ItemsData.ItemDataFile[] Items; // 0x20
	[Tooltip("ID used in the spawn points")]
	public HashString SpawnPointsDefaultID; // 0x28
	[Tooltip("The maximum amount of items that can appear at the same time")]
	public int MaxItemsOnScreen; // 0x38
	[Tooltip("The time for the item to indicate unavailable (bliking)")]
	public FP DefaultDisappearingTime; // 0x40
	[Header("Item Low Spawn Frecuency")]
	[Tooltip("The minimun spawn time for an item")]
	public FP LowFrecuencyMinSpawnTime; // 0x48
	[Tooltip("The maximun spawn time for an item")]
	public FP LowFrecuencyMaxISpawnTime; // 0x50
	[Header("Item Medium Spawn Frecuency")]
	[Tooltip("The minimun spawn time for an item")]
	public FP MedFrecuencyMinSpawnTime; // 0x58
	[Tooltip("The maximun spawn time for an item")]
	public FP MedFrecuencyMaxSpawnTime; // 0x60
	[Header("Item High Spawn Frecuency")]
	[Tooltip("The minimun spawn time for an item")]
	public FP HighFrecuencyMinSpawnTime; // 0x68
	[Tooltip("The maximun spawn time for an item")]
	public FP HighFrecuencyMaxSpawnTime; // 0x70

	// Methods

	// RVA: 0x2148120 Offset: 0x2146720 VA: 0x182148120
	public void .ctor() { }
}
