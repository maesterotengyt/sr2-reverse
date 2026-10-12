// Namespace: 
public class OnlineHubWorld : MainMenuWorldScreen // TypeDefIndex: 3130
{
	// Fields
	public TMP_Text RankText; // 0x30
	public TMP_Text RankProgressText; // 0x38
	public UINavigator Navigator; // 0x40
	public OnlineMenuOption TournamentModeOption; // 0x48
	public GameObject ComingSoonLabel; // 0x50
	public List<OnlineMenuOption> OnlineMenuOptions; // 0x58
	public LocalizedString JoiningLobbyString; // 0x60
	public LocalizedString DisabledDescriptionString; // 0x68

	// Methods

	// RVA: 0x574660 Offset: 0x572C60 VA: 0x180574660 Slot: 5
	public override void Show() { }

	// RVA: 0x5749C0 Offset: 0x572FC0 VA: 0x1805749C0
	public void ToggleTournamentMode(bool status) { }

	// RVA: 0x573E50 Offset: 0x572450 VA: 0x180573E50
	public void SelectQuickMatch() { }

	// RVA: 0x5742D0 Offset: 0x5728D0 VA: 0x1805742D0
	public void SelectRanked() { }

	// RVA: 0x574090 Offset: 0x572690 VA: 0x180574090
	public void SelectRanked1v1() { }

	// RVA: 0x573960 Offset: 0x571F60 VA: 0x180573960
	public void Select8PlayersMode() { }

	// RVA: 0x574510 Offset: 0x572B10 VA: 0x180574510
	public void SelectTournamentMode() { }

	// RVA: 0x573C10 Offset: 0x572210 VA: 0x180573C10
	public void SelectPlaygroundMode() { }

	// RVA: 0x5745B0 Offset: 0x572BB0 VA: 0x1805745B0
	private void ShowConnectingUI() { }

	// RVA: 0x573690 Offset: 0x571C90 VA: 0x180573690
	private void SearchMatchMakingLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x573BA0 Offset: 0x5721A0 VA: 0x180573BA0
	public void SelectCustomMatch() { }

	// RVA: 0x573620 Offset: 0x571C20 VA: 0x180573620
	public void ReturnToPreviousScreen() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
