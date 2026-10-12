// Namespace: Quantum
public class CombatUtils // TypeDefIndex: 10686
{
	// Methods

	// RVA: 0x20EA210 Offset: 0x20E8810 VA: 0x1820EA210
	public static void CalculateAttackDamage(Frame frame, Combat* instigator, Combat* victim, AttackData attackData, bool checkForDamageOverride, bool hitFromOwner, bool sameTeam, out FP damage, out FP blockDamage) { }

	// RVA: 0x20EA3A0 Offset: 0x20E89A0 VA: 0x1820EA3A0
	public static FP CalculateAttackKnockback(Frame frame, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FP baseKnockback, FP knockbackGain, FP ratio) { }

	// RVA: 0x20EA5E0 Offset: 0x20E8BE0 VA: 0x1820EA5E0
	public static FP CalculateHitStun(FP knockback, FP hitStunMultiplier, FP hitStunMinimum, FP globalhitStunMultiplier, FP hitStunFramesAdd) { }

	// RVA: 0x20EA6B0 Offset: 0x20E8CB0 VA: 0x1820EA6B0
	public static FP CalculateMaxClankHitlagFrames(CombatSettingsData combatSettingsData, AttackData attackData1, AttackData attackData2) { }

	// RVA: 0x20EA720 Offset: 0x20E8D20 VA: 0x1820EA720
	public static FP CalculateMinClankHitlagFrames(CombatSettingsData combatSettingsData, AttackData attackData1, AttackData attackData2) { }

	// RVA: 0x20EAD80 Offset: 0x20E9380 VA: 0x1820EAD80
	public static void ExecuteSimpleAttack(Frame frame, int attackDataHash, EntityRef instigatorEntity, EntityRef victimEntity) { }

	// RVA: 0x20EA790 Offset: 0x20E8D90 VA: 0x1820EA790
	public static bool CanEntitiesInteract(Frame frame, CombatEntity check, CombatEntity target, out bool hittingOwner, out bool hitFromOwner, out bool sameTeam, out int facingDirection) { }

	// RVA: 0x20EAD50 Offset: 0x20E9350 VA: 0x1820EAD50
	private static bool CanInteractBasedOnPolicy(CombatInteractionPolicy checkInteractionPolicy, CombatInteractionPolicy targetInteractionPolicy) { }

	// RVA: 0x20EB5B0 Offset: 0x20E9BB0 VA: 0x1820EB5B0
	private static CombatInteractionPolicy GetInteractionPolicy(Frame frame, Combat* combat, GameEntityType entityType) { }

	// RVA: 0x20EB550 Offset: 0x20E9B50 VA: 0x1820EB550
	public static int GetHitPriorityForEntityType(GameEntityType entityType) { }

	// RVA: 0x20EB510 Offset: 0x20E9B10 VA: 0x1820EB510
	public static int GetHitBoxTypePriority(HitBoxType hitBoxType) { }

	// RVA: 0x20EA620 Offset: 0x20E8C20 VA: 0x1820EA620
	public static FP CalculateHorizontalHitDirection(Frame frame, HitBoxSpecialBehaviour hitBoxHorizontalBehaviour, FPVector2 hitBoxPosition, EntityRef victim) { }

	// RVA: 0x20EA510 Offset: 0x20E8B10 VA: 0x1820EA510
	public static FP CalculateDIAngle(FPVector2 launchVector, FPVector2 inputVector, FP maxDIAngle) { }
}
