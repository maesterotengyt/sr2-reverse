// Namespace: Quantum
public struct HazardsRaceGameModeManager : IComponent // TypeDefIndex: 9998
{
	// Fields
	public FP AmountOfHazardsToSpawn; // 0x10
	public FP CurrentHazardsTimer; // 0x18
	[PtrQList(typeof(EntityRef))]
	private Ptr HazardSpawnAreaListPtr; // 0xC
	public QBoolean HazardsWarningActive; // 0x4
	public FP HazardsWarningTimer; // 0x20
	public FP ItemSpawnCooldown; // 0x28
	[HideInInspector]
	public FP RandomHazardIndex; // 0x30
	public HazardSpawnDirection SpawnDirection; // 0x0
	public QBoolean SpawnDirectionSet; // 0x8

	// Properties
	public QListPtr<EntityRef> HazardSpawnAreaList { get; set; }

	// Methods

	// RVA: 0x211C6D0 Offset: 0x211ACD0 VA: 0x18211C6D0
	public QListPtr<EntityRef> get_HazardSpawnAreaList() { }

	// RVA: 0x1ED2120 Offset: 0x1ED0720 VA: 0x181ED2120
	public void set_HazardSpawnAreaList(QListPtr<EntityRef> value) { }

	// RVA: 0x211C480 Offset: 0x211AA80 VA: 0x18211C480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C9B80 Offset: 0x20C8180 VA: 0x1820C9B80
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x211C510 Offset: 0x211AB10 VA: 0x18211C510
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x211C590 Offset: 0x211AB90 VA: 0x18211C590
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
