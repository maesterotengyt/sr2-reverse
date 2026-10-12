// Namespace: Quantum.Physics3D
public struct SpringJoint3D // TypeDefIndex: 11845
{
	// Fields
	public FPVector3 Anchor; // 0x0
	public FPVector3 ConnectedAnchor; // 0x18
	public EntityRef ConnectedEntity; // 0x30
	public FP Spring; // 0x38
	public FP Damper; // 0x40
	public FP Distance; // 0x48

	// Methods

	// RVA: 0x22671D0 Offset: 0x22657D0 VA: 0x1822671D0
	public void .ctor(FP spring, FP damper, FP distance, EntityRef connectedEntity, FPVector3 anchor, FPVector3 connectedAnchor) { }

	// RVA: 0x2266F30 Offset: 0x2265530 VA: 0x182266F30
	public static Joint3D CreateJoint(FP spring, FP damper, FP distance, EntityRef connectedEntity, FPVector3 anchor, FPVector3 connectedAnchor) { }

	// RVA: 0x22670F0 Offset: 0x22656F0 VA: 0x1822670F0
	public void SetStiffness(FP frequency, FP dampingRatio, PhysicsBody3D* jointBody, PhysicsBody3D* connectedBody) { }

	// RVA: 0x2266E40 Offset: 0x2265440 VA: 0x182266E40
	public static void ComputeStiffness(FP frequency, FP dampingRatio, PhysicsBody3D* jointBody, PhysicsBody3D* connectedBody, out FP spring, out FP damper) { }

	// RVA: 0x2267070 Offset: 0x2265670 VA: 0x182267070
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2266FF0 Offset: 0x22655F0 VA: 0x182266FF0 Slot: 2
	public override int GetHashCode() { }
}
