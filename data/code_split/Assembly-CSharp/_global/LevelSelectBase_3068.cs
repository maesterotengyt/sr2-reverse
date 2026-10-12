// Namespace: 
public class LevelSelectBase : MainMenuScreen // TypeDefIndex: 3068
{
	// Fields
	[Header("Level Select")]
	public float DecidingAnimationDuration; // 0x90
	public float ShowChosenLevelAnimationDuration; // 0x94
	public List<LevelSelector> Selectors; // 0x98
	public MenuPlayersHighlight PlayerHighlights; // 0xA0
	public UINavigator UINavigator; // 0xA8
	public Transform LevelOptions; // 0xB0
	public List<LevelSelectBase.GameModeStagesBlacklist> StagesBlacklists; // 0xB8
	public LevelSelectedAnimation LevelSelectedAnimation; // 0xC0
	public LocalizedString PlayerShorteningString; // 0xC8
	public LocalizedString CPUNameString; // 0xD0

	// Properties
	protected SceneLoader sceneLoadManager { get; }
	protected AudioManager audioManager { get; }
	protected UIManager uiManager { get; }
	protected OnlineManager onlineManager { get; }
	protected DataManager dataManager { get; }

	// Methods

	// RVA: 0x5435A0 Offset: 0x541BA0 VA: 0x1805435A0
	protected SceneLoader get_sceneLoadManager() { }

	// RVA: 0x5434B0 Offset: 0x541AB0 VA: 0x1805434B0
	protected AudioManager get_audioManager() { }

	// RVA: 0x5435F0 Offset: 0x541BF0 VA: 0x1805435F0
	protected UIManager get_uiManager() { }

	// RVA: 0x543550 Offset: 0x541B50 VA: 0x180543550
	protected OnlineManager get_onlineManager() { }

	// RVA: 0x543500 Offset: 0x541B00 VA: 0x180543500
	protected DataManager get_dataManager() { }

	// RVA: 0x5423F0 Offset: 0x5409F0 VA: 0x1805423F0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x543250 Offset: 0x541850 VA: 0x180543250 Slot: 7
	public override void Show() { }

	// RVA: 0x542630 Offset: 0x540C30 VA: 0x180542630
	private void OnInputDeviceActivated(int inputDeviceIndex) { }

	// RVA: 0x5413E0 Offset: 0x53F9E0 VA: 0x1805413E0
	private void DeactivateUnusedInputDevices() { }

	// RVA: 0x5426D0 Offset: 0x540CD0 VA: 0x1805426D0
	private void SetOptionsData() { }

	// RVA: 0x5418B0 Offset: 0x53FEB0 VA: 0x1805418B0
	private void GenerateSelectors() { }

	// RVA: 0x541310 Offset: 0x53F910 VA: 0x180541310
	public void CreatePlayerSelector(int playerIndex, int inputDeviceIndex) { }

	// RVA: 0x541120 Offset: 0x53F720 VA: 0x180541120
	public void CreateCPUSelectorIdentifier(string cpuName) { }

	// RVA: 0x5422A0 Offset: 0x5408A0 VA: 0x1805422A0
	public LevelSelector GetUnusedSelector() { }

	// RVA: 0x542150 Offset: 0x540750 VA: 0x180542150
	public LevelSelector GetPlayerSelector(int playerIndex) { }

	// RVA: 0x5420E0 Offset: 0x5406E0 VA: 0x1805420E0
	private LevelSelectOption GetLevelOption(int index) { }

	// RVA: 0x540FD0 Offset: 0x53F5D0 VA: 0x180540FD0
	public bool AreAllSelectorsReady() { }

	// RVA: 0x541F50 Offset: 0x540550 VA: 0x180541F50
	public List<LevelSelector> GetEnabledSelectors() { }

	// RVA: 0x541690 Offset: 0x53FC90 VA: 0x180541690 Slot: 12
	public override void Disable() { }

	// RVA: 0x543410 Offset: 0x541A10 VA: 0x180543410
	public void .ctor() { }
}
