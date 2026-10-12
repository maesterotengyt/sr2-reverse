// Namespace: 
public class StellarManager : MonoBehaviour // TypeDefIndex: 3309
{
	// Fields
	public static StellarManager.OnStellarInitialized StellarInitialized; // 0x0
	public static StellarManager Instance; // 0x8
	public bool AutoInitialize; // 0x20
	[Header("Stellar Systems")]
	public StellarDataSystem DataSystem; // 0x28
	public StellarSettingsSystem SettingsSystem; // 0x30
	public StellarInputSystem InputSystem; // 0x38
	public StellarSaveSystem SaveSystem; // 0x40
	public StellarOnlineSystem OnlineSystem; // 0x48
	public StellarSimulationSystem SimulationSystem; // 0x50
	public StellarUISystem UISystem; // 0x58
	public StellarAudioSystem AudioSystem; // 0x60
	public StellarCameraSystem CameraSystem; // 0x68
	public StellarDLCSystem DLCSystem; // 0x70
	public StellarSceneLoadingSystem SceneLoadingSystem; // 0x78
	public StellarFileLoadingSystem FileLoadingSystem; // 0x80
	public StellarGameModeSystem GameModeSystem; // 0x88
	public StellarGameTimeSystem GameTimeSystem; // 0x90
	public StellarDebugSystem DebugSystem; // 0x98
	public StellarPlatformSystem PlatformSystem; // 0xA0
	public StellarData Data; // 0xA8
	[CompilerGenerated]
	private LoadingState <LoadingState>k__BackingField; // 0xB0

	// Properties
	public LoadingState LoadingState { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C61E0 Offset: 0x5C47E0 VA: 0x1805C61E0
	public LoadingState get_LoadingState() { }

	[CompilerGenerated]
	// RVA: 0x5C61F0 Offset: 0x5C47F0 VA: 0x1805C61F0
	public void set_LoadingState(LoadingState value) { }

	// RVA: 0x5C5BC0 Offset: 0x5C41C0 VA: 0x1805C5BC0
	private void Awake() { }

	// RVA: 0x5C5E30 Offset: 0x5C4430 VA: 0x1805C5E30
	public void Initialization() { }

	// RVA: 0x5C60F0 Offset: 0x5C46F0 VA: 0x1805C60F0
	public void PlatformInitialized() { }

	// RVA: 0x5C5D10 Offset: 0x5C4310 VA: 0x1805C5D10
	public string GetFullGameVersion() { }

	// RVA: 0x5C5DA0 Offset: 0x5C43A0 VA: 0x1805C5DA0
	public string GetVersionBuildString() { }

	// RVA: 0x5C5F90 Offset: 0x5C4590 VA: 0x1805C5F90
	private BuildManifest LoadBuildManifest() { }

	// RVA: 0x5C5F70 Offset: 0x5C4570 VA: 0x1805C5F70
	public bool IsLoadingActive() { }

	// RVA: 0x5C6080 Offset: 0x5C4680 VA: 0x1805C6080
	private void OnApplicationQuit() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
