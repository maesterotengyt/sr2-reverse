// Namespace: 
public class OnlineModeSelect : MainMenuScreen // TypeDefIndex: 3135
{
	// Fields
	public UINavigator UINavigator; // 0x90
	public UINavigator UINavigatorNo8PlayerOption; // 0x98
	public MenuPlayersHighlight PlayerHighlights; // 0xA0
	public LocalizedString JoiningLobbyString; // 0xA8
	public LocalizedString DisabledDescriptionString; // 0xB0

	// Properties
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x578230 Offset: 0x576830 VA: 0x180578230
	private OnlineManager get_onlineManager() { }

	// RVA: 0x577730 Offset: 0x575D30 VA: 0x180577730 Slot: 4
	public override void Initialize() { }

	// RVA: 0x5776F0 Offset: 0x575CF0 VA: 0x1805776F0
	private UINavigator GetUINavigator() { }

	// RVA: 0x577C70 Offset: 0x576270 VA: 0x180577C70 Slot: 7
	public override void Show() { }

	// RVA: 0x577BC0 Offset: 0x5761C0 VA: 0x180577BC0
	public void SetNavigator(int index) { }

	// RVA: 0x5781B0 Offset: 0x5767B0 VA: 0x1805781B0 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x577A00 Offset: 0x576000 VA: 0x180577A00
	public void SelectQuickMatch() { }

	// RVA: 0x577AE0 Offset: 0x5760E0 VA: 0x180577AE0
	public void SelectRanked() { }

	// RVA: 0x577A70 Offset: 0x576070 VA: 0x180577A70
	public void SelectRanked1v1() { }

	// RVA: 0x5778B0 Offset: 0x575EB0 VA: 0x1805778B0
	public void Select8PlayersMode() { }

	// RVA: 0x577990 Offset: 0x575F90 VA: 0x180577990
	public void SelectPlaygroundMode() { }

	// RVA: 0x577920 Offset: 0x575F20 VA: 0x180577920
	public void SelectCustomMatch() { }

	// RVA: 0x577B50 Offset: 0x576150 VA: 0x180577B50
	public void SelectTournamentMode() { }

	// RVA: 0x577810 Offset: 0x575E10 VA: 0x180577810
	public void ReturnToPreviousScreen() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
