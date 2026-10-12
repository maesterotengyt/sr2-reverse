// Namespace: Quantum.Physics2D
internal struct DistanceJointConstraint // TypeDefIndex: 11923
{
	// Fields
	public JointConstraint JointConstraint; // 0x0
	public FP LowerVelBounds; // 0x80
	public FP UpperVelBounds; // 0x88
	public FP ActiveMassInverse; // 0x90
	public FPVector2 Direction; // 0x98

	// Methods

	// RVA: 0x22788D0 Offset: 0x2276ED0 VA: 0x1822788D0 Slot: 4
	public void InitConstraint(ConstraintData* cst, DistanceJointConstraint* distCst, FP dt) { }

	// RVA: 0x2278E30 Offset: 0x2277430 VA: 0x182278E30 Slot: 5
	public void SolveVelocityConstraint(ConstraintData* cst, DistanceJointConstraint* distCst) { }

	// RVA: 0x2278AB0 Offset: 0x22770B0 VA: 0x182278AB0 Slot: 6
	public void SolvePositionConstraint(ConstraintData* cst, DistanceJointConstraint* distCst) { }
}
