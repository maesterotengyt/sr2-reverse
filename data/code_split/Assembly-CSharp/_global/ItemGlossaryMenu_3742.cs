// Namespace: 
public class ItemGlossaryMenu : MainMenuScreen // TypeDefIndex: 3742
{
	// Fields
	public List<GlossaryMenuOption> Options; // 0x90
	public TextMeshProUGUI ItemTitle; // 0x98
	public TextMeshProUGUI ItemDescription; // 0xA0
	public Image ItemIcon; // 0xA8
	public Image ItemUsageIllustration; // 0xB0
	public Image ItemWireframe; // 0xB8
	[HideInInspector]
	public HashString CurrentItemID; // 0xC0
	[SerializeField]
	private GlossaryItemsData GlossaryItemsData; // 0xD0

	// Properties
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x642B70 Offset: 0x641170 VA: 0x180642B70
	private OnlineManager get_onlineManager() { }

	// RVA: 0x641F40 Offset: 0x640540 VA: 0x180641F40 Slot: 4
	public override void Initialize() { }

	// RVA: 0x6429B0 Offset: 0x640FB0 VA: 0x1806429B0 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x642590 Offset: 0x640B90 VA: 0x180642590 Slot: 7
	public override void Show() { }

	// RVA: 0x642840 Offset: 0x640E40 VA: 0x180642840
	private void UpdateOptionsText() { }

	// RVA: 0x642370 Offset: 0x640970 VA: 0x180642370
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x641F00 Offset: 0x640500 VA: 0x180641F00 Slot: 8
	public override void Hide() { }

	// RVA: 0x642270 Offset: 0x640870 VA: 0x180642270
	public void LoadItemData(HashString itemID) { }

	// RVA: 0x641EA0 Offset: 0x6404A0 VA: 0x180641EA0
	public void ChangeItemSprite() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
