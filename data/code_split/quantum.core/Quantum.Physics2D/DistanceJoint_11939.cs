// Namespace: Quantum.Physics2D
public struct DistanceJoint // TypeDefIndex: 11939
{
	// Fields
	public FPVector2 Anchor; // 0x0
	public FPVector2 ConnectedAnchor; // 0x10
	public EntityRef ConnectedEntity; // 0x20
	internal FP _minDistance; // 0x28
	internal FP _maxDistance; // 0x30

	// Methods

	// RVA: 0x21FF750 Offset: 0x21FDD50 VA: 0x1821FF750
	public void .ctor(FP minDistance, FP maxDistance, EntityRef connectedEntity, FPVector2 anchor, FPVector2 connectedAnchor) { }

	// RVA: 0x21FF5C0 Offset: 0x21FDBC0 VA: 0x1821FF5C0
	public static Joint CreateJoint(FP minDistance, FP maxDistance, EntityRef connectedEntity, FPVector2 anchor, FPVector2 connectedAnchor) { }

	// RVA: 0x21FF6E0 Offset: 0x21FDCE0 VA: 0x1821FF6E0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x21FF670 Offset: 0x21FDC70 VA: 0x1821FF670 Slot: 2
	public override int GetHashCode() { }
}
