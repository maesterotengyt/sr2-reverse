// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CheckpointManager))]
[Serializable]
public class CheckpointManager_Prototype : PrototypeAdapter<CheckpointManager_Prototype> // TypeDefIndex: 3874
{
	// Fields
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] CheckpointList; // 0x10
	[HideInInspector]
	[LocalReference]
	public EntityPrototype CurrentWinningPlayer; // 0x18
	[HideInInspector]
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] Ranking; // 0x20
	[HideInInspector]
	public FP TotalLapDistance; // 0x28
	[HideInInspector]
	[LocalReference]
	public EntityPrototype LastRespawnPoint; // 0x30
	[HideInInspector]
	public int LastSpawnDirection; // 0x38

	// Methods

	// RVA: 0x6724C0 Offset: 0x670AC0 VA: 0x1806724C0 Slot: 5
	public sealed override CheckpointManager_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672690 Offset: 0x670C90 VA: 0x180672690
	public void .ctor() { }
}
