// Namespace: 
public class CharacterViewerInputSettingPanel : MonoBehaviour // TypeDefIndex: 3623
{
	// Fields
	public CharacterViewerAnimationEditor AnimationEditor; // 0x20
	[Header("Timeline")]
	public RectTransformHorizontalExpander TimelineSizeControl; // 0x28
	public Slider Timeline; // 0x30
	public MultipleHandlesSlider KeyFramesSlider; // 0x38
	public TMP_Text FrameDisplay; // 0x40
	public Button CreateKeyFrameButton; // 0x48
	public Button DeleteKeyFrameButton; // 0x50
	[Header("Controller")]
	public CustomThumbStickInput LeftThumbStick; // 0x58
	public CustomThumbStickInput RightThumbStick; // 0x60
	public List<CharacterViewerInputSettingPanel.KeyMap> InputKeyMap; // 0x68
	private int duration; // 0x70
	private List<CharacterViewerInputSettingPanel.KeyFrame> keyFrames; // 0x78
	private int selectedKeyFrame; // 0x80
	private bool loadingInputs; // 0x84

	// Methods

	// RVA: 0x609C00 Offset: 0x608200 VA: 0x180609C00
	private void Start() { }

	// RVA: 0x6090C0 Offset: 0x6076C0 VA: 0x1806090C0
	private void OnEnable() { }

	// RVA: 0x60A0F0 Offset: 0x6086F0 VA: 0x18060A0F0
	public void UpdateInputsTab() { }

	[IteratorStateMachine(typeof(CharacterViewerInputSettingPanel.<ShowInputsTab>d__17))]
	// RVA: 0x609B90 Offset: 0x608190 VA: 0x180609B90
	private IEnumerator ShowInputsTab() { }

	// RVA: 0x608C30 Offset: 0x607230 VA: 0x180608C30
	public void LoadAnimationInputs() { }

	// RVA: 0x60A180 Offset: 0x608780 VA: 0x18060A180
	public void UpdateTimelineDuration(int duration = 0) { }

	// RVA: 0x60A020 Offset: 0x608620 VA: 0x18060A020
	public void UpdateFrameText() { }

	// RVA: 0x608EA0 Offset: 0x6074A0 VA: 0x180608EA0
	public void NewKeyFrame() { }

	// RVA: 0x608790 Offset: 0x606D90 VA: 0x180608790
	public void DeleteKeyFrame() { }

	// RVA: 0x609B50 Offset: 0x608150 VA: 0x180609B50
	public void SetSelectedKeyFrame() { }

	// RVA: 0x6095C0 Offset: 0x607BC0 VA: 0x1806095C0
	public void SetInputController(CharacterViewerSimulatedInput input) { }

	// RVA: 0x609140 Offset: 0x607740 VA: 0x180609140
	public void ResetInputController() { }

	// RVA: 0x609720 Offset: 0x607D20 VA: 0x180609720
	private void SetKeyFrame() { }

	// RVA: 0x608830 Offset: 0x606E30 VA: 0x180608830
	public void FramesUpdated() { }

	// RVA: 0x609CF0 Offset: 0x6082F0 VA: 0x180609CF0
	public void ToggleInput(CustomToggleButton input) { }

	// RVA: 0x608980 Offset: 0x606F80 VA: 0x180608980
	public void GetInputDirection(CustomThumbStickInput input) { }

	// RVA: 0x609290 Offset: 0x607890 VA: 0x180609290
	public void SaveChanges() { }

	// RVA: 0x60A1F0 Offset: 0x6087F0 VA: 0x18060A1F0
	public void .ctor() { }
}
