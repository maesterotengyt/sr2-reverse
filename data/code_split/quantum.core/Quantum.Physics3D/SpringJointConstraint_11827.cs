// Namespace: Quantum.Physics3D
internal struct SpringJointConstraint // TypeDefIndex: 11827
{
	// Fields
	public JointConstraint JointConstraint; // 0x0
	public FP Gamma; // 0xB0
	public FP Bias; // 0xB8
	public FP AccumulatedImpulsesMag; // 0xC0
	public FP ActiveMassInverse; // 0xC8
	public FPVector3 Direction; // 0xD0

	// Methods

	// RVA: 0x223E820 Offset: 0x223CE20 VA: 0x18223E820 Slot: 4
	public void InitConstraint(ConstraintData* cst, SpringJointConstraint* springCst, FP dt) { }

	// RVA: 0x223EA40 Offset: 0x223D040 VA: 0x18223EA40 Slot: 5
	public void SolveVelocityConstraint(ConstraintData* cst, SpringJointConstraint* springCst) { }
}
