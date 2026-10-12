// Namespace: Quantum
[Serializable]
public class FootstepSFX_Behaviour : StateBehaviour // TypeDefIndex: 10505
{
	// Fields
	[DrawWithLabel]
	public EntityVariable OutLastStepIndex; // 0x60
	public bool UseExplicitChannelTargeting; // 0x68
	[DrawIf("UseExplicitChannelTargeting", 1, 0, 3)]
	public AnimationChannel TargetChannel; // 0x6C
	public BehaviourFootStepInfo[] Footsteps; // 0x70
	public int LoopFrame; // 0x78

	// Methods

	// RVA: 0x21B6D40 Offset: 0x21B5340 VA: 0x1821B6D40 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B6DD0 Offset: 0x21B53D0 VA: 0x1821B6DD0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B7190 Offset: 0x21B5790 VA: 0x1821B7190
	public void .ctor() { }
}
