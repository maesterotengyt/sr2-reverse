// Namespace: 
public class PauseSubMenu : SRMonoBehaviour // TypeDefIndex: 3216
{
	// Fields
	public PauseSubMenuID ID; // 0x20
	public string ShowAnimTrigger; // 0x28
	public string HideAnimTrigger; // 0x30
	public UINavigator UINavigator; // 0x38
	protected bool initialized; // 0x40
	protected bool visible; // 0x41
	private PauseMenu pauseMenu; // 0x48
	private Coroutine disableCoroutine; // 0x50

	// Methods

	// RVA: 0x585590 Offset: 0x583B90 VA: 0x180585590 Slot: 4
	public virtual void Init(PauseMenu pauseMenu) { }

	// RVA: 0x5855E0 Offset: 0x583BE0 VA: 0x1805855E0 Slot: 5
	public virtual void Show(bool inmediate = False) { }

	// RVA: 0x585420 Offset: 0x583A20 VA: 0x180585420 Slot: 6
	public virtual void Hide(bool inmediate = False) { }

	[IteratorStateMachine(typeof(PauseSubMenu.<Disable>d__11))]
	// RVA: 0x5853B0 Offset: 0x5839B0 VA: 0x1805853B0
	private IEnumerator Disable() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
