// Namespace: 
public class EmotesManager : SRMonoBehaviour // TypeDefIndex: 2933
{
	// Fields
	public GameObject BottomPromptsContainer; // 0x20
	public Image Background; // 0x28
	[Header("UI References")]
	public StellarUIAnimator EmotesPreviewAnimator; // 0x30
	public GameObject FloatingEmotesContainer; // 0x38
	public GameObject RunnerEmotesContainer; // 0x40
	public GameObject AnalogStickBackground; // 0x48
	public GameObject AnalogStick; // 0x50
	public RegularPauseMenu PauseMenu; // 0x58
	public RectTransform MatchHUDRect; // 0x60
	[Header("Emote Lists")]
	public List<GameplayEmote> PreviewEmotes; // 0x68
	public List<GameplayEmote> FloatingEmotes; // 0x70
	public List<GameplayEmote> RunnerEmotes; // 0x78
	public List<float> EmotesCooldownList; // 0x80
	public List<string> EmotePreviewAnimationList; // 0x88
	[Header("Emote General Settings")]
	public float EmoteTransitionDelay; // 0x90
	public float TimeToHidePreview; // 0x94
	public float EmoteVisibleTime; // 0x98
	public float EmotePositionMargin; // 0x9C
	[Header("Emote Stick Settings")]
	[Range(0, 1)]
	public float EmoteStickTolerance; // 0xA0
	[Range(0, 1)]
	public float EmoteStickHighThreshold; // 0xA4
	[Range(0, 1)]
	public float EmoteStickDiagonalMinThreshold; // 0xA8
	[Header("Floating Emotes Settings")]
	[Range(0, 0.5)]
	public float EmotesHorizontalMargin; // 0xAC
	[Range(0, 1)]
	public float EmotesVerticalPosition; // 0xB0
	[CompilerGenerated]
	private StellarCharacterData <LocalCharacterData>k__BackingField; // 0xB8
	[CompilerGenerated]
	private List<StellarCharacterData> <CharactersDataList>k__BackingField; // 0x238
	private StellarPlayer localPlayer; // 0x240
	private Coroutine hideWithDelayCoroutine; // 0x248
	private DispatcherSubscription knockoutEventSubscription; // 0x250
	private DispatcherSubscription resetRoundEventSubscription; // 0x258
	private DispatcherSubscription startRoundEventSubscription; // 0x260
	private SpeedRunnersMatchHUD speedRunnersMatchHUD; // 0x268
	private bool isLocalPlayerKO; // 0x270
	private bool isSpectating; // 0x271
	private bool startingRound; // 0x272
	private DispatcherSubscription pickUpItemEvent; // 0x274

	// Properties
	public StellarCharacterData LocalCharacterData { get; set; }
	public List<StellarCharacterData> CharactersDataList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x761070 Offset: 0x75F670 VA: 0x180761070
	public StellarCharacterData get_LocalCharacterData() { }

	[CompilerGenerated]
	// RVA: 0x761100 Offset: 0x75F700 VA: 0x180761100
	public void set_LocalCharacterData(StellarCharacterData value) { }

	[CompilerGenerated]
	// RVA: 0x761060 Offset: 0x75F660 VA: 0x180761060
	public List<StellarCharacterData> get_CharactersDataList() { }

	[CompilerGenerated]
	// RVA: 0x7610E0 Offset: 0x75F6E0 VA: 0x1807610E0
	public void set_CharactersDataList(List<StellarCharacterData> value) { }

	// RVA: 0x75F580 Offset: 0x75DB80 VA: 0x18075F580
	public void Initialize(SpeedRunnersMatchHUD MatchHUD) { }

	// RVA: 0x760D90 Offset: 0x75F390 VA: 0x180760D90
	private void Update() { }

	// RVA: 0x760510 Offset: 0x75EB10 VA: 0x180760510
	public void ResetEmotesForGameplay() { }

	// RVA: 0x75CC50 Offset: 0x75B250 VA: 0x18075CC50
	public void AddToCharacterDataList(StellarCharacterData characterData) { }

	// RVA: 0x760C50 Offset: 0x75F250 VA: 0x180760C50
	private void UpdatePromptsVisibility() { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0
	private bool IsLocalPlayerSingleJoyCon() { }

	// RVA: 0x75FC20 Offset: 0x75E220 VA: 0x18075FC20
	public void NotifyRaceRoundStart(EventRoundStart callback) { }

	[IteratorStateMachine(typeof(EmotesManager.<StartingRoundTimer>d__48))]
	// RVA: 0x760BE0 Offset: 0x75F1E0 VA: 0x180760BE0
	public IEnumerator StartingRoundTimer() { }

	// RVA: 0x75CE90 Offset: 0x75B490 VA: 0x18075CE90
	public void CheckForEmoteInput(StellarPlayer player) { }

	// RVA: 0x7609B0 Offset: 0x75EFB0 VA: 0x1807609B0
	private void ShowPreviewEmotes() { }

	// RVA: 0x75EE30 Offset: 0x75D430 VA: 0x18075EE30
	private void HidePreviewEmotes() { }

	// RVA: 0x760620 Offset: 0x75EC20 VA: 0x180760620
	private void SendEmote(string playerNickname, int emoteIndex, int playerIndex) { }

	// RVA: 0x75FEE0 Offset: 0x75E4E0 VA: 0x18075FEE0
	private void OnPickupItem(EventOnPickupItem callback) { }

	// RVA: 0x75FAC0 Offset: 0x75E0C0 VA: 0x18075FAC0
	private bool IsEmoteOnCooldown(int playerIndex) { }

	[IteratorStateMachine(typeof(EmotesManager.<HidePreviewWithDelay>d__55))]
	// RVA: 0x75F020 Offset: 0x75D620 VA: 0x18075F020
	private IEnumerator HidePreviewWithDelay(float time) { }

	// RVA: 0x75EF60 Offset: 0x75D560 VA: 0x18075EF60
	public void HidePreviewInmediate() { }

	// RVA: 0x75F0A0 Offset: 0x75D6A0 VA: 0x18075F0A0
	public void InitializePreviewEmotes() { }

	// RVA: 0x75F460 Offset: 0x75DA60 VA: 0x18075F460
	public void InitializeRunnerEmotes() { }

	// RVA: 0x760870 Offset: 0x75EE70 VA: 0x180760870
	public void SetEmoteButtonIconVisibility(bool visible) { }

	// RVA: 0x75EDE0 Offset: 0x75D3E0 VA: 0x18075EDE0
	private void HandleOnlineEmoteSent(PlayerEmoteMessage emoteMessage) { }

	// RVA: 0x760440 Offset: 0x75EA40 VA: 0x180760440
	private void ProcessEmote(string playerNickname, string emoteID) { }

	// RVA: 0x75E1F0 Offset: 0x75C7F0 VA: 0x18075E1F0
	private void DisplayWinnerScreenEmote(string playerNickname, string emoteID) { }

	// RVA: 0x75D750 Offset: 0x75BD50 VA: 0x18075D750
	private void DisplayAlivePlayerEmote(string playerNickname, string emoteID) { }

	// RVA: 0x75DFA0 Offset: 0x75C5A0 VA: 0x18075DFA0
	private void DisplayKOPlayerEmote(string playerNickname, string emoteID) { }

	// RVA: 0x75ECA0 Offset: 0x75D2A0 VA: 0x18075ECA0
	private Vector2 GetRandomEdgePosition() { }

	// RVA: 0x75FB30 Offset: 0x75E130 VA: 0x18075FB30
	private bool IsPlayerAlive(EntityRef entity) { }

	// RVA: 0x75FCA0 Offset: 0x75E2A0 VA: 0x18075FCA0
	public void OnCharacterKnockout(EventCharacterKnockout callback) { }

	// RVA: 0x760430 Offset: 0x75EA30 VA: 0x180760430
	private void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x75E9D0 Offset: 0x75CFD0 VA: 0x18075E9D0
	private EntityRef GetCharacterEntityRefByNickname(string nickname) { }

	// RVA: 0x760550 Offset: 0x75EB50 VA: 0x180760550
	private void SendEmoteMessage(string playerNickname, string emoteID) { }

	// RVA: 0x760810 Offset: 0x75EE10 VA: 0x180760810
	private void SendLocalEmote(string playerNickname, string emoteID) { }

	// RVA: 0x75FD40 Offset: 0x75E340 VA: 0x18075FD40
	public void OnDestroy() { }

	// RVA: 0x760F80 Offset: 0x75F580 VA: 0x180760F80
	public void .ctor() { }
}
