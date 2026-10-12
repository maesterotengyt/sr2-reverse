// Namespace: Quantum
[Serializable]
public struct AttackDataValues // TypeDefIndex: 10414
{
	// Fields
	public AttackDataValue Damage; // 0x0
	public AttackDataValue BlockDamage; // 0x10
	public AttackDataValue BaseKnockback; // 0x20
	public AttackDataValue BlockPush; // 0x30
	public AttackDataValue BlockStun; // 0x40
	public AttackDataValue DIMultiplier; // 0x50
	public AttackDataValue FixedKnockback; // 0x60
	public AttackDataValue HitStunMinimum; // 0x70
	public AttackDataValue HitStunMultiplier; // 0x80
	public AttackDataValue HitLagBaseOnBlock; // 0x90
	public AttackDataValue HitLagBaseOnHit; // 0xA0
	public AttackDataValue InstigatorAdvantageOnBlock; // 0xB0
	public AttackDataValue InstigatorAdvantageOnHit; // 0xC0
	public AttackDataValue KnockbackGain; // 0xD0
	public AttackDataValue SDIMultiplier; // 0xE0

	// Methods

	// RVA: 0x2197670 Offset: 0x2195C70 VA: 0x182197670
	public HitInfo GenerateHitInfo(Frame frame, AttackData attackData, CombatSettingsData combatSettingsData, HitResult hitResult) { }

	// RVA: 0x21970C0 Offset: 0x21956C0 VA: 0x1821970C0
	internal FP CalculateAngle(Frame frame, AttackData attackData, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FPVector2 hitBoxPosition, int facingDirection) { }

	// RVA: 0x2197250 Offset: 0x2195850 VA: 0x182197250
	private FPVector2 CalculateLaunchDirection(Frame frame, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FPVector2 hitBoxPosition, SpecialAnglePreset specialAngle, FP angle, FP knockback, int facingDirection, bool reversible) { }
}
