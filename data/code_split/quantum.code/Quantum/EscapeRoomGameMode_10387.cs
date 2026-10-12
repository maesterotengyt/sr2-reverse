// Namespace: Quantum
[Serializable]
public class EscapeRoomGameMode : SpeedRunnersBaseGameMode // TypeDefIndex: 10387
{
	// Fields
	public FP WaitTimeBetweenRounds; // 0x68
	public FP WaitTimeToReturnToMainMenu; // 0x70
	public FP WaitTimeToShowBanners; // 0x78
	[Header("EscapeRoom Data")]
	public EscapeRoomCourse[] Courses; // 0x80
	public GameSpeedModifier DialogueSpeedModifier; // 0x88
	public GameSpeedModifier EndSlowDownSpeedModifier; // 0xA8

	// Methods

	// RVA: 0x21A11F0 Offset: 0x219F7F0 VA: 0x1821A11F0
	public static bool TryFindManager(Frame frame, out EscapeRoomGameModeManager* escapeRoomManager) { }

	// RVA: 0x21A0950 Offset: 0x219EF50 VA: 0x1821A0950 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21A1170 Offset: 0x219F770 VA: 0x1821A1170 Slot: 27
	public virtual void StartMatch(Frame frame) { }

	// RVA: 0x21A0D90 Offset: 0x219F390 VA: 0x1821A0D90 Slot: 13
	public override void OnUpdate(Frame frame) { }

	// RVA: 0x21A0A70 Offset: 0x219F070 VA: 0x1821A0A70
	public void OnPlayingUpdate(Frame frame, EscapeRoomGameModeManager* escapeRoomManager) { }

	// RVA: 0x21994F0 Offset: 0x2197AF0 VA: 0x1821994F0
	protected bool IsCountdownOver(Frame frame, EscapeRoomGameModeManager* escapeRoomGameModeManager) { }

	// RVA: 0x21A0CD0 Offset: 0x219F2D0 VA: 0x1821A0CD0 Slot: 28
	public virtual void OnRaceFinishedUpdate(Frame frame, EscapeRoomGameModeManager* escapeRoomGameModeManager) { }

	// RVA: 0x21A0670 Offset: 0x219EC70 VA: 0x1821A0670 Slot: 29
	public virtual void OnCountdownUpdate(Frame frame, EscapeRoomGameModeManager* escapeRoomGameModeManager) { }

	// RVA: 0x21A05F0 Offset: 0x219EBF0 VA: 0x1821A05F0 Slot: 30
	public virtual void OnCountdownUpdateOver(Frame frame, EscapeRoomGameModeManager* escapeRoomGameModeManager) { }

	// RVA: 0x21A03B0 Offset: 0x219E9B0 VA: 0x1821A03B0 Slot: 31
	public virtual void OnBannerShowUpdate(Frame frame, EscapeRoomGameModeManager* escapeRoomGameModeManager) { }

	// RVA: 0x21A06F0 Offset: 0x219ECF0 VA: 0x1821A06F0
	public void OnCourseInfoSetup(Frame frame, string currentCourseID, bool hasDialogue, int difficulty) { }

	// RVA: 0x21A0190 Offset: 0x219E790 VA: 0x1821A0190
	public void CompleteCourse(Frame frame, EscapeRoomGameModeManager* escapeRoomManager) { }

	// RVA: 0x21A1110 Offset: 0x219F710 VA: 0x1821A1110
	protected void RestartCourse(Frame frame, EscapeRoomGameModeManager* escapeRoomManager) { }

	// RVA: 0x21A09A0 Offset: 0x219EFA0 VA: 0x1821A09A0 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x21A0450 Offset: 0x219EA50 VA: 0x1821A0450
	public void OnCampaignDialogueFinished(Frame frame) { }

	// RVA: 0x21A0230 Offset: 0x219E830 VA: 0x1821A0230 Slot: 32
	protected virtual EntityRef GetWinnerCharacter(Frame frame) { }

	// RVA: 0x21A04B0 Offset: 0x219EAB0 VA: 0x1821A04B0
	public void OnCampaignForceWin(Frame frame) { }

	// RVA: 0x21A13D0 Offset: 0x219F9D0 VA: 0x1821A13D0
	public void .ctor() { }
}
