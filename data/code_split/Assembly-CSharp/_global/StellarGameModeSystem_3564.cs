// Namespace: 
public class StellarGameModeSystem : MonoBehaviour // TypeDefIndex: 3564
{
	// Fields
	[CompilerGenerated]
	private HashString <CurrentGameModeID>k__BackingField; // 0x20
	[CompilerGenerated]
	private StellarGameMode <CurrentGameMode>k__BackingField; // 0x30
	private List<AsyncOperationHandle<GameObject>> gameModeLoadOperations; // 0x38

	// Properties
	public HashString CurrentGameModeID { get; set; }
	public StellarGameMode CurrentGameMode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5EE1D0 Offset: 0x5EC7D0 VA: 0x1805EE1D0
	public HashString get_CurrentGameModeID() { }

	[CompilerGenerated]
	// RVA: 0x5EE1E0 Offset: 0x5EC7E0 VA: 0x1805EE1E0
	public void set_CurrentGameModeID(HashString value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public StellarGameMode get_CurrentGameMode() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_CurrentGameMode(StellarGameMode value) { }

	// RVA: 0x5EDD10 Offset: 0x5EC310 VA: 0x1805EDD10
	public bool IsGameModeActive(HashString gameModeID) { }

	// RVA: 0x5EDC30 Offset: 0x5EC230 VA: 0x1805EDC30
	public void CreateSimpleGameModeManager(HashString gameModeID) { }

	// RVA: 0x5EDF50 Offset: 0x5EC550 VA: 0x1805EDF50
	public void SetupGameMode(HashString gameModeID, StellarGameMode newGameMode) { }

	// RVA: 0x5EDE50 Offset: 0x5EC450 VA: 0x1805EDE50
	public void SetupGameMode(HashString gameModeID, StellarGameMode newGameMode, AsyncOperationHandle<GameObject> operationHandle) { }

	// RVA: 0x5EDDD0 Offset: 0x5EC3D0 VA: 0x1805EDDD0
	internal void ReloadGameMode() { }

	// RVA: 0x5ED9B0 Offset: 0x5EBFB0 VA: 0x1805ED9B0
	public void ClearCurrentGameMode() { }

	// RVA: 0x5EE150 Offset: 0x5EC750 VA: 0x1805EE150
	public void .ctor() { }
}
