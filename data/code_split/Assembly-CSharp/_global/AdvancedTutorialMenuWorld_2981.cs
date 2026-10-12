// Namespace: 
public class AdvancedTutorialMenuWorld : MainMenuWorldScreen // TypeDefIndex: 2981
{
	// Fields
	public HashString AdvancedTutorialStageID; // 0x30
	public LocalizedString ItemsTitleString; // 0x40
	public LocalizedString MechanicsTitleString; // 0x48
	public LocalizedString PracticeSectionString; // 0x50
	public UINavigator TutorialsNavigator; // 0x58
	public Image TutorialImage; // 0x60
	public TMP_Text TutorialNameText; // 0x68
	public TMP_Text TutorialDescriptionText; // 0x70

	// Methods

	// RVA: 0x76D930 Offset: 0x76BF30 VA: 0x18076D930 Slot: 4
	public override void Initialize(MainMenuScreen mainMenuScreen) { }

	// RVA: 0x76E190 Offset: 0x76C790 VA: 0x18076E190 Slot: 5
	public override void Show() { }

	// RVA: 0x76D880 Offset: 0x76BE80 VA: 0x18076D880 Slot: 6
	public override void Hide() { }

	// RVA: 0x76DAC0 Offset: 0x76C0C0 VA: 0x18076DAC0
	private void OnHeaderOptionSelected(int optionIndex) { }

	// RVA: 0x76DAE0 Offset: 0x76C0E0 VA: 0x18076DAE0
	public void OnTutorialHighlighted() { }

	// RVA: 0x76DBC0 Offset: 0x76C1C0 VA: 0x18076DBC0
	public void OnTutorialSelected(int tutorialIndex) { }

	// RVA: 0x76E0D0 Offset: 0x76C6D0 VA: 0x18076E0D0
	public void SetTutorialInfo(AdvancedTutorialMenuOption tutorialMenuOption) { }

	// RVA: 0x76D800 Offset: 0x76BE00 VA: 0x18076D800
	public AdvancedTutorialMenuOption GetMenuOption(int optionIndex) { }

	// RVA: 0x76DCE0 Offset: 0x76C2E0 VA: 0x18076DCE0
	public void ReloadItemTutorials() { }

	// RVA: 0x76DEA0 Offset: 0x76C4A0 VA: 0x18076DEA0
	public void ReloadMechanicTutorials() { }

	// RVA: 0x76E060 Offset: 0x76C660 VA: 0x18076E060
	public void ReturnToPreviousScreen() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
