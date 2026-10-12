// Namespace: Quantum
public struct AttackDataValuesResult // TypeDefIndex: 10416
{
	// Fields
	public FP Damage; // 0x0
	public FP BlockDamage; // 0x8
	public FP BaseKnockback; // 0x10
	public FP BlockPush; // 0x18
	public FP BlockStun; // 0x20
	public FP DI_Multiplier; // 0x28
	public FP FixedKnockback; // 0x30
	public FP HitStunMinimum; // 0x38
	public FP HitStunMultiplier; // 0x40
	public FP HitLagBaseOnBlock; // 0x48
	public FP HitLagBaseOnHit; // 0x50
	public FP InstigatorAdvantageOnBlock; // 0x58
	public FP InstigatorAdvantageOnHit; // 0x60
	public FP KnockbackGain; // 0x68
	public FP SDI_Multiplier; // 0x70

	// Methods

	// RVA: 0x21B0EB0 Offset: 0x21AF4B0 VA: 0x1821B0EB0
	public static AttackDataValuesResult FromAttackDataValues(AttackDataValues values) { }

	// RVA: 0x21B0C20 Offset: 0x21AF220 VA: 0x1821B0C20
	public void Combine(AttackDataValues values) { }

	// RVA: 0x21B0890 Offset: 0x21AEE90 VA: 0x1821B0890
	public void CombineWithLerp(AttackDataValues values, FP lerpValue) { }
}
