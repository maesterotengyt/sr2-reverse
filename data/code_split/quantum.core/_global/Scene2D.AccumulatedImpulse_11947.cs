// Namespace: 
private struct Scene2D.AccumulatedImpulse // TypeDefIndex: 11947
{
	// Fields
	public FPVector2 Velocity; // 0x0
	public FP AngularVelocity; // 0x10

	// Methods

	// RVA: 0x21FCFE0 Offset: 0x21FB5E0 VA: 0x1821FCFE0
	public void Add(Scene2D.AccumulatedImpulse impulse, Scene2D.AccumulatedImpulseType addImpulseType) { }

	// RVA: 0x21FD0D0 Offset: 0x21FB6D0 VA: 0x1821FD0D0
	public void Integrate(PhysicsBody2D* body, ref FPVector2 im, ref FPVector2 cv, bool useRotation) { }

	// RVA: 0x21FD040 Offset: 0x21FB640 VA: 0x1821FD040
	public void Apply(Entry2D* entry) { }
}
