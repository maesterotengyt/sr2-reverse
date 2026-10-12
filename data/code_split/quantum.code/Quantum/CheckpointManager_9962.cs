// Namespace: Quantum
public struct CheckpointManager : IComponent // TypeDefIndex: 9962
{
	// Fields
	[PtrQList(typeof(EntityRef))]
	private Ptr CheckpointListPtr; // 0x4
	[HideInInspector]
	public EntityRef CurrentWinningPlayer; // 0x10
	[HideInInspector]
	public EntityRef LastRespawnPoint; // 0x18
	[HideInInspector]
	public int LastSpawnDirection; // 0x0
	[HideInInspector]
	[PtrQList(typeof(EntityRef))]
	private Ptr RankingPtr; // 0x8
	[HideInInspector]
	public FP TotalLapDistance; // 0x20
	public static ColorRGBA PlayerDistanceColor; // 0x0
	public static ColorRGBA WinningPlayerDistanceColor; // 0x4

	// Properties
	public QListPtr<EntityRef> CheckpointList { get; set; }
	public QListPtr<EntityRef> Ranking { get; set; }

	// Methods

	// RVA: 0x20CCAD0 Offset: 0x20CB0D0 VA: 0x1820CCAD0
	public QListPtr<EntityRef> get_CheckpointList() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_CheckpointList(QListPtr<EntityRef> value) { }

	// RVA: 0x20CCB10 Offset: 0x20CB110 VA: 0x1820CCB10
	public QListPtr<EntityRef> get_Ranking() { }

	// RVA: 0x1ED2130 Offset: 0x1ED0730 VA: 0x181ED2130
	public void set_Ranking(QListPtr<EntityRef> value) { }

	// RVA: 0x20CB240 Offset: 0x20C9840 VA: 0x1820CB240 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CA940 Offset: 0x20C8F40 VA: 0x1820CA940
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20CB7B0 Offset: 0x20C9DB0 VA: 0x1820CB7B0
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20CB850 Offset: 0x20C9E50 VA: 0x1820CB850
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20CB2B0 Offset: 0x20C98B0 VA: 0x1820CB2B0
	public void OnInit(Frame frame) { }

	// RVA: 0x20CC9D0 Offset: 0x20CAFD0 VA: 0x1820CC9D0
	public void Update(Frame frame) { }

	// RVA: 0x20CBB10 Offset: 0x20CA110 VA: 0x1820CBB10
	public void UpdateCheckpointDebugLines(Frame frame) { }

	// RVA: 0x20CA900 Offset: 0x20C8F00 VA: 0x1820CA900
	private void CalculateStepsToReachCheckpoint(int totalCheckpoints, int target, int start, int direction, out int steps, out bool overflow) { }

	// RVA: 0x20CBE70 Offset: 0x20CA470 VA: 0x1820CBE70
	public void UpdateCheckpoint(Frame frame, EntityRef checkpointEntity, EntityRef playerEntity, EntityRef respawnPointEntity) { }

	// RVA: 0x20CAC70 Offset: 0x20C9270 VA: 0x1820CAC70
	public void EvaluateCheckpointDirection(Frame frame, EntityRef checkpointEntity, EntityRef characterEntity) { }

	// RVA: 0x20CA950 Offset: 0x20C8F50 VA: 0x1820CA950
	public void DisableCheckpoints(Frame frame) { }

	// RVA: 0x20CAAE0 Offset: 0x20C90E0 VA: 0x1820CAAE0
	public void EnableCheckpoints(Frame frame) { }

	// RVA: 0x20CC120 Offset: 0x20CA720 VA: 0x1820CC120
	public void UpdateRanking(Frame frame) { }

	// RVA: 0x20CB9C0 Offset: 0x20C9FC0 VA: 0x1820CB9C0
	public static bool TryFind(Frame frame, out CheckpointManager* checkpointManager) { }

	// RVA: 0x20CCA70 Offset: 0x20CB070 VA: 0x1820CCA70
	private static void .cctor() { }
}
