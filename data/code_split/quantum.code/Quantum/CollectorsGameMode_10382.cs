// Namespace: Quantum
[Serializable]
public class CollectorsGameMode : RaceGameMode // TypeDefIndex: 10382
{
	// Fields
	public FP MatchTime; // 0xA0
	public FP TreasureSpawnRate; // 0xA8
	public int MaxTreasures; // 0xB0
	public TreasureWeightElement[] Treasures; // 0xB8
	public CollectorAttackData[] AttackDatasToDropTreasures; // 0xC0

	// Methods

	// RVA: 0x217E750 Offset: 0x217CD50 VA: 0x18217E750
	public static bool TryFindCollectorsModeManager(Frame frame, out CollectorsGameModeManager* collectorsManager) { }

	// RVA: 0x217D4E0 Offset: 0x217BAE0 VA: 0x18217D4E0 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x217D450 Offset: 0x217BA50 VA: 0x18217D450 Slot: 8
	public override void OnCharacterSpawn(Frame frame, EntityRef entity, CharacterSpawnData characterSpawnData) { }

	// RVA: 0x217D130 Offset: 0x217B730 VA: 0x18217D130 Slot: 25
	public override void OnCharacterHurt(Frame frame, EntityRef characterEntity, int attackDataID) { }

	// RVA: 0x217DD10 Offset: 0x217C310 VA: 0x18217DD10 Slot: 31
	public override void OnPlayingUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x217D720 Offset: 0x217BD20 VA: 0x18217D720 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 11
	public override void OnCharacterKnockOut(Frame frame, EntityRef entity) { }

	// RVA: 0x217E8A0 Offset: 0x217CEA0 VA: 0x18217E8A0
	public void .ctor() { }
}
