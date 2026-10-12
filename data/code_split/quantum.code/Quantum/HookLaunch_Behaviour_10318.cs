// Namespace: Quantum
[Serializable]
public class HookLaunch_Behaviour : StateBehaviour // TypeDefIndex: 10318
{
	// Fields
	public ExecuteGroupEvent HookHitGroup; // 0x60
	public ExecuteGroupEvent HookFailedGroup; // 0x78
	public FPVector2 HookStartPoint; // 0x90
	public FP HookLengthIncreaseRate; // 0xA0
	public FP HookAngle; // 0xA8
	public CollisionLayer[] CeilingLayers; // 0xB0

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2171CA0 Offset: 0x21702A0 VA: 0x182171CA0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2171F10 Offset: 0x2170510 VA: 0x182171F10 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2171FD0 Offset: 0x21705D0 VA: 0x182171FD0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21716A0 Offset: 0x216FCA0 VA: 0x1821716A0
	private void CheckForHookCollision(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnerCharacter) { }

	// RVA: 0x2172100 Offset: 0x2170700 VA: 0x182172100
	public void .ctor() { }
}
