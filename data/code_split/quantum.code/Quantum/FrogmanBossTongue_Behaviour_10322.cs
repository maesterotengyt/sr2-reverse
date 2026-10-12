// Namespace: Quantum
[Serializable]
public class FrogmanBossTongue_Behaviour : StateBehaviour // TypeDefIndex: 10322
{
	// Fields
	public HashString AttackDataID; // 0x60
	[Space(10)]
	public FP MovementVelocity; // 0x70
	public FP HookRadius; // 0x78
	public FP AttractVelocity; // 0x80
	public FP FrozenAttractVelocity; // 0x88
	public FP MinAttractDistance; // 0x90
	public FP TargetTimeoutFrames; // 0x98
	public FP PullTimeoutFrames; // 0xA0
	[Space(10)]
	public FP HookTargetMaxOutputVelocity; // 0xA8
	[Space(10)]
	public ChangeStateEvent PulledByHookState; // 0xB0

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x216B790 Offset: 0x2169D90 VA: 0x18216B790 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x216B950 Offset: 0x2169F50 VA: 0x18216B950 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x216BA00 Offset: 0x216A000 VA: 0x18216BA00 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x216B650 Offset: 0x2169C50 VA: 0x18216B650
	private void MoveCharacterTowardsCenter(Frame frame, EntityRef entity, Transform2D* transform, PhysicsBody* physicsBody, FPVector2 middlePoint) { }

	// RVA: 0x216B260 Offset: 0x2169860 VA: 0x18216B260
	private void FindTarget(Frame frame, CachedEntityData targetEntityData, FrogmanBossTongue* frogmanBossTongue, bool firstTime = False) { }

	// RVA: 0x216CEE0 Offset: 0x216B4E0 VA: 0x18216CEE0
	public void .ctor() { }
}
