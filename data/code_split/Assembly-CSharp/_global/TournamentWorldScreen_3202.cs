// Namespace: 
public class TournamentWorldScreen : MainMenuWorldScreen // TypeDefIndex: 3202
{
	// Fields
	public List<TournamentPhaseSegment> TournamentPhases; // 0x30
	public TournamentBracketWinnerPanel TournamentBracketWinnerPanel; // 0x38
	public TournamentFindingPanel FindingPanel; // 0x40
	public TMP_Text TimerLabelText; // 0x48
	public TMP_Text TimerLabelShadow; // 0x50
	public TMP_Text TimerText; // 0x58
	public TMP_Text StateText; // 0x60
	public TMP_Text StateShadowText; // 0x68
	public TMP_Text ActiveRoomCount; // 0x70
	public TMP_Text RoundText; // 0x78
	public Animator BraketAnimator; // 0x80
	public Animator RoundLabelAnimator; // 0x88
	public Animator TimerAnimator; // 0x90
	public Animator StateSegmentAnimator; // 0x98
	public List<ScrollingRows> ScrollingRows; // 0xA0
	public LocalizedString RemaingString; // 0xA8
	public LocalizedString HangOn; // 0xB0
	public LocalizedString NextMatchString; // 0xB8
	public LocalizedString GetReadyString; // 0xC0
	public LocalizedString RoundString; // 0xC8
	public LocalizedString SemiFinalsString; // 0xD0
	public LocalizedString FinalsString; // 0xD8
	public RectTransform RoomHighlight; // 0xE0
	public float RoomHighlightSpeed; // 0xE8
	public GameObject SpectatorUI; // 0xF0
	public TournamentRoomSpectatorPreview RoomSpectatorPreview; // 0xF8
	private TournamentState lastState; // 0x100
	private RectTransform roomHighlightTarget; // 0x108
	private int selectedRoomNavigationIndex; // 0x110

	// Methods

	// RVA: 0x5940C0 Offset: 0x5926C0 VA: 0x1805940C0 Slot: 4
	public override void Initialize(MainMenuScreen mainMenuScreen) { }

	// RVA: 0x594C10 Offset: 0x593210 VA: 0x180594C10 Slot: 5
	public override void Show() { }

	// RVA: 0x595260 Offset: 0x593860 VA: 0x180595260
	public void UpdateData() { }

	// RVA: 0x594880 Offset: 0x592E80 VA: 0x180594880
	private void SetData() { }

	// RVA: 0x5960C0 Offset: 0x5946C0 VA: 0x1805960C0 Slot: 7
	public override void UpdateScreen() { }

	// RVA: 0x594560 Offset: 0x592B60 VA: 0x180594560
	public void RoomHighlighted(int roomID, RoomData roomData, List<TournamentPlayer> tournamentPlayers, RectTransform highlightTarget) { }

	// RVA: 0x594600 Offset: 0x592C00 VA: 0x180594600
	public void SelectRoom(int roomID, int navigationIndex) { }

	// RVA: 0x594200 Offset: 0x592800 VA: 0x180594200
	private void JoinAfterLeavingCurrent() { }

	// RVA: 0x596250 Offset: 0x594850 VA: 0x180596250
	private void Update() { }

	// RVA: 0x594350 Offset: 0x592950 VA: 0x180594350
	public void OnDisable() { }

	// RVA: 0x593E90 Offset: 0x592490 VA: 0x180593E90 Slot: 6
	public override void Hide() { }

	// RVA: 0x596550 Offset: 0x594B50 VA: 0x180596550
	public void .ctor() { }
}
