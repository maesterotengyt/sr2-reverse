// Namespace: 
public class EscapeRoomManager : SpeedRunnersGameModeManager // TypeDefIndex: 2588
{
	// Properties
	private SceneLoader sceneLoadManager { get; }
	private CampaignManager campaignManager { get; }
	private SaveManager saveManager { get; }

	// Methods

	// RVA: 0x6F5420 Offset: 0x6F3A20 VA: 0x1806F5420
	private SceneLoader get_sceneLoadManager() { }

	// RVA: 0x6F5380 Offset: 0x6F3980 VA: 0x1806F5380
	private CampaignManager get_campaignManager() { }

	// RVA: 0x6F53D0 Offset: 0x6F39D0 VA: 0x1806F53D0
	private SaveManager get_saveManager() { }

	// RVA: 0x6F48B0 Offset: 0x6F2EB0 VA: 0x1806F48B0 Slot: 4
	public override void Init() { }

	// RVA: 0x6F5160 Offset: 0x6F3760 VA: 0x1806F5160
	private void OnEscapeRoomStarted(EventEscapeRoomStarted callback) { }

	// RVA: 0x6F5300 Offset: 0x6F3900 VA: 0x1806F5300
	private void OnRestartEscapeRoomCourse(EventRestartEscapeRoomCourse callback) { }

	// RVA: 0x6F4AA0 Offset: 0x6F30A0 VA: 0x1806F4AA0
	public void LoadCurrentCourse() { }

	// RVA: 0x6F5310 Offset: 0x6F3910 VA: 0x1806F5310
	public void OnSaveChapterBestTime(EventSaveChapterBestTime callback) { }

	// RVA: 0x6F4E60 Offset: 0x6F3460 VA: 0x1806F4E60
	public void OnEscapeRoomCompleted() { }

	// RVA: 0x6EFA30 Offset: 0x6EE030 VA: 0x1806EFA30
	public void .ctor() { }
}
