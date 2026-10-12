// Namespace: 
public class UIManager : SRMonoBehaviour // TypeDefIndex: 3257
{
	// Fields
	public GameObject UIPanel; // 0x20
	public OnlineAuthenticate OnlineAuthenticate; // 0x28
	public LoadingUIManager LoadingUIManager; // 0x30
	public PopupManager PopupManager; // 0x38
	public AutoSaveIcon AutoSaveIcon; // 0x40
	public GameObject Watermark; // 0x48
	public ChatBoxManager ChatBoxManager; // 0x50
	public ReportWindow ReportWindow; // 0x58
	public RewardUnlockedPopup RewardUnlockedPopup; // 0x60
	public FPSDebugger FPSDebugger; // 0x68
	[Header("Data Files")]
	public MainMenuData MainMenuData; // 0x70
	public PlayerCustomizationData PlayerCustomizationData; // 0x78
	public InputLocalizationData InputLocalizationData; // 0x80
	public CustomData CustomData; // 0x88
	public AdvancedTutorialUIData AdvancedTutorialsUIData; // 0x90
	public ItemsUIData ItemsUIData; // 0x98
	public CampaignBossUIData BossesUIData; // 0xA0
	public CampaignChapterRanksUIData RanksUIData; // 0xA8
	[Header("Strings")]
	public LocalizedString PlayerShorteningString; // 0xB0
	[CompilerGenerated]
	private SpeedRunnersMatchHUD <MatchHUD>k__BackingField; // 0xB8
	[CompilerGenerated]
	private MainMenu <MainMenu>k__BackingField; // 0xC0
	[CompilerGenerated]
	private bool <ControllerDisconnectAlertEnabled>k__BackingField; // 0xC8
	[CompilerGenerated]
	private bool <OpenBetaAlertDisplayed>k__BackingField; // 0xC9
	public UIManager.OnInputDeviceDisconnected DeviceDisconnected; // 0xD0
	private StringBuilder stringBuilderFull; // 0xD8
	private StringBuilder stringBuilderShort; // 0xE0
	private const float secondToMinute = 0.016666668;
	private const float trimMilisecond = 0.1;

	// Properties
	public SpeedRunnersMatchHUD MatchHUD { get; set; }
	public MainMenu MainMenu { get; set; }
	public bool ControllerDisconnectAlertEnabled { get; set; }
	public bool OpenBetaAlertDisplayed { get; set; }
	public StellarUISystem StellarSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5A9A10 Offset: 0x5A8010 VA: 0x1805A9A10
	public SpeedRunnersMatchHUD get_MatchHUD() { }

	[CompilerGenerated]
	// RVA: 0x545940 Offset: 0x543F40 VA: 0x180545940
	public void set_MatchHUD(SpeedRunnersMatchHUD value) { }

	[CompilerGenerated]
	// RVA: 0x5A9A00 Offset: 0x5A8000 VA: 0x1805A9A00
	public MainMenu get_MainMenu() { }

	[CompilerGenerated]
	// RVA: 0x5A9A90 Offset: 0x5A8090 VA: 0x1805A9A90
	public void set_MainMenu(MainMenu value) { }

	[CompilerGenerated]
	// RVA: 0x5A99F0 Offset: 0x5A7FF0 VA: 0x1805A99F0
	public bool get_ControllerDisconnectAlertEnabled() { }

	[CompilerGenerated]
	// RVA: 0x5A9A80 Offset: 0x5A8080 VA: 0x1805A9A80
	public void set_ControllerDisconnectAlertEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5A9A20 Offset: 0x5A8020 VA: 0x1805A9A20
	public bool get_OpenBetaAlertDisplayed() { }

	[CompilerGenerated]
	// RVA: 0x5A9AB0 Offset: 0x5A80B0 VA: 0x1805A9AB0
	public void set_OpenBetaAlertDisplayed(bool value) { }

	// RVA: 0x5A9A30 Offset: 0x5A8030 VA: 0x1805A9A30
	public StellarUISystem get_StellarSystem() { }

	// RVA: 0x5A8A90 Offset: 0x5A7090 VA: 0x1805A8A90
	public void Initialize() { }

	// RVA: 0x5A85F0 Offset: 0x5A6BF0 VA: 0x1805A85F0
	public string GetCharacterNickname(StellarCharacterData characterData) { }

	// RVA: 0x5A8520 Offset: 0x5A6B20 VA: 0x1805A8520
	public string GetCharacterNickname(EntityRef characterEntity) { }

	// RVA: 0x5A8840 Offset: 0x5A6E40 VA: 0x1805A8840
	public string GetFinalNickname(string nickName) { }

	// RVA: 0x5A8E50 Offset: 0x5A7450 VA: 0x1805A8E50
	private void InputDeviceDisconnected(int inputDeviceIndex) { }

	// RVA: 0x5A8EE0 Offset: 0x5A74E0 VA: 0x1805A8EE0
	private void InputDeviceReconnected(int inputDeviceIndex) { }

	// RVA: 0x5A9150 Offset: 0x5A7750 VA: 0x1805A9150
	private void SavingData() { }

	// RVA: 0x5A88F0 Offset: 0x5A6EF0 VA: 0x1805A88F0
	public void GoToMainMenu(bool closeSimulation = False) { }

	// RVA: 0x5A9170 Offset: 0x5A7770 VA: 0x1805A9170
	public string SecondsToTimeFullFormat(float totalSeconds) { }

	// RVA: 0x5A9320 Offset: 0x5A7920 VA: 0x1805A9320
	public string SecondsToTimeShortFormat(float totalSeconds) { }

	// RVA: 0x5A9450 Offset: 0x5A7A50 VA: 0x1805A9450
	public bool TryGetPlayerCustomization(StellarCharacterData characterData, out PlayerCustomization playerCustomization) { }

	// RVA: 0x5A8F30 Offset: 0x5A7530 VA: 0x1805A8F30
	private void OnDestroy() { }

	// RVA: 0x5A9940 Offset: 0x5A7F40 VA: 0x1805A9940
	public void .ctor() { }
}
