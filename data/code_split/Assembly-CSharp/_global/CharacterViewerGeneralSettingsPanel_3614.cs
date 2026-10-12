// Namespace: 
public class CharacterViewerGeneralSettingsPanel : MonoBehaviour // TypeDefIndex: 3614
{
	// Fields
	public CharacterViewerAnimationEditor AnimationEditor; // 0x20
	public TMP_Dropdown StateDropdown; // 0x28
	public TMP_InputField LoopsInput; // 0x30
	public TMP_InputField DurationInput; // 0x38
	public TMP_InputField PlayAllDelayInput; // 0x40
	public TMP_InputField StartFrameInput; // 0x48
	public TMP_InputField DamageInput; // 0x50
	public TMP_InputField FallSpeedInput; // 0x58
	public CustomToggleGroup AttackDirectionToggleGroup; // 0x60
	private List<HashString> stateList; // 0x68

	// Properties
	private CharacterViewer characterViewer { get; }

	// Methods

	// RVA: 0x608770 Offset: 0x606D70 VA: 0x180608770
	private CharacterViewer get_characterViewer() { }

	// RVA: 0x6081B0 Offset: 0x6067B0 VA: 0x1806081B0
	private void Start() { }

	// RVA: 0x6078E0 Offset: 0x605EE0 VA: 0x1806078E0
	public void LoadStateAnimationsList() { }

	// RVA: 0x607710 Offset: 0x605D10 VA: 0x180607710
	public List<string> GetStateList(string input) { }

	// RVA: 0x6085A0 Offset: 0x606BA0 VA: 0x1806085A0
	public void UpdateGeneralTab() { }

	// RVA: 0x608340 Offset: 0x606940 VA: 0x180608340
	public void StateChanged(string option) { }

	// RVA: 0x6081D0 Offset: 0x6067D0 VA: 0x1806081D0
	public void StateChanged() { }

	// RVA: 0x6084B0 Offset: 0x606AB0 VA: 0x1806084B0
	public void StateDropdownUpdate() { }

	// RVA: 0x607EC0 Offset: 0x6064C0 VA: 0x180607EC0
	public void RefreshAnimation() { }

	// RVA: 0x608000 Offset: 0x606600 VA: 0x180608000
	public void RefreshStateLabel() { }

	// RVA: 0x6080A0 Offset: 0x6066A0 VA: 0x1806080A0
	public void SelectStateFilter() { }

	// RVA: 0x607DC0 Offset: 0x6063C0 VA: 0x180607DC0
	public void LoopsChanged(TMP_InputField inputField) { }

	// RVA: 0x607E40 Offset: 0x606440 VA: 0x180607E40
	public void PlayAllDelayChanged(TMP_InputField inputField) { }

	// RVA: 0x608130 Offset: 0x606730 VA: 0x180608130
	public void StartFrameChanged(TMP_InputField inputField) { }

	// RVA: 0x607610 Offset: 0x605C10 VA: 0x180607610
	public void DurationChanged(TMP_InputField inputField) { }

	// RVA: 0x607590 Offset: 0x605B90 VA: 0x180607590
	public void DamageChanged(TMP_InputField inputField) { }

	// RVA: 0x607690 Offset: 0x605C90 VA: 0x180607690
	public void FallSpeedChanged(TMP_InputField inputField) { }

	// RVA: 0x607480 Offset: 0x605A80 VA: 0x180607480
	public void AttackDirectionChanged(int facingDirection) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
