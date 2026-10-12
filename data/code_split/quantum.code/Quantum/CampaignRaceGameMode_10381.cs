// Namespace: Quantum
[Serializable]
public class CampaignRaceGameMode : RaceGameMode // TypeDefIndex: 10381
{
	// Fields
	public GameSpeedModifier DialogueSpeedModifier; // 0xA0

	// Methods

	// RVA: 0x217CDB0 Offset: 0x217B3B0 VA: 0x18217CDB0
	public static bool TryFindManager(Frame frame, out CampaignRaceGameModeManager* campaignManager) { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 27
	protected override bool StartMatchAutomatically() { }

	// RVA: 0x217CDA0 Offset: 0x217B3A0 VA: 0x18217CDA0 Slot: 37
	public virtual void StartMatch(Frame frame) { }

	// RVA: 0x217CD20 Offset: 0x217B320 VA: 0x18217CD20
	public void RestartMatch(Frame frame) { }

	// RVA: 0x217C540 Offset: 0x217AB40 VA: 0x18217C540 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x217C0A0 Offset: 0x217A6A0 VA: 0x18217C0A0
	public void OnCampaignDialogueFinished(Frame frame) { }

	// RVA: 0x217C050 Offset: 0x217A650 VA: 0x18217C050
	public void OnCampaignChapterFinished(Frame frame) { }

	// RVA: 0x217C480 Offset: 0x217AA80 VA: 0x18217C480
	internal void OnInfoSetup(Frame frame, bool hasDialogue) { }

	// RVA: 0x217C430 Offset: 0x217AA30 VA: 0x18217C430 Slot: 33
	public override void OnCountdownUpdateOver(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x217CAF0 Offset: 0x217B0F0 VA: 0x18217CAF0 Slot: 31
	public override void OnPlayingUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x217CCB0 Offset: 0x217B2B0 VA: 0x18217CCB0 Slot: 30
	public override void OnRoundWaitUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x217C570 Offset: 0x217AB70 VA: 0x18217C570 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x217CBB0 Offset: 0x217B1B0 VA: 0x18217CBB0 Slot: 29
	public override void OnRaceFinishedUpdate(Frame frame, RaceGameModeManager* raceGameModeManager) { }

	// RVA: 0x217C100 Offset: 0x217A700 VA: 0x18217C100
	public void OnCampaignForceWin(Frame frame) { }

	// RVA: 0x217CF70 Offset: 0x217B570 VA: 0x18217CF70
	public void .ctor() { }
}
