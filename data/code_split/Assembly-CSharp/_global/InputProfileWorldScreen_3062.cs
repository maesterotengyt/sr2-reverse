// Namespace: 
public class InputProfileWorldScreen : MainMenuWorldScreen // TypeDefIndex: 3062
{
	// Fields
	public TMP_Text TitleText; // 0x30
	public TMP_Text DescriptionText; // 0x38
	public Animator HeaderAnimator; // 0x40
	[Header("Sub screens")]
	public DeleteInputProfileSubMenu DeleteProfileMenu; // 0x48
	public InputProfileNewProfileSubMenu NewProfileMenu; // 0x50
	public InputProfileConfirmSubMenu ConfirmMenu; // 0x58
	public EditInputProfile EditInputProfileMenu; // 0x60
	public InputEditorSubMenu EditInputMenu; // 0x68
	public InputProfileSelectSubMenu InputProfileSelectSubMenu; // 0x70
	[Header("Strings")]
	public LocalizedString ProfileString; // 0x78
	public LocalizedString YesString; // 0x80
	public LocalizedString BackString; // 0x88
	public LocalizedString ConfirmString; // 0x90
	public LocalizedString CancelString; // 0x98
	public LocalizedString ApplyString; // 0xA0

	// Methods

	// RVA: 0x53FF20 Offset: 0x53E520 VA: 0x18053FF20 Slot: 5
	public override void Show() { }

	// RVA: 0x53FEA0 Offset: 0x53E4A0 VA: 0x18053FEA0 Slot: 6
	public override void Hide() { }

	// RVA: 0x53FA70 Offset: 0x53E070 VA: 0x18053FA70
	public void GenerateProfileOptions(List<InputProfileOption> profileOptionList) { }

	// RVA: 0x540030 Offset: 0x53E630 VA: 0x180540030 Slot: 7
	public override void UpdateScreen() { }

	// RVA: 0x53FD60 Offset: 0x53E360 VA: 0x18053FD60
	public void HideScreens() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x53FFB0 Offset: 0x53E5B0 VA: 0x18053FFB0
	private void <GenerateProfileOptions>b__17_0() { }
}
