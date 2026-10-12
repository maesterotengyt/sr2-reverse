// Namespace: 
public class CustomThumbStickInput : Selectable, IDragHandler, IEventSystemHandler // TypeDefIndex: 3640
{
	// Fields
	public RectTransform SocketTransform; // 0x100
	public RectTransform StickTransform; // 0x108
	public RectTransform DistanceReferenceTransform; // 0x110
	public Vector2 InputVector; // 0x118
	public Vector2 NormalizedInput; // 0x120
	public UnityEvent OnChangedValue; // 0x128

	// Properties
	public float DistanceRange { get; }

	// Methods

	// RVA: 0x615520 Offset: 0x613B20 VA: 0x180615520
	public float get_DistanceRange() { }

	// RVA: 0x614DE0 Offset: 0x6133E0 VA: 0x180614DE0 Slot: 39
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x6151C0 Offset: 0x6137C0 VA: 0x1806151C0 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x615370 Offset: 0x613970 VA: 0x180615370
	public void SetStickVector(float angle, float distance) { }

	// RVA: 0x6151F0 Offset: 0x6137F0 VA: 0x1806151F0
	public void SetStickVector(Vector2 normalPosition) { }

	// RVA: 0x614D90 Offset: 0x613390 VA: 0x180614D90 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x60A3B0 Offset: 0x6089B0 VA: 0x18060A3B0 Slot: 34
	public override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x60A400 Offset: 0x608A00 VA: 0x18060A400 Slot: 35
	public override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x6154D0 Offset: 0x613AD0 VA: 0x1806154D0
	public void .ctor() { }
}
