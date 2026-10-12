// Namespace: 
public class CharacterHUD : SRMonoBehaviour // TypeDefIndex: 2894
{
	// Fields
	public List<CharacterHUD.CharacterColorData> ColorsData; // 0x20
	public TMP_Text NicknameText; // 0x28
	public TMP_Text NicknameShadowText; // 0x30
	public Image Background; // 0x38
	public Image CharacterIcon; // 0x40
	public Image CharacterIconShadow; // 0x48
	public RectTransform RectTransform; // 0x50
	public CanvasGroup CanvasGroup; // 0x58
	public CharacterBoostBar BoostBar; // 0x60
	public CharacterItemHUD ItemsHUD; // 0x68
	public GameplayEmote Emote; // 0x70
	public StellarUIAnimator EmoteAnimator; // 0x78
	public List<CharacterHUDMedalSlot> Medals; // 0x80
	public GameObject ScreenStatic; // 0x88
	public GameObject Highlight; // 0x90
	public BadgePlatformIcon BadgePlatformIcon; // 0x98
	[Range(0, 1)]
	public float TransparencyLevel; // 0xA0
	public Color CharacterIconKOColor; // 0xA4
	[Header("Game Mode Specific Containers")]
	public GameObject WinsContainer; // 0xB8
	public GameObject ItemContainer; // 0xC0
	public GameObject CollectorsScoreContainer; // 0xC8
	[Header("Collectors")]
	public TextMeshProUGUI CollectorScoreText; // 0xD0
	public Animator CollectorScoreAnimator; // 0xD8
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0xE0
	[CompilerGenerated]
	private StellarCharacter <Character>k__BackingField; // 0xE8
	private ItemBubbleHUD itemBubbleHUD; // 0x188
	private DispatcherSubscription boostEvent; // 0x190
	private float targetAlpha; // 0x198

	// Properties
	public bool Initialized { get; set; }
	public StellarCharacter Character { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x74F640 Offset: 0x74DC40 VA: 0x18074F640
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x74F6D0 Offset: 0x74DCD0 VA: 0x18074F6D0
	public void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x74F5C0 Offset: 0x74DBC0 VA: 0x18074F5C0
	public StellarCharacter get_Character() { }

	[CompilerGenerated]
	// RVA: 0x74F650 Offset: 0x74DC50 VA: 0x18074F650
	public void set_Character(StellarCharacter value) { }

	// RVA: 0x74DFB0 Offset: 0x74C5B0 VA: 0x18074DFB0
	public void Initialize(StellarCharacterData characterData) { }

	// RVA: 0x74F170 Offset: 0x74D770 VA: 0x18074F170
	private void SetupGameModeVisuals() { }

	// RVA: 0x74DC30 Offset: 0x74C230 VA: 0x18074DC30
	public void CalculateTransparency(List<Rect> playerRects) { }

	// RVA: 0x74DB70 Offset: 0x74C170 VA: 0x18074DB70
	public void AnimateTransparency() { }

	// RVA: 0x74EDE0 Offset: 0x74D3E0 VA: 0x18074EDE0
	private void OnCollectorScoreUpdate(EventOnCollectorScoreUpdate callback) { }

	// RVA: 0x74ECD0 Offset: 0x74D2D0 VA: 0x18074ECD0
	private void OnCharacterBoostUpdated(EventCharacterBoostUpdated callback) { }

	// RVA: 0x74EF20 Offset: 0x74D520 VA: 0x18074EF20
	public void SetRoundsWon(int rounds) { }

	// RVA: 0x74DE70 Offset: 0x74C470 VA: 0x18074DE70
	public void DisableHUD() { }

	// RVA: 0x74ED50 Offset: 0x74D350 VA: 0x18074ED50
	private void OnCharacterKnockOut(EventOnCharacterKnockOut callback) { }

	// RVA: 0x74EEC0 Offset: 0x74D4C0 VA: 0x18074EEC0
	private void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x74EEC0 Offset: 0x74D4C0 VA: 0x18074EEC0
	public void ResetVisuals() { }

	// RVA: 0x74DF00 Offset: 0x74C500 VA: 0x18074DF00
	public CharacterHUD.CharacterColorData GetColorData(int spawnOrder) { }

	// RVA: 0x74F570 Offset: 0x74DB70 VA: 0x18074F570
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x74F370 Offset: 0x74D970 VA: 0x18074F370
	private void <Initialize>b__34_0(AsyncOperationHandle handle) { }

	[CompilerGenerated]
	// RVA: 0x74F400 Offset: 0x74DA00 VA: 0x18074F400
	private void <Initialize>b__34_1(AsyncOperationHandle handle) { }
}
