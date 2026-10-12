// Namespace: 
public class CharacterViewerMapIcon : Selectable, IDragHandler, IEventSystemHandler // TypeDefIndex: 3624
{
	// Fields
	public CharacterViewerPositionMap Map; // 0x100
	public CustomToggleButton Direction; // 0x108
	public CharacterViewerPositioningTooltip Tooltip; // 0x110
	public RectTransform IconTransform; // 0x118
	public RectTransform TopTooltipTransform; // 0x120
	public RectTransform BottomTooltipTransform; // 0x128
	public RectTransform ContentTransform; // 0x130
	public UnityEvent OnChangedValue; // 0x138
	public Vector2 WorldPosition; // 0x140
	private bool updateNotify; // 0x148

	// Properties
	public bool FacingRight { get; }

	// Methods

	// RVA: 0x60A8B0 Offset: 0x608EB0 VA: 0x18060A8B0
	public bool get_FacingRight() { }

	// RVA: 0x60A510 Offset: 0x608B10 VA: 0x18060A510
	public void SetIconPosition(Vector2 worldPosition) { }

	// RVA: 0x60A650 Offset: 0x608C50 VA: 0x18060A650
	public void ToggleFacingDirection(bool facingRight) { }

	// RVA: 0x60A770 Offset: 0x608D70 VA: 0x18060A770
	public void UpdateFacingDirecction() { }

	// RVA: 0x60A370 Offset: 0x608970 VA: 0x18060A370 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x60A2A0 Offset: 0x6088A0 VA: 0x18060A2A0 Slot: 39
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x60A440 Offset: 0x608A40 VA: 0x18060A440 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x60A270 Offset: 0x608870 VA: 0x18060A270 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x60A3B0 Offset: 0x6089B0 VA: 0x18060A3B0 Slot: 34
	public override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x60A400 Offset: 0x608A00 VA: 0x18060A400 Slot: 35
	public override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x60A860 Offset: 0x608E60 VA: 0x18060A860
	public void .ctor() { }
}
