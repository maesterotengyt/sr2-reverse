// Namespace: 
public class PlayerProfileMenu : MainMenuScreen // TypeDefIndex: 3159
{
	// Fields
	public CustomizationSubScreen CustomizationSubScreen; // 0x90
	public PlayerProfileElement CharacterRenderSegment; // 0x98
	public Image CharacterRender; // 0xA0
	public PlayerProfileElement StatSegment; // 0xA8
	public PlayerProfileElement CustomizationSegment; // 0xB0
	public RectTransformAutoRebuild AutoRebuild; // 0xB8
	[Header("Online Banner")]
	public OnlineBadgeElement OnlineBadgeElement; // 0xC0
	public TMP_Text CurrentLevelText; // 0xC8
	public TMP_Text ExperiencePointsText; // 0xD0
	public Image LevelBar; // 0xD8
	[Header("Player Stats")]
	public TMP_Text MatchesWonText; // 0xE0
	public TMP_Text RankedWonText; // 0xE8
	public Image CurrentRankIcon; // 0xF0
	public Image MaxRankIcon; // 0xF8
	public TMP_Text MostUsedCharacterText; // 0x100
	public LocalizedString MatchString; // 0x108
	public LocalizedString MatchesString; // 0x110
	public LocalizedString OverviewString; // 0x118
	public LocalizedString CustomizationString; // 0x120

	// Properties
	private OnlineManager onlineManager { get; }
	private SaveManager saveManager { get; }
	private DataManager dataManager { get; }
	private UIManager uiManager { get; }
	private FileLoadingManager fileLoadingManager { get; }
	private ProgressionManager progressionManager { get; }

	// Methods

	// RVA: 0x57B5D0 Offset: 0x579BD0 VA: 0x18057B5D0
	private OnlineManager get_onlineManager() { }

	// RVA: 0x57B670 Offset: 0x579C70 VA: 0x18057B670
	private SaveManager get_saveManager() { }

	// RVA: 0x57B530 Offset: 0x579B30 VA: 0x18057B530
	private DataManager get_dataManager() { }

	// RVA: 0x57B6C0 Offset: 0x579CC0 VA: 0x18057B6C0
	private UIManager get_uiManager() { }

	// RVA: 0x57B580 Offset: 0x579B80 VA: 0x18057B580
	private FileLoadingManager get_fileLoadingManager() { }

	// RVA: 0x57B620 Offset: 0x579C20 VA: 0x18057B620
	private ProgressionManager get_progressionManager() { }

	// RVA: 0x57A590 Offset: 0x578B90 VA: 0x18057A590 Slot: 7
	public override void Show() { }

	// RVA: 0x57A370 Offset: 0x578970 VA: 0x18057A370
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x579CB0 Offset: 0x5782B0 VA: 0x180579CB0
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x57B330 Offset: 0x579930 VA: 0x18057B330 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x57A110 Offset: 0x578710 VA: 0x18057A110
	public void OnTabOptionSelected(int option) { }

	// RVA: 0x579E20 Offset: 0x578420 VA: 0x180579E20 Slot: 8
	public override void Hide() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
