// Namespace: 
public class LevelUpScreen : SRMonoBehaviour // TypeDefIndex: 3248
{
	// Fields
	public ResultScreen ResultScreen; // 0x20
	public Animator Animator; // 0x28
	public TMP_Text ExperienceGained; // 0x30
	public TMP_Text ExperienceGainedShadow; // 0x38
	public TMP_Text Timer; // 0x40
	public TMP_Text RewardsCountText; // 0x48
	public GameObject TimerSegment; // 0x50
	public GameObject Arrows; // 0x58
	public GameObject RewardsButton; // 0x60
	public GameObject RestartButton; // 0x68
	public RewardUnlockedPopup RewardUnlockedPopup; // 0x70
	public TMP_Text RankGained; // 0x78
	public TMP_Text PointsText; // 0x80
	public LevelUpExperienceBar PlayerLevelBar; // 0x88
	public LevelUpExperienceBar CharacterLevelBar; // 0x90
	public Transform CharacterSpot; // 0x98
	public CanvasGroup ProfileTexts; // 0xA0
	public RectTransformAutoRebuild HeaderTexts; // 0xA8
	public float TimerDuration; // 0xB0
	[Header("Ranked")]
	public GameObject RankedData; // 0xB8
	public TMP_Text LeagueName; // 0xC0
	public Image RankImage; // 0xC8
	public Image NewRatingMeter; // 0xD0
	public Image RatingMeter; // 0xD8
	public RankUpPopup RankUpPopup; // 0xE0
	[Header("Events")]
	public TMP_Text EventTitle; // 0xE8
	public TMP_Text EventDescription; // 0xF0
	public TMP_Text EventValue; // 0xF8
	public List<ExperienceEventButton> ExperienceEventButtons; // 0x100
	public UINavigator EventNavigation; // 0x108
	public GameObject ScrollArrows; // 0x110
	public RectTransformAutoRebuild Rebuild; // 0x118
	public Camera GestureCamera; // 0x120
	public LocalizedString GainedExperienceString; // 0x128
	public LocalizedString ExperienceFormat; // 0x130
	public LocalizedString RankFormat; // 0x138
	public LocalizedString Skip; // 0x140
	public LocalizedString Continue; // 0x148
	private bool rankGained; // 0x150
	private bool screenActive; // 0x151
	private bool startTimer; // 0x152
	private int bonusCheatExperience; // 0x154
	private GameContext previousContext; // 0x158
	private bool goingToMainMenu; // 0x15C
	private Transform basicCharacter; // 0x160

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void Awake() { }

	// RVA: 0x59D2B0 Offset: 0x59B8B0 VA: 0x18059D2B0
	public void Show() { }

	// RVA: 0x59CF80 Offset: 0x59B580 VA: 0x18059CF80
	public void SetLocalPlayerCharacter() { }

	// RVA: 0x59F0F0 Offset: 0x59D6F0 VA: 0x18059F0F0
	public void UpdateScreen() { }

	// RVA: 0x59C720 Offset: 0x59AD20 VA: 0x18059C720
	public void Next() { }

	// RVA: 0x59E9F0 Offset: 0x59CFF0 VA: 0x18059E9F0
	public void ToggleRankUpPopup() { }

	// RVA: 0x59C550 Offset: 0x59AB50 VA: 0x18059C550
	private void CharacterRenderLoaded(string operationID, Sprite sprite) { }

	// RVA: 0x59EBE0 Offset: 0x59D1E0 VA: 0x18059EBE0
	private void UpdateRankData() { }

	// RVA: 0x59CD60 Offset: 0x59B360 VA: 0x18059CD60
	public void PreviewEvent(ExperienceData eventData, int count) { }

	// RVA: 0x59C6D0 Offset: 0x59ACD0 VA: 0x18059C6D0
	private void GoToMainMenu(bool closeSimulation = False) { }

	// RVA: 0x59CEA0 Offset: 0x59B4A0 VA: 0x18059CEA0
	public void RestartOfflineLevel() { }

	// RVA: 0x59F580 Offset: 0x59DB80 VA: 0x18059F580
	public void .ctor() { }
}
