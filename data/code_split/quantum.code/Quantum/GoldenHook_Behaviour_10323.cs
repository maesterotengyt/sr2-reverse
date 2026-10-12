// Namespace: Quantum
[Serializable]
public class GoldenHook_Behaviour : StateBehaviour // TypeDefIndex: 10323
{
	// Fields
	public HashString AttackDataID; // 0x60
	public ExecuteGroupEvent CollisionDetectedGroup; // 0x70
	public ExecuteGroupEvent AttractStartedGroup; // 0x88
	public ExecuteGroupEvent AttractFinishedGroup; // 0xA0
	public ExecuteGroupEvent TimeoutGroup; // 0xB8
	public ExecuteGroupEvent DetectedSlideTargetGroup; // 0xD0
	public ExecuteGroupEvent DetectedWallSlideTargetGroup; // 0xE8
	[Space(10)]
	public FP MovementVelocity; // 0x100
	public FP HookRadius; // 0x108
	public FP AttractVelocity; // 0x110
	public FP FrozenAttractVelocity; // 0x118
	public FP MinAttractDistance; // 0x120
	public FP TargetTimeoutFrames; // 0x128
	public FP PullTimeoutFrames; // 0x130
	[Space(10)]
	public FP HookOwnerMaxOutputVelocity; // 0x138
	public FP HookTargetMaxOutputVelocity; // 0x140
	[Space(10)]
	public ChangeStateEvent PulledByHookState; // 0x148

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x216F1B0 Offset: 0x216D7B0 VA: 0x18216F1B0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x216B950 Offset: 0x2169F50 VA: 0x18216B950 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x216F360 Offset: 0x216D960 VA: 0x18216F360 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x216F070 Offset: 0x216D670 VA: 0x18216F070
	private void MoveCharacterTowardsCenter(Frame frame, EntityRef entity, Transform2D* transform, PhysicsBody* physicsBody, FPVector2 middlePoint) { }

	// RVA: 0x216ECB0 Offset: 0x216D2B0 VA: 0x18216ECB0
	private void FindTarget(Frame frame, CachedEntityData targetEntityData, GoldenHook* goldenHook) { }

	// RVA: 0x2170D90 Offset: 0x216F390 VA: 0x182170D90
	public void .ctor() { }
}
