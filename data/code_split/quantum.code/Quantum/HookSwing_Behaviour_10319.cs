// Namespace: Quantum
[Serializable]
public class HookSwing_Behaviour : StateBehaviour // TypeDefIndex: 10319
{
	// Fields
	public ExecuteGroupEvent MaxAngleReachGroup; // 0x60
	public ExecuteGroupEvent HookCancelGroup; // 0x78
	public FPVector2 HookStartPoint; // 0x90
	public FP MaxSwingAngle; // 0xA0

	// Methods

	// RVA: 0x2172170 Offset: 0x2170770 VA: 0x182172170 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2172270 Offset: 0x2170870 VA: 0x182172270 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2172320 Offset: 0x2170920 VA: 0x182172320 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2172420 Offset: 0x2170A20 VA: 0x182172420
	protected void UpdateVelocity(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
