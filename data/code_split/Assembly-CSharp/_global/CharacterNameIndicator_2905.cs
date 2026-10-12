// Namespace: 
public class CharacterNameIndicator : SRMonoBehaviour // TypeDefIndex: 2905
{
	// Fields
	public bool Initialized; // 0x20
	public GameObject Indicator; // 0x28
	public TextMeshProUGUI Name; // 0x30
	public TextMeshProUGUI NameShadow; // 0x38
	public BadgePlatformIcon BadgePlatformIcon; // 0x40
	public UIWorldIndicator UIWorldIndicator; // 0x48
	public float UpOffset; // 0x50
	public float DownOffset; // 0x54
	public bool IsLocal; // 0x58
	public float wrongDirectionTimeout; // 0x5C
	public StellarUIAnimator Animator; // 0x60
	[CompilerGenerated]
	private StellarCharacter <Character>k__BackingField; // 0x68
	[CompilerGenerated]
	private IndicatorState <CurrentState>k__BackingField; // 0x108
	[CompilerGenerated]
	private bool <AutoHide>k__BackingField; // 0x10C
	private IndicatorState currentState; // 0x110
	private IndicatorState lastState; // 0x114
	private DispatcherSubscription pickUpItemEvent; // 0x118
	private Coroutine showIndicatorCoroutine; // 0x120
	private Coroutine hideWrongDirectionCoroutine; // 0x128

	// Properties
	public StellarCharacter Character { get; set; }
	public IndicatorState CurrentState { get; set; }
	public bool AutoHide { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x750330 Offset: 0x74E930 VA: 0x180750330
	public StellarCharacter get_Character() { }

	[CompilerGenerated]
	// RVA: 0x7503D0 Offset: 0x74E9D0 VA: 0x1807503D0
	public void set_Character(StellarCharacter value) { }

	[CompilerGenerated]
	// RVA: 0x7503B0 Offset: 0x74E9B0 VA: 0x1807503B0
	public IndicatorState get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x750440 Offset: 0x74EA40 VA: 0x180750440
	public void set_CurrentState(IndicatorState value) { }

	[CompilerGenerated]
	// RVA: 0x750320 Offset: 0x74E920 VA: 0x180750320
	public bool get_AutoHide() { }

	[CompilerGenerated]
	// RVA: 0x7503C0 Offset: 0x74E9C0 VA: 0x1807503C0
	public void set_AutoHide(bool value) { }

	// RVA: 0x7566A0 Offset: 0x754CA0 VA: 0x1807566A0
	public void Initialize(StellarCharacter character, Transform characterPoint, RectTransform canvasRect, string name, bool isLocal) { }

	// RVA: 0x756AF0 Offset: 0x7550F0 VA: 0x180756AF0
	public void SetState(IndicatorState state) { }

	// RVA: 0x756D60 Offset: 0x755360 VA: 0x180756D60
	public void Show(bool autoHide = True) { }

	// RVA: 0x74F6E0 Offset: 0x74DCE0 VA: 0x18074F6E0
	public void Clean() { }

	// RVA: 0x756630 Offset: 0x754C30 VA: 0x180756630
	public void Hide() { }

	// RVA: 0x756AD0 Offset: 0x7550D0 VA: 0x180756AD0
	public void SetPositionUp() { }

	// RVA: 0x756AB0 Offset: 0x7550B0 VA: 0x180756AB0
	public void SetPositionDown() { }

	// RVA: 0x756920 Offset: 0x754F20 VA: 0x180756920
	private void OnPickupItem(EventOnPickupItem callback) { }

	[IteratorStateMachine(typeof(CharacterNameIndicator.<ShowIndicatorAfterDelay>d__36))]
	// RVA: 0x756CE0 Offset: 0x7552E0 VA: 0x180756CE0
	private IEnumerator ShowIndicatorAfterDelay(float delay) { }

	[IteratorStateMachine(typeof(CharacterNameIndicator.<HideAfterTime>d__37))]
	// RVA: 0x7565B0 Offset: 0x754BB0 VA: 0x1807565B0
	private IEnumerator HideAfterTime(float time) { }

	[IteratorStateMachine(typeof(CharacterNameIndicator.<WrongDirectionTimeoutRoutine>d__38))]
	// RVA: 0x756E80 Offset: 0x755480 VA: 0x180756E80
	private IEnumerator WrongDirectionTimeoutRoutine(bool hide) { }

	// RVA: 0x7568B0 Offset: 0x754EB0 VA: 0x1807568B0
	private void OnDestroy() { }

	// RVA: 0x7563D0 Offset: 0x7549D0 VA: 0x1807563D0
	public List<Vector2> GetIndicatorScreenPositions() { }

	// RVA: 0x756F00 Offset: 0x755500 VA: 0x180756F00
	public void .ctor() { }
}
