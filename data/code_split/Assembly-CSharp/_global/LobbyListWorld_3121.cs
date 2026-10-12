// Namespace: 
public class LobbyListWorld : MainMenuWorldScreen // TypeDefIndex: 3121
{
	// Fields
	public Transform LobbyOptions; // 0x30
	public UINavigator UINavigator; // 0x38
	public GameObject LobbyListPanel; // 0x40
	public GameObject NoLobbiesPanel; // 0x48
	public GameObject ScrollBar; // 0x50
	[Header("Strings")]
	public LocalizedString LobbyNameString; // 0x58
	public LocalizedString SearchingLobbiesString; // 0x60
	public LocalizedString JoiningLobbyString; // 0x68
	public LocalizedString RefreshString; // 0x70
	public LocalizedString PublicLobbiesString; // 0x78
	public LocalizedString ErrorLobbyFullString; // 0x80

	// Methods

	// RVA: 0x570580 Offset: 0x56EB80 VA: 0x180570580 Slot: 4
	public override void Initialize(MainMenuScreen mainMenuScreen) { }

	// RVA: 0x571620 Offset: 0x56FC20 VA: 0x180571620 Slot: 5
	public override void Show() { }

	// RVA: 0x5716C0 Offset: 0x56FCC0 VA: 0x1805716C0 Slot: 7
	public override void UpdateScreen() { }

	// RVA: 0x570A20 Offset: 0x56F020 VA: 0x180570A20
	public void RefreshLobbies() { }

	[IteratorStateMachine(typeof(LobbyListWorld.<RefreshCoroutine>d__15))]
	// RVA: 0x5709B0 Offset: 0x56EFB0 VA: 0x1805709B0
	private IEnumerator RefreshCoroutine() { }

	// RVA: 0x570AA0 Offset: 0x56F0A0 VA: 0x180570AA0
	public void RefreshRoomList() { }

	// RVA: 0x5715A0 Offset: 0x56FBA0 VA: 0x1805715A0
	private void SetFooter() { }

	// RVA: 0x5710C0 Offset: 0x56F6C0 VA: 0x1805710C0
	public void SelectLobby(string photomRoomID) { }

	// RVA: 0x570670 Offset: 0x56EC70 VA: 0x180570670
	private void JoinLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x570510 Offset: 0x56EB10 VA: 0x180570510
	private LobbyOption GetLobbyOption(int index) { }

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0
	private bool IsNumberOfPlayersValid(int playersNumber) { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
