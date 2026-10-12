// Namespace: Quantum
public struct SimpleLineRenderer : IComponent // TypeDefIndex: 10033
{
	// Fields
	public EntityRef Entity; // 0x10
	public FPVector2 PointA; // 0x18
	public SimpleLineEndRotationMode PointARotationMode; // 0x4
	public FPVector2 PointB; // 0x28
	public SimpleLineEndRotationMode PointBRotationMode; // 0x8
	public QBoolean Visible; // 0x0

	// Methods

	// RVA: 0x212B770 Offset: 0x2129D70 VA: 0x18212B770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212B7D0 Offset: 0x2129DD0 VA: 0x18212B7D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
