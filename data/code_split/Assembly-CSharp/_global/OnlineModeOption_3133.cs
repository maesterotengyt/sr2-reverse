// Namespace: 
public class OnlineModeOption : UINavigationElement // TypeDefIndex: 3133
{
	// Fields
	[Header("Online Hub Option")]
	public TMP_Text ModeNameText; // 0x98
	public TMP_Text ModeNameShadow; // 0xA0
	public TMP_Text ModeDescriptionText; // 0xA8
	public LocalizedString ModeName; // 0xB0
	public LocalizedString ModeDescription; // 0xB8
	public List<LocalizedString> LabelsStrings; // 0xC0
	public List<TMP_Text> LabelsText; // 0xC8
	public RectTransformAutoRebuild RectTransformAutoRebuild; // 0xD0
	public RectTransform HighlightRef; // 0xD8
	private OnlineModeSelect onlineModeSelect; // 0xE0

	// Methods

	// RVA: 0x576B70 Offset: 0x575170 VA: 0x180576B70
	public void SetTitle(OnlineModeSelect onlineModeSelect) { }

	// RVA: 0x576EC0 Offset: 0x5754C0 VA: 0x180576EC0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
