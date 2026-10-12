// Namespace: 
public class PracticeMenuOption : UINavigationElement // TypeDefIndex: 3162
{
	// Fields
	[Header("Practice Menu Option")]
	public PracticeMenuModeDisplay ModeDisplay; // 0x98
	public LocalizedString ModeName; // 0xA0
	public LocalizedString ModeDescription; // 0xA8
	[Space(10)]
	public bool ShowCompletedInfo; // 0xB0
	public GameObject CompletedInfoContainer; // 0xB8
	public Image CompletedIcon; // 0xC0
	public TextMeshProUGUI CompletedText; // 0xC8
	public Color CompletedColor; // 0xD0
	public Color NonCompletedColor; // 0xE0

	// Methods

	// RVA: 0x57B710 Offset: 0x579D10 VA: 0x18057B710 Slot: 5
	public override void Initialize(UINavigator uiNavigator, int navigationIndex) { }

	// RVA: 0x57B800 Offset: 0x579E00 VA: 0x18057B800 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x57B750 Offset: 0x579D50 VA: 0x18057B750
	public void SetCompletedState(bool completed) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
