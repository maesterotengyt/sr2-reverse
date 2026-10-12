// Namespace: Quantum
[Serializable]
public struct DamageOverride // TypeDefIndex: 9918
{
	// Fields
	public const int SIZE = 24;
	public const int ALIGNMENT = 4;
	public int EnemySetDamage; // 0x0
	public int OwnerSetDamage; // 0x4
	public int TeamSetDamage; // 0x8
	public QBoolean UseSetDamageFromEnemy; // 0xC
	public QBoolean UseSetDamageFromOwner; // 0x10
	public QBoolean UseSetDamageFromTeam; // 0x14

	// Methods

	// RVA: 0x20CDB70 Offset: 0x20CC170 VA: 0x1820CDB70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CDBD0 Offset: 0x20CC1D0 VA: 0x1820CDBD0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
