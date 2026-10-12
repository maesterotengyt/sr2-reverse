// Namespace: Quantum
public struct HitInfo // TypeDefIndex: 9926
{
	// Fields
	public FP Angle; // 0x48
	public int AttackDataID; // 0x8
	public FP BlockDamage; // 0x50
	public FP BlockHitLag; // 0x58
	public FP BlockPushDistance; // 0x60
	public FP BlockStun; // 0x68
	public QBoolean Blocked; // 0xC
	public FP DIMultiplier; // 0x70
	public FP Damage; // 0x78
	public FPVector2 Direction; // 0xB8
	public QBoolean Flinchless; // 0x10
	public HitBoxSpecialBehaviour HitBoxHorizontalBehaviour; // 0x4
	public FPVector2 HitBoxPosition; // 0xC8
	public FP HitLag; // 0x80
	public FP HitStun; // 0x88
	public EntityRef Instigator; // 0x28
	public FP InstigatorAdvantageOnBlock; // 0x90
	public FP InstigatorAdvantageOnHit; // 0x98
	public EntityRef InstigatorCharacterEntity; // 0x30
	public FP InstigatorPushBack; // 0xA0
	public QBoolean IsVictimInvincible; // 0x14
	public QBoolean JabLock; // 0x18
	public FP Knockback; // 0xA8
	public QBoolean PerfectBlock; // 0x1C
	public FP SDIMultiplier; // 0xB0
	public QBoolean Trade; // 0x20
	public QBoolean Untechable; // 0x24
	public EntityRef Victim; // 0x38
	public EntityRef VictimCharacterEntity; // 0x40
	public AttackVictimDirection VictimDirection; // 0x0

	// Methods

	// RVA: 0x20CF8E0 Offset: 0x20CDEE0 VA: 0x1820CF8E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CFCA0 Offset: 0x20CE2A0 VA: 0x1820CFCA0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20CFAB0 Offset: 0x20CE0B0 VA: 0x1820CFAB0
	public FP GetValue(HitInfoVariable variable) { }
}
