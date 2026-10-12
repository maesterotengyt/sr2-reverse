// Namespace: 
public class DangerIndicator : SRMonoBehaviour // TypeDefIndex: 2928
{
	// Fields
	public bool Initialized; // 0x20
	public GameObject Indicator; // 0x28
	public Image PlayerIcon; // 0x30
	public UIWorldIndicator UIWorldIndicator; // 0x38
	public float nearBlastzoneTimeout; // 0x40
	public StellarUIAnimator Animator; // 0x48
	[CompilerGenerated]
	private StellarCharacter <Character>k__BackingField; // 0x50
	private DispatcherSubscription nearBlastzoneEvent; // 0xF0
	private Coroutine showIndicatorCoroutine; // 0xF8
	private bool isShowing; // 0x100

	// Properties
	public StellarCharacter Character { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x75C910 Offset: 0x75AF10 VA: 0x18075C910
	public StellarCharacter get_Character() { }

	[CompilerGenerated]
	// RVA: 0x75C980 Offset: 0x75AF80 VA: 0x18075C980
	public void set_Character(StellarCharacter value) { }

	// RVA: 0x75C4E0 Offset: 0x75AAE0 VA: 0x18075C4E0
	public void Initialize(StellarCharacter character, Transform characterPoint, RectTransform canvasRect) { }

	// RVA: 0x75C640 Offset: 0x75AC40 VA: 0x18075C640
	private void OnDangerZone(EventPlayerNearDeath callback) { }

	[IteratorStateMachine(typeof(DangerIndicator.<ShowAndHideRoutine>d__15))]
	// RVA: 0x75C810 Offset: 0x75AE10 VA: 0x18075C810
	private IEnumerator ShowAndHideRoutine(bool alreadyShowing) { }

	// RVA: 0x75C890 Offset: 0x75AE90 VA: 0x18075C890
	public void Show() { }

	// RVA: 0x75C490 Offset: 0x75AA90 VA: 0x18075C490
	public void Hide() { }

	// RVA: 0x75C160 Offset: 0x75A760 VA: 0x18075C160
	public void Clean() { }

	// RVA: 0x75C7B0 Offset: 0x75ADB0 VA: 0x18075C7B0
	public void ResetTimer() { }

	// RVA: 0x75C2B0 Offset: 0x75A8B0 VA: 0x18075C2B0
	public List<Vector2> GetIndicatorScreenPositions() { }

	// RVA: 0x75C740 Offset: 0x75AD40 VA: 0x18075C740
	private void OnDestroy() { }

	// RVA: 0x75C900 Offset: 0x75AF00 VA: 0x18075C900
	public void .ctor() { }
}
