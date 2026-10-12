// Namespace: 
public class GraphicsSettingsPanel : SettingsSubPanel // TypeDefIndex: 3171
{
	// Fields
	public bool IsInMainMenu; // 0x50
	public UINavigationElement[] MainMenuOnlyOptions; // 0x58
	public StellarSelectorOption ResolutionsSelector; // 0x60
	public StellarSelectorOption DisplayModeSelector; // 0x68
	public StellarSelectorOption QualitySelector; // 0x70
	public StellarSelectorOption VSyncSelector; // 0x78
	[Header("Strings")]
	public LocalizedString DisplayMode1String; // 0x80
	public LocalizedString DisplayMode2String; // 0x88
	public LocalizedString DisplayMode3String; // 0x90
	public LocalizedString Quality1String; // 0x98
	public LocalizedString Quality2String; // 0xA0
	public LocalizedString Quality3String; // 0xA8
	public LocalizedString YesString; // 0xB0
	public LocalizedString NoString; // 0xB8

	// Methods

	// RVA: 0x56F830 Offset: 0x56DE30 VA: 0x18056F830 Slot: 4
	public override void Init(SettingsPanelManager panelManager) { }

	// RVA: 0x5700F0 Offset: 0x56E6F0 VA: 0x1805700F0 Slot: 5
	public override void Show() { }

	// RVA: 0x56FFB0 Offset: 0x56E5B0 VA: 0x18056FFB0
	public void ResolutionChanged(int option) { }

	// RVA: 0x56F7B0 Offset: 0x56DDB0 VA: 0x18056F7B0
	public void DisplayModeChanged(int option) { }

	// RVA: 0x56FF50 Offset: 0x56E550 VA: 0x18056FF50
	public void QualityChanged(int option) { }

	// RVA: 0x570440 Offset: 0x56EA40 VA: 0x180570440
	public void VSyncValueChanged(int value) { }

	// RVA: 0x5704B0 Offset: 0x56EAB0 VA: 0x1805704B0
	public void .ctor() { }
}
