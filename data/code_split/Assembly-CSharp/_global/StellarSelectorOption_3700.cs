// Namespace: 
public class StellarSelectorOption : UINavigationElement // TypeDefIndex: 3700
{
	// Fields
	[SerializeField]
	private StellarSelectorOption.InteractEventClass OnSelectorChangeValue; // 0x98
	public TMP_Text ValueText; // 0xA0
	public string NavigateSFX; // 0xA8
	protected int currentOption; // 0xB0
	protected List<string> currentOptions; // 0xB8

	// Methods

	// RVA: 0x64E560 Offset: 0x64CB60 VA: 0x18064E560
	private void Update() { }

	// RVA: 0x5C61E0 Offset: 0x5C47E0 VA: 0x1805C61E0
	public int GetCurrentOptionIndex() { }

	// RVA: 0x64E4E0 Offset: 0x64CAE0 VA: 0x18064E4E0
	public void SetOptions(List<string> options, bool setFirstOptionAsDefault = False) { }

	// RVA: 0x64E460 Offset: 0x64CA60 VA: 0x18064E460
	public void SetDefaultOption(int defaultOption, bool notify = True) { }

	// RVA: 0x64E2B0 Offset: 0x64C8B0 VA: 0x18064E2B0
	public void RightSelection() { }

	// RVA: 0x64E240 Offset: 0x64C840 VA: 0x18064E240
	public void LeftSelection() { }

	// RVA: 0x64E330 Offset: 0x64C930 VA: 0x18064E330
	public void SetCurrentOption(bool notify = True) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected virtual void OnCurrentOptionUpdated() { }

	// RVA: 0x64E6C0 Offset: 0x64CCC0 VA: 0x18064E6C0
	public void .ctor() { }
}
