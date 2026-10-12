// Namespace: 
public class MainMenu : SRMonoBehaviour // TypeDefIndex: 3082
{
	// Fields
	[ScreenIDDropdown]
	public string WorkingScreen; // 0x20
	[ScreenIDDropdown]
	public string BuildStartingScreen; // 0x28
	public MainMenuHeader Header; // 0x30
	public MainMenuHeader LeaningHeader; // 0x38
	public ScreenFooter Footer; // 0x40
	public OnlineConnectUI OnlineConnectUI; // 0x48
	public MainMenuStreetTexts CharacterSelectStreetTexts; // 0x50
	public MainMenuStreetTexts LevelSelectStreetTexts; // 0x58
	public TMP_Text BuildingTitleText; // 0x60
	public AssetReference MainMenuAudioBank; // 0x68
	public float DefaultCameraBlend; // 0x70
	public float SameCameraTransitionDuration; // 0x74
	public DiscordButton DiscordButton; // 0x78
	[CompilerGenerated]
	private string <CurrentScreenID>k__BackingField; // 0x80
	[CompilerGenerated]
	private MainMenuScreen <PreviousScreen>k__BackingField; // 0x88
	[CompilerGenerated]
	private OnlineConnectMode <OnlineConnectMode>k__BackingField; // 0x90
	[CompilerGenerated]
	private CharacterSelectBase <CurrentCharacterSelect>k__BackingField; // 0x98
	[CompilerGenerated]
	private CinemachineVirtualCamera <CurrentCamera>k__BackingField; // 0xA0
	private MainMenuScreen[] mainMenuScreens; // 0xA8
	private MainMenuScreen currentScreen; // 0xB0

	// Properties
	public string CurrentScreenID { get; set; }
	public MainMenuScreen PreviousScreen { get; set; }
	public OnlineConnectMode OnlineConnectMode { get; set; }
	public CharacterSelectBase CurrentCharacterSelect { get; set; }
	public CinemachineVirtualCamera CurrentCamera { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x54C330 Offset: 0x54A930 VA: 0x18054C330
	public string get_CurrentScreenID() { }

	[CompilerGenerated]
	// RVA: 0x54C390 Offset: 0x54A990 VA: 0x18054C390
	public void set_CurrentScreenID(string value) { }

	[CompilerGenerated]
	// RVA: 0x531670 Offset: 0x52FC70 VA: 0x180531670
	public MainMenuScreen get_PreviousScreen() { }

	[CompilerGenerated]
	// RVA: 0x54C3B0 Offset: 0x54A9B0 VA: 0x18054C3B0
	public void set_PreviousScreen(MainMenuScreen value) { }

	[CompilerGenerated]
	// RVA: 0x54C340 Offset: 0x54A940 VA: 0x18054C340
	public OnlineConnectMode get_OnlineConnectMode() { }

	[CompilerGenerated]
	// RVA: 0x54C3A0 Offset: 0x54A9A0 VA: 0x18054C3A0
	public void set_OnlineConnectMode(OnlineConnectMode value) { }

	[CompilerGenerated]
	// RVA: 0x54C320 Offset: 0x54A920 VA: 0x18054C320
	public CharacterSelectBase get_CurrentCharacterSelect() { }

	[CompilerGenerated]
	// RVA: 0x54C370 Offset: 0x54A970 VA: 0x18054C370
	public void set_CurrentCharacterSelect(CharacterSelectBase value) { }

	[CompilerGenerated]
	// RVA: 0x54C310 Offset: 0x54A910 VA: 0x18054C310
	public CinemachineVirtualCamera get_CurrentCamera() { }

	[CompilerGenerated]
	// RVA: 0x54C350 Offset: 0x54A950 VA: 0x18054C350
	public void set_CurrentCamera(CinemachineVirtualCamera value) { }

	// RVA: 0x54ADB0 Offset: 0x5493B0 VA: 0x18054ADB0
	private void Awake() { }

	// RVA: 0x54C2C0 Offset: 0x54A8C0 VA: 0x18054C2C0
	private void Update() { }

	// RVA: 0x54BF50 Offset: 0x54A550 VA: 0x18054BF50
	private void OnDestroy() { }

	// RVA: 0x54BA80 Offset: 0x54A080 VA: 0x18054BA80
	public void Initialize() { }

	// RVA: 0x54B0E0 Offset: 0x5496E0 VA: 0x18054B0E0
	private void CheckTransitions() { }

	// RVA: 0x54C220 Offset: 0x54A820 VA: 0x18054C220
	private void ShowFirstScreen(bool gameLaunch, string uiScreenID) { }

	// RVA: 0x54ABD0 Offset: 0x5491D0 VA: 0x18054ABD0
	private void AudioBankLoaded(string identifier) { }

	// RVA: 0x54AFC0 Offset: 0x5495C0 VA: 0x18054AFC0
	public void ChangeScreen(string uiScreenID, string cameraTransition = "", bool force = False) { }

	// RVA: 0x54AE40 Offset: 0x549440 VA: 0x18054AE40
	private void ChangeScreen(MainMenuScreen screen, string cameraTransition = "") { }

	// RVA: 0x54B970 Offset: 0x549F70 VA: 0x18054B970
	private void HideScreenPanels(string excluded = "Undefined") { }

	// RVA: 0x54B880 Offset: 0x549E80 VA: 0x18054B880
	public MainMenuScreen GetMainMenuScreen(string screenID) { }

	// RVA: 0x54C0C0 Offset: 0x54A6C0 VA: 0x18054C0C0
	public void ReturnToPreviousScreen() { }

	// RVA: 0x54B730 Offset: 0x549D30 VA: 0x18054B730
	public void EnableCamera(CinemachineVirtualCamera virtualCamera, float blendTime, string movementSFX = "") { }

	// RVA: 0x54B5D0 Offset: 0x549BD0 VA: 0x18054B5D0
	public void CleanMainMenu() { }

	// RVA: 0x54C150 Offset: 0x54A750 VA: 0x18054C150
	public void SetBuildingText(string text) { }

	// RVA: 0x54C070 Offset: 0x54A670 VA: 0x18054C070
	public void ResetInits() { }

	// RVA: 0x54C2F0 Offset: 0x54A8F0 VA: 0x18054C2F0
	public void .ctor() { }
}
