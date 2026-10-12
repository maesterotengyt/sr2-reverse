// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(SpeedRunnersCharacter))]
[Serializable]
public class SpeedRunnersCharacter_Prototype : PrototypeAdapter<SpeedRunnersCharacter_Prototype> // TypeDefIndex: 3925
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Alive; // 0x18
	public QBoolean IsBoostAlwaysActive; // 0x1C
	public QBoolean HasInfiniteBoost; // 0x20
	public QBoolean FlyModeEnabled; // 0x24
	public QBoolean UsingSR1Physics; // 0x28
	public QBoolean HasSuperSpeed; // 0x2C
	public QBoolean IsSliding; // 0x30
	public QBoolean IsInWallSlide; // 0x34
	public int Rank; // 0x38
	public FP TimeSinceDeath; // 0x40
	public FP DistanceTraveled; // 0x48
	public FPVector2 HookHitPoint; // 0x50
	public FPVector2 LastHookPosition; // 0x60
	public FP HookHitDistance; // 0x70
	public FP CaterpillarWindowFrames; // 0x78
	public int EquipedItemID; // 0x80
	public int ItemUses; // 0x84
	public ItemButtonUseMode_Prototype ItemUseMode; // 0x88
	public FP ItemPowerCharged; // 0x90
	public FP ItemPowerIncrease; // 0x98
	public QBoolean AutoUseItemOnFullCharge; // 0xA0
	public int LastItemUsed; // 0xA4
	public FP ItemUseActiveFrames; // 0xA8
	public int FacingDirectionOnItemUse; // 0xB0
	public FP InviciDrillFrames; // 0xB8
	public FP FreezeFrames; // 0xC0
	public QBoolean PulledByHook; // 0xC8
	public FP ItemUseCooldownFrames; // 0xD0
	public FPVector2 LastValidDirectionForItem; // 0xD8
	public QBoolean IsBoostActive; // 0xE8
	public FP Boost; // 0xF0
	public FP BoostCountdownFrames; // 0xF8
	public FP WallHangCountdownFrames; // 0x100
	public FP HookCooldownFrames; // 0x108
	public FP SlideCooldownFrames; // 0x110
	public FP WallSlideCooldownFrames; // 0x118
	public QBoolean ClearAirJump; // 0x120
	public QBoolean IsJumping; // 0x124
	public FP CurrentJumpFrames; // 0x128
	public FP JumpDuration; // 0x130
	public FPVector2 JumpDirection; // 0x138
	public FPVector2 JumpVelocityBonus; // 0x148
	public FPVector2 JumpVelocity; // 0x158
	public FP JumpPower; // 0x168
	public QBoolean TriggeredInstantJump; // 0x170
	public QBoolean SlideLocked; // 0x174
	public QBoolean IgnoreSlideMinVelocity; // 0x178
	public QBoolean IsSteppingOverLedge; // 0x17C
	public FP SteppingOverLedgeFrames; // 0x180
	public FPVector2 SteppingTargetPosition; // 0x188
	[LocalReference]
	public EntityPrototype LastSuperBoostEntity; // 0x198
	public QBoolean IsInSuperBoost; // 0x1A0
	public SuperBoostDirection_Prototype SuperBoostDirection; // 0x1A4
	public FP SuperBoostCountdownFrames; // 0x1A8
	public FP SlopeSurfNotificationCooldown; // 0x1B0
	public QBoolean IsRunningBackwards; // 0x1B8
	public FP RunningBackwardsTime; // 0x1C0
	[LocalReference]
	public EntityPrototype TargetCheckpoint; // 0x1C8
	public QBoolean EnteredCheckpointGoingForward; // 0x1D0
	public QBoolean EnteredCheckpointGoingBackward; // 0x1D4
	public FP DistanceToFinish; // 0x1D8
	public int Laps; // 0x1E0
	public FP FramesInBlastzone; // 0x1E8
	public QBoolean HasPowerfulTackle; // 0x1F0
	public QBoolean LastIntangibility; // 0x1F4

	// Methods

	// RVA: 0x682830 Offset: 0x680E30 VA: 0x180682830 Slot: 5
	public sealed override SpeedRunnersCharacter_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x682BD0 Offset: 0x6811D0 VA: 0x180682BD0
	public void .ctor() { }
}
