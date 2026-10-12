// Namespace: 
public class MultipleHandlesSlider : Slider // TypeDefIndex: 3650
{
	// Fields
	public UnityEvent SelectHandleEvent; // 0x168
	public UnityEvent OnValueChanged; // 0x170
	public float CustomMaxValue; // 0x178
	public int SelectedIndex; // 0x17C
	public int HighlightedIndex; // 0x180
	public int LastSelectedIndex; // 0x184
	public float LastSelectedValue; // 0x188
	private List<MultipleHandlesSlider.Handle> handleList; // 0x190
	private RectTransform defaultHandler; // 0x198

	// Methods

	// RVA: 0x618620 Offset: 0x616C20 VA: 0x180618620 Slot: 6
	protected override void Start() { }

	// RVA: 0x617C10 Offset: 0x616210 VA: 0x180617C10
	public int GetHandlerIndex(RectTransform handle) { }

	// RVA: 0x617CF0 Offset: 0x6162F0 VA: 0x180617CF0
	public int GetHandlerIndex(float value) { }

	// RVA: 0x617DD0 Offset: 0x6163D0 VA: 0x180617DD0
	public int GetNewIndex() { }

	// RVA: 0x6184E0 Offset: 0x616AE0 VA: 0x1806184E0
	public void SetHandleValue(float value, int index) { }

	// RVA: 0x617B80 Offset: 0x616180 VA: 0x180617B80
	public float GetHandleValue(int index) { }

	// RVA: 0x618920 Offset: 0x616F20 VA: 0x180618920
	public void ToogleHandle(bool active, int index) { }

	// RVA: 0x617B50 Offset: 0x616150 VA: 0x180617B50
	public void DisableSelectedHandle() { }

	// RVA: 0x617E80 Offset: 0x616480 VA: 0x180617E80 Slot: 54
	public override void OnDrag(PointerEventData eventData) { }

	// RVA: 0x617FB0 Offset: 0x6165B0 VA: 0x180617FB0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x618190 Offset: 0x616790 VA: 0x180618190 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x6180E0 Offset: 0x6166E0 VA: 0x1806180E0 Slot: 34
	public override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x618160 Offset: 0x616760 VA: 0x180618160 Slot: 35
	public override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x617A20 Offset: 0x616020 VA: 0x180617A20
	private void CheckCustomMaxValue() { }

	// RVA: 0x618360 Offset: 0x616960 VA: 0x180618360
	public void ResetHandles() { }

	// RVA: 0x618A50 Offset: 0x617050 VA: 0x180618A50
	public void .ctor() { }
}
