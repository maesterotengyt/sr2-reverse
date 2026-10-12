// Namespace: 
public class GameSettingsPanel : SettingsSubPanel // TypeDefIndex: 3167
{
	// Fields
	public List<LanguageData> Languages; // 0x50
	public List<OutlineColorOptionData> OutlineColorOptionData; // 0x58
	public List<OutlineOnlineOptionData> OutlineOnlineOptionData; // 0x60
	public List<OutlineOnlineOptionData> OpponentsOutlineOptionData; // 0x68
	public List<LocalizedString> TrailsOptionData; // 0x70
	public List<TMP_FontAsset> DynamicFonts; // 0x78
	public StellarSelectorOption LanguageSelector; // 0x80
	public StellarSelectorOption CameraFOVSelector; // 0x88
	public StellarSelectorOption DetailedRopeEffectSelector; // 0x90
	public StellarSelectorOption EmotesSelector; // 0x98
	public StellarSelectorOption FPSCapToggleSelector; // 0xA0
	public StellarSelectorOption TrailsSelector; // 0xA8
	public StellarSelectorOption OutlineColorSelector; // 0xB0
	public StellarSelectorOption OutlineOnlineSelector; // 0xB8
	public StellarSelectorOption OpponentsOutlineSelector; // 0xC0
	public LocalizedString CameraFOV1String; // 0xC8
	public LocalizedString CameraFOV2String; // 0xD0
	public LocalizedString CameraFOV3String; // 0xD8
	public LocalizedString EmotesHudOnlyString; // 0xE0
	public LocalizedString YesString; // 0xE8
	public LocalizedString NoString; // 0xF0
	public bool FromPauseMenu; // 0xF8
	private bool settingsChanged; // 0xF9
	private Coroutine saveCoroutine; // 0x100
	private const float saveDelay = 1.5;

	// Methods

	// RVA: 0x56F4E0 Offset: 0x56DAE0 VA: 0x18056F4E0 Slot: 7
	protected override void Update() { }

	[IteratorStateMachine(typeof(GameSettingsPanel.<SaveSettingsWithDelay>d__26))]
	// RVA: 0x56DF00 Offset: 0x56C500 VA: 0x18056DF00
	private IEnumerator SaveSettingsWithDelay() { }

	// RVA: 0x56CFF0 Offset: 0x56B5F0 VA: 0x18056CFF0 Slot: 4
	public override void Init(SettingsPanelManager panelManager) { }

	// RVA: 0x56E370 Offset: 0x56C970 VA: 0x18056E370
	private void SetLanguageOptions() { }

	// RVA: 0x56E7B0 Offset: 0x56CDB0 VA: 0x18056E7B0
	private void SetOutlineColorOptions() { }

	// RVA: 0x56E9D0 Offset: 0x56CFD0 VA: 0x18056E9D0
	private void SetOutlineOnlineOptions() { }

	// RVA: 0x56E590 Offset: 0x56CB90 VA: 0x18056E590
	private void SetOpponentOutlineOptions() { }

	// RVA: 0x56DF70 Offset: 0x56C570 VA: 0x18056DF70
	private void SetCameraFOVOptions() { }

	// RVA: 0x56E170 Offset: 0x56C770 VA: 0x18056E170
	private void SetEmotesOptions() { }

	// RVA: 0x56EBF0 Offset: 0x56D1F0 VA: 0x18056EBF0
	private void SetTrailsOptions() { }

	// RVA: 0x56EE20 Offset: 0x56D420 VA: 0x18056EE20 Slot: 5
	public override void Show() { }

	// RVA: 0x56D260 Offset: 0x56B860 VA: 0x18056D260
	public void LanguageChanged(int option) { }

	// RVA: 0x56CE90 Offset: 0x56B490 VA: 0x18056CE90
	public void CameraFOVChanged(int option) { }

	// RVA: 0x56CEE0 Offset: 0x56B4E0 VA: 0x18056CEE0
	public void DetailedRopeEffectChanged(int option) { }

	// RVA: 0x56CF30 Offset: 0x56B530 VA: 0x18056CF30
	public void EmotesEnabledChanged(int option) { }

	// RVA: 0x56DBD0 Offset: 0x56C1D0 VA: 0x18056DBD0
	public void OutlineColorChanged(int option) { }

	// RVA: 0x56DD80 Offset: 0x56C380 VA: 0x18056DD80
	public void OutlineOnlineChanged(int option) { }

	// RVA: 0x56DB50 Offset: 0x56C150 VA: 0x18056DB50
	public void OpponentsOutlineChanged(int option) { }

	// RVA: 0x56F470 Offset: 0x56DA70 VA: 0x18056F470
	public void TrailsChanged(int option) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void FPSCapEnabledChanged(int option) { }

	// RVA: 0x56F5F0 Offset: 0x56DBF0 VA: 0x18056F5F0
	public void .ctor() { }
}
