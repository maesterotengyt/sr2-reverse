// Namespace: Quantum.Physics3D
public struct HingeJoint3D // TypeDefIndex: 11844
{
	// Fields
	public FPVector3 Anchor; // 0x0
	public FPVector3 ConnectedAnchor; // 0x18
	public EntityRef ConnectedEntity; // 0x30
	internal int _useAngleLimits; // 0x38
	internal int _useMotor; // 0x3C
	public FP LowerLimitRad; // 0x40
	public FP UpperLimitRad; // 0x48
	public FP MotorSpeed; // 0x50
	public FP MaxMotorTorque; // 0x58
	internal FPVector3RawInt _jointAxisLocalRawInt; // 0x60
	internal FPVector3RawInt _connectedAxisRawInt; // 0x6C
	internal FPQuaternionRawInt _relRotRefInv; // 0x78

	// Properties
	public FPQuaternion RelativeRotationReference { set; }

	// Methods

	// RVA: 0x2264940 Offset: 0x2262F40 VA: 0x182264940
	public void set_RelativeRotationReference(FPQuaternion value) { }

	// RVA: 0x22647B0 Offset: 0x2262DB0 VA: 0x1822647B0
	public void .ctor(FrameBase f, EntityRef jointEntity, FPVector3 axis, NullableFP lowerLimitRad, NullableFP upperLimitRad, NullableFP motorSpeed, NullableFP maxMotorTorque, EntityRef connectedEntity, FPVector3 anchor, FPVector3 connectedAnchor) { }

	// RVA: 0x2264060 Offset: 0x2262660 VA: 0x182264060
	public static Joint3D CreateJoint(FrameBase f, EntityRef jointEntity, FPVector3 axis, NullableFP lowerLimitRad, NullableFP upperLimitRad, NullableFP motorSpeed, NullableFP maxMotorTorque, EntityRef connectedEntity, FPVector3 anchor, FPVector3 connectedAnchor) { }

	// RVA: 0x22644D0 Offset: 0x2262AD0 VA: 0x1822644D0
	public void SetAxis(FrameBase f, EntityRef jointEntity, FPVector3 axis, bool resetRelRotRef = False) { }

	// RVA: 0x22643A0 Offset: 0x22629A0 VA: 0x1822643A0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x22642C0 Offset: 0x22628C0 VA: 0x1822642C0 Slot: 2
	public override int GetHashCode() { }
}
