// Namespace: 
public class UIPlayerNavigator // TypeDefIndex: 3681
{
	// Fields
	public UINavigator UINavigator; // 0x10
	public bool Active; // 0x18
	public int CurrentElementIndex; // 0x1C
	public int PlayerIndex; // 0x20
	public int InputDeviceIndex; // 0x24
	private bool useAllDevices; // 0x28
	private bool scrolling; // 0x29
	private Vector2 scrollTargetPosition; // 0x2C
	private Vector2 scrollBarTargetPosition; // 0x34
	private float mouseHighlightTimer; // 0x3C
	private float timeHolding; // 0x40
	private bool holdingButton; // 0x44
	private UIKey buttonBeingHolded; // 0x48

	// Properties
	private StellarInputSystem inputSystem { get; }
	private int maxOptions { get; }
	private List<UINavigator.ElementInfo> elements { get; }
	private UINavigator.NavigationStyles navigationStyle { get; }
	private UINavigationElement currentElement { get; }
	private int gridColumnsAmount { get; }

	// Methods

	// RVA: 0x625D70 Offset: 0x624370 VA: 0x180625D70
	private StellarInputSystem get_inputSystem() { }

	// RVA: 0x625DC0 Offset: 0x6243C0 VA: 0x180625DC0
	private int get_maxOptions() { }

	// RVA: 0x625D30 Offset: 0x624330 VA: 0x180625D30
	private List<UINavigator.ElementInfo> get_elements() { }

	// RVA: 0x625E10 Offset: 0x624410 VA: 0x180625E10
	private UINavigator.NavigationStyles get_navigationStyle() { }

	// RVA: 0x625CD0 Offset: 0x6242D0 VA: 0x180625CD0
	private UINavigationElement get_currentElement() { }

	// RVA: 0x625D50 Offset: 0x624350 VA: 0x180625D50
	private int get_gridColumnsAmount() { }

	// RVA: 0x6247A0 Offset: 0x622DA0 VA: 0x1806247A0
	public void Init(UINavigator uiNavigator, int inputDeviceIndex, int playerIndex, bool useAllDevices) { }

	// RVA: 0x6230F0 Offset: 0x6216F0 VA: 0x1806230F0
	public void CheckInputs() { }

	// RVA: 0x624620 Offset: 0x622C20 VA: 0x180624620
	public void IncrementElement() { }

	// RVA: 0x623CD0 Offset: 0x6222D0 VA: 0x180623CD0
	public void DecrementElement() { }

	// RVA: 0x6253C0 Offset: 0x6239C0 VA: 0x1806253C0
	private bool SelectAvailableElement(List<UINavigationElement> elements) { }

	// RVA: 0x624480 Offset: 0x622A80 VA: 0x180624480
	public void HighlightCurrentElement(bool playSound = False) { }

	// RVA: 0x624E60 Offset: 0x623460 VA: 0x180624E60
	public void ScrollToOption(int currentElementIndex) { }

	// RVA: 0x624E10 Offset: 0x623410 VA: 0x180624E10
	public void ResetScroll() { }

	// RVA: 0x624360 Offset: 0x622960 VA: 0x180624360
	private Vector2 GetScrollEndPosition(int disabledElementsCount) { }

	// RVA: 0x6241C0 Offset: 0x6227C0 VA: 0x1806241C0
	private Vector2 GetScrollEndPositionGrid(int disabledRowsCount) { }

	// RVA: 0x625690 Offset: 0x623C90 VA: 0x180625690
	public void Update() { }

	// RVA: 0x623F10 Offset: 0x622510 VA: 0x180623F10
	public void DisableAllHighlights(bool ignoreCurrentElement = False) { }

	// RVA: 0x624D60 Offset: 0x623360 VA: 0x180624D60
	private bool IsCurrentElementAvailable() { }

	// RVA: 0x6247F0 Offset: 0x622DF0 VA: 0x1806247F0
	private bool InputDown(UIKey uIKey, bool checkHold = True) { }

	// RVA: 0x624B20 Offset: 0x623120 VA: 0x180624B20
	private bool InputHold(UIKey uIKey) { }

	// RVA: 0x624C40 Offset: 0x623240 VA: 0x180624C40
	private bool InputUp(UIKey uIKey) { }

	// RVA: 0x6240C0 Offset: 0x6226C0 VA: 0x1806240C0
	private int GetElementIndex(UINavigationElement element) { }

	// RVA: 0x625CC0 Offset: 0x6242C0 VA: 0x180625CC0
	public void .ctor() { }
}
