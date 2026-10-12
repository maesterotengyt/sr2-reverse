// Namespace: Quantum
[Serializable]
public class BossRocket_Behaviour : StateBehaviour // TypeDefIndex: 10321
{
	// Fields
	public FP HomingCooldown; // 0x60
	public FP InitialInterpolationSpeed; // 0x68
	public FP InterpolationSpeedIncrease; // 0x70
	public FP InitialSpeed; // 0x78
	public FP TargetVerticalOffset; // 0x80
	public int FramesForNewTargetCheck; // 0x88

	// Methods

	// RVA: 0x2165DB0 Offset: 0x21643B0 VA: 0x182165DB0 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2165E90 Offset: 0x2164490 VA: 0x182165E90 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2165AB0 Offset: 0x21640B0 VA: 0x182165AB0
	private void FindTarget(Frame frame, CachedEntityData rocketEntityData, Rocket* rocket, int currentFrame) { }

	// RVA: 0x2166260 Offset: 0x2164860 VA: 0x182166260
	public void .ctor() { }
}
