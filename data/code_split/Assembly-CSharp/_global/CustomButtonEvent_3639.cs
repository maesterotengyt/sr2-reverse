// Namespace: 
public class CustomButtonEvent : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler // TypeDefIndex: 3639
{
	// Fields
	public UnityEvent OnSelectEvent; // 0x20
	public UnityEvent OnDeselectEvent; // 0x28
	public UnityEvent OnPointerEnterEvent; // 0x30
	public UnityEvent OnPointerExitEvent; // 0x38
	public UnityEvent OnPointerClickEvent; // 0x40

	// Methods

	// RVA: 0x614D70 Offset: 0x613370 VA: 0x180614D70 Slot: 4
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x614CF0 Offset: 0x6132F0 VA: 0x180614CF0 Slot: 5
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x614D30 Offset: 0x613330 VA: 0x180614D30 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x614D50 Offset: 0x613350 VA: 0x180614D50 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x614D10 Offset: 0x613310 VA: 0x180614D10 Slot: 8
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
