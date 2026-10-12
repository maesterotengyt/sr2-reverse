// Namespace: Quantum
[Serializable]
public class PlatformFightGameMode : SpeedRunnersBaseGameMode // TypeDefIndex: 10404
{
	// Fields
	public FP WaitTimeBetweenRounds; // 0x68
	public FP WaitTimeToReturnToMainMenu; // 0x70
	public FP WaitTimeToShowBanners; // 0x78
	[Header("Time modifiers")]
	public GameSpeedModifier SlowdownTimeModifier; // 0x80

	// Methods

	// RVA: 0x21A8290 Offset: 0x21A6890 VA: 0x1821A8290
	public static bool TryFindGameModeManager(Frame frame, out PlatformFightGameModeManager* speedBrosGameModeManager) { }

	// RVA: 0x21A7670 Offset: 0x21A5C70 VA: 0x1821A7670 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21A8070 Offset: 0x21A6670 VA: 0x1821A8070 Slot: 27
	protected virtual void StartMatch(Frame frame) { }

	// RVA: 0x21A7CD0 Offset: 0x21A62D0 VA: 0x1821A7CD0 Slot: 13
	public override void OnUpdate(Frame frame) { }

	// RVA: 0x21A7BA0 Offset: 0x21A61A0 VA: 0x1821A7BA0 Slot: 28
	public virtual void OnRaceFinishedUpdate(Frame frame, PlatformFightGameModeManager* gameModeManager) { }

	// RVA: 0x21A7C30 Offset: 0x21A6230 VA: 0x1821A7C30 Slot: 29
	public virtual void OnRoundWaitUpdate(Frame frame, PlatformFightGameModeManager* gameModeManager) { }

	// RVA: 0x21A7A10 Offset: 0x21A6010 VA: 0x1821A7A10 Slot: 30
	public virtual void OnPlayingUpdate(Frame frame, PlatformFightGameModeManager* gameModeManager) { }

	// RVA: 0x21A75F0 Offset: 0x21A5BF0 VA: 0x1821A75F0 Slot: 31
	public virtual void OnCountdownUpdate(Frame frame, PlatformFightGameModeManager* gameModeManager) { }

	// RVA: 0x21A7540 Offset: 0x21A5B40 VA: 0x1821A7540 Slot: 32
	public virtual void OnCountdownUpdateOver(Frame frame, PlatformFightGameModeManager* gameModeManager) { }

	// RVA: 0x21A7120 Offset: 0x21A5720 VA: 0x1821A7120 Slot: 33
	public virtual void OnBannerShowUpdate(Frame frame, PlatformFightGameModeManager* gameModeManager) { }

	// RVA: 0x21A6910 Offset: 0x21A4F10 VA: 0x1821A6910 Slot: 26
	public override void MovePlayersToRespawnPoints(Frame frame, bool initialSpawn) { }

	// RVA: 0x21A7230 Offset: 0x21A5830 VA: 0x1821A7230 Slot: 11
	public override void OnCharacterKnockOut(Frame frame, EntityRef entity) { }

	// RVA: 0x21A76D0 Offset: 0x21A5CD0 VA: 0x1821A76D0 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x21A71C0 Offset: 0x21A57C0 VA: 0x1821A71C0 Slot: 12
	public override bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x21A7E00 Offset: 0x21A6400 VA: 0x1821A7E00
	protected void ResetRound(Frame frame) { }

	// RVA: 0x21A68D0 Offset: 0x21A4ED0 VA: 0x1821A68D0
	private bool IsCountdownOver(Frame frame, PlatformFightGameModeManager* gameModeManager) { }

	// RVA: 0x21A66E0 Offset: 0x21A4CE0 VA: 0x1821A66E0 Slot: 34
	protected virtual EntityRef GetWinnerCharacter(Frame frame) { }

	// RVA: 0x21A6860 Offset: 0x21A4E60 VA: 0x1821A6860 Slot: 17
	public override bool HasMatchEnded(Frame frame) { }

	// RVA: 0x21A6570 Offset: 0x21A4B70 VA: 0x1821A6570
	private int GetNewLoserRank(Frame frame) { }

	// RVA: 0x21A83E0 Offset: 0x21A69E0 VA: 0x1821A83E0
	public void .ctor() { }
}
