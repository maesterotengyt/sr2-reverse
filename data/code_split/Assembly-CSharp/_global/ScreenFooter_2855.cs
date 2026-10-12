// Namespace: 
public class ScreenFooter : MonoBehaviour // TypeDefIndex: 2855
{
	// Fields
	public StellarUIAnimator Animator; // 0x20
	public StellarUIAnimator BackgroundAnimator; // 0x28
	public CanvasGroup CanvasGroup; // 0x30
	public LocalizedString BackString; // 0x38
	public List<ScreenFooterButton> ButtonIcons; // 0x40
	public GameObject ButtonIconsParent; // 0x48
	public GameObject LoadingLabel; // 0x50
	public TMP_Text LoadingLabelText; // 0x58
	public RectTransformAutoRebuild AutoRebuild; // 0x60
	private ScreenFooterState currentState; // 0x68
	private ScreenFooterBackgroundState currentSize; // 0x6C

	// Methods

	// RVA: 0x750D10 Offset: 0x74F310 VA: 0x180750D10
	public void Initialize() { }

	// RVA: 0x750E60 Offset: 0x74F460 VA: 0x180750E60
	public void SetState(ScreenFooterState state, bool forceUpdate = False) { }

	// RVA: 0x750B50 Offset: 0x74F150 VA: 0x180750B50
	public void AddFooterButton(string text, UIKey key, bool cleanPreviousButtons = False) { }

	// RVA: 0x750D20 Offset: 0x74F320 VA: 0x180750D20
	public void SetBackAction(bool cleanPreviousButtons = True) { }

	// RVA: 0x750E10 Offset: 0x74F410 VA: 0x180750E10
	public void SetLoadingLabel(string label = "") { }

	// RVA: 0x750D90 Offset: 0x74F390 VA: 0x180750D90
	public void SetBackgroundState(ScreenFooterBackgroundState size) { }

	// RVA: 0x7510B0 Offset: 0x74F6B0 VA: 0x1807510B0
	public void ToggleFooterVisbility(bool visible) { }

	// RVA: 0x7510F0 Offset: 0x74F6F0 VA: 0x1807510F0
	public void .ctor() { }
}
