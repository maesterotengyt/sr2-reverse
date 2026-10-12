// Namespace: Quantum
public struct CollectorsGameModeManager : IComponent // TypeDefIndex: 9965
{
	// Fields
	public QBoolean MatchFinished; // 0x0
	public FP NextTreasureSpawnTimer; // 0x8
	public FP RemainingMatchTime; // 0x10
	[PtrQHashSet(typeof(int))]
	private Ptr SpawnAreasUsedPtr; // 0x4

	// Properties
	public QHashSetPtr<int> SpawnAreasUsed { get; set; }

	// Methods

	// RVA: 0x20CD100 Offset: 0x20CB700 VA: 0x1820CD100
	public QHashSetPtr<int> get_SpawnAreasUsed() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_SpawnAreasUsed(QHashSetPtr<int> value) { }

	// RVA: 0x20CCF40 Offset: 0x20CB540 VA: 0x1820CCF40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CCF30 Offset: 0x20CB530 VA: 0x1820CCF30
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20CCF90 Offset: 0x20CB590 VA: 0x1820CCF90
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20CD010 Offset: 0x20CB610 VA: 0x1820CD010
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
