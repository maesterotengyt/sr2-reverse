// Namespace: Quantum.Physics2D
internal struct HingeJointConstraint // TypeDefIndex: 11924
{
	// Fields
	public JointConstraint JointConstraint; // 0x0
	public int SolveMotor; // 0x80
	public int SolveAngleLimits; // 0x84
	public FP ActiveInertiaInv; // 0x88
	public FP LowerAngVelBounds; // 0x90
	public FP UpperAngVelBounds; // 0x98
	public FP MaxMotorImpulse; // 0xA0
	public FP AccMotorImpulse; // 0xA8
	public FPMatrix2x2 K; // 0xB0

	// Methods

	// RVA: 0x227B370 Offset: 0x2279970 VA: 0x18227B370 Slot: 4
	public void InitConstraint(ConstraintData* cst, HingeJointConstraint* hingeCst, FP dt) { }

	// RVA: 0x227BCB0 Offset: 0x227A2B0 VA: 0x18227BCB0 Slot: 5
	public void SolveVelocityConstraint(ConstraintData* cst, HingeJointConstraint* hingeCst) { }

	// RVA: 0x227B5E0 Offset: 0x2279BE0 VA: 0x18227B5E0 Slot: 6
	public void SolvePositionConstraint(ConstraintData* cst, HingeJointConstraint* hingeCst) { }
}
