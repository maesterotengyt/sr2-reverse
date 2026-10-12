// Namespace: 
public class MainMenuHub : MainMenuScreen // TypeDefIndex: 3094
{
	// Fields
	[Header("Main Menu Hub")]
	public TMP_Text VersionText; // 0x90
	public UINavigationElement ExitOption; // 0x98
	public MenuPlayersHighlight PlayerHighlights; // 0xA0
	public CinemachineVirtualCamera MatchMakingVirtualCamera; // 0xA8
	public MainMenuCharacterSpawner CharacterSpawner; // 0xB0
	public CharacterDataPanel CharacterDataPanel; // 0xB8
	public MainMenuLobbyManager MainMenuLobbyManager; // 0xC0
	public MainMenuHubPanel MainMenuHubPanel; // 0xC8
	public MainMenuFeedbackPanel FeedbackPanel; // 0xD0
	public UINavigationElement FeedbackButton; // 0xD8
	public RunnerPanel MainMenuRunnerMenu; // 0xE0
	public BadgesPanel BadgesPanel; // 0xE8
	public OnlinePlayerList onlinePlayerList; // 0xF0
	public PlaygroundRulesPanel RulesPanel; // 0xF8
	public MainMenuCostumeFooter MainMenuCostumeFooter; // 0x100
	public TMP_Text OnlineSettingsLabelText; // 0x108
	public UINavigator RunnerMenu; // 0x110
	[Header("Text Colors")]
	public Color CrossplayEnabledColor; // 0x118
	public Color CrossplayDisabledColor; // 0x128
	public Color RegionColor; // 0x138
	[Header("Strings")]
	public LocalizedString ConnectingString; // 0x148
	public LocalizedString OnlineString; // 0x150
	public LocalizedString GameModeString; // 0x158
	public LocalizedString ExitGameString; // 0x160
	public LocalizedString ExitGameWarningString; // 0x168
	public LocalizedString WishlistMessageString; // 0x170
	public LocalizedString WishlistDescriptionString; // 0x178
	public LocalizedString ContinueString; // 0x180
	public LocalizedString OpenWishlistString; // 0x188
	public LocalizedString CrossplayString; // 0x190
	public LocalizedString RegionString; // 0x198
	public LocalizedString YesString; // 0x1A0
	public LocalizedString NoString; // 0x1A8
	private bool exitGameFunctionalityBlocked; // 0x1B0

	// Properties
	private UIManager uiManager { get; }
	private OnlineManager onlineManager { get; }
	private SaveManager saveManager { get; }
	private StellarInputSystem stellarInputSystem { get; }

	// Methods

	// RVA: 0x559690 Offset: 0x557C90 VA: 0x180559690
	private UIManager get_uiManager() { }

	// RVA: 0x5595A0 Offset: 0x557BA0 VA: 0x1805595A0
	private OnlineManager get_onlineManager() { }

	// RVA: 0x5595F0 Offset: 0x557BF0 VA: 0x1805595F0
	private SaveManager get_saveManager() { }

	// RVA: 0x559640 Offset: 0x557C40 VA: 0x180559640
	private StellarInputSystem get_stellarInputSystem() { }

	// RVA: 0x556940 Offset: 0x554F40 VA: 0x180556940 Slot: 4
	public override void Initialize() { }

	// RVA: 0x556EA0 Offset: 0x5554A0 VA: 0x180556EA0 Slot: 5
	public override void Load() { }

	// RVA: 0x556D80 Offset: 0x555380 VA: 0x180556D80 Slot: 6
	public override void LoadFinished() { }

	// RVA: 0x556F00 Offset: 0x555500 VA: 0x180556F00
	private void OnAuthenticationCheckFinished(bool isAuthenticated) { }

	// RVA: 0x5578E0 Offset: 0x555EE0 VA: 0x1805578E0
	private void OnServerInfoRequestFinished() { }

	// RVA: 0x558250 Offset: 0x556850 VA: 0x180558250
	private void ShowIfStillCurrentScreen() { }

	// RVA: 0x5562C0 Offset: 0x5548C0 VA: 0x1805562C0
	private void ConnectOnlineResult(bool success, string errorID) { }

	// RVA: 0x558BB0 Offset: 0x5571B0 VA: 0x180558BB0
	public void UpdateCharacter() { }

	// RVA: 0x557B20 Offset: 0x556120 VA: 0x180557B20
	public void SetCharacter(int characterID, int costume, bool random) { }

	// RVA: 0x557DF0 Offset: 0x5563F0 VA: 0x180557DF0
	private void SetOnlineSettingsLabelText() { }

	// RVA: 0x556050 Offset: 0x554650 VA: 0x180556050
	private void ConfirmPressedOnAlert(string popUpID) { }

	// RVA: 0x5582E0 Offset: 0x5568E0 VA: 0x1805582E0 Slot: 7
	public override void Show() { }

	// RVA: 0x559040 Offset: 0x557640 VA: 0x180559040 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x557580 Offset: 0x555B80 VA: 0x180557580
	public void OnExitOptionSelected(string popUpID, int option) { }

	// RVA: 0x557CF0 Offset: 0x5562F0 VA: 0x180557CF0
	public void SetMatchMakingCamera() { }

	// RVA: 0x557BF0 Offset: 0x5561F0 VA: 0x180557BF0
	public void SetDefaultCamera() { }

	// RVA: 0x5568E0 Offset: 0x554EE0 VA: 0x1805568E0 Slot: 8
	public override void Hide() { }

	// RVA: 0x556760 Offset: 0x554D60 VA: 0x180556760 Slot: 12
	public override void Disable() { }

	// RVA: 0x556840 Offset: 0x554E40 VA: 0x180556840
	internal void HidePlayerList() { }

	// RVA: 0x559550 Offset: 0x557B50 VA: 0x180559550
	public void .ctor() { }
}
