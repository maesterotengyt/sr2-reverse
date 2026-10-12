// Namespace: 
public class StellarSimulationSystem : QuantumCallbacks // TypeDefIndex: 3578
{
	// Fields
	public EntityViewUpdater EntityViewUpdater; // 0x20
	public static StellarSimulationSystem.OnSimulationStarted SimulationStarted; // 0x0
	public static StellarSimulationSystem.OnSimulationEnded SimulationEnded; // 0x8
	[CompilerGenerated]
	private List<PlayerSimulationData> <CurrentPlayers>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <QuantumCoreFilesPreloaded>k__BackingField; // 0x30
	[CompilerGenerated]
	private QuantumGame <CurrentQuantumGame>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <LoadingCharacters>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <NextMatchOnlinePlayersAmount>k__BackingField; // 0x44
	[CompilerGenerated]
	private int <NextMatchCharactersAmount>k__BackingField; // 0x48
	private int charactersLoaded; // 0x4C
	private float loadingTimer; // 0x50
	private DispatcherSubscription onEntitySpawnSubscription; // 0x54
	private bool isMaster; // 0x5C
	private bool timeoutActive; // 0x5D
	private string lastReportedCharactersLoadMessage; // 0x60
	private string lastReportedPlayersLoadMessage; // 0x68

	// Properties
	public List<PlayerSimulationData> CurrentPlayers { get; set; }
	public bool QuantumCoreFilesPreloaded { get; set; }
	public QuantumGame CurrentQuantumGame { get; set; }
	public bool LoadingCharacters { get; set; }
	public int NextMatchOnlinePlayersAmount { get; set; }
	public int NextMatchCharactersAmount { get; set; }
	public bool SimulationActive { get; }
	public Frame PredictedFrame { get; }
	public Frame VerifiedFrame { get; }
	private StellarOnlineSystem onlineSystem { get; }
	private StellarInputSystem inputSystem { get; }
	private StellarDataSystem dataSystem { get; }
	private StellarData stellarData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public List<PlayerSimulationData> get_CurrentPlayers() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	public void set_CurrentPlayers(List<PlayerSimulationData> value) { }

	[CompilerGenerated]
	// RVA: 0x5DCA80 Offset: 0x5DB080 VA: 0x1805DCA80
	public bool get_QuantumCoreFilesPreloaded() { }

	[CompilerGenerated]
	// RVA: 0x5DCA90 Offset: 0x5DB090 VA: 0x1805DCA90
	public void set_QuantumCoreFilesPreloaded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public QuantumGame get_CurrentQuantumGame() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	public void set_CurrentQuantumGame(QuantumGame value) { }

	[CompilerGenerated]
	// RVA: 0x5CC0D0 Offset: 0x5CA6D0 VA: 0x1805CC0D0
	public bool get_LoadingCharacters() { }

	[CompilerGenerated]
	// RVA: 0x611280 Offset: 0x60F880 VA: 0x180611280
	public void set_LoadingCharacters(bool value) { }

	[CompilerGenerated]
	// RVA: 0x611000 Offset: 0x60F600 VA: 0x180611000
	public int get_NextMatchOnlinePlayersAmount() { }

	[CompilerGenerated]
	// RVA: 0x611290 Offset: 0x60F890 VA: 0x180611290
	public void set_NextMatchOnlinePlayersAmount(int value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B60 Offset: 0x5C4160 VA: 0x1805C5B60
	public int get_NextMatchCharactersAmount() { }

	[CompilerGenerated]
	// RVA: 0x5C5BB0 Offset: 0x5C41B0 VA: 0x1805C5BB0
	public void set_NextMatchCharactersAmount(int value) { }

	// RVA: 0x611040 Offset: 0x60F640 VA: 0x180611040
	public bool get_SimulationActive() { }

	// RVA: 0x611010 Offset: 0x60F610 VA: 0x180611010
	public Frame get_PredictedFrame() { }

	// RVA: 0x611110 Offset: 0x60F710 VA: 0x180611110
	public Frame get_VerifiedFrame() { }

	// RVA: 0x6111E0 Offset: 0x60F7E0 VA: 0x1806111E0
	private StellarOnlineSystem get_onlineSystem() { }

	// RVA: 0x611190 Offset: 0x60F790 VA: 0x180611190
	private StellarInputSystem get_inputSystem() { }

	// RVA: 0x611140 Offset: 0x60F740 VA: 0x180611140
	private StellarDataSystem get_dataSystem() { }

	// RVA: 0x611230 Offset: 0x60F830 VA: 0x180611230
	private StellarData get_stellarData() { }

	// RVA: 0x60FA60 Offset: 0x60E060 VA: 0x18060FA60
	public void StartOfflineSimulation(RuntimeConfig runtimeConfig) { }

	// RVA: 0x60FF10 Offset: 0x60E510 VA: 0x18060FF10
	public void StartOnlineSimulation(RuntimeConfig runtimeConfig, bool disableInputDelay = False) { }

	// RVA: 0x60E5D0 Offset: 0x60CBD0 VA: 0x18060E5D0 Slot: 6
	public override void OnGameStart(QuantumGame game) { }

	// RVA: 0x60F080 Offset: 0x60D680 VA: 0x18060F080
	public void SendPlayersData() { }

	// RVA: 0x60F590 Offset: 0x60DB90 VA: 0x18060F590
	public bool SpawnLocalPlayersCharacters() { }

	// RVA: 0x60F9A0 Offset: 0x60DFA0 VA: 0x18060F9A0
	public void StartCharacterLoading() { }

	// RVA: 0x60D560 Offset: 0x60BB60 VA: 0x18060D560
	public void CharacterLoaded() { }

	// RVA: 0x60E8B0 Offset: 0x60CEB0 VA: 0x18060E8B0
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x610C10 Offset: 0x60F210 VA: 0x180610C10
	private void Update() { }

	// RVA: 0x60D570 Offset: 0x60BB70 VA: 0x18060D570
	public void CheckIfCharacterLoadingFinished() { }

	// RVA: 0x60DE60 Offset: 0x60C460 VA: 0x18060DE60
	private void FinishLoading() { }

	// RVA: 0x60E780 Offset: 0x60CD80 VA: 0x18060E780
	public void OnLoadingFinished() { }

	// RVA: 0x60EAB0 Offset: 0x60D0B0 VA: 0x18060EAB0
	public void ReleaseQuantumAssets() { }

	// RVA: 0x60DFB0 Offset: 0x60C5B0 VA: 0x18060DFB0
	public void FinishSimulation() { }

	// RVA: 0x60EE00 Offset: 0x60D400 VA: 0x18060EE00
	public void SendCommand(DeterministicCommand command) { }

	// RVA: 0x60EF20 Offset: 0x60D520 VA: 0x18060EF20
	public void SendMasterCommand(DeterministicCommand command) { }

	// RVA: 0x60E0F0 Offset: 0x60C6F0 VA: 0x18060E0F0
	public StellarCharacterData GetCharacter(EntityRef entityRef) { }

	// RVA: 0x60EFE0 Offset: 0x60D5E0 VA: 0x18060EFE0
	public void SendPlayerData(StellarPlayer stellarPlayer) { }

	// RVA: 0x60D070 Offset: 0x60B670 VA: 0x18060D070
	public void AddCharacterToPlayer(StellarCharacterData characterData) { }

	// RVA: 0x610A70 Offset: 0x60F070 VA: 0x180610A70
	public bool TryGetPlayerData(string playerID, out PlayerSimulationData playerData) { }

	// RVA: 0x6108D0 Offset: 0x60EED0 VA: 0x1806108D0
	public bool TryGetPlayerDataWithNickname(string playerNickname, out PlayerSimulationData playerData) { }

	// RVA: 0x60E590 Offset: 0x60CB90 VA: 0x18060E590
	public bool IsLocalPlayer(PlayerRef playerRef) { }

	// RVA: -1 Offset: -1
	public List<T> ConvertList<T>(QListPtr<T> quantumListPtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41260 Offset: 0xC3F860 VA: 0x180C41260
	|-StellarSimulationSystem.ConvertList<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x60DA80 Offset: 0x60C080 VA: 0x18060DA80
	public void CheckSpawnOrder() { }

	// RVA: 0x610F20 Offset: 0x60F520 VA: 0x180610F20
	public void .ctor() { }
}
