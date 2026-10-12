// Namespace: 
public class CharacterSelectOnline : CharacterSelectBase // TypeDefIndex: 3008
{
	// Fields
	public LocalizedString RequiredPlayersTipString; // 0xC8
	public LocalizedString CPUPrefixString; // 0xD0
	public Transform Badges; // 0xD8
	public TMP_Text PlayersReady; // 0xE0
	public TMP_Text PasswordText; // 0xE8
	public GameObject PasswordToggle; // 0xF0
	public LocalizedString PlayersReadyFormat; // 0xF8
	public GameObject InviteButton; // 0x100
	public GameObject ChatPrompt; // 0x108
	[Header("CPUs")]
	public GameObject CPUsContainer; // 0x110
	public Image CPUsDifficultyBackground; // 0x118
	public TextProxy CPUsDifficultyText; // 0x120
	public CPUDifficultyVisualData EasyVisualData; // 0x128
	public CPUDifficultyVisualData MediumVisualData; // 0x140
	public CPUDifficultyVisualData HardVisualData; // 0x158
	public CPUDifficultyVisualData UnfairVisualData; // 0x170
	public CPUDifficultyVisualData RandomVisualData; // 0x188
	[Header("Timer")]
	public GameObject Timer; // 0x1A0
	public TMP_Text TimerText; // 0x1A8
	private bool passwordHidden; // 0x1B0
	private int previousPlayerCount; // 0x1B4
	private bool foundBlockedPlayerPopup; // 0x1B8
	private bool leavingLobby; // 0x1B9
	public LocalizedString BlockedPlayerInMatchString; // 0x1C0
	public LocalizedString BlockedPlayerInMatchDescriptionString; // 0x1C8
	public Image Xbutton; // 0x1D0
	public UINavigator badgesNavigator; // 0x1D8
	public UINavigator characterPanelNavigator; // 0x1E0
	private bool isInputBadges; // 0x1E8

	// Methods

	// RVA: 0x78AD90 Offset: 0x789390 VA: 0x18078AD90 Slot: 5
	public override void Load() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void ToggleBadgesInput() { }

	// RVA: 0x78A720 Offset: 0x788D20 VA: 0x18078A720
	public void DisableBadgesInput() { }

	// RVA: 0x78AC10 Offset: 0x789210 VA: 0x18078AC10 Slot: 8
	public override void Hide() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnBlockedListUpdate() { }

	// RVA: 0x78C800 Offset: 0x78AE00 VA: 0x18078C800 Slot: 7
	public override void Show() { }

	// RVA: 0x78B340 Offset: 0x789940 VA: 0x18078B340
	private void OnOtherPlayerJoined(Player otherPlayer) { }

	// RVA: 0x78C620 Offset: 0x78AC20 VA: 0x18078C620
	private void SetBadgesFocusButton() { }

	// RVA: 0x78B650 Offset: 0x789C50 VA: 0x18078B650
	private void OtherPlayerLeavePhotonRoom(Player otherPlayer) { }

	// RVA: 0x78B840 Offset: 0x789E40 VA: 0x18078B840
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x78C660 Offset: 0x78AC60 VA: 0x18078C660
	private void ShowBlockedPlayerPopup() { }

	// RVA: 0x78B1B0 Offset: 0x7897B0 VA: 0x18078B1B0
	public void OnBlockedPlayerFoundOptionSelected(string popUpID, int optionIndex) { }

	// RVA: 0x78D220 Offset: 0x78B820 VA: 0x18078D220
	private void StartMatch() { }

	// RVA: 0x78D550 Offset: 0x78BB50 VA: 0x18078D550 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x78D3F0 Offset: 0x78B9F0 VA: 0x18078D3F0
	public void TogglePassword() { }

	// RVA: 0x78D410 Offset: 0x78BA10 VA: 0x18078D410
	public void TogglePassword(bool hidden) { }

	// RVA: 0x78ABA0 Offset: 0x7891A0 VA: 0x18078ABA0
	private CharacterSelectOnlineBadge GetBadge(int index) { }

	// RVA: 0x78C5B0 Offset: 0x78ABB0 VA: 0x18078C5B0 Slot: 13
	public override void ReturnToPreviousScreen(string screen = "Undefined", string cameraTransition = "") { }

	// RVA: 0x78AD50 Offset: 0x789350 VA: 0x18078AD50
	public void LeaveLobby() { }

	// RVA: 0x78C3E0 Offset: 0x78A9E0 VA: 0x18078C3E0
	private void ReturnToOnlineMenu() { }

	// RVA: 0x78A7B0 Offset: 0x788DB0 VA: 0x18078A7B0 Slot: 12
	public override void Disable() { }

	// RVA: 0x78D6F0 Offset: 0x78BCF0 VA: 0x18078D6F0
	public void .ctor() { }
}
