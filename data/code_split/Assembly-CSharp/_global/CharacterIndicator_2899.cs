// Namespace: 
public class CharacterIndicator : SRMonoBehaviour // TypeDefIndex: 2899
{
	// Fields
	public bool Initialized; // 0x20
	public GameObject Indicator; // 0x28
	public Image PlayerIcon; // 0x30
	public UIWorldIndicator UIWorldIndicator; // 0x38
	[Header("Sprites")]
	public Sprite DeathSprite; // 0x40
	public Sprite AliveSprite; // 0x48
	public Sprite WrongDirectionSprite; // 0x50
	[Header("Settings")]
	[Tooltip("How long (in seconds) without receiving the WrongDirection event before it hides.")]
	public float wrongDirectionTimeout; // 0x58
	public StellarUIAnimator Animator; // 0x60
	[CompilerGenerated]
	private StellarCharacter <Character>k__BackingField; // 0x68
	[CompilerGenerated]
	private IndicatorState <CurrentState>k__BackingField; // 0x108
	[CompilerGenerated]
	private bool <AutoHide>k__BackingField; // 0x10C
	private IndicatorState currentState; // 0x110
	private IndicatorState lastState; // 0x114
	private Coroutine hideWrongDirectionCoroutine; // 0x118
	private DispatcherSubscription pickUpItemEvent; // 0x120
	private Coroutine showIndicatorCoroutine; // 0x128

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

	// RVA: 0x74FA70 Offset: 0x74E070 VA: 0x18074FA70
	public void Initialize(StellarCharacter character, Transform characterPoint, RectTransform canvasRect) { }

	// RVA: 0x74FDD0 Offset: 0x74E3D0 VA: 0x18074FDD0
	public void SetState(IndicatorState state) { }

	// RVA: 0x74FC40 Offset: 0x74E240 VA: 0x18074FC40
	private void OnPickupItem(EventOnPickupItem callback) { }

	[IteratorStateMachine(typeof(CharacterIndicator.<ShowIndicatorAfterDelay>d__29))]
	// RVA: 0x7500F0 Offset: 0x74E6F0 VA: 0x1807500F0
	private IEnumerator ShowIndicatorAfterDelay(float delay) { }

	[IteratorStateMachine(typeof(CharacterIndicator.<WrongDirectionTimeoutRoutine>d__30))]
	// RVA: 0x750280 Offset: 0x74E880 VA: 0x180750280
	private IEnumerator WrongDirectionTimeoutRoutine(bool hide) { }

	// RVA: 0x750170 Offset: 0x74E770 VA: 0x180750170
	public void Show(bool autoHide = True) { }

	[IteratorStateMachine(typeof(CharacterIndicator.<HideAfterTime>d__32))]
	// RVA: 0x74F9A0 Offset: 0x74DFA0 VA: 0x18074F9A0
	private IEnumerator HideAfterTime(float time) { }

	// RVA: 0x74F6E0 Offset: 0x74DCE0 VA: 0x18074F6E0
	public void Clean() { }

	// RVA: 0x74FA20 Offset: 0x74E020 VA: 0x18074FA20
	public void Hide() { }

	// RVA: 0x74F7C0 Offset: 0x74DDC0 VA: 0x18074F7C0
	public List<Vector2> GetIndicatorScreenPositions() { }

	// RVA: 0x74FBD0 Offset: 0x74E1D0 VA: 0x18074FBD0
	private void OnDestroy() { }

	// RVA: 0x750300 Offset: 0x74E900 VA: 0x180750300
	public void .ctor() { }
}
