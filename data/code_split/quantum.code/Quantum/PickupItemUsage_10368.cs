// Namespace: Quantum
[Serializable]
public struct PickupItemUsage // TypeDefIndex: 10368
{
	// Fields
	public PickupItemAction Action; // 0x0
	public int ItemUseActiveFrames; // 0x4
	public string[] SFXToPlay; // 0x8
	[DrawIf("Action", 0, 1, 3)]
	public HashString TargetState; // 0x10
	[DrawIf("Action", 0, 0, 3)]
	public AssetRefGameEntityData GameEntity; // 0x20
	[DrawWithLabel]
	[DrawIf("Action", 0, 0, 3)]
	public bool CheckCollisionsInBetween; // 0x28
	[DrawWithLabel]
	[DrawIf("Action", 0, 0, 3)]
	public EntityVariable XPosition; // 0x30
	[DrawWithLabel]
	[DrawIf("Action", 0, 0, 3)]
	public EntityVariable YPosition; // 0x38
	[DrawIf("Action", 0, 0, 3)]
	public bool PositionRelativeToSpawner; // 0x40
	[DrawIf("Action", 0, 0, 3)]
	public bool UseSpawnerFacingDirection; // 0x41

	// Methods

	// RVA: 0x2190CB0 Offset: 0x218F2B0 VA: 0x182190CB0
	public void Execute(Frame frame, EntityRef fromEntity) { }
}
