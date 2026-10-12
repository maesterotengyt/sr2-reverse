// Namespace: Quantum
[Serializable]
public class StartShake_Behaviour : StateBehaviour // TypeDefIndex: 10614
{
	// Fields
	public FP ShakeDuration; // 0x60
	public FP ShakePower; // 0x68
	public bool ShakeHorizontally; // 0x70
	public bool ShakeVertically; // 0x71
	public bool StopOnExit; // 0x72

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20FA0A0 Offset: 0x20F86A0 VA: 0x1820FA0A0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x20FA1F0 Offset: 0x20F87F0 VA: 0x1820FA1F0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
