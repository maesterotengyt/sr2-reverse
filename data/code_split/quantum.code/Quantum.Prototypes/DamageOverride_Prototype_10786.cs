// Namespace: Quantum.Prototypes
[Prototype(typeof(DamageOverride))]
[Serializable]
public sealed class DamageOverride_Prototype : StructPrototype // TypeDefIndex: 10786
{
	// Fields
	public QBoolean UseSetDamageFromEnemy; // 0x10
	public int EnemySetDamage; // 0x14
	public QBoolean UseSetDamageFromOwner; // 0x18
	public int OwnerSetDamage; // 0x1C
	public QBoolean UseSetDamageFromTeam; // 0x20
	public int TeamSetDamage; // 0x24

	// Methods

	// RVA: 0x2102920 Offset: 0x2100F20 VA: 0x182102920
	public void Materialize(Frame frame, ref DamageOverride result, in PrototypeMaterializationContext context) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
