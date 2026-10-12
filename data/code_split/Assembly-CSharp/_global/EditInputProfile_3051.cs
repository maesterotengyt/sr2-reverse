// Namespace: 
public class EditInputProfile : InputProfileSubMenu // TypeDefIndex: 3051
{
	// Fields
	[Header("Edit Input Profile")]
	public UINavigator InputNavigator; // 0x38
	public InputOption RightInputOption; // 0x40
	public InputOption LeftInputOption; // 0x48
	public List<InputOption> InputOptions; // 0x50
	public LocalizedString ConfirmResetDefaultString; // 0x58
	public LocalizedString ResetToDefaultString; // 0x60
	public LocalizedString EditString; // 0x68
	private int editingInputProfileIndex; // 0x70
	private InputProfile currentProfile; // 0x78

	// Methods

	// RVA: 0x53BA60 Offset: 0x53A060 VA: 0x18053BA60
	public void Show(int index) { }

	// RVA: 0x53A900 Offset: 0x538F00 VA: 0x18053A900
	public void GenerateInput() { }

	// RVA: 0x53B660 Offset: 0x539C60 VA: 0x18053B660
	public void ResetProfileToDefault() { }

	// RVA: 0x53B3F0 Offset: 0x5399F0 VA: 0x18053B3F0
	public void ResetProfileConfirm() { }

	// RVA: 0x53B9A0 Offset: 0x539FA0 VA: 0x18053B9A0
	public void SetProfileData(InputProfile profile) { }

	// RVA: 0x53BEF0 Offset: 0x53A4F0 VA: 0x18053BEF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x53BDE0 Offset: 0x53A3E0 VA: 0x18053BDE0
	private void <GenerateInput>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0x53BE60 Offset: 0x53A460 VA: 0x18053BE60
	private void <GenerateInput>b__10_1() { }

	[CompilerGenerated]
	// RVA: 0x53BEE0 Offset: 0x53A4E0 VA: 0x18053BEE0
	private void <ResetProfileToDefault>b__11_0() { }
}
