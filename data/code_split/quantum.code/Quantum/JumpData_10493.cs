// Namespace: Quantum
[Serializable]
public class JumpData // TypeDefIndex: 10493
{
	// Fields
	[Tooltip("Gravity multiplier for the jump while going up (Applied while the jump impulse is active)")]
	public FP GravityMultiplier; // 0x10
	[Tooltip("Force applied in the last pre-jump frame")]
	public FP HorizontalForce; // 0x18
	[Tooltip("Velocity limit for pre-jump horizontal force")]
	public FP HorizontalMaxVelocity; // 0x20
	[Tooltip("Impulse applied to the entity during the jump")]
	public ImpulseData ImpulseData; // 0x28

	// Methods

	// RVA: 0x21B9CA0 Offset: 0x21B82A0 VA: 0x1821B9CA0
	public void .ctor() { }
}
