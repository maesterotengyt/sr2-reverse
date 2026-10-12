// Namespace: 
public class SpeedRunnersMatchHUD : StellarGameModeHUD // TypeDefIndex: 2966
{
	// Fields
	public Animator MatchElementsAnimator; // 0x28
	public Animator CountdownAnimator; // 0x30
	public RectTransform CanvasRect; // 0x38
	public PauseMenu PauseMenu; // 0x40
	public EmotesManager EmotesManager; // 0x48
	public HUDIntroAnimation HUDIntroAnimation; // 0x50
	public HUDEndAnimation HUDEndAnimation; // 0x58
	public TutorialDialogueHUD DialogueHUD; // 0x60
	public GameObject RoundSpeechBubble; // 0x68
	public GameObject WinnerSpeechBubble; // 0x70
	public GameObject ChatPrompt; // 0x78
	public GameObject CharacterIndicatorsContainer; // 0x80
	public GameObject CharacterNameIndicatorsContainer; // 0x88
	public GameObject DangerIndicatorsContainer; // 0x90
	public BettingHUD BettingHUD; // 0x98
	public List<CharacterIndicator> CharacterIndicators; // 0xA0
	public List<CharacterNameIndicator> CharacterNameIndicators; // 0xA8
	public List<DangerIndicator> DangerIndicators; // 0xB0
	public GameObject DestroyBotsPrompt; // 0xB8
	protected bool isSpectator; // 0xC0
	protected bool onlyBotsAlive; // 0xC1
	protected Coroutine knockoutBots; // 0xC8
	[CompilerGenerated]
	private List<CharacterHUD> <ActiveCharacterHUDs>k__BackingField; // 0xD0
	private int activeCharacterHUDTransparencyUpdate; // 0xD8
	private const float playerRectanglesUpdateInterval = 0.05;
	private float playerRectanglesUpdateTimer; // 0xDC
	private List<Rect> playerRects; // 0xE0
	private const float transparencyUpdateInterval = 0.1;
	private float transparencyUpdateTimer; // 0xE8

	// Properties
	public List<CharacterHUD> ActiveCharacterHUDs { get; set; }
	protected DataManager dataManager { get; }
	protected SettingsManager settingsManager { get; }
	protected SaveManager saveManager { get; }
	protected OnlineManager onlineManager { get; }
	protected SimulationManager simulationManager { get; }
	protected UIManager uiManager { get; }
	protected GameStateManager gameStateManager { get; }
	protected MatchResourcesManager matchResourcesManager { get; }
	protected AudioManager audioManager { get; }
	protected SceneLoader sceneLoader { get; }
	protected GameModeManager gameModeManager { get; }
	protected FileLoadingManager fileLoadingManager { get; }
	protected StellarSimulationSystem stellarSimulationSystem { get; }
	protected StellarCameraSystem stellarCameraSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6230C0 Offset: 0x6216C0 VA: 0x1806230C0
	public List<CharacterHUD> get_ActiveCharacterHUDs() { }

	[CompilerGenerated]
	// RVA: 0x6230D0 Offset: 0x6216D0 VA: 0x1806230D0
	public void set_ActiveCharacterHUDs(List<CharacterHUD> value) { }

	// RVA: 0x7826F0 Offset: 0x780CF0 VA: 0x1807826F0
	protected DataManager get_dataManager() { }

	// RVA: 0x782970 Offset: 0x780F70 VA: 0x180782970
	protected SettingsManager get_settingsManager() { }

	// RVA: 0x7828D0 Offset: 0x780ED0 VA: 0x1807828D0
	protected SaveManager get_saveManager() { }

	// RVA: 0x782880 Offset: 0x780E80 VA: 0x180782880
	protected OnlineManager get_onlineManager() { }

	// RVA: 0x7829C0 Offset: 0x780FC0 VA: 0x1807829C0
	protected SimulationManager get_simulationManager() { }

	// RVA: 0x782AB0 Offset: 0x7810B0 VA: 0x180782AB0
	protected UIManager get_uiManager() { }

	// RVA: 0x7827E0 Offset: 0x780DE0 VA: 0x1807827E0
	protected GameStateManager get_gameStateManager() { }

	// RVA: 0x782830 Offset: 0x780E30 VA: 0x180782830
	protected MatchResourcesManager get_matchResourcesManager() { }

	// RVA: 0x7826A0 Offset: 0x780CA0 VA: 0x1807826A0
	protected AudioManager get_audioManager() { }

	// RVA: 0x782920 Offset: 0x780F20 VA: 0x180782920
	protected SceneLoader get_sceneLoader() { }

	// RVA: 0x782790 Offset: 0x780D90 VA: 0x180782790
	protected GameModeManager get_gameModeManager() { }

	// RVA: 0x782740 Offset: 0x780D40 VA: 0x180782740
	protected FileLoadingManager get_fileLoadingManager() { }

	// RVA: 0x782480 Offset: 0x780A80 VA: 0x180782480
	public void ToggleMatchElementsVisibility(Animator animator, bool state, bool immediate = False) { }

	// RVA: 0x77E730 Offset: 0x77CD30 VA: 0x18077E730
	protected int GetTotalPlayersInMatch() { }

	// RVA: 0x780800 Offset: 0x77EE00 VA: 0x180780800 Slot: 8
	protected virtual void OnMatchStart(EventMatchStarted callback) { }

	// RVA: 0x780490 Offset: 0x77EA90 VA: 0x180780490 Slot: 9
	protected virtual void OnCountdownFinished(EventCountdownFinished callback) { }

	// RVA: 0x77F130 Offset: 0x77D730 VA: 0x18077F130 Slot: 4
	public override void Initialize() { }

	// RVA: 0x782A60 Offset: 0x781060 VA: 0x180782A60
	protected StellarSimulationSystem get_stellarSimulationSystem() { }

	// RVA: 0x782A10 Offset: 0x781010 VA: 0x180782A10
	protected StellarCameraSystem get_stellarCameraSystem() { }

	// RVA: 0x780DE0 Offset: 0x77F3E0 VA: 0x180780DE0 Slot: 7
	protected override void OnUpdate() { }

	// RVA: 0x7815E0 Offset: 0x77FBE0 VA: 0x1807815E0 Slot: 5
	public override void Reload() { }

	// RVA: 0x780AF0 Offset: 0x77F0F0 VA: 0x180780AF0 Slot: 10
	public virtual void OnRestart() { }

	// RVA: 0x780790 Offset: 0x77ED90 VA: 0x180780790 Slot: 11
	public virtual void OnExit() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 12
	protected virtual void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x77E910 Offset: 0x77CF10 VA: 0x18077E910
	public void InitializeCharacterIndicator(StellarCharacterData characterData) { }

	// RVA: 0x780130 Offset: 0x77E730 VA: 0x180780130 Slot: 13
	protected virtual void OnCharacterKnockOut(EventOnCharacterKnockOut callback) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 14
	protected virtual void PlayerLeftDuringMatch(List<StellarCharacterData> characters) { }

	// RVA: 0x77FE90 Offset: 0x77E490 VA: 0x18077FE90 Slot: 15
	protected virtual void MatchStart(EventShowIntroAnimation callback) { }

	// RVA: 0x781B10 Offset: 0x780110 VA: 0x180781B10 Slot: 16
	public virtual void ShowDialogue(EventShowDialogue callback) { }

	// RVA: 0x780B70 Offset: 0x77F170 VA: 0x180780B70 Slot: 17
	public virtual void OnShowRaceRoundEndMessage(EventShowRaceRoundEndMessage callback) { }

	// RVA: 0x782090 Offset: 0x780690 VA: 0x180782090 Slot: 18
	public virtual void ShowRaceRoundEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x781BB0 Offset: 0x7801B0 VA: 0x180781BB0 Slot: 19
	public virtual void ShowRaceEndMessage(EntityRef winnerEntity, int roundsWon, int totalStars = 3) { }

	// RVA: 0x780890 Offset: 0x77EE90 VA: 0x180780890 Slot: 20
	protected virtual void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x77CCC0 Offset: 0x77B2C0 VA: 0x18077CCC0 Slot: 21
	protected virtual void OnRaceRoundStart(EventRoundStart callback) { }

	// RVA: 0x77E430 Offset: 0x77CA30 VA: 0x18077E430
	public CharacterHUD GetCharacterHUDByNickname(string playerNickname) { }

	// RVA: 0x77E5D0 Offset: 0x77CBD0 VA: 0x18077E5D0
	public CharacterHUD GetCharacterHUD(EntityRef entity) { }

	// RVA: 0x782540 Offset: 0x780B40 VA: 0x180782540
	protected void TurnOffWinnings(CharacterHUD hud) { }

	[IteratorStateMachine(typeof(SpeedRunnersMatchHUD.<AllowKnockOut>d__83))]
	// RVA: 0x77E300 Offset: 0x77C900 VA: 0x18077E300
	protected IEnumerator AllowKnockOut() { }

	// RVA: 0x77E370 Offset: 0x77C970 VA: 0x18077E370
	protected void DisableBotsKnockOut() { }

	// RVA: 0x780510 Offset: 0x77EB10 VA: 0x180780510 Slot: 22
	protected virtual void OnDestroy() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 23
	public virtual void OnResultsScreen() { }

	// RVA: 0x77E830 Offset: 0x77CE30 VA: 0x18077E830
	public bool GetVisibilityState() { }

	// RVA: 0x781A40 Offset: 0x780040 VA: 0x180781A40
	public void SetVisibility(bool visibilityState) { }

	// RVA: 0x780880 Offset: 0x77EE80 VA: 0x180780880 Slot: 6
	protected override void OnPlayersInputEnabled(EventOnPlayersInputEnabled callback) { }

	// RVA: 0x782600 Offset: 0x780C00 VA: 0x180782600
	public void .ctor() { }
}
