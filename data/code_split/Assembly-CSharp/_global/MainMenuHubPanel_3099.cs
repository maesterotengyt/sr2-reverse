// Namespace: 
public class MainMenuHubPanel : MainMenuSubPanel // TypeDefIndex: 3099
{
	// Fields
	public Animator MatchmakingSectionAnimator; // 0x48
	public TMP_Text GameModeLabel; // 0x50
	public TMP_Text SearchingGameModeLabel; // 0x58
	public TMP_Text ButtonStateLabel; // 0x60
	public TMP_Text RegionLabel; // 0x68
	public TMP_Text RoomNameLabel; // 0x70
	public TMP_Text TimerLabel; // 0x78
	public TMP_Text StateLabel; // 0x80
	public Image MachmakingModeImage; // 0x88
	public List<MatchmakingModeImage> MatchmakingModeSprites; // 0x90
	public UINavigationElement CancelOption; // 0x98
	public UINavigationElement RunOption; // 0xA0
	public UINavigationElement ModeSelectOption; // 0xA8
	public UINavigationElement TournamentSpectateOption; // 0xB0
	public GameObject JoinTournamentViaCode; // 0xB8
	public RectTransformAutoRebuild JoinTournamentViaCodeRebuild; // 0xC0
	public GameObject ToggleRulesPlayers; // 0xC8
	public TextMeshProUGUI ToggleButtonText; // 0xD0
	public Button ToggleButton; // 0xD8
	public LocalizedString WaitingPlayerString; // 0xE0
	public LocalizedString MatchMakingString; // 0xE8
	public LocalizedString MatchMakingXboxPTString; // 0xF0
	public LocalizedString RankedString; // 0xF8
	public LocalizedString Ranked1v1String; // 0x100
	public LocalizedString QuickPlayString; // 0x108
	public LocalizedString TournamentString; // 0x110
	public LocalizedString QuickPlay8Player; // 0x118
	public LocalizedString PlaygroundsString; // 0x120
	public LocalizedString SearchingString; // 0x128
	public LocalizedString StartingString; // 0x130
	public LocalizedString ViewPlayerListString; // 0x138
	public LocalizedString ViewGameRulesString; // 0x140
	public bool rulesShowing; // 0x148

	// Methods

	// RVA: 0x553EB0 Offset: 0x5524B0 VA: 0x180553EB0 Slot: 4
	public override void Initialize(MainMenuHub newMainMenu) { }

	// RVA: 0x554FF0 Offset: 0x5535F0 VA: 0x180554FF0 Slot: 5
	public override void Show() { }

	// RVA: 0x553F70 Offset: 0x552570 VA: 0x180553F70
	public void SelectJoinTournamentAsSpectator() { }

	// RVA: 0x554070 Offset: 0x552670 VA: 0x180554070
	public void SelectJoinTournamentViaCode() { }

	// RVA: 0x5558C0 Offset: 0x553EC0 VA: 0x1805558C0 Slot: 6
	public override void UpdatePanel() { }

	// RVA: 0x556010 Offset: 0x554610 VA: 0x180556010
	public void UpdateTimer(string time) { }

	// RVA: 0x555710 Offset: 0x553D10 VA: 0x180555710
	public void StartingGame(bool state) { }

	// RVA: 0x553EF0 Offset: 0x5524F0 VA: 0x180553EF0
	private void ResetAllAnimatorTriggers(Animator animator) { }

	// RVA: 0x554230 Offset: 0x552830 VA: 0x180554230
	public void SetMatchmakingMode() { }

	// RVA: 0x554870 Offset: 0x552E70 VA: 0x180554870
	public void SetModeSelectMode() { }

	// RVA: 0x554EC0 Offset: 0x5534C0 VA: 0x180554EC0
	public void ShowRunnerSelect() { }

	// RVA: 0x554170 Offset: 0x552770 VA: 0x180554170
	public void SelectMode() { }

	// RVA: 0x555770 Offset: 0x553D70 VA: 0x180555770
	public void ToggleRules() { }

	[IteratorStateMachine(typeof(MainMenuHubPanel.<FadeToggleText>d__46))]
	// RVA: 0x553D90 Offset: 0x552390 VA: 0x180553D90
	private IEnumerator FadeToggleText(string newText) { }

	[IteratorStateMachine(typeof(MainMenuHubPanel.<Fade>d__47))]
	// RVA: 0x553E20 Offset: 0x552420 VA: 0x180553E20
	private IEnumerator Fade(float startAlpha, float endAlpha) { }

	// RVA: 0x556040 Offset: 0x554640 VA: 0x180556040
	public void .ctor() { }
}
