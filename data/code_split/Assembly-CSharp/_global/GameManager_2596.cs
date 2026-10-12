// Namespace: 
public class GameManager : MonoBehaviour // TypeDefIndex: 2596
{
	// Fields
	public static GameManager Instance; // 0x0
	public StellarManager Stellar; // 0x20
	public SceneLoader SceneLoader; // 0x28
	[Header("Managers")]
	public DataManager DataManager; // 0x30
	public SettingsManager SettingsManager; // 0x38
	public SaveManager SaveManager; // 0x40
	public OnlineManager OnlineManager; // 0x48
	public SimulationManager SimulationManager; // 0x50
	public UIManager UIManager; // 0x58
	public AudioManager AudioManager; // 0x60
	public CameraManager CameraManager; // 0x68
	public MatchResourcesManager MatchResourcesManager; // 0x70
	public GameModeManager GameModeManager; // 0x78
	public CheatsManager CheatsManager; // 0x80
	public GameStateManager GameStateManager; // 0x88
	public FileLoadingManager FileLoadingManager; // 0x90
	public InvitationManager InvitationManager; // 0x98
	public AchievementsManager AchievementsManager; // 0xA0
	public AnalyticsManager AnalyticsManager; // 0xA8
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <LaunchAssetsPreloaded>k__BackingField; // 0xB1
	[CompilerGenerated]
	private bool <GameJustStarted>k__BackingField; // 0xB2

	// Properties
	public bool Initialized { get; set; }
	public bool LaunchAssetsPreloaded { get; set; }
	public bool GameJustStarted { get; set; }
	private SaveManager saveManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6F6BF0 Offset: 0x6F51F0 VA: 0x1806F6BF0
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x6F6C70 Offset: 0x6F5270 VA: 0x1806F6C70
	public void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6F6C00 Offset: 0x6F5200 VA: 0x1806F6C00
	public bool get_LaunchAssetsPreloaded() { }

	[CompilerGenerated]
	// RVA: 0x6F6C80 Offset: 0x6F5280 VA: 0x1806F6C80
	public void set_LaunchAssetsPreloaded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6F6BE0 Offset: 0x6F51E0 VA: 0x1806F6BE0
	public bool get_GameJustStarted() { }

	[CompilerGenerated]
	// RVA: 0x6F6C60 Offset: 0x6F5260 VA: 0x1806F6C60
	public void set_GameJustStarted(bool value) { }

	// RVA: 0x6F6C10 Offset: 0x6F5210 VA: 0x1806F6C10
	private SaveManager get_saveManager() { }

	// RVA: 0x6F5A50 Offset: 0x6F4050 VA: 0x1806F5A50
	private void Awake() { }

	// RVA: 0x6F5E30 Offset: 0x6F4430 VA: 0x1806F5E30
	private bool OnWantsToQuit() { }

	// RVA: 0x6F6480 Offset: 0x6F4A80 VA: 0x1806F6480
	private void StellarInitialized() { }

	// RVA: 0x6F5ED0 Offset: 0x6F44D0 VA: 0x1806F5ED0
	private void SaveSystemReady() { }

	// RVA: 0x6F6080 Offset: 0x6F4680 VA: 0x1806F6080
	public void SetDefaultLocalPlayer(bool gameLaunch = False) { }

	// RVA: 0x6F6150 Offset: 0x6F4750 VA: 0x1806F6150
	public void SetDefaultMatchData() { }

	// RVA: 0x6F6310 Offset: 0x6F4910 VA: 0x1806F6310
	public static void SpawnGameManager() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
