// Namespace: 
public class WinnerScreen : SRMonoBehaviour // TypeDefIndex: 3255
{
	// Fields
	public bool Enabled; // 0x20
	public ResultScreen ResultScreen; // 0x28
	public Transform WinnerCharacterSpot; // 0x30
	public GameObject WinnerUsernameGameObject; // 0x38
	public GameObject BestTimeObject; // 0x40
	public TMP_Text WinnerUsernameText; // 0x48
	public TMP_Text WinnerShadowText; // 0x50
	public TMP_Text BestTimeText; // 0x58
	public TMP_Text LastChapterTimeText; // 0x60
	public Image ChapterRankImage; // 0x68
	public OnlineBadgeElement OnlineBadge; // 0x70
	public LocalizedString ContinueString; // 0x78
	public LocalizedString EmotesString; // 0x80
	public Animator Animator; // 0x88
	public Animator BestTimeResultAnimator; // 0x90
	public Animator FooterAnimator; // 0x98
	public float TimerDuration; // 0xA0
	public Camera WinnerGestureCamera; // 0xA8
	public TextMeshProUGUI GameModeText; // 0xB0
	public BadgePlatformIcon BadgePlatformIcon; // 0xB8
	public RectTransformAutoRebuild VictoryLabelGroup; // 0xC0
	[Header("Strings")]
	public LocalizedString LocalVersusString; // 0xC8
	public LocalizedString QuickString; // 0xD0
	public LocalizedString RankedString; // 0xD8
	public LocalizedString Ranked1v1String; // 0xE0
	public LocalizedString CustomString; // 0xE8
	public LocalizedString EightPlayersString; // 0xF0
	public LocalizedString PlaygroundString; // 0xF8
	private bool startTimer; // 0x100
	private bool triggeredExitResults; // 0x101

	// Properties
	private CampaignManager campaignManager { get; }

	// Methods

	// RVA: 0x5ABA40 Offset: 0x5AA040 VA: 0x1805ABA40
	private CampaignManager get_campaignManager() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void Awake() { }

	// RVA: 0x5AA670 Offset: 0x5A8C70 VA: 0x1805AA670
	public void Show() { }

	// RVA: 0x5A9F70 Offset: 0x5A8570 VA: 0x1805A9F70
	public bool ShowBestTimeResult() { }

	// RVA: 0x5AB730 Offset: 0x5A9D30 VA: 0x1805AB730
	public void UpdateScreen() { }

	[IteratorStateMachine(typeof(WinnerScreen.<ExitResults>d__36))]
	// RVA: 0x5A9D60 Offset: 0x5A8360 VA: 0x1805A9D60
	private IEnumerator ExitResults() { }

	// RVA: 0x5A9DD0 Offset: 0x5A83D0 VA: 0x1805A9DD0
	public void GetPersistentCharacters() { }

	// RVA: 0x5ABA20 Offset: 0x5AA020 VA: 0x1805ABA20
	public void .ctor() { }
}
