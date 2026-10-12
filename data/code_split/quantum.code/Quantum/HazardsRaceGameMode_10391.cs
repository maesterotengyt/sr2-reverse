// Namespace: Quantum
[Serializable]
public class HazardsRaceGameMode : RaceGameMode // TypeDefIndex: 10391
{
	// Fields
	public AssetRefGameEntityData ItemSpawner; // 0xA0
	public FP ItemSpawnCooldown; // 0xA8
	public FP StartHazardsTimer; // 0xB0
	public FP HazardsIncomingTimer; // 0xB8
	public FP AmountOfHazardsToSpawn; // 0xC0
	public List<HashString> HazardsList; // 0xC8
	private bool HazardsWarningActive; // 0xD0
	private bool SpawnDirectionSet; // 0xD1

	// Methods

	// RVA: 0x21A1DB0 Offset: 0x21A03B0 VA: 0x1821A1DB0 Slot: 28
	protected override void StartMatch(Frame frame) { }

	// RVA: 0x21A1BE0 Offset: 0x21A01E0 VA: 0x1821A1BE0 Slot: 30
	public override void OnRoundWaitUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A1620 Offset: 0x219FC20 VA: 0x1821A1620 Slot: 31
	public override void OnPlayingUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21A1CA0 Offset: 0x21A02A0 VA: 0x1821A1CA0
	public void ResetRoundTimers(Frame frame) { }

	// RVA: 0x219AFE0 Offset: 0x21995E0 VA: 0x18219AFE0
	public bool IsInside(FPVector2 pt, FPVector2 TopLeft, FPVector2 BottomRight) { }

	// RVA: 0x21A2160 Offset: 0x21A0760 VA: 0x1821A2160
	public static bool TryFindManager(Frame frame, out HazardsRaceGameModeManager* hazardsRaceManager) { }

	// RVA: 0x21A2010 Offset: 0x21A0610 VA: 0x1821A2010
	public static bool TryFindGameModeItemAutoTrigger(Frame frame, out GameModeItemAutoTrigger* autoTrigger) { }

	// RVA: 0x21A1540 Offset: 0x219FB40 VA: 0x1821A1540 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21A15C0 Offset: 0x219FBC0 VA: 0x1821A15C0 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x21A2330 Offset: 0x21A0930 VA: 0x1821A2330
	public void .ctor() { }
}
