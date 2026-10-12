// Namespace: Quantum
[Serializable]
public class SpeedRunnersSettingsData : AssetObject // TypeDefIndex: 10181
{
	// Fields
	[Header("Camera")]
	public SimpleAABB DefaultViewPort; // 0x20
	public FP MinZoom; // 0x40
	public FP MaxZoom; // 0x48
	public FP ZoomInSpeed; // 0x50
	public FP ZoomOutSpeed; // 0x58
	public FP MovementSmoothing; // 0x60
	public FPVector2 CameraOffset; // 0x68
	public FPVector2 MaxDistanceToCenter; // 0x78
	public FP MaxSuddenDeathZoom; // 0x88
	public FP SinglePlayerMovementSmoothing; // 0x90
	public FPVector2 SinglePlayerCameraOffset; // 0x98
	[Header("Match")]
	public FP RoundWonSlowdownMultiplier; // 0xA8
	[Header("General VFX")]
	public HashString InviciDrillActiveVFX_ID; // 0xB0
	public HashString InviciDrillGroundedVFX_ID; // 0xC0
	public HashString SwitchActivationVFX_ID; // 0xD0
	[Header("Accolades Cooldown")]
	public int SuperSpeedAccoladeCooldownFrames; // 0xE0
	public int BigAirAccoladeCooldownFrames; // 0xE4
	public int FloorIsLavaAccoladeRequiredFrames; // 0xE8
	[Header("Accolades VFX")]
	public HashString SuperSpeedVFX_ID; // 0xF0
	public HashString DoubleHitVFX_ID; // 0x100
	public HashString TripleHitVFX_ID; // 0x110
	public HashString BackfiredVFX_ID; // 0x120
	public HashString BigAirVFX_ID; // 0x130
	public HashString TackleVFX_ID; // 0x140
	public HashString GotchaVFX_ID; // 0x150
	public HashString RevengeVFX_ID; // 0x160
	public HashString StillAliveVFX_ID; // 0x170
	public HashString DodgedVFX_ID; // 0x180
	public HashString TheDistanceVFX_ID; // 0x190
	public HashString FreezeVFX_ID; // 0x1A0
	public HashString DeflectedVFX_ID; // 0x1B0
	public HashString BlockedVFX_ID; // 0x1C0
	public HashString TreasureVFX_ID; // 0x1D0
	[Header("General SFX")]
	public string SwitchActivationSFX_ID; // 0x1E0
	public string SuddenDeathActivationSFX_ID; // 0x1E8
	public string BoostSFX_ID; // 0x1F0
	[Header("Tutorials")]
	public HashString SlopeSurfGoalID; // 0x1F8
	public HashString ReverseGrappleGoalID; // 0x208
	[Header("Blastzone")]
	public FP BlastzoneMinimalSizePercent; // 0x218
	public FP BlastzoneReduceSpeed; // 0x220
	public FP BlastzoneTimeToForceReduction; // 0x228
	public FP BlastzoneTimeToShowTimer; // 0x230
	public FP LastPlayerFramesInBlastzoneToKO; // 0x238
	public FP NonLastPlayerFramesInBlastzoneToKO; // 0x240
	[Header("Hazards and Items")]
	public FP RocketKnockback; // 0x248
	public FP DefaultAttackKnockback; // 0x250
	[Header("Cooldown")]
	public int HookCooldownFrames; // 0x258
	public int SlideCooldownFrames; // 0x25C
	public int WallSlideCooldownFrames; // 0x260
	public int ObstacleCooldownTime; // 0x264
	public int RoundStartItemUseCooldownFrames; // 0x268
	public int ItemUseCooldownFramesOnPickup; // 0x26C
	[Header("Frame windows")]
	public int ReverseGrappleWindowFrames; // 0x270
	public int CaterpillarWindowFrames; // 0x274
	[Header("Boost")]
	public FP MinBoost; // 0x278
	public FP MaxBoost; // 0x280
	public FP BoostDepletionRate; // 0x288
	public FP BoostFillRate; // 0x290
	public FP SinglePlayerBoostFillMultiplier; // 0x298
	[Header("Jumps")]
	public FP JumpFrames; // 0x2A0
	public FP JumpPower; // 0x2A8
	public FP DoubleJumpPower; // 0x2B0
	public FP WallJumpPower; // 0x2B8
	public FP WallJumpUpwardMotionRetainer; // 0x2C0
	public FP WallJumpAngle; // 0x2C8
	public FP CaterpillarSpeedBoost; // 0x2D0
	[Header("Wall Climb")]
	public FPVector2 AboveWallCheckLinecastStart; // 0x2D8
	public FP AboveWallCheckLinecastDistance; // 0x2E8
	public FP DistanceToStepUp; // 0x2F0
	public FPVector2 StepUpLinecastStart; // 0x2F8
	public FP StepUpLinecastDistance; // 0x308
	public ColorRGBA StepUpLinecastColor; // 0x310
	[Header("Movement")]
	public FP SlopeVelocityInheritanceMultiplier; // 0x318
	public FP UpSlopeMultiplier; // 0x320
	public FP DownSlopeMultiplier; // 0x328
	public FP MaxWalkVelocity; // 0x330
	public FP MaxRunVelocity; // 0x338
	public FP MaxBoostVelocity; // 0x340
	public FP MaxHookVelocity; // 0x348
	public FP MinVelocityToSlide; // 0x350
	public FP MinVelocityForRunTurn; // 0x358
	public FP VelocityForSuperSpeed; // 0x360
	public FP Gravity; // 0x368
	public FP MaxFallSpeed; // 0x370
	[Space(10)]
	public FP MinVelocity; // 0x378
	public FP MinVelocityForTrip; // 0x380
	public FP MinVelocityForDrag; // 0x388
	public FP TerminalVelocity; // 0x390
	[Space(10)]
	public FP BrakeDeceleration; // 0x398
	public FP SlideDeceleration; // 0x3A0
	public FP SlideDecelerationPostBoosting; // 0x3A8
	public FP SlideDecelerationForBoost; // 0x3B0
	public FP BoostDeceleration; // 0x3B8
	[Space(10)]
	public FP WalkAcceleration; // 0x3C0
	public FP RunAcceleration; // 0x3C8
	public FP AirAcceleration; // 0x3D0
	public FP AirAccelerationAfterWallJump; // 0x3D8
	[Space(10)]
	public FP BoostWalkAcceleration; // 0x3E0
	public FP BoostRunAcceleration; // 0x3E8
	public FP BoostAcceleration; // 0x3F0
	[Space(10)]
	public FP GroundDeceleration; // 0x3F8
	public FP AirDeceleration; // 0x400
	[Space(10)]
	public FP MaxSwingSpeed; // 0x408
	public FP SwingDeceleration; // 0x410
	[Space(10)]
	public FP MaxSuperBoostVelocity; // 0x418
	public FP SuperBoostAcceleration; // 0x420
	public FP SuperBoostDeceleration; // 0x428
	[Space(10)]
	public FP StunnedAcceleration; // 0x430
	public FP StunnedTurnAcceleration; // 0x438
	public FP StunnedDeceleration; // 0x440
	public FP StunnedMaxVelocity; // 0x448
	[Header("Slope Surf")]
	public HashString SlopeSurfActivationVFX_ID; // 0x450
	public HashString SlopeSurfActivationSFX_ID; // 0x460
	public FP SlopeSurfVerticalVelocityThreshold; // 0x470
	public int SlopeSurfCooldown; // 0x478
	[Header("General Events")]
	public int FramesToGetBigAir; // 0x47C
	public int AllowedGrappleSwingForBigAir; // 0x480

	// Methods

	// RVA: 0x21482B0 Offset: 0x21468B0 VA: 0x1821482B0
	public void .ctor() { }
}
