// Namespace: 
public class TournamentRoomSlot : UINavigationElement // TypeDefIndex: 3197
{
	// Fields
	public List<TournamentPlayerSlot> PlayerSlots; // 0x98
	public RectTransform HighlightRef; // 0xA0
	public GameObject MatchActiveHighlight; // 0xA8
	public Animator PlayerSlotsAnimator; // 0xB0
	private TournamentWorldScreen tournamenScreen; // 0xB8
	private List<TournamentPlayer> tournamentPlayers; // 0xC0
	private RoomData roomData; // 0xC8
	private int roomID; // 0xD8
	private bool matchActive; // 0xDC
	private TournamentPhaseData phaseData; // 0xE0

	// Properties
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x592F90 Offset: 0x591590 VA: 0x180592F90
	private OnlineManager get_onlineManager() { }

	// RVA: 0x5920C0 Offset: 0x5906C0 VA: 0x1805920C0
	public void Init(TournamentWorldScreen tournamenScreen) { }

	// RVA: 0x592290 Offset: 0x590890 VA: 0x180592290
	public void SetData(List<TournamentPlayer> tournamentPlayers, RoomData newRoomData, TournamentPhaseData phase) { }

	// RVA: 0x592100 Offset: 0x590700 VA: 0x180592100
	public void OnEnable() { }

	[IteratorStateMachine(typeof(TournamentRoomSlot.<DelayAnimation>d__15))]
	// RVA: 0x592020 Offset: 0x590620 VA: 0x180592020
	private IEnumerator DelayAnimation(float time, string animation) { }

	// RVA: 0x591E40 Offset: 0x590440 VA: 0x180591E40
	public void Clear() { }

	// RVA: 0x592DC0 Offset: 0x5913C0 VA: 0x180592DC0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x591DE0 Offset: 0x5903E0 VA: 0x180591DE0
	public void CallSelection() { }

	// RVA: 0x5921D0 Offset: 0x5907D0 VA: 0x1805921D0
	public void SelectRoom() { }

	// RVA: 0x591DF0 Offset: 0x5903F0 VA: 0x180591DF0
	public bool CanBeSpectated() { }

	// RVA: 0x592EB0 Offset: 0x5914B0 VA: 0x180592EB0
	public void .ctor() { }
}
