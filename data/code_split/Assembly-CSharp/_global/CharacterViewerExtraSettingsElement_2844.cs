// Namespace: 
public class CharacterViewerExtraSettingsElement : MonoBehaviour // TypeDefIndex: 2844
{
	// Fields
	public InputFieldSpinner StartFrameInputField; // 0x20
	public InputFieldSpinner AmountInputField; // 0x28
	public TMP_Dropdown OptionDropdownInput; // 0x30
	public TMP_Text SettingNameLabel; // 0x38
	public TMP_Text AmountSpecificationLabel; // 0x40
	public CharacterViewerExtraSettings ExtraSettings; // 0x48
	public RectTransform Container; // 0x50
	public GameObject HeaderContracted; // 0x58
	public float ContractedSize; // 0x60
	public GameObject HeaderExpanded; // 0x68
	public float ExpandedSize; // 0x70
	private int settingIndex; // 0x74
	private bool expanded; // 0x78

	// Properties
	private List<string> optionsList { get; }
	private List<CharacterViewerExtraOptionsData> additionalOptions { get; }
	private StellarData stellarData { get; }

	// Methods

	// RVA: 0x728C40 Offset: 0x727240 VA: 0x180728C40
	private List<string> get_optionsList() { }

	// RVA: 0x728C00 Offset: 0x727200 VA: 0x180728C00
	private List<CharacterViewerExtraOptionsData> get_additionalOptions() { }

	// RVA: 0x728C70 Offset: 0x727270 VA: 0x180728C70
	private StellarData get_stellarData() { }

	// RVA: 0x7276A0 Offset: 0x725CA0 VA: 0x1807276A0
	public void AmountChanged() { }

	// RVA: 0x728650 Offset: 0x726C50 VA: 0x180728650
	public void StartFrameChanged() { }

	// RVA: 0x727C80 Offset: 0x726280 VA: 0x180727C80
	public void OptionChanged() { }

	// RVA: 0x727A40 Offset: 0x726040 VA: 0x180727A40
	private string ItemNameConfigure(CharacterViewerExtraSetting setting) { }

	// RVA: 0x728600 Offset: 0x726C00 VA: 0x180728600
	public void SetExtraSettingData(int index) { }

	// RVA: 0x7280D0 Offset: 0x7266D0 VA: 0x1807280D0
	private void RefreshUI() { }

	// RVA: 0x7280C0 Offset: 0x7266C0 VA: 0x1807280C0
	public void RefreshUICall() { }

	// RVA: 0x728A00 Offset: 0x727000 VA: 0x180728A00
	public void ToggleExpandElement(bool expand) { }

	// RVA: 0x727980 Offset: 0x725F80 VA: 0x180727980
	private void ContractElement() { }

	// RVA: 0x7279E0 Offset: 0x725FE0 VA: 0x1807279E0
	private void ExpandElement() { }

	// RVA: 0x5FF160 Offset: 0x5FD760 VA: 0x1805FF160
	public float GetYSize() { }

	// RVA: 0x727BA0 Offset: 0x7261A0 VA: 0x180727BA0
	public void OnEnable() { }

	// RVA: 0x5FF2E0 Offset: 0x5FD8E0 VA: 0x1805FF2E0
	public void OnDisable() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x728AE0 Offset: 0x7270E0 VA: 0x180728AE0
	private bool <OptionChanged>b__13_0(CharacterViewerExtraOptionsData x) { }

	[CompilerGenerated]
	// RVA: 0x728B70 Offset: 0x727170 VA: 0x180728B70
	private bool <OptionChanged>b__13_1(CharacterViewerExtraOptionsData x) { }
}
