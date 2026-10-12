// Namespace: Quantum
public struct ContinuousRotation : IComponent // TypeDefIndex: 9977
{
	// Fields
	public QBoolean Active; // 0x0
	public FP InitialRotation; // 0x8
	public FP RotationSpeed; // 0x10

	// Methods

	// RVA: 0x20DB880 Offset: 0x20D9E80 VA: 0x1820DB880 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20DB8C0 Offset: 0x20D9EC0 VA: 0x1820DB8C0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20DB910 Offset: 0x20D9F10 VA: 0x1820DB910
	public void Update(Frame frame, EntityRef entity) { }
}
