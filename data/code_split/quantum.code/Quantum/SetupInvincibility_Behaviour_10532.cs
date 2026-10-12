// Namespace: Quantum
[Serializable]
public class SetupInvincibility_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10532
{
	// Fields
	public bool FullInvincibility; // 0x68
	public int InvincibilityFrames; // 0x6C
	public HashString[] InvincibleHurtBoxes; // 0x70

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C1120 Offset: 0x21BF720 VA: 0x1821C1120 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C12C0 Offset: 0x21BF8C0 VA: 0x1821C12C0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21C13E0 Offset: 0x21BF9E0 VA: 0x1821C13E0
	public void .ctor() { }
}
