// Namespace: 
public class CampaignActOption : UINavigationElement // TypeDefIndex: 2984
{
	// Fields
	[Header("Act Select Option")]
	public TMP_Text ActNameText; // 0x98
	public TMP_Text ActNameShadowText; // 0xA0
	public TMP_Text ActDescriptionText; // 0xA8
	public Image ActImage; // 0xB0
	public RectTransform HighlightRef; // 0xB8
	public GameObject LockedIcon; // 0xC0
	public GameObject GrayOutEffect; // 0xC8
	public GameObject CompletedIcon; // 0xD0
	public bool Initialized; // 0xD8
	private CampaignMenu campaignMenu; // 0xE0
	private CampaignActData actData; // 0xE8

	// Methods

	// RVA: 0x76E490 Offset: 0x76CA90 VA: 0x18076E490
	public void Initialize(CampaignMenu campaignMenu, CampaignActData actData, ActStatus actStatus) { }

	// RVA: 0x76E5D0 Offset: 0x76CBD0 VA: 0x18076E5D0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
