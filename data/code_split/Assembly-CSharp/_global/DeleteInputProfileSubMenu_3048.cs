// Namespace: 
public class DeleteInputProfileSubMenu : InputProfileSubMenu // TypeDefIndex: 3048
{
	// Fields
	public List<InputProfileOption> InputDeleteProfileOptions; // 0x38
	public UINavigator DeleteProfileNavigator; // 0x40
	public LocalizedString ConfirmProfileDeleteString; // 0x48
	public LocalizedString SelectProfileDeleteString; // 0x50
	public LocalizedString DeleteString; // 0x58

	// Methods

	// RVA: 0x53A560 Offset: 0x538B60 VA: 0x18053A560 Slot: 4
	public override void Show() { }

	// RVA: 0x53A270 Offset: 0x538870 VA: 0x18053A270
	public void ShowConfirmDeleteProfileScreen(int index) { }

	// RVA: 0x53A0C0 Offset: 0x5386C0 VA: 0x18053A0C0
	public void DeleteProfileConfirm(int indexToDelete) { }

	// RVA: 0x53A240 Offset: 0x538840 VA: 0x18053A240 Slot: 5
	public override void Hide() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
