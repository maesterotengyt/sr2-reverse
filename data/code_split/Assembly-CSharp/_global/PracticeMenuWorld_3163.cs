// Namespace: 
public class PracticeMenuWorld : MainMenuWorldScreen // TypeDefIndex: 3163
{
	// Fields
	public const string BasicTutorialPopupID = "tutorial_popup";
	public PracticeMenuOption BasicTutorialOption; // 0x30
	public LocalizedString PracticeSectionString; // 0x38
	public LocalizedString BasicTutorialConfirmationTitleString; // 0x40
	public LocalizedString BasicTutorialConfirmationDescription; // 0x48
	public LocalizedString TryBasicTutorialString; // 0x50
	public LocalizedString TryBasicTutorialDescriptionString; // 0x58
	private bool basicTutorialPopupActive; // 0x60

	// Properties
	protected SceneLoader sceneLoadManager { get; }

	// Methods

	// RVA: 0x57CA10 Offset: 0x57B010 VA: 0x18057CA10
	protected SceneLoader get_sceneLoadManager() { }

	// RVA: 0x57C500 Offset: 0x57AB00 VA: 0x18057C500 Slot: 5
	public override void Show() { }

	// RVA: 0x57B920 Offset: 0x579F20 VA: 0x18057B920 Slot: 6
	public override void Hide() { }

	// RVA: 0x57C1E0 Offset: 0x57A7E0 VA: 0x18057C1E0
	public void SelectTraining() { }

	// RVA: 0x57BDC0 Offset: 0x57A3C0 VA: 0x18057BDC0
	public void SelectAdvancedTutorial() { }

	// RVA: 0x57C0C0 Offset: 0x57A6C0 VA: 0x18057C0C0
	public void SelectBasicTutorial() { }

	// RVA: 0x57B8B0 Offset: 0x579EB0 VA: 0x18057B8B0
	private void BasicTutorialPopupOptionSelected(string popUpID, int optionIndex) { }

	// RVA: 0x57C7B0 Offset: 0x57ADB0 VA: 0x18057C7B0
	private void StartBasicTutorial() { }

	// RVA: 0x57BBC0 Offset: 0x57A1C0 VA: 0x18057BBC0
	public void OnGoToTutorialSelectedFromTraining(string popUpID, int optionIndex) { }

	// RVA: 0x57BA50 Offset: 0x57A050 VA: 0x18057BA50
	public void OnGoToTutorialSelectedFromAdvanced(string popUpID, int optionIndex) { }

	// RVA: 0x57BD30 Offset: 0x57A330 VA: 0x18057BD30
	public void ReturnToPreviousScreen() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
