// Namespace: Quantum
[Serializable]
public struct AnimationSpeedUpdater // TypeDefIndex: 10501
{
	// Fields
	public AnimationChannel TargetChannel; // 0x0
	public AnimationSpeedUpdateMode UpdateMode; // 0x4
	[DrawWithLabel]
	[DrawIf("UpdateMode", 1, 0, 3)]
	public EntityVariable Speed; // 0x8
	[DrawWithLabel]
	[DrawIf("UpdateMode", 2, 0, 3)]
	public EntityVariable MinAnimationSpeed; // 0x10
	[DrawWithLabel]
	[DrawIf("UpdateMode", 2, 0, 3)]
	public EntityVariable MaxAnimationSpeed; // 0x18
	[DrawWithLabel]
	[DrawIf("UpdateMode", 2, 0, 3)]
	public EntityVariable MinInputValue; // 0x20
	[DrawWithLabel]
	[DrawIf("UpdateMode", 2, 0, 3)]
	public EntityVariable MaxInputValue; // 0x28
	[DrawWithLabel]
	[DrawIf("UpdateMode", 2, 0, 3)]
	public EntityVariable InputValue; // 0x30

	// Methods

	// RVA: 0x21B0070 Offset: 0x21AE670 VA: 0x1821B0070
	public FP CalculateSpeed(Frame frame, CachedEntityData entityData) { }
}
