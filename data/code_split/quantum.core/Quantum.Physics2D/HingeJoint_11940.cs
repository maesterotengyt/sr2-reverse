// Namespace: Quantum.Physics2D
public struct HingeJoint // TypeDefIndex: 11940
{
	// Fields
	public FPVector2 Anchor; // 0x0
	public FPVector2 ConnectedAnchor; // 0x10
	public EntityRef ConnectedEntity; // 0x20
	internal int _useAngleLimits; // 0x28
	internal int _useMotor; // 0x2C
	public FP LowerLimitRad; // 0x30
	public FP UpperLimitRad; // 0x38
	public FP MotorSpeed; // 0x40
	public FP MaxMotorTorque; // 0x48

	// Methods

	// RVA: 0x21FFEF0 Offset: 0x21FE4F0 VA: 0x1821FFEF0
	public void .ctor(NullableFP lowerLimitRad, NullableFP upperLimitRad, NullableFP motorSpeed, NullableFP maxMotorTorque, EntityRef connectedEntity, FPVector2 anchor, FPVector2 connectedAnchor) { }

	// RVA: 0x21FFBB0 Offset: 0x21FE1B0 VA: 0x1821FFBB0
	public static Joint CreateJoint(NullableFP lowerLimitRad, NullableFP upperLimitRad, NullableFP motorSpeed, NullableFP maxMotorTorque, EntityRef connectedEntity, FPVector2 anchor, FPVector2 connectedAnchor) { }

	// RVA: 0x21FFDF0 Offset: 0x21FE3F0 VA: 0x1821FFDF0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x21FFD40 Offset: 0x21FE340 VA: 0x1821FFD40 Slot: 2
	public override int GetHashCode() { }
}
