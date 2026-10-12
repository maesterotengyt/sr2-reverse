// Namespace: 
public class CustomizationOption : UINavigationElement // TypeDefIndex: 3144
{
	// Fields
	public TMP_Text ButtonText; // 0x98
	public GameObject GrayOutEffect; // 0xA0
	public Image ButtonImage; // 0xA8
	public bool Unlocked; // 0xB0
	public bool Selected; // 0xB1
	private CustomizationSubScreen customizationSubScreen; // 0xB8

	// Methods

	// RVA: 0x569B90 Offset: 0x568190 VA: 0x180569B90
	public void Initialize(string text, CustomizationSubScreen customizationSubScreen, bool selected = False, bool unlocked = False) { }

	// RVA: 0x569E30 Offset: 0x568430 VA: 0x180569E30 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x569D10 Offset: 0x568310 VA: 0x180569D10
	public void SetTriggers(bool selected = False, bool unlocked = False) { }

	// RVA: 0x56A0D0 Offset: 0x5686D0 VA: 0x18056A0D0
	public void UpdateTriggers(bool selected = False, bool unlocked = False) { }

	// RVA: 0x569CC0 Offset: 0x5682C0 VA: 0x180569CC0
	public void SetImage(Sprite sprite) { }

	// RVA: 0x569A90 Offset: 0x568090 VA: 0x180569A90 Slot: 4
	public override void ElementSelected(int playerIndex) { }

	// RVA: 0x569EE0 Offset: 0x5684E0 VA: 0x180569EE0
	public void UpdatePreview() { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
