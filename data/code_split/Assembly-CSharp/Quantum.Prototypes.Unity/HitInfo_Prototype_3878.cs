// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(HitInfo))]
[Serializable]
public class HitInfo_Prototype : PrototypeAdapter<HitInfo_Prototype> // TypeDefIndex: 3878
{
	// Fields
	public int AttackDataID; // 0x10
	[LocalReference]
	public EntityPrototype InstigatorCharacterEntity; // 0x18
	[LocalReference]
	public EntityPrototype VictimCharacterEntity; // 0x20
	[LocalReference]
	public EntityPrototype Instigator; // 0x28
	[LocalReference]
	public EntityPrototype Victim; // 0x30
	public AttackVictimDirection_Prototype VictimDirection; // 0x38
	public HitBoxSpecialBehaviour_Prototype HitBoxHorizontalBehaviour; // 0x3C
	public QBoolean Flinchless; // 0x40
	public QBoolean JabLock; // 0x44
	public QBoolean IsVictimInvincible; // 0x48
	public QBoolean Blocked; // 0x4C
	public QBoolean PerfectBlock; // 0x50
	public QBoolean Trade; // 0x54
	public QBoolean Untechable; // 0x58
	public FP Knockback; // 0x60
	public FP BlockPushDistance; // 0x68
	public FP BlockStun; // 0x70
	public FP HitStun; // 0x78
	public FP DIMultiplier; // 0x80
	public FP SDIMultiplier; // 0x88
	public FP HitLag; // 0x90
	public FP BlockHitLag; // 0x98
	public FP Damage; // 0xA0
	public FP BlockDamage; // 0xA8
	public FP Angle; // 0xB0
	public FP InstigatorAdvantageOnHit; // 0xB8
	public FP InstigatorAdvantageOnBlock; // 0xC0
	public FP InstigatorPushBack; // 0xC8
	public FPVector2 Direction; // 0xD0
	public FPVector2 HitBoxPosition; // 0xE0

	// Methods

	// RVA: 0x6777B0 Offset: 0x675DB0 VA: 0x1806777B0 Slot: 5
	public sealed override HitInfo_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677970 Offset: 0x675F70 VA: 0x180677970
	public void .ctor() { }
}
