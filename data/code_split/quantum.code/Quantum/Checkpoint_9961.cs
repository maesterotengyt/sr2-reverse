// Namespace: Quantum
public struct Checkpoint : IComponent // TypeDefIndex: 9961
{
	// Fields
	public QBoolean Active; // 0x0
	public FP DistanceToFinish; // 0x10
	public EntityRef RespawnPoint; // 0x8
	public QBoolean StartPoint; // 0x4

	// Methods

	// RVA: 0x20CCB50 Offset: 0x20CB150 VA: 0x1820CCB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CCD20 Offset: 0x20CB320 VA: 0x1820CCD20
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20CCBA0 Offset: 0x20CB1A0 VA: 0x1820CCBA0
	public void OnBodyEnter(Frame frame, EntityRef triggerEntity, EntityRef otherEntity) { }

	// RVA: 0x20CCC70 Offset: 0x20CB270 VA: 0x1820CCC70
	public void OnBodyExit(Frame frame, EntityRef triggerEntity, EntityRef otherEntity) { }
}
