// Namespace: Quantum
public struct RespawnPoint : IComponent // TypeDefIndex: 10026
{
	// Fields
	public RespawnDirection Direction; // 0x4
	public QBoolean IsInitial; // 0x0
	[HideInInspector]
	public EntityRef NextCheckPoint; // 0x8

	// Methods

	// RVA: 0x212B4A0 Offset: 0x2129AA0 VA: 0x18212B4A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212B4C0 Offset: 0x2129AC0 VA: 0x18212B4C0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
