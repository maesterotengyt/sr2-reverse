// Namespace: Quantum
[Serializable]
public class Freeze_Behaviour : StateBehaviour // TypeDefIndex: 10355
{
	// Fields
	public ExecuteGroupEvent FreezeEndGroup; // 0x60

	// Methods

	// RVA: 0x218BD90 Offset: 0x218A390 VA: 0x18218BD90 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x218BE30 Offset: 0x218A430 VA: 0x18218BE30 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x218C060 Offset: 0x218A660 VA: 0x18218C060 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x218C360 Offset: 0x218A960 VA: 0x18218C360
	private void UpdateVelocity(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnersCharacter) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
