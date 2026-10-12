// Namespace: 
public class CharacterSelectPanelUINavigationElement : UINavigationElement // TypeDefIndex: 3022
{
	// Fields
	[Header("Character Panel")]
	public RectTransform HighlightRef; // 0x98
	public List<Image> ColoredHighlightsImages; // 0xA0
	protected int selectorNumber; // 0xA8

	// Properties
	private UIManager uiManager { get; }
	private CharacterSelectBase characterSelect { get; }
	protected CharacterSelector selector { get; }

	// Methods

	// RVA: 0x78E980 Offset: 0x78CF80 VA: 0x18078E980
	private UIManager get_uiManager() { }

	// RVA: 0x78E870 Offset: 0x78CE70 VA: 0x18078E870
	private CharacterSelectBase get_characterSelect() { }

	// RVA: 0x78E8D0 Offset: 0x78CED0 VA: 0x18078E8D0
	protected CharacterSelector get_selector() { }

	// RVA: 0x78E640 Offset: 0x78CC40 VA: 0x18078E640
	public void SetSelector(int selectorNumber) { }

	// RVA: 0x78E3F0 Offset: 0x78C9F0 VA: 0x18078E3F0
	public void SetColor() { }

	// RVA: 0x78E650 Offset: 0x78CC50 VA: 0x18078E650 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
