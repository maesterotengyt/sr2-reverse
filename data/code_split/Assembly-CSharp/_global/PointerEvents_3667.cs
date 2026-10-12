// Namespace: 
public class PointerEvents : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 3667
{
	// Fields
	public UnityEvent OnPointerDownEvent; // 0x20
	public UnityEvent OnPointerUpEvent; // 0x28
	public UnityEvent OnPointerEnterEvent; // 0x30
	public UnityEvent OnPointerExitEvent; // 0x38

	// Methods

	// RVA: 0x614D70 Offset: 0x613370 VA: 0x180614D70 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x614CF0 Offset: 0x6132F0 VA: 0x180614CF0 Slot: 5
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x614D30 Offset: 0x613330 VA: 0x180614D30 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x614D50 Offset: 0x613350 VA: 0x180614D50 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
