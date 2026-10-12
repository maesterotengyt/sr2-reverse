// Namespace: Quantum
[Serializable]
public class Jump_Behaviour : StateBehaviour // TypeDefIndex: 10576
{
	// Fields
	public JumpBehaviourType JumpToExecute; // 0x60
	public bool StopActiveImpulse; // 0x64
	public bool OverrideXVelocity; // 0x65
	[DrawWithLabel]
	[DrawIf("OverrideXVelocity", 1, 0, 3)]
	public EntityVariable XVelocity; // 0x68
	public bool OverrideYVelocity; // 0x70
	[DrawWithLabel]
	[DrawIf("OverrideYVelocity", 1, 0, 3)]
	public EntityVariable YVelocity; // 0x78
	public bool StopJumpOnExit; // 0x80

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BA040 Offset: 0x21B8640 VA: 0x1821BA040 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BA600 Offset: 0x21B8C00 VA: 0x1821BA600 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B9CC0 Offset: 0x21B82C0 VA: 0x1821B9CC0
	private void ExecuteJump(Frame frame, CachedEntityData targetEntityData, Jump* jump, JumpData JumpData, JumpType jumpType) { }

	// RVA: 0x21B9E80 Offset: 0x21B8480 VA: 0x1821B9E80
	private void ExecuteWallJump(Frame frame, CachedEntityData targetEntityData, Jump* jump, JumpData JumpData) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
