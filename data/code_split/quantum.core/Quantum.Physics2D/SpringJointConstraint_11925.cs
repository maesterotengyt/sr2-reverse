// Namespace: Quantum.Physics2D
internal struct SpringJointConstraint // TypeDefIndex: 11925
{
	// Fields
	public JointConstraint JointConstraint; // 0x0
	public FP Gamma; // 0x80
	public FP Bias; // 0x88
	public FP AccumulatedImpulsesMag; // 0x90
	public FP ActiveMassInverse; // 0x98
	public FPVector2 Direction; // 0xA0

	// Methods

	// RVA: 0x227E780 Offset: 0x227CD80 VA: 0x18227E780 Slot: 4
	public void InitConstraint(ConstraintData* cst, SpringJointConstraint* springCst, FP dt) { }

	// RVA: 0x227E990 Offset: 0x227CF90 VA: 0x18227E990 Slot: 5
	public void SolveVelocityConstraint(ConstraintData* cst, SpringJointConstraint* springCst) { }
}
