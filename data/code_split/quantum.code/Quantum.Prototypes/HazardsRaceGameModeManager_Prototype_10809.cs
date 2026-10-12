// Namespace: Quantum.Prototypes
[Prototype(typeof(HazardsRaceGameModeManager))]
[Serializable]
public sealed class HazardsRaceGameModeManager_Prototype : ComponentPrototype<HazardsRaceGameModeManager> // TypeDefIndex: 10809
{
	// Fields
	public FP CurrentHazardsTimer; // 0x18
	public FP HazardsWarningTimer; // 0x20
	public FP ItemSpawnCooldown; // 0x28
	public FP AmountOfHazardsToSpawn; // 0x30
	public HazardSpawnDirection_Prototype SpawnDirection; // 0x38
	public QBoolean HazardsWarningActive; // 0x3C
	public QBoolean SpawnDirectionSet; // 0x40
	[HideInInspector]
	public FP RandomHazardIndex; // 0x48
	[DynamicCollection]
	public MapEntityId[] HazardSpawnAreaList; // 0x50

	// Methods

	// RVA: 0x2106A00 Offset: 0x2105000 VA: 0x182106A00 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2106D30 Offset: 0x2105330 VA: 0x182106D30
	public void Materialize(Frame frame, ref HazardsRaceGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2106CA0 Offset: 0x21052A0 VA: 0x182106CA0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2106EF0 Offset: 0x21054F0 VA: 0x182106EF0
	public void .ctor() { }
}
