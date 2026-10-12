// Namespace: 
public class GameModeManager : SRMonoBehaviour // TypeDefIndex: 2599
{
	// Fields
	public GameModeManager.OnGameModeObjectsReady GameModeReady; // 0x20
	public AssetReferenceGameObject DefaultGameModePrefab; // 0x28
	public GameModePrefabReference[] GameModePrefabs; // 0x30

	// Properties
	public StellarGameModeSystem StellarSystem { get; }

	// Methods

	// RVA: 0x6F70F0 Offset: 0x6F56F0 VA: 0x1806F70F0
	public StellarGameModeSystem get_StellarSystem() { }

	// RVA: 0x6F6E80 Offset: 0x6F5480 VA: 0x1806F6E80
	public void LoadGameMode() { }

	// RVA: 0x6F6C90 Offset: 0x6F5290 VA: 0x1806F6C90
	private void LoadGameModePrefab(HashString gameModeID, AssetReferenceGameObject gameModePrefab) { }

	// RVA: 0x6F7090 Offset: 0x6F5690 VA: 0x1806F7090
	public void .ctor() { }
}
