// Namespace: Quantum
[Serializable]
public class RaceGameMode : SpeedRunnersBaseGameMode // TypeDefIndex: 10400
{
	// Fields
	public FP WaitTimeBetweenRounds; // 0x68
	public FP WaitTimeToReturnToMainMenu; // 0x70
	public FP WaitTimeToShowBanners; // 0x78
	[Header("Time modifiers")]
	public GameSpeedModifier SlowdownTimeModifier; // 0x80

	// Methods

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 27
	protected virtual bool StartMatchAutomatically() { }

	// RVA: 0x21A9A10 Offset: 0x21A8010 VA: 0x1821A9A10
	public static bool TryFindRaceModeManager(Frame frame, out RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A8E60 Offset: 0x21A7460 VA: 0x1821A8E60 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21A9970 Offset: 0x21A7F70 VA: 0x1821A9970 Slot: 28
	protected virtual void StartMatch(Frame frame) { }

	// RVA: 0x21A96A0 Offset: 0x21A7CA0 VA: 0x1821A96A0 Slot: 13
	public override void OnUpdate(Frame frame) { }

	// RVA: 0x21A7BA0 Offset: 0x21A61A0 VA: 0x1821A7BA0 Slot: 29
	public virtual void OnRaceFinishedUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A95F0 Offset: 0x21A7BF0 VA: 0x1821A95F0 Slot: 30
	public virtual void OnRoundWaitUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A9250 Offset: 0x21A7850 VA: 0x1821A9250 Slot: 31
	public virtual void OnPlayingUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A8DE0 Offset: 0x21A73E0 VA: 0x1821A8DE0 Slot: 32
	public virtual void OnCountdownUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A8D20 Offset: 0x21A7320 VA: 0x1821A8D20 Slot: 33
	public virtual void OnCountdownUpdateOver(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A7120 Offset: 0x21A5720 VA: 0x1821A7120 Slot: 34
	public virtual void OnBannerShowUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A8970 Offset: 0x21A6F70 VA: 0x1821A8970 Slot: 11
	public override void OnCharacterKnockOut(Frame frame, EntityRef entity) { }

	// RVA: 0x21A8EC0 Offset: 0x21A74C0 VA: 0x1821A8EC0 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x21A8850 Offset: 0x21A6E50 VA: 0x1821A8850 Slot: 12
	public override bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x21A9800 Offset: 0x21A7E00 VA: 0x1821A9800 Slot: 35
	protected virtual void ResetRound(Frame frame) { }

	// RVA: 0x21A68D0 Offset: 0x21A4ED0 VA: 0x1821A68D0
	protected bool IsCountdownOver(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A84B0 Offset: 0x21A6AB0 VA: 0x1821A84B0 Slot: 36
	protected virtual EntityRef GetWinnerCharacter(Frame frame) { }

	// RVA: 0x21A8630 Offset: 0x21A6C30 VA: 0x1821A8630
	public void KnockOutLastPlayer(Frame frame) { }

	// RVA: 0x21A6860 Offset: 0x21A4E60 VA: 0x1821A6860 Slot: 17
	public override bool HasMatchEnded(Frame frame) { }

	// RVA: 0x21A9B60 Offset: 0x21A8160 VA: 0x1821A9B60
	public void .ctor() { }
}
