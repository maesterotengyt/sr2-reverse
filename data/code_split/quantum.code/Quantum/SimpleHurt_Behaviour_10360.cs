// Namespace: Quantum
[Serializable]
public class SimpleHurt_Behaviour : StateBehaviour // TypeDefIndex: 10360
{
	// Fields
	public ExecuteGroupEvent GroupForSuccessfulHit; // 0x60
	public HashString[] AttackDatasToReact; // 0x78

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2192500 Offset: 0x2190B00 VA: 0x182192500 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21926A0 Offset: 0x2190CA0 VA: 0x1821926A0
	public void .ctor() { }
}
