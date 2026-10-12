// Namespace: Quantum
[Serializable]
public struct MoveLimit // TypeDefIndex: 9931
{
	// Fields
	public const int SIZE = 20;
	public const int ALIGNMENT = 4;
	public int MaxUses; // 0x0
	public QBoolean ResetOnHurt; // 0x8
	public QBoolean SpendGrounded; // 0xC
	public QBoolean SpendInAir; // 0x10
	[HideInInspector]
	public int UsesAvailable; // 0x4

	// Methods

	// RVA: 0x20D0650 Offset: 0x20CEC50 VA: 0x1820D0650 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20D06A0 Offset: 0x20CECA0 VA: 0x1820D06A0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
