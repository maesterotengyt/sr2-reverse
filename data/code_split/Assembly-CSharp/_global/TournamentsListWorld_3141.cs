// Namespace: 
public class TournamentsListWorld : MainMenuWorldScreen // TypeDefIndex: 3141
{
	// Fields
	public Transform Options; // 0x30
	public UINavigator ListUINavigator; // 0x38
	public UINavigator SearchPanelUINavigator; // 0x40
	public GameObject ListPanel; // 0x48
	public GameObject NotFoundPanel; // 0x50
	public GameObject SearchPanel; // 0x58
	public GameObject ScrollBar; // 0x60
	public StellarInputField PasswordInputField; // 0x68
	[Header("Strings")]
	public LocalizedString RefreshString; // 0x70
	public LocalizedString SearchString; // 0x78
	public LocalizedString SearchingString; // 0x80
	public LocalizedString ConfirmString; // 0x88
	public LocalizedString TournamentString; // 0x90
	private TournamentsListWorld.TournamentsListPanel currentPanel; // 0x98
	private List<TournamentData> currentTournaments; // 0xA0
	private string selectedTournamentID; // 0xA8

	// Methods

	// RVA: 0x57D060 Offset: 0x57B660 VA: 0x18057D060 Slot: 4
	public override void Initialize(MainMenuScreen mainMenuScreen) { }

	// RVA: 0x57DC40 Offset: 0x57C240 VA: 0x18057DC40 Slot: 5
	public override void Show() { }

	// RVA: 0x57E1C0 Offset: 0x57C7C0 VA: 0x18057E1C0 Slot: 7
	public override void UpdateScreen() { }

	// RVA: 0x57D280 Offset: 0x57B880 VA: 0x18057D280
	public void RefreshList() { }

	[IteratorStateMachine(typeof(TournamentsListWorld.<RefreshListCoroutine>d__21))]
	// RVA: 0x57D210 Offset: 0x57B810 VA: 0x18057D210
	private IEnumerator RefreshListCoroutine() { }

	// RVA: 0x57D300 Offset: 0x57B900 VA: 0x18057D300
	public void RefreshTournamentsList() { }

	// RVA: 0x57D760 Offset: 0x57BD60 VA: 0x18057D760
	public void SetPanel(TournamentsListWorld.TournamentsListPanel panel) { }

	// RVA: 0x57CE70 Offset: 0x57B470 VA: 0x18057CE70
	private TournamentOption GetOption(int index) { }

	// RVA: 0x57D130 Offset: 0x57B730 VA: 0x18057D130
	public void JoinTournament() { }

	// RVA: 0x57D4D0 Offset: 0x57BAD0 VA: 0x18057D4D0
	public void SelectTournament(string tournamentID) { }

	// RVA: 0x57D390 Offset: 0x57B990 VA: 0x18057D390
	private void RegionChanged(bool success, string errorID) { }

	// RVA: 0x57DBC0 Offset: 0x57C1C0 VA: 0x18057DBC0
	private void ShowErrorJoining() { }

	// RVA: 0x57CD50 Offset: 0x57B350 VA: 0x18057CD50
	public void EnterTournament() { }

	// RVA: 0x57DCF0 Offset: 0x57C2F0 VA: 0x18057DCF0
	public bool TournamentExist(string tournamentID) { }

	// RVA: 0x57CEE0 Offset: 0x57B4E0 VA: 0x18057CEE0
	public string GetTournamentRegion(string tournamentID) { }

	// RVA: 0x57E430 Offset: 0x57CA30 VA: 0x18057E430
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x57DE60 Offset: 0x57C460 VA: 0x18057DE60
	private void <RefreshTournamentsList>b__22_0(bool success, List<TournamentData> list) { }
}
