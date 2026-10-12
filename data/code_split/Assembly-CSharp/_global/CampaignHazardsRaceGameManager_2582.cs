// Namespace: 
public class CampaignHazardsRaceGameManager : SpeedRunnersGameModeManager // TypeDefIndex: 2582
{
	// Properties
	private SaveManager saveManager { get; }
	private SceneLoader sceneLoader { get; }
	private CampaignManager campaignManager { get; }
	private UIManager uiManager { get; }

	// Methods

	// RVA: 0x6F20F0 Offset: 0x6F06F0 VA: 0x1806F20F0
	private SaveManager get_saveManager() { }

	// RVA: 0x6F2140 Offset: 0x6F0740 VA: 0x1806F2140
	private SceneLoader get_sceneLoader() { }

	// RVA: 0x6F20A0 Offset: 0x6F06A0 VA: 0x1806F20A0
	private CampaignManager get_campaignManager() { }

	// RVA: 0x6F2190 Offset: 0x6F0790 VA: 0x1806F2190
	private UIManager get_uiManager() { }

	// RVA: 0x6F0EC0 Offset: 0x6EF4C0 VA: 0x1806F0EC0 Slot: 4
	public override void Init() { }

	// RVA: 0x6F1EA0 Offset: 0x6F04A0 VA: 0x1806F1EA0
	private void OnCampaignMatchLoadedAndReady(EventCampaignMatchLoadedAndReady callback) { }

	// RVA: 0x6F1F80 Offset: 0x6F0580 VA: 0x1806F1F80
	private void OnMatchFinished(bool MatchWon) { }

	// RVA: 0x6F2020 Offset: 0x6F0620 VA: 0x1806F2020
	private void OnRestartHazardsRace(EventRestartHazardsRace callback) { }

	// RVA: 0x6F1230 Offset: 0x6EF830 VA: 0x1806F1230
	public void LoadCurrentSection() { }

	// RVA: 0x6F2030 Offset: 0x6F0630 VA: 0x1806F2030
	public void OnSaveChapterBestTime(EventSaveChapterBestTime callback) { }

	// RVA: 0x6F1A00 Offset: 0x6F0000 VA: 0x1806F1A00
	private void OnCampaignChapterCompleted(EventCampaignChapterCompleted callback) { }

	// RVA: 0x6EFA30 Offset: 0x6EE030 VA: 0x1806EFA30
	public void .ctor() { }
}
