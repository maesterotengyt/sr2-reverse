// Namespace: Quantum.Physics3D
public struct DistanceJoint3D // TypeDefIndex: 11843
{
	// Fields
	public FPVector3 Anchor; // 0x0
	public FPVector3 ConnectedAnchor; // 0x18
	public EntityRef ConnectedEntity; // 0x30
	internal FP _minDistance; // 0x38
	internal FP _maxDistance; // 0x40

	// Methods

	// RVA: 0x2263FE0 Offset: 0x22625E0 VA: 0x182263FE0
	public void .ctor(FP minDistance, FP maxDistance, EntityRef connectedEntity, FPVector3 anchor, FPVector3 connectedAnchor) { }

	// RVA: 0x2263DF0 Offset: 0x22623F0 VA: 0x182263DF0
	public static Joint3D CreateJoint(FP minDistance, FP maxDistance, EntityRef connectedEntity, FPVector3 anchor, FPVector3 connectedAnchor) { }

	// RVA: 0x2263F70 Offset: 0x2262570 VA: 0x182263F70
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2263F00 Offset: 0x2262500 VA: 0x182263F00 Slot: 2
	public override int GetHashCode() { }
}
