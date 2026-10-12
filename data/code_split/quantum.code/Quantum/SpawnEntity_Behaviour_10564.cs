// Namespace: Quantum
[Serializable]
public class SpawnEntity_Behaviour : StateBehaviour // TypeDefIndex: 10564
{
	// Fields
	public AssetRefGameEntityData GameEntity; // 0x60
	[DrawWithLabel]
	public EntityVariable SpawnedEntityIndexOutput; // 0x68
	[Space(5)]
	[DrawWithLabel]
	public EntityVariable CostumeIndex; // 0x70
	[DrawWithLabel]
	public EntityVariable XPosition; // 0x78
	[DrawWithLabel]
	public EntityVariable YPosition; // 0x80
	public bool PositionRelativeToSpawner; // 0x88

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C1920 Offset: 0x21BFF20 VA: 0x1821C1920 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21C1C10 Offset: 0x21C0210 VA: 0x1821C1C10
	public void .ctor() { }
}
