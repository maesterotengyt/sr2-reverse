// Namespace: Quantum.Prototypes
[Prototype(typeof(HitInfo))]
[Serializable]
public sealed class HitInfo_Prototype : StructPrototype // TypeDefIndex: 10812
{
	// Fields
	public int AttackDataID; // 0x10
	public MapEntityId InstigatorCharacterEntity; // 0x14
	public MapEntityId VictimCharacterEntity; // 0x18
	public MapEntityId Instigator; // 0x1C
	public MapEntityId Victim; // 0x20
	public AttackVictimDirection_Prototype VictimDirection; // 0x24
	public HitBoxSpecialBehaviour_Prototype HitBoxHorizontalBehaviour; // 0x28
	public QBoolean Flinchless; // 0x2C
	public QBoolean JabLock; // 0x30
	public QBoolean IsVictimInvincible; // 0x34
	public QBoolean Blocked; // 0x38
	public QBoolean PerfectBlock; // 0x3C
	public QBoolean Trade; // 0x40
	public QBoolean Untechable; // 0x44
	public FP Knockback; // 0x48
	public FP BlockPushDistance; // 0x50
	public FP BlockStun; // 0x58
	public FP HitStun; // 0x60
	public FP DIMultiplier; // 0x68
	public FP SDIMultiplier; // 0x70
	public FP HitLag; // 0x78
	public FP BlockHitLag; // 0x80
	public FP Damage; // 0x88
	public FP BlockDamage; // 0x90
	public FP Angle; // 0x98
	public FP InstigatorAdvantageOnHit; // 0xA0
	public FP InstigatorAdvantageOnBlock; // 0xA8
	public FP InstigatorPushBack; // 0xB0
	public FPVector2 Direction; // 0xB8
	public FPVector2 HitBoxPosition; // 0xC8

	// Methods

	// RVA: 0x21071D0 Offset: 0x21057D0 VA: 0x1821071D0
	public void Materialize(Frame frame, ref HitInfo result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
