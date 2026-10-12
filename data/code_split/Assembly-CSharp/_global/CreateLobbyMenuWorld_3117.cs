// Namespace: 
public class CreateLobbyMenuWorld : MainMenuWorldScreen // TypeDefIndex: 3117
{
	// Fields
	public Animator SettingsPanelAnimator; // 0x30
	public StellarSelectorOption PrivateLobby; // 0x38
	public StellarSelectorOption PlayerLimitSelector; // 0x40
	public StellarSelectorOption GameModeSelector; // 0x48
	public StellarSelectorOption CPUsSelector; // 0x50
	public StellarSelectorOption CPUsDifficultySelector; // 0x58
	public UINavigator SettingsUINavigator; // 0x60
	public TMP_Text SettingsTitleText; // 0x68
	[Header("Strings")]
	public LocalizedString ConfirmString; // 0x70
	public LocalizedString CreatingLobbyString; // 0x78
	public LocalizedString CreateLobbyString; // 0x80
	public LocalizedString YesString; // 0x88
	public LocalizedString NoString; // 0x90
	public LobbyGameModeData[] GameModes; // 0x98
	[Header("CPU options strings")]
	public LocalizedString NoCPUsString; // 0xA0
	public LocalizedString FillCPUsString; // 0xA8
	public LocalizedString EasyString; // 0xB0
	public LocalizedString MediumString; // 0xB8
	public LocalizedString HardString; // 0xC0
	public LocalizedString UnfairString; // 0xC8
	public LocalizedString RandomString; // 0xD0
	private bool publicLobby; // 0xD8
	private HashString gameModeID; // 0xE0
	private int playerLimit; // 0xF0
	private LobbyCPUsNumberSetting cpuNumberSetting; // 0xF4
	private LobbyCPUDifficulty cpusDifficulty; // 0xF8
	private bool settingsPanelActive; // 0xFC
	private bool creatingLobby; // 0xFD

	// Methods

	// RVA: 0x550110 Offset: 0x54E710 VA: 0x180550110 Slot: 4
	public override void Initialize(MainMenuScreen mainMenuScreen) { }

	// RVA: 0x551290 Offset: 0x54F890 VA: 0x180551290 Slot: 5
	public override void Show() { }

	// RVA: 0x551550 Offset: 0x54FB50 VA: 0x180551550 Slot: 7
	public override void UpdateScreen() { }

	// RVA: 0x550CF0 Offset: 0x54F2F0 VA: 0x180550CF0
	public void ReturnToPreviousScreen() { }

	// RVA: 0x550EB0 Offset: 0x54F4B0 VA: 0x180550EB0
	public void SetPublicLobby(int option) { }

	// RVA: 0x550BD0 Offset: 0x54F1D0 VA: 0x180550BD0
	public void PlayerLimitChanged(int option) { }

	// RVA: 0x550E60 Offset: 0x54F460 VA: 0x180550E60
	public void SetGameMode(int option) { }

	// RVA: 0x54F490 Offset: 0x54DA90 VA: 0x18054F490
	public void CPUsOptionChanged(int option) { }

	// RVA: 0x54F480 Offset: 0x54DA80 VA: 0x18054F480
	public void CPUsDifficultyOptionChanged(int option) { }

	// RVA: 0x550EC0 Offset: 0x54F4C0 VA: 0x180550EC0
	public void ShowLobbyTypePanel() { }

	// RVA: 0x5510C0 Offset: 0x54F6C0 VA: 0x1805510C0
	public void ShowSettingsPanel() { }

	// RVA: 0x550D90 Offset: 0x54F390 VA: 0x180550D90
	public void SetCreatingMode() { }

	// RVA: 0x54F530 Offset: 0x54DB30 VA: 0x18054F530
	public void CreateLobby() { }

	// RVA: 0x54F8A0 Offset: 0x54DEA0 VA: 0x18054F8A0
	private void CreatingLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
