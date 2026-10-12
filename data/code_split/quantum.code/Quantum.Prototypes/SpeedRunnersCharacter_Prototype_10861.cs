// Namespace: Quantum.Prototypes
[Prototype(typeof(SpeedRunnersCharacter))]
[Serializable]
public sealed class SpeedRunnersCharacter_Prototype : ComponentPrototype<SpeedRunnersCharacter> // TypeDefIndex: 10861
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Alive; // 0x1C
	public QBoolean IsBoostAlwaysActive; // 0x20
	public QBoolean HasInfiniteBoost; // 0x24
	public QBoolean FlyModeEnabled; // 0x28
	public QBoolean UsingSR1Physics; // 0x2C
	public QBoolean HasSuperSpeed; // 0x30
	public QBoolean IsSliding; // 0x34
	public QBoolean IsInWallSlide; // 0x38
	public int Rank; // 0x3C
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
	public MapEntityId LastSuperBoostEntity; // 0x198
	public QBoolean IsInSuperBoost; // 0x19C
	public SuperBoostDirection_Prototype SuperBoostDirection; // 0x1A0
	public FP SuperBoostCountdownFrames; // 0x1A8
	public FP SlopeSurfNotificationCooldown; // 0x1B0
	public QBoolean IsRunningBackwards; // 0x1B8
	public FP RunningBackwardsTime; // 0x1C0
	public MapEntityId TargetCheckpoint; // 0x1C8
	public QBoolean EnteredCheckpointGoingForward; // 0x1CC
	public QBoolean EnteredCheckpointGoingBackward; // 0x1D0
	public FP DistanceToFinish; // 0x1D8
	public int Laps; // 0x1E0
	public FP FramesInBlastzone; // 0x1E8
	public QBoolean HasPowerfulTackle; // 0x1F0
	public QBoolean LastIntangibility; // 0x1F4

	// Methods

	// RVA: 0x210F370 Offset: 0x210D970 VA: 0x18210F370 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210F8C0 Offset: 0x210DEC0 VA: 0x18210F8C0
	public void Materialize(Frame frame, ref SpeedRunnersCharacter result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210F830 Offset: 0x210DE30 VA: 0x18210F830 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210FBE0 Offset: 0x210E1E0 VA: 0x18210FBE0
	public void .ctor() { }
}
