// Namespace: Quantum.Prototypes
[Prototype(typeof(CheckpointManager))]
[Serializable]
public sealed class CheckpointManager_Prototype : ComponentPrototype<CheckpointManager> // TypeDefIndex: 10766
{
	// Fields
	[DynamicCollection]
	public MapEntityId[] CheckpointList; // 0x18
	[HideInInspector]
	public MapEntityId CurrentWinningPlayer; // 0x20
	[HideInInspector]
	[DynamicCollection]
	public MapEntityId[] Ranking; // 0x28
	[HideInInspector]
	public FP TotalLapDistance; // 0x30
	[HideInInspector]
	public MapEntityId LastRespawnPoint; // 0x38
	[HideInInspector]
	public int LastSpawnDirection; // 0x3C

	// Methods

	// RVA: 0x20FE040 Offset: 0x20FC640 VA: 0x1820FE040 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FE1F0 Offset: 0x20FC7F0 VA: 0x1820FE1F0
	public void Materialize(Frame frame, ref CheckpointManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FE160 Offset: 0x20FC760 VA: 0x1820FE160 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FE530 Offset: 0x20FCB30 VA: 0x1820FE530
	public void .ctor() { }
}
