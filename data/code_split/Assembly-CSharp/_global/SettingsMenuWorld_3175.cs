// Namespace: 
public class SettingsMenuWorld : MainMenuWorldScreen // TypeDefIndex: 3175
{
	// Fields
	public SettingsPanelManager SettingsPanelManager; // 0x30
	public UINavigator UINavigator; // 0x38
	public UINavigationElement OnlineNavigationElement; // 0x40
	public LocalizedString ExitGameString; // 0x48
	public LocalizedString ExitGameWarningString; // 0x50
	public LocalizedString YesString; // 0x58
	public LocalizedString NoString; // 0x60
	public StellarUIAnimator ExitOption; // 0x68
	public TMP_Text VersionText; // 0x70
	[SerializeField]
	private GameObject GraphicsSettingsButton; // 0x78
	[SerializeField]
	private GameObject ExitButton; // 0x80
	[SerializeField]
	private GameObject ReportBugButton; // 0x88

	// Methods

	// RVA: 0x58BF90 Offset: 0x58A590 VA: 0x18058BF90 Slot: 4
	public override void Initialize(MainMenuScreen mainMenuScreen) { }

	// RVA: 0x58C7A0 Offset: 0x58ADA0 VA: 0x18058C7A0 Slot: 5
	public override void Show() { }

	// RVA: 0x58C740 Offset: 0x58AD40 VA: 0x18058C740
	public void SelectGraphicsOption() { }

	// RVA: 0x58C570 Offset: 0x58AB70 VA: 0x18058C570
	public void SelectAudioOption() { }

	// RVA: 0x58C680 Offset: 0x58AC80 VA: 0x18058C680
	public void SelectGameOption() { }

	// RVA: 0x58C6B0 Offset: 0x58ACB0 VA: 0x18058C6B0
	public void SelectGlossaryOption() { }

	// RVA: 0x58C310 Offset: 0x58A910 VA: 0x18058C310
	public void ReportBug() { }

	// RVA: 0x58C450 Offset: 0x58AA50 VA: 0x18058C450
	public void ReportWindowsClosed(bool isActive) { }

	// RVA: 0x58C770 Offset: 0x58AD70 VA: 0x18058C770
	public void SelectOnlineOption() { }

	// RVA: 0x58C5A0 Offset: 0x58ABA0 VA: 0x18058C5A0
	public void SelectControlsOption() { }

	// RVA: 0x58C610 Offset: 0x58AC10 VA: 0x18058C610
	public void SelectCredits() { }

	// RVA: 0x53BF00 Offset: 0x53A500 VA: 0x18053BF00
	public void ReturnToHub() { }

	// RVA: 0x58BBA0 Offset: 0x58A1A0 VA: 0x18058BBA0
	public void ExitGame() { }

	// RVA: 0x58BF20 Offset: 0x58A520 VA: 0x18058BF20 Slot: 6
	public override void Hide() { }

	// RVA: 0x58C070 Offset: 0x58A670 VA: 0x18058C070
	public void OnExitOptionSelected(string popUpID, int option) { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
