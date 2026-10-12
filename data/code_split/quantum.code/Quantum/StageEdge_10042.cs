// Namespace: Quantum
public struct StageEdge : IComponent // TypeDefIndex: 10042
{
	// Fields
	public QBoolean Active; // 0x4
	public EdgeSide EdgeSide; // 0x0
	[HideInInspector]
	public EntityRef GrabbedEntity; // 0x8

	// Methods

	// RVA: 0x2130540 Offset: 0x212EB40 VA: 0x182130540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2130560 Offset: 0x212EB60 VA: 0x182130560
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
