// Namespace: 
public class UIPopup : SRMonoBehaviour // TypeDefIndex: 3235
{
	// Fields
	public Animator Animator; // 0x20
	[HideInInspector]
	public string PopUpID; // 0x28
	protected PopupManager popupManager; // 0x30

	// Properties
	private StellarInputSystem inputSystem { get; }

	// Methods

	// RVA: 0x597410 Offset: 0x595A10 VA: 0x180597410
	private StellarInputSystem get_inputSystem() { }

	// RVA: 0x5972B0 Offset: 0x5958B0 VA: 0x1805972B0
	public void Init(PopupManager popupManager, string popUpID) { }

	// RVA: 0x597310 Offset: 0x595910 VA: 0x180597310 Slot: 4
	public virtual void Show() { }

	// RVA: 0x597180 Offset: 0x595780 VA: 0x180597180 Slot: 5
	public virtual void Hide(bool destroy) { }

	[IteratorStateMachine(typeof(UIPopup.<DestroyPopup>d__8))]
	// RVA: 0x597110 Offset: 0x595710 VA: 0x180597110
	private IEnumerator DestroyPopup() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
