// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(HazardsRaceGameModeManager))]
[Serializable]
public class HazardsRaceGameModeManager_Prototype : PrototypeAdapter<HazardsRaceGameModeManager_Prototype> // TypeDefIndex: 3902
{
	// Fields
	public FP CurrentHazardsTimer; // 0x10
	public FP HazardsWarningTimer; // 0x18
	public FP ItemSpawnCooldown; // 0x20
	public FP AmountOfHazardsToSpawn; // 0x28
	public HazardSpawnDirection_Prototype SpawnDirection; // 0x30
	public QBoolean HazardsWarningActive; // 0x34
	public QBoolean SpawnDirectionSet; // 0x38
	[HideInInspector]
	public FP RandomHazardIndex; // 0x40
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] HazardSpawnAreaList; // 0x48

	// Methods

	// RVA: 0x677510 Offset: 0x675B10 VA: 0x180677510 Slot: 5
	public sealed override HazardsRaceGameModeManager_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x677670 Offset: 0x675C70 VA: 0x180677670
	public void .ctor() { }
}
