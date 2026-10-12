// Namespace: Quantum
[Serializable]
public class UpdateEntityHitFilter_Behaviour : StateBehaviour // TypeDefIndex: 10537
{
	// Fields
	public bool ResetToDefault; // 0x60
	[DrawIf("ResetToDefault", 0, 0, 3)]
	public EntityHitFilter HitFilter; // 0x64

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C3130 Offset: 0x21C1730 VA: 0x1821C3130 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C3270 Offset: 0x21C1870 VA: 0x1821C3270 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
