// Namespace: 
public class EquipableItemOption : UINavigationElement // TypeDefIndex: 2967
{
	// Fields
	public Image ItemIcon; // 0x98
	public Sprite NoItemSprite; // 0xA0
	[CompilerGenerated]
	private HashString <ItemID>k__BackingField; // 0xA8
	private TrainingMatchHUD trainingMatchHUD; // 0xB8
	private string itemName; // 0xC0

	// Properties
	public HashString ItemID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x776100 Offset: 0x774700 VA: 0x180776100
	public HashString get_ItemID() { }

	[CompilerGenerated]
	// RVA: 0x776110 Offset: 0x774710 VA: 0x180776110
	public void set_ItemID(HashString value) { }

	// RVA: 0x775F70 Offset: 0x774570 VA: 0x180775F70
	public void Initialize(TrainingMatchHUD trainingMatchHUD, ItemUIData itemUIData) { }

	// RVA: 0x775F10 Offset: 0x774510 VA: 0x180775F10
	internal void InitializeAsNone(TrainingMatchHUD trainingMatchHUD) { }

	// RVA: 0x776040 Offset: 0x774640 VA: 0x180776040 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
