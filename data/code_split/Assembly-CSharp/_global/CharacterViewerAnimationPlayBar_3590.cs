// Namespace: 
public class CharacterViewerAnimationPlayBar : MonoBehaviour // TypeDefIndex: 3590
{
	// Fields
	public CharacterViewer CharacterViewer; // 0x20
	public CharacterViewerAnimationList AnimationList; // 0x28
	public CharacterViewerAnimationEditor AnimationEditor; // 0x30
	public CharacterViewerCameraControl CameraControl; // 0x38
	public Animator Animator; // 0x40
	public TMP_Text IndexText; // 0x48
	public TMP_Text NameText; // 0x50
	public TMP_Text FramesText; // 0x58
	public GameObject PlayButton; // 0x60
	public GameObject PauseButton; // 0x68
	public Button AdvanceFrameButton; // 0x70
	public int CurrentStateAnimationIndex; // 0x78
	public bool RunningDelay; // 0x7C
	public bool StartDelayActive; // 0x7D
	private bool pauseButtonActive; // 0x7E

	// Methods

	// RVA: 0x5FEA70 Offset: 0x5FD070 VA: 0x1805FEA70
	public void SetCurrentStateAnimation(int index, string animationName) { }

	// RVA: 0x5FE0E0 Offset: 0x5FC6E0 VA: 0x1805FE0E0
	public void NextAnimation() { }

	// RVA: 0x5FEDE0 Offset: 0x5FD3E0 VA: 0x1805FEDE0
	public void TogglePlayblar(bool enabled) { }

	// RVA: 0x5FE5A0 Offset: 0x5FCBA0 VA: 0x1805FE5A0
	public void PreviousAnimation() { }

	// RVA: 0x5FE4D0 Offset: 0x5FCAD0 VA: 0x1805FE4D0
	public void PlayStateAnimation() { }

	// RVA: 0x5FECA0 Offset: 0x5FD2A0 VA: 0x1805FECA0
	public void StopStateAnimation() { }

	[IteratorStateMachine(typeof(CharacterViewerAnimationPlayBar.<RestartFrameByFrame>d__21))]
	// RVA: 0x5FEA00 Offset: 0x5FD000 VA: 0x1805FEA00
	private IEnumerator RestartFrameByFrame() { }

	// RVA: 0x5FEBD0 Offset: 0x5FD1D0 VA: 0x1805FEBD0
	public void ShowPlayButton() { }

	// RVA: 0x5FEB80 Offset: 0x5FD180 VA: 0x1805FEB80
	public void ShowPauseButton() { }

	// RVA: 0x5FE940 Offset: 0x5FCF40 VA: 0x1805FE940
	public void ResetTriggers() { }

	// RVA: 0x5FEE80 Offset: 0x5FD480 VA: 0x1805FEE80
	public void ToggleVideoMode(bool enabled) { }

	// RVA: 0x5FEC20 Offset: 0x5FD220 VA: 0x1805FEC20
	public void StartFrameByFrame() { }

	// RVA: 0x5FE0C0 Offset: 0x5FC6C0 VA: 0x1805FE0C0
	public void AdvanceFramebyFrame() { }

	// RVA: 0x5FEF60 Offset: 0x5FD560 VA: 0x1805FEF60
	private void Update() { }

	// RVA: 0x5FF150 Offset: 0x5FD750 VA: 0x1805FF150
	public void .ctor() { }
}
