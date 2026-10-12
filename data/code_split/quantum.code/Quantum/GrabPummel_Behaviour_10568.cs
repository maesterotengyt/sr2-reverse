// Namespace: Quantum
[Serializable]
public class GrabPummel_Behaviour : StateBehaviour // TypeDefIndex: 10568
{
	// Fields
	[Header("Logic")]
	public FP Damage; // 0x60
	public bool TriggerPummelStateOnVictim; // 0x68
	[Header("Visuals")]
	public int HitlagFrames; // 0x6C

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B7600 Offset: 0x21B5C00 VA: 0x1821B7600 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21B7870 Offset: 0x21B5E70 VA: 0x1821B7870
	public void .ctor() { }
}
