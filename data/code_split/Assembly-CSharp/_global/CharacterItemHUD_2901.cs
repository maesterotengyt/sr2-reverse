// Namespace: 
public class CharacterItemHUD : SRMonoBehaviour // TypeDefIndex: 2901
{
	// Fields
	public GameObject Container; // 0x20
	public Image ItemButtonIcon; // 0x28
	public Image ItemIcon; // 0x30
	public Animator Animator; // 0x38
	private EntityRef entityRef; // 0x40

	// Methods

	// RVA: 0x755E90 Offset: 0x754490 VA: 0x180755E90
	public void Initialize(EntityRef entityRef) { }

	// RVA: 0x756120 Offset: 0x754720 VA: 0x180756120
	private void OnPickupItem(EventOnPickupItem callback) { }

	// RVA: 0x756240 Offset: 0x754840 VA: 0x180756240
	private void OnUseItem(EventOnUseItem callback) { }

	// RVA: 0x7562C0 Offset: 0x7548C0 VA: 0x1807562C0
	private void ShowItemSprite(int itemID, int usageIndex) { }

	// RVA: 0x756070 Offset: 0x754670 VA: 0x180756070
	private void OnDropItem(EventOnDropItem callback) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
