// Namespace: 
public class InputProfileSelectSubMenu : InputProfileSubMenu // TypeDefIndex: 3060
{
	// Fields
	public UINavigator ProfileOptions; // 0x38
	public UINavigator CreateProfileOptions; // 0x40
	public UINavigationElement DeleteProfileOption; // 0x48
	public UINavigationElement NewProfileOption; // 0x50
	public List<InputProfileOption> InputProfileOptions; // 0x58
	public GameObject ProfileLabel; // 0x60
	public GameObject ScrollBar; // 0x68
	public RectTransformAutoRebuild Rebuild; // 0x70
	public LocalizedString ControlsString; // 0x78
	public LocalizedString SetDefaultString; // 0x80
	public LocalizedString EditString; // 0x88
	private bool selectingInputProfile; // 0x90
	private GameObject currentHighlightedOption; // 0x98

	// Methods

	// RVA: 0x53F210 Offset: 0x53D810 VA: 0x18053F210 Slot: 4
	public override void Show() { }

	// RVA: 0x53F6F0 Offset: 0x53DCF0 VA: 0x18053F6F0
	public void Update() { }

	[IteratorStateMachine(typeof(InputProfileSelectSubMenu.<ToggleWithDelay>d__15))]
	// RVA: 0x53F680 Offset: 0x53DC80 VA: 0x18053F680
	private IEnumerator ToggleWithDelay() { }

	// RVA: 0x53F190 Offset: 0x53D790 VA: 0x18053F190
	public void SelectInputProfile() { }

	// RVA: 0x53F4B0 Offset: 0x53DAB0 VA: 0x18053F4B0
	public void ToggleProfileSection() { }

	// RVA: 0x53EE10 Offset: 0x53D410 VA: 0x18053EE10
	public void OptionHoveredFooterState(bool highlighted, GameObject option) { }

	// RVA: 0x53EDC0 Offset: 0x53D3C0 VA: 0x18053EDC0 Slot: 5
	public override void Hide() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
