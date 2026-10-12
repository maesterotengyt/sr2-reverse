// Namespace: Quantum
public struct HitResult // TypeDefIndex: 10420
{
	// Fields
	public GameEntityType InstigatorType; // 0x0
	public CombatEntity Instigator; // 0x8
	public CombatEntity Victim; // 0x40
	public HitBox* HitBox; // 0x78
	public HurtBox* HurtBox; // 0x80
	public int AttackDataID; // 0x88
	public bool HittingOwner; // 0x8C
	public bool HitFromOwner; // 0x8D
	public bool SameTeam; // 0x8E
	public int FacingDirection; // 0x90
	public FP Distance; // 0x98
	public HitInfo HitInfo; // 0xA0

	// Methods

	// RVA: 0x21B8670 Offset: 0x21B6C70 VA: 0x1821B8670
	public void .ctor(GameEntityType instigatorType, CombatEntity instigator, CombatEntity victim, HitBox* hitBox, HurtBox* hurtBox, int attackDataID, bool hittingOwner, bool hitFromOwner, bool sameTeam, int facingDirection, FP distance) { }

	// RVA: 0x21B8360 Offset: 0x21B6960 VA: 0x1821B8360
	public void GenerateHitInfo(Frame frame, CombatSettingsData combatSettingsData) { }
}
