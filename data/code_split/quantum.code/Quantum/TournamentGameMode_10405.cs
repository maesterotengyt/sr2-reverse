// Namespace: Quantum
[Serializable]
public class TournamentGameMode : RaceGameMode // TypeDefIndex: 10405
{
	// Fields
	public AssetRefGameEntityData ItemSpawner; // 0xA0
	public FP ItemSpawnCooldown; // 0xA8
	public FP StartRocketsTimer; // 0xB0
	public FP RocketsIncomingTimer; // 0xB8

	// Methods

	// RVA: 0x21ACED0 Offset: 0x21AB4D0 VA: 0x1821ACED0 Slot: 28
	protected override void StartMatch(Frame frame) { }

	// RVA: 0x21AD070 Offset: 0x21AB670 VA: 0x1821AD070
	public static bool TryFindGameModeItemAutoTrigger(Frame frame, out GameModeItemAutoTrigger* autoTrigger) { }

	// RVA: 0x21AD1C0 Offset: 0x21AB7C0 VA: 0x1821AD1C0
	public static bool TryFindManager(Frame frame, out TournamentGameModeManager* tournamentManager) { }

	// RVA: 0x21A1540 Offset: 0x219FB40 VA: 0x1821A1540 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x21ACC50 Offset: 0x21AB250 VA: 0x1821ACC50 Slot: 31
	public override void OnPlayingUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x21ACBC0 Offset: 0x21AB1C0 VA: 0x1821ACBC0 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x21A2330 Offset: 0x21A0930 VA: 0x1821A2330
	public void .ctor() { }
}
