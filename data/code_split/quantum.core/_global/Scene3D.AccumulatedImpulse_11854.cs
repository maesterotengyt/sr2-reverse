// Namespace: 
private struct Scene3D.AccumulatedImpulse // TypeDefIndex: 11854
{
	// Fields
	public FPVector3 Velocity; // 0x0
	public FPVector3 AngularVelocity; // 0x18

	// Methods

	// RVA: 0x225C790 Offset: 0x225AD90 VA: 0x18225C790
	public void Accumulate(Scene3D.AccumulatedImpulse impulse, Scene3D.AccumulatedImpulseFlags flags) { }

	// RVA: 0x225CBF0 Offset: 0x225B1F0 VA: 0x18225CBF0
	public void Integrate(PhysicsBody3D* body, ref FPVector3 im, ref FPVector3 cv, bool useRotation) { }

	// RVA: 0x225CB10 Offset: 0x225B110 VA: 0x18225CB10
	public void Apply(Entry3D* entry) { }
}
