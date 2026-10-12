// Namespace: Quantum
[Serializable]
public class CombatSettingsData : AssetObject // TypeDefIndex: 10197
{
	// Fields
	public static readonly HashString GrabSlotID; // 0x0
	public static readonly HashString ItemSlotID; // 0x10
	[Header("Stellar Data")]
	public AttackDataValues DefaultAttackValues; // 0x20
	public AttackMultiplier[] AttackValueMultipliers; // 0x110
	public FP HitStunFramesMultiplier; // 0x118
	public FP HitStunFramesAdd; // 0x120
	public FP MaxKnockbackForJabLock; // 0x128
	public int PercentageDifferenceToClank; // 0x130
	public FP RedirectBiasAngleStep; // 0x138
	public FP MaxDamage; // 0x140
	[Header("Sakurai Settings")]
	public FP SakuraiMinKnockbackThreshold; // 0x148
	public FP SakuraiMaxKnockbackThreshold; // 0x150
	[Header("Autolink Settings")]
	public FP AutoLinkGroundedAngle; // 0x158
	public FP AutoLinkSpeedCapFrameCheck; // 0x160
	public FP AutoLinkSpeedCap; // 0x168
	[Header("DI / SDI / ASDI")]
	public FP DefaultDIAngle; // 0x170
	public DIForKnockback[] DIAngles; // 0x178
	[Space(5)]
	public FP SDIThreshold; // 0x180
	public FP SDIMinAngleDifference; // 0x188
	public FP[] SDIDistances; // 0x190
	public FP ASDIDistance; // 0x198
	[Header("Knockback Stack")]
	public FP KnockbackStackMultiplierThreshold; // 0x1A0
	public FP KnockbackStackIgnoreThreshold; // 0x1A8
	[Header("Stamina Settings")]
	public FP BaseDamageForKnockback; // 0x1B0
	public FP ExtraDamageForKnockbackIncreaseRate; // 0x1B8
	public FP MaxExtraDamageForKnockback; // 0x1C0
	public int ExtraDamageForKnockbackResetFrames; // 0x1C8
	[Header("Grabs")]
	public FP DefaultStaminaGrabFrames; // 0x1D0
	public FP DefaultGrabFrames; // 0x1D8
	public FP GrabFramesDamageMultiplier; // 0x1E0
	public FP GrabReboundHitLagFrames; // 0x1E8
	[Space(5)]
	public InputFlag GrabEscapeButton; // 0x1F0
	public FP GrabEscapeMinFrames; // 0x1F8
	public FP GrabButtonMashReducedFrames; // 0x200
	public FP DirectionMashReducedFrames; // 0x208
	[Header("Respawn")]
	public FP RespawnWaitFrames; // 0x210
	[Header("Block & Tech")]
	public InputFlag BlockButton; // 0x218
	[Space(5)]
	public int TechBufferFrames; // 0x21C
	public int TechLockFrames; // 0x220
	[Space(5)]
	public int PerfectBlockFramesRange; // 0x224
	public int PerfectBlockLockFrames; // 0x228
	public int PerfectBlockStunFrames; // 0x22C
	public int PerfectBlockInstigatorHitLagFrames; // 0x230
	public int PerfectBlockVictimHitLagFrames; // 0x234
	[Space(5)]
	public int BlockBreakHitLagFrames; // 0x238
	public int BlockBreakMinimumStun; // 0x23C
	public FP BlockBreakExtraStunMultiplier; // 0x240
	[Space(5)]
	public FP MaxBlockStamina; // 0x248
	public FP BlockStaminaDecreaseRate; // 0x250
	public FP BlockStaminaRecoveryRate; // 0x258
	[Header("Charge Attacks")]
	public int GroundAttackMaxChargeFrames; // 0x260
	public int FramesToReleaseChargeGroundAttack; // 0x264
	public int AirAttackMaxChargeFrames; // 0x268
	public int FramesToReleaseChargeAirAttack; // 0x26C

	// Methods

	// RVA: 0x20AAC60 Offset: 0x20A9260 VA: 0x1820AAC60
	internal FP GetHitLagMultiplier(Frame frame) { }

	// RVA: 0x2150B20 Offset: 0x214F120 VA: 0x182150B20
	public FP CalculateDIAngle(FP knockback) { }

	// RVA: 0x2150B90 Offset: 0x214F190 VA: 0x182150B90
	public FP GetRedirectAngle(FP originalAngle) { }

	// RVA: 0x2150BE0 Offset: 0x214F1E0 VA: 0x182150BE0
	public bool TryGetAttackMultiplier(int identifierHash, out AttackDataValues attackValues) { }

	// RVA: 0x2150E90 Offset: 0x214F490 VA: 0x182150E90
	public void .ctor() { }

	// RVA: 0x2150DC0 Offset: 0x214F3C0 VA: 0x182150DC0
	private static void .cctor() { }
}
