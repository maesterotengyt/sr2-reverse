// Namespace: 
public class CharacterViewerPlaylistEditor : MonoBehaviour // TypeDefIndex: 3628
{
	// Fields
	public CharacterViewerAnimationList AnimationList; // 0x20
	public CharacterViewerDragDropList PlayList; // 0x28
	public CustomToggleButton EditorToggleButton; // 0x30
	public GameObject AnimationListCover; // 0x38
	public GameObject PlayAllButton; // 0x40
	public Animator Animator; // 0x48
	public RectTransform ScrollviewContent; // 0x50
	public Scrollbar Scrollbar; // 0x58
	public float ScrollSpeed; // 0x60
	public GameObject UpperTrigger; // 0x68
	public GameObject LowerTrigger; // 0x70
	public GameObject Warning; // 0x78
	public Animator WarningAnimator; // 0x80
	private int lastSelectedIndex; // 0x88
	private bool active; // 0x8C
	private bool scrollTriggered; // 0x8D
	private float scrollDistance; // 0x90

	// Properties
	private List<CharacterViewerAnimationData> animations { get; }

	// Methods

	// RVA: 0x60C750 Offset: 0x60AD50 VA: 0x18060C750
	private List<CharacterViewerAnimationData> get_animations() { }

	// RVA: 0x60C030 Offset: 0x60A630 VA: 0x18060C030
	private void Start() { }

	// RVA: 0x60C580 Offset: 0x60AB80 VA: 0x18060C580
	private void Update() { }

	// RVA: 0x60C200 Offset: 0x60A800 VA: 0x18060C200
	public void ToggleEditor(bool active) { }

	// RVA: 0x60B1E0 Offset: 0x6097E0 VA: 0x18060B1E0
	private void LoadPlayAllList() { }

	// RVA: 0x60BB30 Offset: 0x60A130 VA: 0x18060BB30
	public void SavePlayAllList() { }

	// RVA: 0x60B570 Offset: 0x609B70 VA: 0x18060B570
	public void PlayAll() { }

	// RVA: 0x60B590 Offset: 0x609B90 VA: 0x18060B590
	public void ResetPlayAllList() { }

	// RVA: 0x60BE30 Offset: 0x60A430 VA: 0x18060BE30
	public void SelectElement(CharacterViewerDragDropItemSlot slot) { }

	// RVA: 0x60BA50 Offset: 0x60A050 VA: 0x18060BA50
	private void ResetTriggers() { }

	// RVA: 0x60AFB0 Offset: 0x6095B0 VA: 0x18060AFB0
	private void AdjustScrollView() { }

	// RVA: 0x60BFA0 Offset: 0x60A5A0 VA: 0x18060BFA0
	public void ShowWarning() { }

	// RVA: 0x60B4B0 Offset: 0x609AB0 VA: 0x18060B4B0
	public void OnEnterTrigger(bool lowerTrigger) { }

	// RVA: 0x60B550 Offset: 0x609B50 VA: 0x18060B550
	public void OnExitTrigger() { }

	// RVA: 0x60C1B0 Offset: 0x60A7B0 VA: 0x18060C1B0
	public void ToggleDrag(bool drag) { }

	// RVA: 0x60BF50 Offset: 0x60A550 VA: 0x18060BF50
	public void SetDataSave() { }

	// RVA: 0x60C740 Offset: 0x60AD40 VA: 0x18060C740
	public void .ctor() { }
}
