// Namespace: Quantum
[Serializable]
public class ImpulseData // TypeDefIndex: 10490
{
	// Fields
	public int FramesDuration; // 0x10
	public bool UseLocalCoordinates; // 0x14
	public bool InheritVelocityOnStop; // 0x15
	[Space(5)]
	public ImpulseVelocitySettings XVelocitySettings; // 0x18
	[Space(5)]
	public ImpulseVelocitySettings YVelocitySettings; // 0x88

	// Methods

	// RVA: 0x21B8A90 Offset: 0x21B7090 VA: 0x1821B8A90
	public FPVector2 CalculateLeftStickInfluence(Frame frame, EntityRef entity, int facingDirection) { }

	// RVA: 0x21B9160 Offset: 0x21B7760 VA: 0x1821B9160
	public bool Update(Frame frame, CachedEntityData entityData, ref FP impulseFrames, FPVector2 referenceLeftStick, FP velocityMultiplier, ref FPVector2 impulseVelocity) { }

	// RVA: 0x21B8D60 Offset: 0x21B7360 VA: 0x1821B8D60
	private FP EvaluateVelocity(Frame frame, CachedEntityData entityData, ImpulseVelocitySettings velocitySettings, FP currentFrame) { }

	// RVA: 0x21B9460 Offset: 0x21B7A60 VA: 0x1821B9460
	public void .ctor() { }
}
