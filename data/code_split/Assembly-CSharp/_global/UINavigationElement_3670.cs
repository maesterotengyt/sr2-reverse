// Namespace: 
public class UINavigationElement : StellarMonoBehaviour // TypeDefIndex: 3670
{
	// Fields
	public bool Enabled; // 0x20
	public Button Button; // 0x28
	public Animator Animator; // 0x30
	public UnityEvent SelectionEvent; // 0x38
	[Header("Params")]
	public bool OverrideSounds; // 0x40
	[ShowIfBool("OverrideSounds", True)]
	public string SelectionSFX; // 0x48
	[ShowIfBool("OverrideSounds", True)]
	public string HighlightSFX; // 0x50
	public bool OverrideAnimationTriggers; // 0x58
	[ShowIfBool("OverrideAnimationTriggers", True)]
	public string HighlightAnimationTrigger; // 0x60
	[ShowIfBool("OverrideAnimationTriggers", True)]
	public string UndoHighlightAnimationTrigger; // 0x68
	[Header("Settings")]
	public bool DisableNavigationOnSelection; // 0x70
	public bool MouseCantDisableHighlight; // 0x71
	public float DelayBeforeSelectionEvent; // 0x74
	public bool IndependentOfUINavigator; // 0x78
	[CompilerGenerated]
	private int <NavigationIndex>k__BackingField; // 0x7C
	[CompilerGenerated]
	private UINavigator <UINavigator>k__BackingField; // 0x80
	[CompilerGenerated]
	private UnityEvent <SelectionEventNoDelay>k__BackingField; // 0x88
	[CompilerGenerated]
	private bool <SelectionEnabled>k__BackingField; // 0x90
	protected bool highlighted; // 0x91
	protected int currentPlayerIndex; // 0x94

	// Properties
	public int NavigationIndex { get; set; }
	public UINavigator UINavigator { get; set; }
	public UnityEvent SelectionEventNoDelay { get; set; }
	public bool SelectionEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x620240 Offset: 0x61E840 VA: 0x180620240
	public int get_NavigationIndex() { }

	[CompilerGenerated]
	// RVA: 0x620260 Offset: 0x61E860 VA: 0x180620260
	public void set_NavigationIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x54C330 Offset: 0x54A930 VA: 0x18054C330
	public UINavigator get_UINavigator() { }

	[CompilerGenerated]
	// RVA: 0x54C390 Offset: 0x54A990 VA: 0x18054C390
	public void set_UINavigator(UINavigator value) { }

	[CompilerGenerated]
	// RVA: 0x531670 Offset: 0x52FC70 VA: 0x180531670
	public UnityEvent get_SelectionEventNoDelay() { }

	[CompilerGenerated]
	// RVA: 0x54C3B0 Offset: 0x54A9B0 VA: 0x18054C3B0
	public void set_SelectionEventNoDelay(UnityEvent value) { }

	[CompilerGenerated]
	// RVA: 0x620250 Offset: 0x61E850 VA: 0x180620250
	public bool get_SelectionEnabled() { }

	[CompilerGenerated]
	// RVA: 0x620270 Offset: 0x61E870 VA: 0x180620270
	public void set_SelectionEnabled(bool value) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public virtual void ElementSelected(int playerIndex) { }

	// RVA: 0x61F660 Offset: 0x61DC60 VA: 0x18061F660
	public void ElementSelected() { }

	// RVA: 0x61FFC0 Offset: 0x61E5C0 VA: 0x18061FFC0
	private void Start() { }

	// RVA: 0x61F880 Offset: 0x61DE80 VA: 0x18061F880 Slot: 5
	public virtual void Initialize(UINavigator uiNavigator, int navigationIndex) { }

	// RVA: 0x61FD60 Offset: 0x61E360 VA: 0x18061FD60
	public void Selection(int playerIndex, bool playSound = False) { }

	[IteratorStateMachine(typeof(UINavigationElement.<SelectionDelayed>d__37))]
	// RVA: 0x61FC90 Offset: 0x61E290 VA: 0x18061FC90
	private IEnumerator SelectionDelayed(int playerIndex) { }

	// RVA: 0x61FD10 Offset: 0x61E310 VA: 0x18061FD10
	public void SelectionWithMouse() { }

	// RVA: 0x620020 Offset: 0x61E620 VA: 0x180620020 Slot: 6
	public virtual void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x6201E0 Offset: 0x61E7E0 VA: 0x1806201E0
	public void ToggleHighlight(bool highlighted) { }

	// RVA: 0x61F6B0 Offset: 0x61DCB0 VA: 0x18061F6B0
	public void HighlightThisElement(bool playSound = False, int playerIndex = -1) { }

	// RVA: 0x61F7C0 Offset: 0x61DDC0 VA: 0x18061F7C0
	public void HighlightWithMouse(BaseEventData eventData) { }

	// RVA: 0x61F600 Offset: 0x61DC00 VA: 0x18061F600
	public void CancelHighlightWithMouse(BaseEventData eventData) { }

	// RVA: 0x61F6A0 Offset: 0x61DCA0 VA: 0x18061F6A0
	public void HighlightThisElement() { }

	// RVA: 0x61FA30 Offset: 0x61E030 VA: 0x18061FA30
	private bool IsMouseAllowed() { }

	// RVA: 0x61F420 Offset: 0x61DA20 VA: 0x18061F420
	protected EventTrigger AddTriggersEvents(Selectable theSelectable, EventTriggerType eventTriggerType, Action<BaseEventData> onTriggerAction) { }

	// RVA: 0x61FFE0 Offset: 0x61E5E0 VA: 0x18061FFE0
	public void ToggleElement(bool enable) { }

	// RVA: 0x61FB90 Offset: 0x61E190 VA: 0x18061FB90
	public void PlaySFX(string sound) { }

	// RVA: 0x616340 Offset: 0x614940 VA: 0x180616340
	public void .ctor() { }
}
