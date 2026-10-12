// Namespace: Quantum
[Serializable]
public struct EntityHitFilter // TypeDefIndex: 9919
{
	// Fields
	public const int SIZE = 68;
	public const int ALIGNMENT = 4;
	public QBoolean AlwaysIfTeam; // 0x18
	public CombatInteractionPolicy CharacterInteractionPolicy; // 0x0
	public DamageOverride DamageOverrideInfo; // 0x2C
	public QBoolean DamageOwner; // 0x1C
	public QBoolean DamagedByOwner; // 0x20
	public CombatInteractionPolicy HazardInteractionPolicy; // 0x4
	public QBoolean IgnoreEnemy; // 0x24
	public QBoolean IsAlwaysEnemy; // 0x28
	public CombatInteractionPolicy ItemInteractionPolicy; // 0x8
	public CombatInteractionPolicy ProjectileInteractionPolicy; // 0xC
	public CombatInteractionPolicy SameOwnerInteractionPolicy; // 0x10
	public CombatInteractionPolicy StageInteractionPolicy; // 0x14

	// Methods

	// RVA: 0x20CDCB0 Offset: 0x20CC2B0 VA: 0x1820CDCB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CDD80 Offset: 0x20CC380 VA: 0x1820CDD80
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
