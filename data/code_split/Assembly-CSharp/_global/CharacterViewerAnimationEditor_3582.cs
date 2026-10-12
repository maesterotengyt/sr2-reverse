// Namespace: 
public class CharacterViewerAnimationEditor : MonoBehaviour // TypeDefIndex: 3582
{
	// Fields
	public CharacterViewer CharacterViewer; // 0x20
	public Button EditButton; // 0x28
	public Button CloseButton; // 0x30
	public Animator EditorAnimator; // 0x38
	public Animator TabAnimator; // 0x40
	public TMP_Text AnimationIdLabel; // 0x48
	public CustomToggleButton GeneralTabToggle; // 0x50
	public CharacterViewerGeneralSettingsPanel GeneralPanel; // 0x58
	public CharacterViewerPositionSettings PositionPanel; // 0x60
	public CharacterViewerInputSettingPanel InputsPanel; // 0x68
	public CharacterViewerCPUSettingsEditor CPUSettingsEditor; // 0x70
	public StateDropdown StateDropdown; // 0x78
	public CharacterViewerAnimationData CurrentAnimation; // 0x80
	[Header("Reset Warning")]
	public GameObject Warning; // 0x128
	public Animator WarningAnimator; // 0x130
	private GameObject showedPanel; // 0x138
	private bool active; // 0x140

	// Properties
	public GameObject GeneralOptions { get; }
	public GameObject PositionOptions { get; }
	public GameObject InputOptions { get; }
	public bool ActiveGeneralOptions { get; }
	public bool ActivePositionOptions { get; }
	public bool ActiveInputOptions { get; }
	public bool Active { get; set; }

	// Methods

	// RVA: 0x5FBB00 Offset: 0x5FA100 VA: 0x1805FBB00
	public GameObject get_GeneralOptions() { }

	// RVA: 0x5FBB40 Offset: 0x5FA140 VA: 0x1805FBB40
	public GameObject get_PositionOptions() { }

	// RVA: 0x5FBB20 Offset: 0x5FA120 VA: 0x1805FBB20
	public GameObject get_InputOptions() { }

	// RVA: 0x5FB970 Offset: 0x5F9F70 VA: 0x1805FB970
	public bool get_ActiveGeneralOptions() { }

	// RVA: 0x5FBA70 Offset: 0x5FA070 VA: 0x1805FBA70
	public bool get_ActivePositionOptions() { }

	// RVA: 0x5FB9F0 Offset: 0x5F9FF0 VA: 0x1805FB9F0
	public bool get_ActiveInputOptions() { }

	// RVA: 0x5FBAF0 Offset: 0x5FA0F0 VA: 0x1805FBAF0
	public bool get_Active() { }

	// RVA: 0x5FBB60 Offset: 0x5FA160 VA: 0x1805FBB60
	public void set_Active(bool value) { }

	// RVA: 0x5FB7B0 Offset: 0x5F9DB0 VA: 0x1805FB7B0
	private void Start() { }

	// RVA: 0x5FB040 Offset: 0x5F9640 VA: 0x1805FB040
	public void SaveChanges() { }

	// RVA: 0x5FA000 Offset: 0x5F8600 VA: 0x1805FA000
	public void AnimationIDChanged() { }

	// RVA: 0x5FB290 Offset: 0x5F9890 VA: 0x1805FB290
	public void ShowAnimationEditor() { }

	// RVA: 0x5FA450 Offset: 0x5F8A50 VA: 0x1805FA450
	public void HideAnimationEditor() { }

	// RVA: 0x5FA540 Offset: 0x5F8B40 VA: 0x1805FA540
	public void OpenEditor() { }

	[IteratorStateMachine(typeof(CharacterViewerAnimationEditor.<ShowGeneralOptions>d__38))]
	// RVA: 0x5FB300 Offset: 0x5F9900 VA: 0x1805FB300
	private IEnumerator ShowGeneralOptions() { }

	// RVA: 0x5FA270 Offset: 0x5F8870 VA: 0x1805FA270
	public void CloseEditor() { }

	// RVA: 0x5FAF30 Offset: 0x5F9530 VA: 0x1805FAF30
	public void ResetTabsTriggers() { }

	// RVA: 0x5FB370 Offset: 0x5F9970 VA: 0x1805FB370
	public void ShowGeneralTab(CustomToggleButton toggle) { }

	// RVA: 0x5FB670 Offset: 0x5F9C70 VA: 0x1805FB670
	public void ShowPositionTab(CustomToggleButton toggle) { }

	// RVA: 0x5FB7E0 Offset: 0x5F9DE0 VA: 0x1805FB7E0
	public void ToggleCPUEditor(CustomToggleButton toggle) { }

	// RVA: 0x5FB860 Offset: 0x5F9E60 VA: 0x1805FB860
	public void ToggleCPUEditor(bool active) { }

	// RVA: 0x5FB520 Offset: 0x5F9B20 VA: 0x1805FB520
	public void ShowInputTab(CustomToggleButton toggle) { }

	[IteratorStateMachine(typeof(CharacterViewerAnimationEditor.<ShowOptions>d__46))]
	// RVA: 0x5FB600 Offset: 0x5F9C00 VA: 0x1805FB600
	private IEnumerator ShowOptions() { }

	// RVA: 0x5FB250 Offset: 0x5F9850 VA: 0x1805FB250
	public void SetDataSave() { }

	// RVA: 0x5FB730 Offset: 0x5F9D30 VA: 0x1805FB730
	public void ShowWarning() { }

	// RVA: 0x5FA850 Offset: 0x5F8E50 VA: 0x1805FA850
	public void ResetCurrentAnimation() { }

	// RVA: 0x5FA4C0 Offset: 0x5F8AC0 VA: 0x1805FA4C0
	public void HideWarning() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5FB920 Offset: 0x5F9F20 VA: 0x1805FB920
	private bool <SaveChanges>b__33_0(CharacterViewerAnimationData x) { }

	[CompilerGenerated]
	// RVA: 0x5FB8E0 Offset: 0x5F9EE0 VA: 0x1805FB8E0
	private bool <ResetCurrentAnimation>b__49_0(CharacterViewerAnimationData x) { }
}
