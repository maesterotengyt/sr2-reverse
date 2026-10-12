// Namespace: 
public class MainMenuHeader : SRMonoBehaviour // TypeDefIndex: 3039
{
	// Fields
	[CompilerGenerated]
	private MainMenuHeader.TabOptionSelected OnHeaderOptionSelected; // 0x20
	public Animator Animator; // 0x28
	public TMP_Text PlayerNameText; // 0x30
	public GameObject LeftBumperIcon; // 0x38
	public GameObject RightBumperIcon; // 0x40
	public UINavigationElement PlayerListButton; // 0x48
	public Animator RewardsButtonAnimator; // 0x50
	public UINavigationElement RewardsButton; // 0x58
	public GameObject PlayerData; // 0x60
	public TMP_Text ExperiencePointsText; // 0x68
	public TMP_Text PlayerLevelText; // 0x70
	public GameObject TabsMenu; // 0x78
	public UINavigator TabsUINavigator; // 0x80
	public GameObject SectionGroup; // 0x88
	public List<TMP_Text> SectionLabels; // 0x90
	public GameObject ProfileTexts; // 0x98
	public Image PlayerIcon; // 0xA0
	public Image LevelBar; // 0xA8
	public Image ButtonIcon; // 0xB0
	public TMP_Text GamerTag; // 0xB8
	public UINavigator ProfileSubMenuNavigator; // 0xC0
	public OnlinePlayerList RecentPlayerList; // 0xC8
	public Animator ProfileSubMenuAnimator; // 0xD0
	public GameObject RewardsIndicator; // 0xD8
	public GameObject RewardsProfileIndicator; // 0xE0
	public TMP_Text RewardsIndicatorText; // 0xE8
	public TMP_Text RewardsProfileIndicatorText; // 0xF0
	public GameObject RayCastScreen; // 0xF8
	public UINavigationElement ProfileRecentPlayerOption; // 0x100
	public RectTransformAutoRebuild RectAutoRebuild; // 0x108
	public LocalizedString OnlineString; // 0x110
	public LocalizedString LocalString; // 0x118
	public LocalizedString PracticeString; // 0x120
	public LocalizedString ExtrasString; // 0x128
	public LocalizedString SettigsString; // 0x130
	public LocalizedString PointsShortString; // 0x138
	private bool visible; // 0x140
	private bool defaultTabOptionsEnabled; // 0x141
	private bool inputActive; // 0x142
	public bool ProfileEnabled; // 0x143
	private HashString currentIconID; // 0x148

	// Methods

	[CompilerGenerated]
	// RVA: 0x79F070 Offset: 0x79D670 VA: 0x18079F070
	public void add_OnHeaderOptionSelected(MainMenuHeader.TabOptionSelected value) { }

	[CompilerGenerated]
	// RVA: 0x79F110 Offset: 0x79D710 VA: 0x18079F110
	public void remove_OnHeaderOptionSelected(MainMenuHeader.TabOptionSelected value) { }

	// RVA: 0x79B320 Offset: 0x799920 VA: 0x18079B320
	public void Initialize() { }

	// RVA: 0x79DE80 Offset: 0x79C480 VA: 0x18079DE80
	public void Start() { }

	// RVA: 0x79C930 Offset: 0x79AF30 VA: 0x18079C930
	private void PhotomRoomInfoUpdate() { }

	// RVA: 0x79E4E0 Offset: 0x79CAE0 VA: 0x18079E4E0
	public void Update() { }

	// RVA: 0x79BD40 Offset: 0x79A340 VA: 0x18079BD40
	public void OpenPlayerProfileSubMenu() { }

	// RVA: 0x79AD20 Offset: 0x799320 VA: 0x18079AD20
	public void HidePlayerProfileSubMenu() { }

	[IteratorStateMachine(typeof(MainMenuHeader.<HideAndDeactiivate>d__50))]
	// RVA: 0x79ABE0 Offset: 0x7991E0 VA: 0x18079ABE0
	private IEnumerator HideAndDeactiivate(string stateName) { }

	// RVA: 0x79C5B0 Offset: 0x79ABB0 VA: 0x18079C5B0
	public void OpenRecentPlayersList() { }

	// RVA: 0x79B120 Offset: 0x799720 VA: 0x18079B120
	public void HideRecentPlayersList() { }

	// RVA: 0x79AC70 Offset: 0x799270 VA: 0x18079AC70
	public void HideOnlyRecentPlayersList() { }

	// RVA: 0x79C2D0 Offset: 0x79A8D0 VA: 0x18079C2D0
	public void OpenPlayerProfile() { }

	// RVA: 0x79C800 Offset: 0x79AE00 VA: 0x18079C800
	public void OpenRewardsPopUp() { }

	// RVA: 0x79CBA0 Offset: 0x79B1A0 VA: 0x18079CBA0
	public void RewardsNext() { }

	// RVA: 0x79E130 Offset: 0x79C730 VA: 0x18079E130
	public void ToggleRewardUnlockedPopup() { }

	// RVA: 0x79DD90 Offset: 0x79C390 VA: 0x18079DD90
	public void Show() { }

	// RVA: 0x79E4A0 Offset: 0x79CAA0 VA: 0x18079E4A0
	public void ToggleTabsInput(bool state, bool profileInputActive = True) { }

	// RVA: 0x79CAE0 Offset: 0x79B0E0 VA: 0x18079CAE0
	public void RestoreDefaultTabOptions() { }

	// RVA: 0x79A8C0 Offset: 0x798EC0 VA: 0x18079A8C0
	public void ApplyDefaultTabsTexts() { }

	// RVA: 0x79D7D0 Offset: 0x79BDD0 VA: 0x18079D7D0
	public void SetupCustomTabOptions(string[] newTabOptions) { }

	// RVA: 0x79E3D0 Offset: 0x79C9D0 VA: 0x18079E3D0
	public void ToggleTabOption(bool state, int tabIndex) { }

	// RVA: 0x79BAE0 Offset: 0x79A0E0 VA: 0x18079BAE0
	public void OnTabOptionSelected(int optionIndex) { }

	// RVA: 0x79D3E0 Offset: 0x79B9E0 VA: 0x18079D3E0
	public void SelectPracticeOption() { }

	// RVA: 0x79AB60 Offset: 0x799160 VA: 0x18079AB60
	public MainMenuHeaderTab GetHeaderTab(int tabIndex) { }

	// RVA: 0x79C9C0 Offset: 0x79AFC0 VA: 0x18079C9C0
	private void RefreshedButtonIcons() { }

	// RVA: 0x79D1A0 Offset: 0x79B7A0 VA: 0x18079D1A0
	public void SelectPlayOption() { }

	// RVA: 0x79CC50 Offset: 0x79B250 VA: 0x18079CC50
	public void SelectExtrasOption() { }

	// RVA: 0x79D590 Offset: 0x79BB90 VA: 0x18079D590
	public void SelectSettingsOption() { }

	// RVA: 0x79CF60 Offset: 0x79B560 VA: 0x18079CF60
	public void SelectLocalOption() { }

	// RVA: 0x79DB10 Offset: 0x79C110 VA: 0x18079DB10
	public void ShowTabsMenu() { }

	// RVA: 0x79D920 Offset: 0x79BF20 VA: 0x18079D920
	public void ShowSectionLabel(string sectionString) { }

	// RVA: 0x79E000 Offset: 0x79C600 VA: 0x18079E000
	public bool TabsActive() { }

	// RVA: 0x79CE90 Offset: 0x79B490 VA: 0x18079CE90
	public void SelectHubTab() { }

	// RVA: 0x79AB50 Offset: 0x799150 VA: 0x18079AB50
	public void EnableDefaultTabOptions() { }

	// RVA: 0x79B190 Offset: 0x799790 VA: 0x18079B190
	public void Hide() { }

	// RVA: 0x79B8C0 Offset: 0x799EC0 VA: 0x18079B8C0
	private void OnDestroy() { }

	// RVA: 0x79F060 Offset: 0x79D660 VA: 0x18079F060
	public void .ctor() { }
}
