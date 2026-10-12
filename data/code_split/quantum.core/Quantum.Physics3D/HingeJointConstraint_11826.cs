// Namespace: Quantum.Physics3D
internal struct HingeJointConstraint // TypeDefIndex: 11826
{
	// Fields
	public JointConstraint JointConstraint; // 0x0
	public int SolveMotor; // 0xB0
	public int SolveAngleLimits; // 0xB4
	public FP ActiveInertiaInv; // 0xB8
	public FP LowerAngVelBounds; // 0xC0
	public FP UpperAngVelBounds; // 0xC8
	public FP MaxMotorImpulse; // 0xD0
	public FP AccMotorImpulse; // 0xD8
	public FPVector3 HingeAxisWorld; // 0xE0
	public FPVector3 ConnectedAxisWorld; // 0xF8
	public FPVector3 ConnectedOrthoCrossHinge1; // 0x110
	public FPVector3 ConnectedOrthoCrossHinge2; // 0x128
	public FPMatrix2x2 JacobianRotation; // 0x140
	public FPMatrix3x3 JacobianTranslation; // 0x160

	// Methods

	// RVA: 0x22393D0 Offset: 0x22379D0 VA: 0x1822393D0 Slot: 4
	public void InitConstraint(ConstraintData* cst, HingeJointConstraint* hingeCst, FP dt) { }

	// RVA: 0x2232C60 Offset: 0x2231260 VA: 0x182232C60
	private static void ComputeRotationJacobianInverse(ref FPMatrix2x2 jacobian, out FPMatrix2x2 result) { }

	// RVA: 0x2232D30 Offset: 0x2231330 VA: 0x182232D30
	private static void ComputeTranslationJacobianInverse(ref FPMatrix3x3 jacobian, out FPMatrix3x3 result) { }

	// RVA: 0x2232F90 Offset: 0x2231590 VA: 0x182232F90
	private FPVector3 GetOrthogonalAxisNormalized(FPVector3 v) { }

	// RVA: 0x223C1B0 Offset: 0x223A7B0 VA: 0x18223C1B0 Slot: 5
	public void SolveVelocityConstraint(ConstraintData* cst, HingeJointConstraint* hingeCst) { }

	// RVA: 0x223A250 Offset: 0x2238850 VA: 0x18223A250 Slot: 6
	public void SolvePositionConstraint(ConstraintData* cst, HingeJointConstraint* hingeCst) { }

	// RVA: 0x2232A50 Offset: 0x2231050 VA: 0x182232A50
	private FP ComputeCurrentHingeRelAngle(HingeJoint3D* hingeJoint, FPQuaternion rotJoint, FPQuaternion rotConnectedAnchor) { }
}
