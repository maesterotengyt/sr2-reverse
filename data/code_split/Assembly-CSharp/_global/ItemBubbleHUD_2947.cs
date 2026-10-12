// Namespace: 
public class ItemBubbleHUD : SRMonoBehaviour // TypeDefIndex: 2947
{
	// Fields
	public GameObject ItemBubble; // 0x20
	public Animator Animator; // 0x28
	public ItemIndicatorUIData NewItemIndicatorData; // 0x30
	public ItemIndicatorUIData CurrentItemIndicatorData; // 0x38
	public Image ItemMaskImage; // 0x40
	public Image ItemIcon; // 0x48
	public Image ContainerShadow; // 0x50
	public Image ContainerMask; // 0x58
	public Image ContainerPattern; // 0x60
	public Image BubbleTail; // 0x68
	private EntityRef entityRef; // 0x70
	private DispatcherSubscription pickUpItemEvent; // 0x78
	private Coroutine hideBubbleCoroutine; // 0x80

	// Methods

	// RVA: 0x768F80 Offset: 0x767580 VA: 0x180768F80
	public void Initialize(EntityRef entityRef) { }

	// RVA: 0x7690C0 Offset: 0x7676C0 VA: 0x1807690C0
	private void OnPickupItem(EventOnPickupItem callback) { }

	[IteratorStateMachine(typeof(ItemBubbleHUD.<HideBubbleAfterDelay>d__15))]
	// RVA: 0x768F00 Offset: 0x767500 VA: 0x180768F00
	private IEnumerator HideBubbleAfterDelay(float delay) { }

	// RVA: 0x769330 Offset: 0x767930 VA: 0x180769330
	private void ShowItemSprite(int itemID, int usageIndex, bool isNewItem) { }

	// RVA: 0x769060 Offset: 0x767660 VA: 0x180769060
	private void OnDestroy() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
