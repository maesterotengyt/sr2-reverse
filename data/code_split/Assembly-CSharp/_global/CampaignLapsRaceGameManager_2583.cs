// Namespace: 
public class CampaignLapsRaceGameManager : SpeedRunnersGameModeManager // TypeDefIndex: 2583
{
	// Properties
	private SaveManager saveManager { get; }
	private SceneLoader sceneLoader { get; }
	private CampaignManager campaignManager { get; }

	// Methods

	// RVA: 0x6F3380 Offset: 0x6F1980 VA: 0x1806F3380
	private SaveManager get_saveManager() { }

	// RVA: 0x6F33D0 Offset: 0x6F19D0 VA: 0x1806F33D0
	private SceneLoader get_sceneLoader() { }

	// RVA: 0x6F3330 Offset: 0x6F1930 VA: 0x1806F3330
	private CampaignManager get_campaignManager() { }

	// RVA: 0x6F21E0 Offset: 0x6F07E0 VA: 0x1806F21E0 Slot: 4
	public override void Init() { }

	// RVA: 0x6F3130 Offset: 0x6F1730 VA: 0x1806F3130
	private void OnCampaignMatchLoadedAndReady(EventCampaignMatchLoadedAndReady callback) { }

	// RVA: 0x6F3210 Offset: 0x6F1810 VA: 0x1806F3210
	private void OnMatchFinished(bool MatchWon) { }

	// RVA: 0x6F32B0 Offset: 0x6F18B0 VA: 0x1806F32B0
	private void OnRestartLapsRace(EventRestartLapsRace callback) { }

	// RVA: 0x6F2550 Offset: 0x6F0B50 VA: 0x1806F2550
	public void LoadCurrentSection() { }

	// RVA: 0x6F32C0 Offset: 0x6F18C0 VA: 0x1806F32C0
	public void OnSaveChapterBestTime(EventSaveChapterBestTime callback) { }

	// RVA: 0x6F2C90 Offset: 0x6F1290 VA: 0x1806F2C90
	private void OnCampaignChapterCompleted(EventCampaignChapterCompleted callback) { }

	// RVA: 0x6EFA30 Offset: 0x6EE030 VA: 0x1806EFA30
	public void .ctor() { }
}
