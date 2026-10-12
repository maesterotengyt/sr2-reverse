// Namespace: Quantum
public struct SpeedRunnersCharacter : IComponent // TypeDefIndex: 10036
{
	// Fields
	public QBoolean Alive; // 0x1C
	public QBoolean AutoUseItemOnFullCharge; // 0x20
	public FP Boost; // 0x98
	public FP BoostCountdownFrames; // 0xA0
	public FP CaterpillarWindowFrames; // 0xA8
	public QBoolean ClearAirJump; // 0x24
	public FP CurrentJumpFrames; // 0xB0
	public FP DistanceToFinish; // 0xB8
	public FP DistanceTraveled; // 0xC0
	public QBoolean EnteredCheckpointGoingBackward; // 0x28
	public QBoolean EnteredCheckpointGoingForward; // 0x2C
	public EntityRef Entity; // 0x80
	public int EquipedItemID; // 0x0
	public int FacingDirectionOnItemUse; // 0x4
	public QBoolean FlyModeEnabled; // 0x30
	public FP FramesInBlastzone; // 0xC8
	public FP FreezeFrames; // 0xD0
	public QBoolean HasInfiniteBoost; // 0x34
	public QBoolean HasPowerfulTackle; // 0x38
	public QBoolean HasSuperSpeed; // 0x3C
	public FP HookCooldownFrames; // 0xD8
	public FP HookHitDistance; // 0xE0
	public FPVector2 HookHitPoint; // 0x160
	public QBoolean IgnoreSlideMinVelocity; // 0x40
	public FP InviciDrillFrames; // 0xE8
	public QBoolean IsBoostActive; // 0x44
	public QBoolean IsBoostAlwaysActive; // 0x48
	public QBoolean IsInSuperBoost; // 0x4C
	public QBoolean IsInWallSlide; // 0x50
	public QBoolean IsJumping; // 0x54
	public QBoolean IsRunningBackwards; // 0x58
	public QBoolean IsSliding; // 0x5C
	public QBoolean IsSteppingOverLedge; // 0x60
	public FP ItemPowerCharged; // 0xF0
	public FP ItemPowerIncrease; // 0xF8
	public FP ItemUseActiveFrames; // 0x100
	public FP ItemUseCooldownFrames; // 0x108
	public ItemButtonUseMode ItemUseMode; // 0x18
	public int ItemUses; // 0x8
	public FPVector2 JumpDirection; // 0x170
	public FP JumpDuration; // 0x110
	public FP JumpPower; // 0x118
	public FPVector2 JumpVelocity; // 0x180
	public FPVector2 JumpVelocityBonus; // 0x190
	public int Laps; // 0xC
	public FPVector2 LastHookPosition; // 0x1A0
	public QBoolean LastIntangibility; // 0x64
	public int LastItemUsed; // 0x10
	public EntityRef LastSuperBoostEntity; // 0x88
	public FPVector2 LastValidDirectionForItem; // 0x1B0
	public QBoolean PulledByHook; // 0x68
	public int Rank; // 0x14
	public FP RunningBackwardsTime; // 0x120
	public FP SlideCooldownFrames; // 0x128
	public QBoolean SlideLocked; // 0x6C
	public FP SlopeSurfNotificationCooldown; // 0x130
	public FP SteppingOverLedgeFrames; // 0x138
	public FPVector2 SteppingTargetPosition; // 0x1C0
	public FP SuperBoostCountdownFrames; // 0x140
	public SuperBoostDirection SuperBoostDirection; // 0x78
	public EntityRef TargetCheckpoint; // 0x90
	public FP TimeSinceDeath; // 0x148
	public QBoolean TriggeredInstantJump; // 0x70
	public QBoolean UsingSR1Physics; // 0x74
	public FP WallHangCountdownFrames; // 0x150
	public FP WallSlideCooldownFrames; // 0x158

	// Properties
	public bool WasJustBoosting { get; set; }
	public bool WasJustHanging { get; set; }

	// Methods

	// RVA: 0x212C8B0 Offset: 0x212AEB0 VA: 0x18212C8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212D720 Offset: 0x212BD20 VA: 0x18212D720
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x212EA70 Offset: 0x212D070 VA: 0x18212EA70
	public bool get_WasJustBoosting() { }

	// RVA: 0x212EAB0 Offset: 0x212D0B0 VA: 0x18212EAB0
	public void set_WasJustBoosting(bool value) { }

	// RVA: 0x212EA90 Offset: 0x212D090 VA: 0x18212EA90
	public bool get_WasJustHanging() { }

	// RVA: 0x212EAD0 Offset: 0x212D0D0 VA: 0x18212EAD0
	public void set_WasJustHanging(bool value) { }

	// RVA: 0x212D250 Offset: 0x212B850 VA: 0x18212D250
	internal bool IsFrozen(Frame frame) { }

	// RVA: 0x212CD80 Offset: 0x212B380 VA: 0x18212CD80
	internal FP GetValue(Frame frame, SpeedRunnersCharacterVariable variable) { }

	// RVA: 0x212DCD0 Offset: 0x212C2D0 VA: 0x18212DCD0
	internal void SetValue(Frame frame, SpeedRunnersCharacterVariable variable, FP value) { }

	// RVA: 0x212E250 Offset: 0x212C850 VA: 0x18212E250
	internal void Update(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData) { }

	// RVA: 0x212CFB0 Offset: 0x212B5B0 VA: 0x18212CFB0
	internal void IntegrateJumping(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData, CachedEntityData targetEntityData) { }

	// RVA: 0x212D270 Offset: 0x212B870 VA: 0x18212D270
	internal void OnTrip(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x212DC50 Offset: 0x212C250 VA: 0x18212DC50
	internal void SetBoost(Frame frame, FP boost) { }

	// RVA: 0x212C6A0 Offset: 0x212ACA0 VA: 0x18212C6A0
	internal void AddBoost(Frame frame, FP boostToAdd) { }

	// RVA: 0x212C770 Offset: 0x212AD70 VA: 0x18212C770
	internal void EquipItem(Frame frame, int itemHash, bool force = False) { }

	// RVA: 0x212E210 Offset: 0x212C810 VA: 0x18212E210
	internal void UnequipItem(Frame frame) { }

	// RVA: 0x212E950 Offset: 0x212CF50 VA: 0x18212E950
	internal void UseItem(Frame frame) { }

	// RVA: 0x212E010 Offset: 0x212C610 VA: 0x18212E010
	internal void StartInvinciDrill(Frame frame, FP invicidrillFramesDuration) { }

	// RVA: 0x212E130 Offset: 0x212C730 VA: 0x18212E130
	internal void StopInviciDrill(Frame frame) { }

	// RVA: 0x212D4C0 Offset: 0x212BAC0 VA: 0x18212D4C0
	internal void ReleaseGoldenHook(Frame frame, bool forceRelease = False) { }

	// RVA: 0x212CC80 Offset: 0x212B280 VA: 0x18212CC80
	internal FPVector2 GetSuperBoostDirectionVector() { }

	// RVA: 0x212C760 Offset: 0x212AD60 VA: 0x18212C760
	public bool CheckIfRunningBackwards() { }

	// RVA: 0x212DC90 Offset: 0x212C290 VA: 0x18212DC90
	public void SetDistanceToFinish(FP distance) { }
}
