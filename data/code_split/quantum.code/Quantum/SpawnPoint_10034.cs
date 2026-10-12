// Namespace: Quantum
public struct SpawnPoint : IComponent // TypeDefIndex: 10034
{
	// Fields
	public SpawnPointDirection FacingDirection; // 0x4
	public QString128 ID; // 0x18
	public int Order; // 0x0
	[HideInInspector]
	public FPVector2 Position; // 0x8

	// Methods

	// RVA: 0x212B8A0 Offset: 0x2129EA0 VA: 0x18212B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212B8F0 Offset: 0x2129EF0 VA: 0x18212B8F0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
