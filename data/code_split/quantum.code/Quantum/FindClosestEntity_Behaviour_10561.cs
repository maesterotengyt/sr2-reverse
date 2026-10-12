// Namespace: Quantum
[Serializable]
public class FindClosestEntity_Behaviour : StateBehaviour // TypeDefIndex: 10561
{
	// Fields
	[DrawWithLabel]
	public EntityVariable OutEntityIndex; // 0x60
	[DrawWithLabel]
	public EntityVariable Radius; // 0x68
	public bool IgnoreOriginalOwner; // 0x70
	public bool IgnoreOwner; // 0x71
	public bool CheckForCharacters; // 0x72
	public bool CheckForProjectiles; // 0x73
	public bool CheckForItems; // 0x74
	public bool CheckForHazards; // 0x75

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B5FB0 Offset: 0x21B45B0 VA: 0x1821B5FB0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
