// Namespace: Quantum
[Serializable]
public class JumpAnticipation_Behaviour : StateBehaviour // TypeDefIndex: 10574
{
	// Fields
	public InputFlag JumpButton; // 0x60
	public ChangeStateEvent JumpState; // 0x68
	public ChangeStateEvent JumpBackState; // 0x80

	// Methods

	// RVA: 0x21B9900 Offset: 0x21B7F00 VA: 0x1821B9900 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B9970 Offset: 0x21B7F70 VA: 0x1821B9970 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B99E0 Offset: 0x21B7FE0 VA: 0x1821B99E0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B9B50 Offset: 0x21B8150 VA: 0x1821B9B50
	public void .ctor() { }
}
