// Namespace: Quantum
[Serializable]
public class CampaignHazardsRaceGameMode : CampaignRaceGameMode // TypeDefIndex: 10390
{
	// Fields
	public AssetRefGameEntityData ItemSpawner; // 0xC0
	public FP ItemSpawnCooldown; // 0xC8
	public FP StartHazardsTimer; // 0xD0
	public FP HazardsIncomingTimer; // 0xD8
	public FP AmountOfHazardsToSpawn; // 0xE0
	public List<HashString> HazardsList; // 0xE8
	private bool HazardsWarningActive; // 0xF0
	private bool SpawnDirectionSet; // 0xF1

	// Methods

	// RVA: 0x219BDA0 Offset: 0x219A3A0 VA: 0x18219BDA0 Slot: 37
	public override void StartMatch(Frame frame) { }

	// RVA: 0x219B4E0 Offset: 0x2199AE0 VA: 0x18219B4E0 Slot: 31
	public override void OnPlayingUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219BC90 Offset: 0x219A290 VA: 0x18219BC90
	public void ResetRoundTimers(Frame frame) { }

	// RVA: 0x219AFE0 Offset: 0x21995E0 VA: 0x18219AFE0
	public bool IsInside(FPVector2 pt, FPVector2 TopLeft, FPVector2 BottomRight) { }

	// RVA: 0x219C0C0 Offset: 0x219A6C0 VA: 0x18219C0C0
	public static bool TryFindManager(Frame frame, out HazardsRaceGameModeManager* hazardsRaceManager) { }

	// RVA: 0x219BF70 Offset: 0x219A570 VA: 0x18219BF70
	public static bool TryFindGameModeItemAutoTrigger(Frame frame, out GameModeItemAutoTrigger* autoTrigger) { }

	// RVA: 0x219B060 Offset: 0x2199660 VA: 0x18219B060 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x219B090 Offset: 0x2199690 VA: 0x18219B090 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x219B010 Offset: 0x2199610 VA: 0x18219B010 Slot: 33
	public override void OnCountdownUpdateOver(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219BC10 Offset: 0x219A210 VA: 0x18219BC10 Slot: 30
	public override void OnRoundWaitUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219BB20 Offset: 0x219A120 VA: 0x18219BB20 Slot: 29
	public override void OnRaceFinishedUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219C290 Offset: 0x219A890 VA: 0x18219C290
	public void .ctor() { }
}
