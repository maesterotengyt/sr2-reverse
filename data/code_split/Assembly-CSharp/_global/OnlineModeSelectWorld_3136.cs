// Namespace: 
public class OnlineModeSelectWorld : MainMenuWorldScreen // TypeDefIndex: 3136
{
	// Fields
	public TMP_Text RankText; // 0x30
	public TMP_Text RankProgressText; // 0x38
	public UINavigator Navigator; // 0x40
	public List<OnlineMenuOption> OnlineMenuOptions; // 0x48
	public LocalizedString JoiningLobbyString; // 0x50
	public LocalizedString DisabledDescriptionString; // 0x58

	// Methods

	// RVA: 0x577390 Offset: 0x575990 VA: 0x180577390 Slot: 5
	public override void Show() { }

	// RVA: 0x577670 Offset: 0x575C70 VA: 0x180577670 Slot: 7
	public override void UpdateScreen() { }

	// RVA: 0x577140 Offset: 0x575740 VA: 0x180577140
	public void SelectQuickMatch() { }

	// RVA: 0x577260 Offset: 0x575860 VA: 0x180577260
	public void SelectRanked() { }

	// RVA: 0x5771D0 Offset: 0x5757D0 VA: 0x1805771D0
	public void SelectRanked1v1() { }

	// RVA: 0x576F80 Offset: 0x575580 VA: 0x180576F80
	public void Select8PlayersMode() { }

	// RVA: 0x577080 Offset: 0x575680 VA: 0x180577080
	public void SelectPlaygroundMode() { }

	// RVA: 0x577010 Offset: 0x575610 VA: 0x180577010
	public void SelectCustomMatch() { }

	// RVA: 0x5772F0 Offset: 0x5758F0 VA: 0x1805772F0
	public void SelectTournamentMode() { }

	// RVA: 0x576F10 Offset: 0x575510 VA: 0x180576F10
	public void ReturnToPreviousScreen() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
