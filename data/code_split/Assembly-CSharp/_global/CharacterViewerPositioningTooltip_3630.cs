// Namespace: 
public class CharacterViewerPositioningTooltip : Selectable // TypeDefIndex: 3630
{
	// Fields
	public CharacterViewerPositionMap Map; // 0x100
	public TMP_InputField XCoordinateInput; // 0x108
	public TMP_InputField YCoordinateInput; // 0x110
	public CustomToggleGroup FacingDirectionToggleGroup; // 0x118
	public RectTransform Viewport; // 0x120
	public RectTransform Panel; // 0x128
	public RectTransform Pointer; // 0x130
	public float ViewportHorizontalSpace; // 0x138
	public float ViewportVerticalSpace; // 0x13C
	public float PanelHorizontalSpace; // 0x140
	public float PanelVerticalSpace; // 0x144
	public float PanelDistance; // 0x148
	private bool focused; // 0x14C
	private CharacterViewerMapIcon icon; // 0x150
	private const float VIEWPADDINGX = 0.22;
	private const float VIEWPADDINGY = 0.35;
	private const float TOOLTIPPADDING = 0.4;

	// Methods

	// RVA: 0x613670 Offset: 0x611C70 VA: 0x180613670
	public void UpdatePosition(RectTransform iconPosition) { }

	// RVA: 0x613630 Offset: 0x611C30 VA: 0x180613630
	public void TryDeselect() { }

	// RVA: 0x613560 Offset: 0x611B60 VA: 0x180613560
	public void SetText(Vector2 position) { }

	// RVA: 0x613600 Offset: 0x611C00 VA: 0x180613600
	public void SetToggle(bool facingRight) { }

	// RVA: 0x6133D0 Offset: 0x6119D0 VA: 0x1806133D0
	public void SetPosition() { }

	// RVA: 0x613340 Offset: 0x611940 VA: 0x180613340
	public void SetFacingDirection(bool facingRight) { }

	// RVA: 0x613280 Offset: 0x611880 VA: 0x180613280 Slot: 34
	public override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x6132A0 Offset: 0x6118A0 VA: 0x1806132A0 Slot: 35
	public override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x6131D0 Offset: 0x6117D0 VA: 0x1806131D0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x613B50 Offset: 0x612150 VA: 0x180613B50
	public void .ctor() { }
}
