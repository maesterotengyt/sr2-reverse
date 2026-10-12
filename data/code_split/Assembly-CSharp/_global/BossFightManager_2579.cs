// Namespace: 
public class BossFightManager : SpeedRunnersGameModeManager // TypeDefIndex: 2579
{
	// Fields
	[CompilerGenerated]
	private int <CurrentSectionIndex>k__BackingField; // 0x48

	// Properties
	public int CurrentSectionIndex { get; set; }
	private SceneLoader sceneLoadManager { get; }
	private CampaignManager campaignManager { get; }
	private SaveManager saveManager { get; }
	private SceneLoader sceneLoader { get; }
	private UIManager uiManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C5B60 Offset: 0x5C4160 VA: 0x1805C5B60
	public int get_CurrentSectionIndex() { }

	[CompilerGenerated]
	// RVA: 0x5C5BB0 Offset: 0x5C41B0 VA: 0x1805C5BB0
	public void set_CurrentSectionIndex(int value) { }

	// RVA: 0x6EFAE0 Offset: 0x6EE0E0 VA: 0x1806EFAE0
	private SceneLoader get_sceneLoadManager() { }

	// RVA: 0x6EFA40 Offset: 0x6EE040 VA: 0x1806EFA40
	private CampaignManager get_campaignManager() { }

	// RVA: 0x6EFA90 Offset: 0x6EE090 VA: 0x1806EFA90
	private SaveManager get_saveManager() { }

	// RVA: 0x6EFB30 Offset: 0x6EE130 VA: 0x1806EFB30
	private SceneLoader get_sceneLoader() { }

	// RVA: 0x6EFB80 Offset: 0x6EE180 VA: 0x1806EFB80
	private UIManager get_uiManager() { }

	// RVA: 0x6EEC90 Offset: 0x6ED290 VA: 0x1806EEC90 Slot: 4
	public override void Init() { }

	// RVA: 0x6EF9B0 Offset: 0x6EDFB0 VA: 0x1806EF9B0
	private void OnRestartBossFight(EventRestartBossFight callback) { }

	// RVA: 0x6EF490 Offset: 0x6EDA90 VA: 0x1806EF490
	private void OnBossFightStarted(EventBossFightStarted callback) { }

	// RVA: 0x6EEF00 Offset: 0x6ED500 VA: 0x1806EEF00
	public void LoadCurrentSection() { }

	// RVA: 0x6EF9C0 Offset: 0x6EDFC0 VA: 0x1806EF9C0
	public void OnSaveChapterBestTime(EventSaveChapterBestTime callback) { }

	// RVA: 0x6EF620 Offset: 0x6EDC20 VA: 0x1806EF620
	private void OnCampaignChapterCompleted(EventCampaignChapterCompleted callback) { }

	// RVA: 0x6EFA30 Offset: 0x6EE030 VA: 0x1806EFA30
	public void .ctor() { }
}
