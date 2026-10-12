// Namespace: Quantum
[Serializable]
public class BossFightGameMode : SpeedRunnersBaseGameMode // TypeDefIndex: 10399
{
	// Fields
	public FP WaitTimeBetweenRounds; // 0x68
	public FP WaitTimeToReturnToMainMenu; // 0x70
	public FP WaitTimeToShowBanners; // 0x78
	public FP PlayerStamina; // 0x80
	public FP[] BossStamina; // 0x88
	public FP BlastzonePercentage; // 0x90
	public FP BlastzoneDamage; // 0x98
	public FP IntagibilityFrames; // 0xA0
	public bool RoundLost; // 0xA8
	public int PlayerIntangibilityFramesOnHurt; // 0xAC
	public string BossDifficultyVariableID; // 0xB0
	[Header("Time modifiers")]
	public GameSpeedModifier SlowdownTimeModifier; // 0xB8
	public GameSpeedModifier DialogueSpeedModifier; // 0xD8

	// Methods

	// RVA: 0x219ACD0 Offset: 0x21992D0 VA: 0x18219ACD0
	public static bool TryFindBossFightModeManager(Frame frame, out BossFightGameModeManager* bossFightGameModeManager) { }

	// RVA: 0x219A2C0 Offset: 0x21988C0 VA: 0x18219A2C0 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21995D0 Offset: 0x2197BD0 VA: 0x1821995D0 Slot: 27
	public virtual void OnBossFightInfoSetup(Frame frame, bool hasDialogue, int difficulty) { }

	// RVA: 0x2199E30 Offset: 0x2198430 VA: 0x182199E30 Slot: 8
	public override void OnCharacterSpawn(Frame frame, EntityRef entity, CharacterSpawnData characterSpawnData) { }

	// RVA: 0x219AAD0 Offset: 0x21990D0 VA: 0x18219AAD0 Slot: 28
	public virtual void StartMatch(Frame frame) { }

	// RVA: 0x219A860 Offset: 0x2198E60 VA: 0x18219A860 Slot: 13
	public override void OnUpdate(Frame frame) { }

	// RVA: 0x2199A60 Offset: 0x2198060 VA: 0x182199A60 Slot: 12
	public override bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x219A6F0 Offset: 0x2198CF0 VA: 0x18219A6F0 Slot: 29
	public virtual void OnRaceFinishedUpdate(Frame frame, BossFightGameModeManager* bossFightGameModeManager) { }

	// RVA: 0x219A560 Offset: 0x2198B60 VA: 0x18219A560 Slot: 30
	public virtual void OnPlayerWon(Frame frame) { }

	// RVA: 0x219A500 Offset: 0x2198B00 VA: 0x18219A500 Slot: 31
	public virtual void OnPlayerLost(Frame frame) { }

	// RVA: 0x219A7C0 Offset: 0x2198DC0 VA: 0x18219A7C0 Slot: 32
	public virtual void OnRoundWaitUpdate(Frame frame, BossFightGameModeManager* bossFightGameModeManager) { }

	// RVA: 0x219A660 Offset: 0x2198C60 VA: 0x18219A660 Slot: 33
	public virtual void OnPlayingUpdate(Frame frame, BossFightGameModeManager* bossFightGameModeManager) { }

	// RVA: 0x219A240 Offset: 0x2198840 VA: 0x18219A240 Slot: 34
	public virtual void OnCountdownUpdate(Frame frame, BossFightGameModeManager* BossFightGameModeManager) { }

	// RVA: 0x219A020 Offset: 0x2198620 VA: 0x18219A020 Slot: 35
	public virtual void OnCountdownUpdateOver(Frame frame, BossFightGameModeManager* bossFightGameModeManager) { }

	// RVA: 0x2199530 Offset: 0x2197B30 VA: 0x182199530 Slot: 36
	public virtual void OnBannerShowUpdate(Frame frame, BossFightGameModeManager* bossFightGameModeManager) { }

	// RVA: 0x219A2F0 Offset: 0x21988F0 VA: 0x18219A2F0 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x2199EE0 Offset: 0x21984E0 VA: 0x182199EE0 Slot: 10
	public override void OnCharacterStaminaUpdate(Frame frame, EntityRef entity, FP newStaminaValue) { }

	// RVA: 0x21994F0 Offset: 0x2197AF0 VA: 0x1821994F0
	protected bool IsCountdownOver(Frame frame, BossFightGameModeManager* bossFightGameModeManager) { }

	// RVA: 0x2199980 Offset: 0x2197F80 VA: 0x182199980 Slot: 37
	public virtual void OnCampaignDialogueFinished(Frame frame) { }

	// RVA: 0x2199060 Offset: 0x2197660 VA: 0x182199060 Slot: 38
	protected virtual EntityRef GetWinnerCharacter(Frame frame) { }

	// RVA: 0x21991C0 Offset: 0x21977C0 VA: 0x1821991C0 Slot: 17
	public override bool HasMatchEnded(Frame frame) { }

	// RVA: 0x2199A20 Offset: 0x2198020 VA: 0x182199A20
	public void OnCampaignForceWin(Frame frame) { }

	// RVA: 0x219AE20 Offset: 0x2199420 VA: 0x18219AE20
	public void .ctor() { }
}
