// Namespace: Quantum
[Serializable]
public class SetupIntangibility_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10531
{
	// Fields
	public bool FullIntangibility; // 0x68
	public int IntangibilityFrames; // 0x6C
	public HashString[] IntangibleHurtBoxes; // 0x70

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C0E00 Offset: 0x21BF400 VA: 0x1821C0E00 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C0FA0 Offset: 0x21BF5A0 VA: 0x1821C0FA0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21C10C0 Offset: 0x21BF6C0 VA: 0x1821C10C0
	public void .ctor() { }
}
