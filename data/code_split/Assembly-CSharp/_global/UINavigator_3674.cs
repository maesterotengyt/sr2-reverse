// Namespace: 
public class UINavigator : StellarMonoBehaviour // TypeDefIndex: 3674
{
	// Fields
	public List<UINavigator.ElementInfo> Elements; // 0x20
	public List<GameObject> ElementsContainers; // 0x28
	public UINavigator.NavigationStyles NavigationStyle; // 0x30
	[ShowIfEnum("NavigationStyle", 3)]
	public GridLayoutGroup GridLayoutGroup; // 0x38
	[ShowIfEnum("NavigationStyle", 3)]
	public int ManualGridColumnAmount; // 0x40
	[Header("Settings")]
	public string InputLayer; // 0x48
	public bool MultiplePlayersSupport; // 0x50
	public bool ManualInputDevice; // 0x51
	public bool ResetWhenEnabled; // 0x52
	public bool HighlightAlwaysAllowed; // 0x53
	public bool MouseAlwaysAllowed; // 0x54
	public bool DontHighlightWhenDisabled; // 0x55
	public UINavigatorExtendedCalls ExtendedCalls; // 0x58
	public bool MouseActive; // 0x60
	public bool UsedMouseInLastInput; // 0x61
	[Header("Scroll Settings")]
	public bool ScrollEnabled; // 0x62
	[ShowIfBool("ScrollEnabled", True)]
	public int AmountOfOptionsToEnableScroll; // 0x64
	[ShowIfBool("ScrollEnabled", True)]
	public RectTransform ScrollContent; // 0x68
	[ShowIfBool("ScrollEnabled", True)]
	public float ScrollSpeed; // 0x70
	[ShowIfBool("ScrollEnabled", True)]
	public Vector2 ScrollStartPosition; // 0x74
	[ShowIfBool("ScrollEnabled", True)]
	public Vector2 ScrollEndPosition; // 0x7C
	[ShowIfBool("ScrollEnabled", True)]
	public bool AutoScrollEnd; // 0x84
	[ShowIfBool("ScrollEnabled", True)]
	public Vector2 ScrollOptionSize; // 0x88
	[ShowIfBool("ScrollEnabled", True)]
	public float ScrollOptionGridSpacingSize; // 0x90
	[ShowIfBool("ScrollEnabled", True)]
	public bool ScrollBarEnabled; // 0x94
	[ShowIfBool("ScrollEnabled", True)]
	public RectTransform ScrollBar; // 0x98
	[ShowIfBool("ScrollEnabled", True)]
	public Vector2 ScrollBarStartPosition; // 0xA0
	[ShowIfBool("ScrollEnabled", True)]
	public Vector2 ScrollBarEndPosition; // 0xA8
	[ShowIfBool("ScrollEnabled", True)]
	[Range(0, 1)]
	public float mouseActivationThreshold; // 0xB0
	[ShowIfBool("ScrollEnabled", True)]
	[Range(0, 1)]
	public bool RestrictScrollToKeyboardDevices; // 0xB4
	public bool AllowOtherPlayersMouseClick; // 0xB5
	public bool UseCancelEvent; // 0xB6
	[ShowIfBool("UseCancelEvent", True)]
	public UnityEvent CancelEvent; // 0xB8
	public bool UseHighlightEvent; // 0xC0
	[ShowIfBool("UseHighlightEvent", True)]
	public UnityEvent OnHighlightEvent; // 0xC8
	[CompilerGenerated]
	private UINavigationElement <LastHighlightedElement>k__BackingField; // 0xD0
	private bool initComplete; // 0xD8
	private bool navigationActive; // 0xD9
	private List<UIPlayerNavigator> playerNavigators; // 0xE0

	// Properties
	public UINavigationElement LastHighlightedElement { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6230C0 Offset: 0x6216C0 VA: 0x1806230C0
	public UINavigationElement get_LastHighlightedElement() { }

	[CompilerGenerated]
	// RVA: 0x6230D0 Offset: 0x6216D0 VA: 0x1806230D0
	public void set_LastHighlightedElement(UINavigationElement value) { }

	// RVA: 0x6221D0 Offset: 0x6207D0 VA: 0x1806221D0
	private void OnEnable() { }

	// RVA: 0x621430 Offset: 0x61FA30 VA: 0x180621430
	public StellarInputSystem GetInputSystem() { }

	// RVA: 0x621990 Offset: 0x61FF90 VA: 0x180621990
	public void Initialize() { }

	// RVA: 0x622330 Offset: 0x620930 VA: 0x180622330
	public void RefreshPlayers() { }

	// RVA: 0x620670 Offset: 0x61EC70 VA: 0x180620670
	public void ClearPlayersData() { }

	// RVA: 0x6206E0 Offset: 0x61ECE0 VA: 0x1806206E0
	public void CreateUIPlayerNavigator(int inputDeviceIndex, int playerIndex, bool useAllDevices) { }

	// RVA: 0x6224E0 Offset: 0x620AE0 VA: 0x1806224E0
	public void RemoveUIPlayerNavigator(int inputDeviceIndex) { }

	// RVA: 0x620550 Offset: 0x61EB50 VA: 0x180620550
	public bool AssignSpecificPlayer(int playerIndex, int inputDeviceIndex) { }

	// RVA: 0x622ED0 Offset: 0x6214D0 VA: 0x180622ED0
	private void Update() { }

	// RVA: 0x621440 Offset: 0x61FA40 VA: 0x180621440
	public void HighlightCurrentElement(bool playSound = False, int playerIndex = -1) { }

	// RVA: 0x621680 Offset: 0x61FC80 VA: 0x180621680
	public void HighlightFirstActiveElement(bool playSound = False) { }

	// RVA: 0x622B40 Offset: 0x621140 VA: 0x180622B40
	public void UpdateAutoScrollEnd() { }

	// RVA: 0x621790 Offset: 0x61FD90 VA: 0x180621790
	public void HighlightLastActiveElement() { }

	// RVA: 0x621750 Offset: 0x61FD50 VA: 0x180621750
	public void HighlightIndex(int index) { }

	// RVA: 0x620900 Offset: 0x61EF00 VA: 0x180620900
	public void DisableAllHighlights(bool ignoreCurrentElement = False) { }

	// RVA: 0x621870 Offset: 0x61FE70 VA: 0x180621870
	public void IncrementElement() { }

	// RVA: 0x6207E0 Offset: 0x61EDE0 VA: 0x1806207E0
	public void DecrementElement() { }

	// RVA: 0x622740 Offset: 0x620D40 VA: 0x180622740
	public void SetCurrentIndex(int index, int playerIndex = -1, bool highlight = False) { }

	// RVA: 0x620F10 Offset: 0x61F510 VA: 0x180620F10
	public int GetCurrentIndex() { }

	// RVA: 0x620F80 Offset: 0x61F580 VA: 0x180620F80
	public int GetCurrentIndex(int playerIndex) { }

	// RVA: 0x620D80 Offset: 0x61F380 VA: 0x180620D80
	public List<UIPlayerNavigator> GetActivePlayerNavigators() { }

	// RVA: 0x6210D0 Offset: 0x61F6D0 VA: 0x1806210D0
	public int GetEnabledElementsCount() { }

	[Obsolete]
	// RVA: 0x6228D0 Offset: 0x620ED0 VA: 0x1806228D0
	public void ToggleNavigation(bool active) { }

	// RVA: 0x620B70 Offset: 0x61F170 VA: 0x180620B70
	public void EnableNavigation(bool highlightFirstElement = True) { }

	// RVA: 0x620A40 Offset: 0x61F040 VA: 0x180620A40
	public void DisableNavigation(bool disableHighlights = True) { }

	// RVA: 0x6229F0 Offset: 0x620FF0 VA: 0x1806229F0
	public void TogglePlayerNavigator(int playerIndex, bool active) { }

	// RVA: 0x6225B0 Offset: 0x620BB0 VA: 0x1806225B0
	public void ResetScrollPosition() { }

	// RVA: 0x621F20 Offset: 0x620520 VA: 0x180621F20
	public bool IsActive() { }

	// RVA: 0x622080 Offset: 0x620680 VA: 0x180622080
	public bool IsPlayerActive(int playerIndex) { }

	// RVA: 0x621240 Offset: 0x61F840 VA: 0x180621240
	public int GetGridColumnCount() { }

	// RVA: 0x622FF0 Offset: 0x6215F0 VA: 0x180622FF0
	public void .ctor() { }
}
