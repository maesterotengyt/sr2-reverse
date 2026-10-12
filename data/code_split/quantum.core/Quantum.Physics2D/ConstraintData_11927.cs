// Namespace: Quantum.Physics2D
internal struct ConstraintData // TypeDefIndex: 11927
{
	// Fields
	public ConstraintFlags Flags; // 0x0
	public long NextInIslandAdr; // 0x8
	public EntrySolverImpulses ImpulsesA; // 0x10
	public EntrySolverImpulses ImpulsesB; // 0x30
	[FieldOverlap(80)]
	public CollisionConstraintData CollisionCst; // 0x50
	[FieldOverlap(80)]
	public JointConstraint JointCst; // 0x50
	[FieldOverlap(80)]
	public DistanceJointConstraint DistanceJointCst; // 0x50
	[FieldOverlap(80)]
	public SpringJointConstraint SpringJointCst; // 0x50
	[FieldOverlap(80)]
	public HingeJointConstraint HingeJointCst; // 0x50

	// Properties
	public bool IgnoreVelocitySolver { get; set; }
	public bool IgnorePositionSolver { get; set; }
	public bool WasSolved { get; set; }

	// Methods

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	public bool get_IgnoreVelocitySolver() { }

	// RVA: 0x2207790 Offset: 0x2205D90 VA: 0x182207790
	public void set_IgnoreVelocitySolver(bool value) { }

	// RVA: 0x2207760 Offset: 0x2205D60 VA: 0x182207760
	public bool get_IgnorePositionSolver() { }

	// RVA: 0x22119C0 Offset: 0x220FFC0 VA: 0x1822119C0
	public void set_IgnorePositionSolver(bool value) { }

	// RVA: 0x22119B0 Offset: 0x220FFB0 VA: 0x1822119B0
	public bool get_WasSolved() { }

	// RVA: 0x22119E0 Offset: 0x220FFE0 VA: 0x1822119E0
	public void set_WasSolved(bool value) { }
}
