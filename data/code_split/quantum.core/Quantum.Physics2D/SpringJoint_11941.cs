// Namespace: Quantum.Physics2D
public struct SpringJoint // TypeDefIndex: 11941
{
	// Fields
	public FPVector2 Anchor; // 0x0
	public FPVector2 ConnectedAnchor; // 0x10
	public EntityRef ConnectedEntity; // 0x20
	public FP Spring; // 0x28
	public FP Damper; // 0x30
	public FP Distance; // 0x38

	// Methods

	// RVA: 0x22039C0 Offset: 0x2201FC0 VA: 0x1822039C0
	public void .ctor(FP spring, FP damper, FP distance, EntityRef connectedEntity, FPVector2 anchor, FPVector2 connectedAnchor) { }

	// RVA: 0x2203770 Offset: 0x2201D70 VA: 0x182203770
	public static Joint CreateJoint(FP spring, FP damper, FP distance, EntityRef connectedEntity, FPVector2 anchor, FPVector2 connectedAnchor) { }

	// RVA: 0x22038E0 Offset: 0x2201EE0 VA: 0x1822038E0
	public void SetStiffness(FP frequency, FP dampingRatio, PhysicsBody2D* jointBody, PhysicsBody2D* connectedBody) { }

	// RVA: 0x2203680 Offset: 0x2201C80 VA: 0x182203680
	public static void ComputeStiffness(FP frequency, FP dampingRatio, PhysicsBody2D* jointBody, PhysicsBody2D* connectedBody, out FP spring, out FP damper) { }

	// RVA: 0x2203860 Offset: 0x2201E60 VA: 0x182203860
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x22037E0 Offset: 0x2201DE0 VA: 0x1822037E0 Slot: 2
	public override int GetHashCode() { }
}
