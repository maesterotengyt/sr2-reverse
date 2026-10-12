// Namespace: Quantum.Prototypes
[Prototype(typeof(EntityHitFilter))]
[Serializable]
public sealed class EntityHitFilter_Prototype : StructPrototype // TypeDefIndex: 10792
{
	// Fields
	public QBoolean DamagedByOwner; // 0x10
	public QBoolean DamageOwner; // 0x14
	public QBoolean AlwaysIfTeam; // 0x18
	public QBoolean IsAlwaysEnemy; // 0x1C
	public QBoolean IgnoreEnemy; // 0x20
	public DamageOverride_Prototype DamageOverrideInfo; // 0x28
	public CombatInteractionPolicy_Prototype CharacterInteractionPolicy; // 0x30
	public CombatInteractionPolicy_Prototype ProjectileInteractionPolicy; // 0x34
	public CombatInteractionPolicy_Prototype ItemInteractionPolicy; // 0x38
	public CombatInteractionPolicy_Prototype HazardInteractionPolicy; // 0x3C
	public CombatInteractionPolicy_Prototype StageInteractionPolicy; // 0x40
	public CombatInteractionPolicy_Prototype SameOwnerInteractionPolicy; // 0x44

	// Methods

	// RVA: 0x2103A90 Offset: 0x2102090 VA: 0x182103A90
	public void Materialize(Frame frame, ref EntityHitFilter result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
