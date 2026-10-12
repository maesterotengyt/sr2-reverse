// Namespace: Quantum
[Serializable]
public struct ImpulseVelocitySettings // TypeDefIndex: 10491
{
	// Fields
	public ImpulseStickInfluence LeftStickInfluence; // 0x0
	[DrawWithLabel]
	[DrawIf("LeftStickInfluence", 5, 0, 3)]
	public EntityVariable LeftStickInfluenceFactor; // 0x8
	public bool ApplyInterpolation; // 0x10
	public bool Loop; // 0x11
	[DrawWithLabel]
	public EntityVariable StartVelocity; // 0x18
	[DrawWithLabel]
	public EntityVariable TargetVelocity; // 0x20
	public FPAnimationCurve InterpolationCurve; // 0x28
	[DrawWithLabel]
	public EntityVariable InterpolationStartFrame; // 0x60
	[DrawWithLabel]
	public EntityVariable InterpolationEndFrame; // 0x68
}
