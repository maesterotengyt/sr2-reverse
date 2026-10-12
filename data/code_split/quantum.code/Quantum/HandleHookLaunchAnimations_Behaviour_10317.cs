// Namespace: Quantum
[Serializable]
public class HandleHookLaunchAnimations_Behaviour : StateBehaviour // TypeDefIndex: 10317
{
	// Fields
	private const int idleChannel = 0;
	private const int idleAirChannel = 1;
	private const int runChannel = 3;
	private const int runBackChannel = 4;
	public AnimationPlayableInfo IdleAnimation; // 0x60
	public AnimationPlayableInfo IdleAirAnimation; // 0xB8
	public AnimationPlayableInfo RunAnimation; // 0x110
	public bool UseSeparateAnimationForRunBack; // 0x168
	[DrawIf("UseSeparateAnimationForRunBack", 1, 0, 3)]
	public AnimationPlayableInfo RunBackAnimation; // 0x170
	public FP MinVelocity; // 0x1C8

	// Methods

	// RVA: 0x2170E30 Offset: 0x216F430 VA: 0x182170E30 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21712E0 Offset: 0x216F8E0 VA: 0x1821712E0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2171360 Offset: 0x216F960 VA: 0x182171360
	private void PlayClip(Frame frame, int channel, CachedEntityData targetEntityData, AnimationPlayableInfo clip) { }

	// RVA: 0x2171500 Offset: 0x216FB00 VA: 0x182171500
	private void UpdateWeights(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
