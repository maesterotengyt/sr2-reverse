// Namespace: 
public class CampaignGameModeManager : SpeedRunnersGameModeManager // TypeDefIndex: 2581
{
	// Fields
	public CampaignMatchHUD CampaignMatchHUD; // 0x48

	// Properties
	private SaveManager saveManager { get; }
	private SceneLoader sceneLoader { get; }
	private CampaignManager campaignManager { get; }

	// Methods

	// RVA: 0x6F0E20 Offset: 0x6EF420 VA: 0x1806F0E20
	private SaveManager get_saveManager() { }

	// RVA: 0x6F0E70 Offset: 0x6EF470 VA: 0x1806F0E70
	private SceneLoader get_sceneLoader() { }

	// RVA: 0x6F0DD0 Offset: 0x6EF3D0 VA: 0x1806F0DD0
	private CampaignManager get_campaignManager() { }

	// RVA: 0x6EFC60 Offset: 0x6EE260 VA: 0x1806EFC60 Slot: 4
	public override void Init() { }

	// RVA: 0x6F0470 Offset: 0x6EEA70 VA: 0x1806F0470
	private void OnCampaignMatchLoadedAndReady(EventCampaignMatchLoadedAndReady callback) { }

	// RVA: 0x6F0550 Offset: 0x6EEB50 VA: 0x1806F0550
	private void OnMatchFinished(bool MatchWon) { }

	// RVA: 0x6F05F0 Offset: 0x6EEBF0 VA: 0x1806F05F0
	private void OnRestartCampaignMatch(EventRestartCampaignMatch callback) { }

	// RVA: 0x6F0670 Offset: 0x6EEC70 VA: 0x1806F0670
	public void ReloadCampaignMatch() { }

	// RVA: 0x6F0600 Offset: 0x6EEC00 VA: 0x1806F0600
	public void OnSaveChapterBestTime(EventSaveChapterBestTime callback) { }

	// RVA: 0x6EFFD0 Offset: 0x6EE5D0 VA: 0x1806EFFD0
	private void OnCampaignChapterCompleted(EventCampaignChapterCompleted callback) { }

	// RVA: 0x6EFA30 Offset: 0x6EE030 VA: 0x1806EFA30
	public void .ctor() { }
}
