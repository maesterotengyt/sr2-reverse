// Namespace: 
public class CharacterViewerCPUActionElement : MonoBehaviour // TypeDefIndex: 3605
{
	// Fields
	public CharacterViewerCPUSettingsEditor CPUEditor; // 0x20
	public Animator Animator; // 0x28
	public StateDropdown StateDropdown; // 0x30
	public InputFieldSpinner StartFrameInputField; // 0x38
	public InputFieldSpinner LoopsInputField; // 0x40
	public TMP_Text StateNameLabel; // 0x48
	public TMP_Dropdown StateDropdownInput; // 0x50
	public GameObject HeaderContracted; // 0x58
	public float ContractedSize; // 0x60
	public GameObject HeaderExpanded; // 0x68
	public float ExpandedSize; // 0x70
	private int actionIndex; // 0x74
	private bool expanded; // 0x78

	// Properties
	private CharacterViewerAnimationData characterData { get; }

	// Methods

	// RVA: 0x5FFC30 Offset: 0x5FE230 VA: 0x1805FFC30
	private CharacterViewerAnimationData get_characterData() { }

	// RVA: 0x5FF700 Offset: 0x5FDD00 VA: 0x1805FF700
	public void SetActionData(int index) { }

	// RVA: 0x5FF3C0 Offset: 0x5FD9C0 VA: 0x1805FF3C0
	public void RefreshUI() { }

	// RVA: 0x5FF320 Offset: 0x5FD920 VA: 0x1805FF320
	public void RefreshSearchLabel() { }

	// RVA: 0x5FF6A0 Offset: 0x5FDCA0 VA: 0x1805FF6A0
	public void SelectStateFilter() { }

	// RVA: 0x5FF180 Offset: 0x5FD780 VA: 0x1805FF180
	public void LoopsChanged() { }

	// RVA: 0x5FF750 Offset: 0x5FDD50 VA: 0x1805FF750
	public void StartFrameChanged() { }

	// RVA: 0x5FF8B0 Offset: 0x5FDEB0 VA: 0x1805FF8B0
	public void StateChanged() { }

	// RVA: 0x5FFB10 Offset: 0x5FE110 VA: 0x1805FFB10
	public void ToggleExpandElement(bool expand) { }

	// RVA: 0x5FF160 Offset: 0x5FD760 VA: 0x1805FF160
	public float GetYSize() { }

	// RVA: 0x5FF2E0 Offset: 0x5FD8E0 VA: 0x1805FF2E0
	public void OnDisable() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5FFC00 Offset: 0x5FE200 VA: 0x1805FFC00
	private bool <StateChanged>b__21_0(HashString x) { }
}
