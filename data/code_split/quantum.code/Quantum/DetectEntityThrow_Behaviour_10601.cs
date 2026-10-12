// Namespace: Quantum
[Serializable]
public class DetectEntityThrow_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10601
{
	// Fields
	public InputTransition ThrowUp; // 0x68
	public InputTransition ThrowDown; // 0xA0
	public InputTransition ThrowBack; // 0xD8
	public InputTransition ThrowForward; // 0x110

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B4110 Offset: 0x21B2710 VA: 0x1821B4110 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B4110 Offset: 0x21B2710 VA: 0x1821B4110 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B4000 Offset: 0x21B2600 VA: 0x1821B4000
	private void EvaluateInput(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x21AFF10 Offset: 0x21AE510 VA: 0x1821AFF10
	public void .ctor() { }
}
