// Namespace: 
[Obsolete]
public class StellarSwitchOption : StellarSelectorOption // TypeDefIndex: 3703
{
	// Fields
	public TMP_Text OnText; // 0xC0
	public Button OnButton; // 0xC8
	public Animator OnAnimator; // 0xD0
	public LocalizedString OnString; // 0xD8
	public TMP_Text OffText; // 0xE0
	public Button OffButton; // 0xE8
	public Animator OffAnimator; // 0xF0
	public LocalizedString OffString; // 0xF8

	// Methods

	// RVA: 0x64EC00 Offset: 0x64D200 VA: 0x18064EC00 Slot: 5
	public override void Initialize(UINavigator uiNavigator, int navigationIndex) { }

	// RVA: 0x64F0C0 Offset: 0x64D6C0 VA: 0x18064F0C0
	private void OnButtonClicked() { }

	// RVA: 0x64F060 Offset: 0x64D660 VA: 0x18064F060
	private void OffButtonClicked() { }

	// RVA: 0x64F130 Offset: 0x64D730 VA: 0x18064F130 Slot: 7
	protected override void OnCurrentOptionUpdated() { }

	// RVA: 0x64F1A0 Offset: 0x64D7A0 VA: 0x18064F1A0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x64F130 Offset: 0x64D730 VA: 0x18064F130
	private void UpdateToggles() { }

	// RVA: 0x64F220 Offset: 0x64D820 VA: 0x18064F220
	public void UpdateToggleAnimator(Animator animator, bool highlighted, bool isOn) { }

	// RVA: 0x64E6C0 Offset: 0x64CCC0 VA: 0x18064E6C0
	public void .ctor() { }
}
