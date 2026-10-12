// Namespace: Quantum
[Serializable]
public class FollowEntity_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10581
{
	// Fields
	public BehaviourTargetEntity EntityToFollow; // 0x68
	[DrawIf("EntityToFollow", 1, 0, 3)]
	public HashString EntityToFollowParameterID; // 0x70
	[DrawWithLabel]
	public EntityVariable XOffset; // 0x80
	[DrawWithLabel]
	public EntityVariable YOffset; // 0x88
	public bool UseEntityFacingDirection; // 0x90

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21B69E0 Offset: 0x21B4FE0 VA: 0x1821B69E0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21AFF10 Offset: 0x21AE510 VA: 0x1821AFF10
	public void .ctor() { }
}
