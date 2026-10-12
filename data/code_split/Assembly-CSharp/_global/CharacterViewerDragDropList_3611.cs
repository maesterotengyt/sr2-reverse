// Namespace: 
public class CharacterViewerDragDropList : MonoBehaviour, IDropHandler, IEventSystemHandler // TypeDefIndex: 3611
{
	// Fields
	public GameObject SlotsContainer; // 0x20
	public Canvas UICanvas; // 0x28
	public UnityEvent OnDropEvent; // 0x30
	public UnityEvent OnBeginDragEvent; // 0x38
	public UnityEvent OnEndDragEvent; // 0x40
	public List<CharacterViewerDragDropItemSlot> Slots; // 0x48
	public List<CharacterViewerAnimationData> PlaylistElements; // 0x50
	public bool AddUnique; // 0x58
	public bool ActiveDrop; // 0x59
	public bool Dragging; // 0x5A
	public CharacterViewerDragDropItemSlot DragSlot; // 0x60
	public int DropIndex; // 0x68
	public CharacterViewerDragDropItemSlot DropSlot; // 0x70

	// Methods

	// RVA: 0x606CB0 Offset: 0x6052B0 VA: 0x180606CB0
	public void RetrieveItem(CharacterViewerDragDropItemSlot slot, CharacterViewerDragDropList list, bool removeOrigin = False, int index = -1) { }

	// RVA: 0x606F40 Offset: 0x605540 VA: 0x180606F40
	public void SendItem(CharacterViewerDragDropItemSlot slot, CharacterViewerDragDropList list, bool removeOrigin = False, int index = -1) { }

	// RVA: 0x606BA0 Offset: 0x6051A0 VA: 0x180606BA0
	public void RemoveItem(CharacterViewerAnimationData data) { }

	// RVA: 0x606330 Offset: 0x604930 VA: 0x180606330
	public void AddItem(CharacterViewerAnimationData data, int positionIndex) { }

	// RVA: 0x606620 Offset: 0x604C20 VA: 0x180606620
	public void InitSlots() { }

	// RVA: 0x607280 Offset: 0x605880 VA: 0x180607280
	public void ToggleDrag(bool active) { }

	// RVA: 0x607330 Offset: 0x605930 VA: 0x180607330
	public void ToggleDrop(bool active) { }

	// RVA: 0x6068C0 Offset: 0x604EC0 VA: 0x1806068C0
	public void LoadData() { }

	// RVA: 0x606F70 Offset: 0x605570 VA: 0x180606F70
	public void ShowSlots(string filter) { }

	// RVA: 0x606A90 Offset: 0x605090 VA: 0x180606A90 Slot: 4
	public void OnDrop(PointerEventData eventData) { }

	// RVA: 0x607400 Offset: 0x605A00 VA: 0x180607400
	public void .ctor() { }
}
