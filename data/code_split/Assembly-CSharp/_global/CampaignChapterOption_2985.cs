// Namespace: 
public class CampaignChapterOption : UINavigationElement // TypeDefIndex: 2985
{
	// Fields
	public Animator ChapterOptionAnimator; // 0x98
	public Image ChapterImage; // 0xA0
	public RectTransform HighlightRef; // 0xA8
	public GameObject Locked; // 0xB0
	public bool Initialized; // 0xB8
	private CampaignChapterData chapterData; // 0xC0
	private CampaignMenu campaignMenu; // 0xC8
	private bool isLocked; // 0xD0

	// Properties
	private UIManager uiManager { get; }
	private SaveManager saveManager { get; }

	// Methods

	// RVA: 0x76EDE0 Offset: 0x76D3E0 VA: 0x18076EDE0
	private UIManager get_uiManager() { }

	// RVA: 0x76ED90 Offset: 0x76D390 VA: 0x18076ED90
	private SaveManager get_saveManager() { }

	// RVA: 0x76E7E0 Offset: 0x76CDE0 VA: 0x18076E7E0
	public void Init(CampaignMenu campaignMenu, CampaignChapterData chapterData, ChapterStatus chapterStatus) { }

	// RVA: 0x76E650 Offset: 0x76CC50 VA: 0x18076E650
	public Sprite DisplayLoadedSprite(AssetReference targetReference) { }

	// RVA: 0x76E770 Offset: 0x76CD70 VA: 0x18076E770 Slot: 4
	public override void ElementSelected(int playerIndex) { }

	// RVA: 0x76E8E0 Offset: 0x76CEE0 VA: 0x18076E8E0 Slot: 6
	public override void ToggleHighlight(bool highlighted, int playerIndex) { }

	// RVA: 0x76E630 Offset: 0x76CC30 VA: 0x18076E630
	public void CleanChapterData() { }

	// RVA: 0x76E8B0 Offset: 0x76CEB0 VA: 0x18076E8B0
	public void OnDestroy() { }

	// RVA: 0x53E050 Offset: 0x53C650 VA: 0x18053E050
	public void .ctor() { }
}
