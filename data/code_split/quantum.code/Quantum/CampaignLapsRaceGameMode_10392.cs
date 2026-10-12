// Namespace: Quantum
[Serializable]
public class CampaignLapsRaceGameMode : CampaignRaceGameMode // TypeDefIndex: 10392
{
	// Fields
	public int LapsToFinish; // 0xC0

	// Methods

	// RVA: 0x219C400 Offset: 0x219AA00 VA: 0x18219C400 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x219C2A0 Offset: 0x219A8A0 VA: 0x18219C2A0 Slot: 11
	public override void OnCharacterKnockOut(Frame frame, EntityRef entity) { }

	// RVA: 0x219C450 Offset: 0x219AA50 VA: 0x18219C450 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x219C330 Offset: 0x219A930 VA: 0x18219C330 Slot: 8
	public override void OnCharacterSpawn(Frame frame, EntityRef entity, CharacterSpawnData characterSpawnData) { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 12
	public override bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x219C340 Offset: 0x219A940 VA: 0x18219C340 Slot: 23
	public override void OnLapCompleted(Frame frame, EntityRef checkpointEntity, EntityRef characterEntity) { }

	// RVA: 0x219B010 Offset: 0x2199610 VA: 0x18219B010 Slot: 33
	public override void OnCountdownUpdateOver(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219C760 Offset: 0x219AD60 VA: 0x18219C760 Slot: 31
	public override void OnPlayingUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219C820 Offset: 0x219AE20 VA: 0x18219C820 Slot: 30
	public override void OnRoundWaitUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219BB20 Offset: 0x219A120 VA: 0x18219BB20 Slot: 29
	public override void OnRaceFinishedUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x219C8D0 Offset: 0x219AED0 VA: 0x18219C8D0
	public void .ctor() { }
}
