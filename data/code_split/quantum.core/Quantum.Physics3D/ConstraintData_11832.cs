// Namespace: Quantum.Physics3D
internal struct ConstraintData // TypeDefIndex: 11832
{
	// Fields
	public ConstraintFlags Flags; // 0x0
	public long NextInIslandAdr; // 0x8
	public EntrySolverImpulses ImpulsesA; // 0x10
	public EntrySolverImpulses ImpulsesB; // 0x48
	[FieldOverlap(128)]
	public CollisionConstraintData CollisionCst; // 0x80
	[FieldOverlap(128)]
	public JointConstraint JointCst; // 0x80
	[FieldOverlap(128)]
	public DistanceJointConstraint DistanceJointCst; // 0x80
	[FieldOverlap(128)]
	public SpringJointConstraint SpringJointCst; // 0x80
	[FieldOverlap(128)]
	public HingeJointConstraint HingeJointCst; // 0x80

	// Properties
	public bool IgnoreVelocitySolver { get; set; }
	public bool IgnorePositionSolver { get; set; }
	public bool WasSolved { get; set; }
	public bool HasDynamicBodyA { get; set; }
	public bool HasDynamicBodyB { get; set; }

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

	// RVA: 0x2207780 Offset: 0x2205D80 VA: 0x182207780
	public bool get_HasDynamicBodyA() { }

	// RVA: 0x2211A00 Offset: 0x2210000 VA: 0x182211A00
	public void set_HasDynamicBodyA(bool value) { }

	// RVA: 0x2234E00 Offset: 0x2233400 VA: 0x182234E00
	public bool get_HasDynamicBodyB() { }

	// RVA: 0x2234E10 Offset: 0x2233410 VA: 0x182234E10
	public void set_HasDynamicBodyB(bool value) { }
}
