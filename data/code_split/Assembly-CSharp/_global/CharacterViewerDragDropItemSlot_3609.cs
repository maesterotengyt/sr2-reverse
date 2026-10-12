// Namespace: 
public class CharacterViewerDragDropItemSlot : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerMoveHandler, IPointerExitHandler // TypeDefIndex: 3609
{
	// Fields
	public CharacterViewerAnimationListElement Item; // 0x20
	public RectTransform ItemContainer; // 0x28
	public CanvasGroup CanvasGroup; // 0x30
	public GameObject TopCover; // 0x38
	public GameObject TopJoint; // 0x40
	public GameObject BottomCover; // 0x48
	public GameObject BottomJoint; // 0x50
	public Canvas UICanvas; // 0x58
	public bool ActiveDrag; // 0x60
	public CharacterViewerDragDropList DragDropList; // 0x68
	private Vector2 startPosition; // 0x70
	private Canvas topCanvas; // 0x78
	private Vector2 lastPosition; // 0x80

	// Methods

	// RVA: 0x606120 Offset: 0x604720 VA: 0x180606120
	private void Start() { }

	// RVA: 0x6062C0 Offset: 0x6048C0 VA: 0x1806062C0
	public void ToggleSlot(bool active, int index = -1) { }

	// RVA: 0x606170 Offset: 0x604770 VA: 0x180606170
	public void ToggleDrag(bool active) { }

	// RVA: 0x606180 Offset: 0x604780 VA: 0x180606180
	public void ToggleDrop(bool active) { }

	// RVA: 0x6061D0 Offset: 0x6047D0 VA: 0x1806061D0
	private int ToggleJoint(GameObject source) { }

	// RVA: 0x605BD0 Offset: 0x6041D0 VA: 0x180605BD0
	public void FilterSlot(string filter) { }

	// RVA: 0x605C80 Offset: 0x604280 VA: 0x180605C80 Slot: 4
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x605E90 Offset: 0x604490 VA: 0x180605E90 Slot: 5
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x605DA0 Offset: 0x6043A0 VA: 0x180605DA0 Slot: 6
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x606060 Offset: 0x604660 VA: 0x180606060
	public void OnScroll() { }

	// RVA: 0x605F80 Offset: 0x604580 VA: 0x180605F80 Slot: 8
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x605FD0 Offset: 0x6045D0 VA: 0x180605FD0 Slot: 7
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
