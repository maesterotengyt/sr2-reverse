// Namespace: 
public class CharacterViewerAnimationList : MonoBehaviour // TypeDefIndex: 3587
{
	// Fields
	public CharacterViewer CharacterViewer; // 0x20
	public CharacterViewerAnimationPlayBar AnimationPlayBar; // 0x28
	public CharacterViewerPlaylistEditor PlaylistEditor; // 0x30
	public Animator Animator; // 0x38
	[Header("Animations List")]
	public CharacterViewerDragDropList AnimationButtons; // 0x40
	public RectTransform ScrollviewContent; // 0x48
	public Scrollbar Scrollbar; // 0x50
	public GameObject ScrollHandle; // 0x58
	[Header("Others")]
	public TMP_InputField SearchBar; // 0x60
	public CustomToggleButton PlayAllToggle; // 0x68
	public CustomToggleButton EditPlayAllToggle; // 0x70
	public bool RunningPlaylist; // 0x78
	public int PlaylistIndex; // 0x7C
	private List<string> animationlist; // 0x80
	private List<string> animationSelection; // 0x88
	private List<CharacterViewerAnimationData> animationPlaylist; // 0x90

	// Properties
	public int AnimationsCount { get; }

	// Methods

	// RVA: 0x5FE080 Offset: 0x5FC680 VA: 0x1805FE080
	public int get_AnimationsCount() { }

	// RVA: 0x5FDA60 Offset: 0x5FC060 VA: 0x1805FDA60
	private void Start() { }

	// RVA: 0x5FBB70 Offset: 0x5FA170 VA: 0x1805FBB70
	public void LoadCharacterData() { }

	// RVA: 0x5FD640 Offset: 0x5FBC40 VA: 0x1805FD640
	public void ShowAnimationList() { }

	// RVA: 0x5FDEC0 Offset: 0x5FC4C0 VA: 0x1805FDEC0
	public void TogglePlaylistEditor(CustomToggleButton button) { }

	// RVA: 0x5FCCE0 Offset: 0x5FB2E0 VA: 0x1805FCCE0
	public void PlayStateAnimation(int index) { }

	// RVA: 0x5FCB40 Offset: 0x5FB140 VA: 0x1805FCB40
	public void PlayStateAnimation(string name) { }

	// RVA: 0x5FCE20 Offset: 0x5FB420 VA: 0x1805FCE20
	public void SelectAnimation(CharacterViewerAnimationData animationData) { }

	// RVA: 0x5FCDB0 Offset: 0x5FB3B0 VA: 0x1805FCDB0
	public void ResetTriggers() { }

	// RVA: 0x5FDD60 Offset: 0x5FC360 VA: 0x1805FDD60
	public void ToggleListPanel(bool enabled) { }

	// RVA: 0x5FDE40 Offset: 0x5FC440 VA: 0x1805FDE40
	public void TogglePlayAll() { }

	// RVA: 0x5FC090 Offset: 0x5FA690 VA: 0x1805FC090
	public void PlayAll() { }

	// RVA: 0x5FC5C0 Offset: 0x5FABC0 VA: 0x1805FC5C0
	public void PlayNext(bool jumpDelay = False) { }

	// RVA: 0x5FC8A0 Offset: 0x5FAEA0 VA: 0x1805FC8A0
	public void PlayPrevious() { }

	// RVA: 0x5FDC30 Offset: 0x5FC230 VA: 0x1805FDC30
	public void StopPlaylist() { }

	// RVA: 0x5FD3C0 Offset: 0x5FB9C0 VA: 0x1805FD3C0
	public void SetPlayBarLastAnimation() { }

	// RVA: 0x5FCD50 Offset: 0x5FB350 VA: 0x1805FCD50
	public void RemoveFromPlaylist(int index) { }

	// RVA: 0x5FDF80 Offset: 0x5FC580 VA: 0x1805FDF80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5FDEF0 Offset: 0x5FC4F0 VA: 0x1805FDEF0
	private bool <SetPlayBarLastAnimation>b__32_0(CharacterViewerDragDropItemSlot x) { }
}
