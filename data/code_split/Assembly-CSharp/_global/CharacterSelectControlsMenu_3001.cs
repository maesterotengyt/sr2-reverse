// Namespace: 
public class CharacterSelectControlsMenu : CharacterSelectSubPanel // TypeDefIndex: 3001
{
	// Fields
	public Transform ProfileOptions; // 0x48
	public LocalizedString DefaultString; // 0x50
	public GameObject ControllerProfileTipText; // 0x58
	public GameObject ScrollBar; // 0x60

	// Methods

	// RVA: 0x7869E0 Offset: 0x784FE0 VA: 0x1807869E0 Slot: 5
	public override void Show() { }

	// RVA: 0x786A50 Offset: 0x785050 VA: 0x180786A50
	public void UpdateProfileData() { }

	// RVA: 0x7868F0 Offset: 0x784EF0 VA: 0x1807868F0
	public void SelectProfileOption(int index, int playerIndex) { }

	// RVA: 0x786870 Offset: 0x784E70 VA: 0x180786870
	public CharacterSelectProfileOption GetProfileOption(int index) { }

	// RVA: 0x786860 Offset: 0x784E60 VA: 0x180786860
	public void CancelOption() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
