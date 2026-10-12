// Namespace: 
public class CharacterViewerCPUSettingsEditor : MonoBehaviour // TypeDefIndex: 3608
{
	// Fields
	public CharacterViewerAnimationEditor AnimationEditor; // 0x20
	public TMP_Dropdown InitialStateDropdown; // 0x28
	public TMP_Dropdown ActionStateDropdown; // 0x30
	public TMP_InputField DamageInput; // 0x38
	public TMP_InputField LoopsInput; // 0x40
	public TMP_InputField StartFrameInput; // 0x48
	public Animator Animator; // 0x50
	public StateDropdown InitialState; // 0x58
	public GameObject ActionListContainer; // 0x60
	public RectTransform PanelContainer; // 0x68
	public RectTransform Content; // 0x70
	public float ListControlSize; // 0x78
	public float ContentExpandYSize; // 0x7C
	public float ContentYOffset; // 0x80
	public Button AddButton; // 0x88
	public Button RemoveButton; // 0x90
	public int LastSelectedIndex; // 0x98
	public List<HashString> StateList; // 0xA0
	private bool activeCPUEditor; // 0xA8
	private List<CharacterViewerCPUActionElement> actionList; // 0xB0

	// Properties
	private CharacterViewerCPU viewerCPU { get; }
	private CharacterViewerCharacterData characterData { get; }

	// Methods

	// RVA: 0x601070 Offset: 0x5FF670 VA: 0x180601070
	private CharacterViewerCPU get_viewerCPU() { }

	// RVA: 0x601030 Offset: 0x5FF630 VA: 0x180601030
	private CharacterViewerCharacterData get_characterData() { }

	// RVA: 0x600170 Offset: 0x5FE770 VA: 0x180600170
	public void LoadStateAnimationsList() { }

	// RVA: 0x5FFEE0 Offset: 0x5FE4E0 VA: 0x1805FFEE0
	public List<string> GetStateList(string input) { }

	// RVA: 0x600F60 Offset: 0x5FF560 VA: 0x180600F60
	public void UpdateCPUEditor() { }

	// RVA: 0x600880 Offset: 0x5FEE80 VA: 0x180600880
	public void ShowCPUActions() { }

	// RVA: 0x6006D0 Offset: 0x5FECD0 VA: 0x1806006D0
	public void ResizeList() { }

	// RVA: 0x5FFCE0 Offset: 0x5FE2E0 VA: 0x1805FFCE0
	public void AddAction() { }

	// RVA: 0x600620 Offset: 0x5FEC20 VA: 0x180600620
	public void RemoveAction() { }

	// RVA: 0x6000C0 Offset: 0x5FE6C0 VA: 0x1806000C0
	private void ListControlRefresh() { }

	// RVA: 0x600BD0 Offset: 0x5FF1D0 VA: 0x180600BD0
	public void StateChanged() { }

	// RVA: 0x600CF0 Offset: 0x5FF2F0 VA: 0x180600CF0
	public void StateDropdownUpdate() { }

	// RVA: 0x6005E0 Offset: 0x5FEBE0 VA: 0x1806005E0
	public void RefreshStateLabel() { }

	// RVA: 0x6007F0 Offset: 0x5FEDF0 VA: 0x1806007F0
	public void SelectStateFilter() { }

	// RVA: 0x5FFE60 Offset: 0x5FE460 VA: 0x1805FFE60
	public void DamageChanged(TMP_InputField inputField) { }

	// RVA: 0x600DD0 Offset: 0x5FF3D0 VA: 0x180600DD0
	public void ToggleCPUEditor(bool active) { }

	// RVA: 0x600F00 Offset: 0x5FF500 VA: 0x180600F00
	public void ToggleCPU(bool active) { }

	// RVA: 0x601010 Offset: 0x5FF610 VA: 0x180601010
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x600F30 Offset: 0x5FF530 VA: 0x180600F30
	private bool <StateChanged>b__32_0(HashString x) { }
}
