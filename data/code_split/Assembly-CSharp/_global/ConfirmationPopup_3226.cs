// Namespace: 
public class ConfirmationPopup : UIPopup // TypeDefIndex: 3226
{
	// Fields
	public UINavigator UINavigator; // 0x38
	public TMP_Text MessageText; // 0x40
	public TMP_Text DescriptionText; // 0x48
	public TMP_Text Option1Text; // 0x50
	public TMP_Text Option2Text; // 0x58
	public Image Option1Icon; // 0x60
	public Image Option2Icon; // 0x68
	public Sprite ConfirmIcon; // 0x70
	public Sprite CancelIcon; // 0x78

	// Methods

	// RVA: 0x5804B0 Offset: 0x57EAB0 VA: 0x1805804B0
	public void SetData(string message, string description, string option1, string option2, ConfirmationPopup.Style style) { }

	// RVA: 0x5806E0 Offset: 0x57ECE0 VA: 0x1805806E0 Slot: 4
	public override void Show() { }

	// RVA: 0x5803C0 Offset: 0x57E9C0 VA: 0x1805803C0 Slot: 5
	public override void Hide(bool destroy) { }

	// RVA: 0x5803F0 Offset: 0x57E9F0 VA: 0x1805803F0
	public void Option1Selected() { }

	// RVA: 0x580450 Offset: 0x57EA50 VA: 0x180580450
	public void Option2Selected() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
