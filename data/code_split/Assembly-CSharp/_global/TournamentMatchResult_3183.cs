// Namespace: 
public class TournamentMatchResult : MainMenuScreen // TypeDefIndex: 3183
{
	// Fields
	public TournamentResultScreenDebugMode DebugMode; // 0x90
	public HashString DebugCharacter; // 0x98
	public TextMeshProUGUI[] PlayerNames; // 0xA8
	public BadgePlatformIcon[] BadgePlatformIcons; // 0xB0
	public TournamentMatchResultPlayerStats[] PlayerStats; // 0xB8
	public TournamentMatchResultCharacterSpawner[] CharacterContainers; // 0xC0
	public LocalizedString TournamentOverString; // 0xC8
	public LocalizedString TournamentOverDescriptionString; // 0xD0
	public LocalizedString ContinueAsSpectatorString; // 0xD8
	public LocalizedString ReturnToMainMenuString; // 0xE0
	public GameObject PlayerNamesFooter; // 0xE8
	public GameObject WinnerFooter; // 0xF0
	public Animator FooterAnimator; // 0xF8
	public CancelHoldBar CancelHoldBar; // 0x100
	public float ThrowBombsStateTime; // 0x108
	public float ShowStatsStateTime; // 0x10C
	public float WaitWinnersExitStateTime; // 0x110
	public float QualifiedStateTime; // 0x114
	public float WonTournamentStateTime; // 0x118
	public float HideElementsBeforeSeconds; // 0x11C
	private const string tournamentOverPopupID = "tournament_over_popup";
	private TournamentResultState currentState; // 0x120
	private float currentStateTime; // 0x124
	private bool isFinalRound; // 0x128
	private bool isLocalPlayerEliminated; // 0x129
	private int totalCharactersToLoad; // 0x12C
	private bool charactersLoadedAndReady; // 0x130

	// Properties
	private GameStateManager gameStateManager { get; }
	private OnlineManager onlineManager { get; }
	private UIManager uiManager { get; }
	protected AudioManager audioManager { get; }

	// Methods

	// RVA: 0x591050 Offset: 0x58F650 VA: 0x180591050
	private GameStateManager get_gameStateManager() { }

	// RVA: 0x5910A0 Offset: 0x58F6A0 VA: 0x1805910A0
	private OnlineManager get_onlineManager() { }

	// RVA: 0x5910F0 Offset: 0x58F6F0 VA: 0x1805910F0
	private UIManager get_uiManager() { }

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	protected AudioManager get_audioManager() { }

	// RVA: 0x58FC40 Offset: 0x58E240 VA: 0x18058FC40 Slot: 4
	public override void Initialize() { }

	// RVA: 0x58FA50 Offset: 0x58E050 VA: 0x18058FA50 Slot: 8
	public override void Hide() { }

	// RVA: 0x590200 Offset: 0x58E800 VA: 0x180590200 Slot: 7
	public override void Show() { }

	// RVA: 0x590BB0 Offset: 0x58F1B0 VA: 0x180590BB0 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x58FE10 Offset: 0x58E410 VA: 0x18058FE10
	private void OnCharacterInstanceFinished() { }

	// RVA: 0x58EE50 Offset: 0x58D450 VA: 0x18058EE50
	private void ChangeState(TournamentResultState newState) { }

	// RVA: 0x58FEB0 Offset: 0x58E4B0 VA: 0x18058FEB0
	private void OnTournamentOverOptionSelected(string popupID, int option) { }

	// RVA: 0x590E90 Offset: 0x58F490 VA: 0x180590E90
	public void .ctor() { }
}
