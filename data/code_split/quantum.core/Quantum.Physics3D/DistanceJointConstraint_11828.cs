// Namespace: Quantum.Physics3D
internal struct DistanceJointConstraint // TypeDefIndex: 11828
{
	// Fields
	public JointConstraint JointConstraint; // 0x0
	public FP LowerVelBounds; // 0xB0
	public FP UpperVelBounds; // 0xB8
	public FP ActiveMassInverse; // 0xC0
	public FPVector3 Direction; // 0xC8

	// Methods

	// RVA: 0x2234E30 Offset: 0x2233430 VA: 0x182234E30 Slot: 4
	public void InitConstraint(ConstraintData* cst, DistanceJointConstraint* distCst, FP dt) { }

	// RVA: 0x22354B0 Offset: 0x2233AB0 VA: 0x1822354B0 Slot: 5
	public void SolveVelocityConstraint(ConstraintData* cst, DistanceJointConstraint* distCst) { }

	// RVA: 0x2235030 Offset: 0x2233630 VA: 0x182235030 Slot: 6
	public void SolvePositionConstraint(ConstraintData* cst, DistanceJointConstraint* distCst) { }
}
