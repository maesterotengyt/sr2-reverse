// Namespace: 
public class StellarUIAnimator : StellarMonoBehaviour // TypeDefIndex: 3689
{
	// Fields
	public Animator Animator; // 0x20
	public UINavigationElement UINavigationElement; // 0x28
	[HideIfNull("UINavigationElement")]
	public float UndoHighlightSpeed; // 0x30
	[HideIfNull("UINavigationElement")]
	public StellarUIAnimator.SelectedState ActionAfterSelection; // 0x34
	[HideIfNull("UINavigationElement")]
	public bool StartSelected; // 0x38
	public UIScreen UIScreen; // 0x40
	[HideIfNull("UIScreen")]
	public float HideScreenSpeed; // 0x48
	private string previousTriggerName; // 0x50

	// Methods

	// RVA: 0x61E3D0 Offset: 0x61C9D0 VA: 0x18061E3D0
	private void Awake() { }

	// RVA: 0x61EF60 Offset: 0x61D560 VA: 0x18061EF60
	private void Start() { }

	// RVA: 0x61E7F0 Offset: 0x61CDF0 VA: 0x18061E7F0
	private void OnEnable() { }

	// RVA: 0x61E9C0 Offset: 0x61CFC0 VA: 0x18061E9C0
	private void SelectionEvent() { }

	[IteratorStateMachine(typeof(StellarUIAnimator.<CancelSelectedStateCoroutine>d__13))]
	// RVA: 0x61E470 Offset: 0x61CA70 VA: 0x18061E470
	private IEnumerator CancelSelectedStateCoroutine() { }

	// RVA: 0x61EB60 Offset: 0x61D160 VA: 0x18061EB60
	public void SetSelectedState(bool cancelOtherSelections = True) { }

	// RVA: 0x61E4E0 Offset: 0x61CAE0 VA: 0x18061E4E0
	public void CancelSelectedState() { }

	// RVA: 0x61EED0 Offset: 0x61D4D0 VA: 0x18061EED0
	public void SetTrigger(string triggerName) { }

	// RVA: 0x61EA80 Offset: 0x61D080 VA: 0x18061EA80
	public void SetBool(string param, bool value) { }

	// RVA: 0x61EAF0 Offset: 0x61D0F0 VA: 0x18061EAF0
	public void SetFloat(string param, float value) { }

	// RVA: 0x61E560 Offset: 0x61CB60 VA: 0x18061E560
	private bool IsClipAssigned(string clipName) { }

	// RVA: 0x61EF80 Offset: 0x61D580 VA: 0x18061EF80
	public void .ctor() { }
}
