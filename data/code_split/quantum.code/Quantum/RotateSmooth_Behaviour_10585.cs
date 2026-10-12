// Namespace: Quantum
[Serializable]
public class RotateSmooth_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10585
{
	// Fields
	[DrawWithLabel]
	public EntityVariable StartRotation; // 0x68
	[DrawWithLabel]
	public EntityVariable TargetRotation; // 0x70

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BEB00 Offset: 0x21BD100 VA: 0x1821BEB00 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21BEBC0 Offset: 0x21BD1C0 VA: 0x1821BEBC0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21AFF10 Offset: 0x21AE510 VA: 0x1821AFF10
	public void .ctor() { }
}
