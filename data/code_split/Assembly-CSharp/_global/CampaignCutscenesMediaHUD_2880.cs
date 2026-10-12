// Namespace: 
public class CampaignCutscenesMediaHUD : MainMenuScreen // TypeDefIndex: 2880
{
	// Fields
	public Animator PanelAnimator; // 0x90
	public Animator ScreenTextAnimator; // 0x98
	public TMP_Text ScreenText; // 0xA0
	public TMP_Text ActTitleText; // 0xA8
	public Image Background1; // 0xB0
	public Image Background2; // 0xB8
	public CutsceneCharacterTextBox DialogueBox; // 0xC0
	public CampaignCutscenesData data; // 0xC8
	public PauseHoldBar CancelHoldBar; // 0xD0
	public RectTransform SwipeOutPositionLeft; // 0xD8
	public CampaignData CampaignData; // 0xE0
	private bool IsStartCutsceneActive; // 0xE8
	private bool IsEndCutsceneActive; // 0xE9
	private CampaignCutscene currentCutscene; // 0xF0
	private int currentPanelIndex; // 0xF8
	private int currentDialogueIndex; // 0xFC
	private bool isShowingLastPanel; // 0x100
	private bool isShowingLastDialogue; // 0x101
	public PauseMenu PauseMenu; // 0x108
	private Dictionary<object, CampaignCutscenesMediaHUD.SpriteAssetInfo> spritePool; // 0x110
	private bool isBackground1; // 0x118
	private bool inFade; // 0x119
	private bool onActStart; // 0x11A
	private bool fromCutscene; // 0x11B
	private bool playedScreenText; // 0x11C
	private float noDialogueTimer; // 0x120
	private const float NO_DIALOGUE_DELAY = 1;
	private bool LoadingSprites; // 0x124

	// Properties
	private DataManager dataManager { get; }
	protected SceneLoader sceneLoader { get; }
	protected AudioManager audioManager { get; }
	protected MainMenu mainMenu { get; }

	// Methods

	// RVA: 0x748160 Offset: 0x746760 VA: 0x180748160
	private DataManager get_dataManager() { }

	// RVA: 0x748210 Offset: 0x746810 VA: 0x180748210
	protected SceneLoader get_sceneLoader() { }

	// RVA: 0x748110 Offset: 0x746710 VA: 0x180748110
	protected AudioManager get_audioManager() { }

	// RVA: 0x7481B0 Offset: 0x7467B0 VA: 0x1807481B0
	protected MainMenu get_mainMenu() { }

	// RVA: 0x7478A0 Offset: 0x745EA0 VA: 0x1807478A0 Slot: 7
	public override void Show() { }

	// RVA: 0x746FA0 Offset: 0x7455A0 VA: 0x180746FA0
	public void FadeSwipe(Image Image, float fadeSpeed) { }

	// RVA: 0x7470A0 Offset: 0x7456A0 VA: 0x1807470A0
	public void FadeSwipe(TMP_Text Text, float fadeSpeed) { }

	// RVA: 0x7469B0 Offset: 0x744FB0 VA: 0x1807469B0
	public void FadeAlpha(Image Image, float fadeSpeed, float targetAlpha) { }

	// RVA: 0x7469B0 Offset: 0x744FB0 VA: 0x1807469B0
	public void FadeAlpha(TMP_Text Text, float fadeSpeed, float targetAlpha) { }

	// RVA: 0x746AE0 Offset: 0x7450E0 VA: 0x180746AE0
	public void FadeBlack(Image Image, float fadeSpeed) { }

	// RVA: 0x746AE0 Offset: 0x7450E0 VA: 0x180746AE0
	public void FadeBlack(TMP_Text Text, float fadeSpeed) { }

	// RVA: 0x746D90 Offset: 0x745390 VA: 0x180746D90
	public void FadeFromBlack(Image Image, float fadeSpeed) { }

	// RVA: 0x746D90 Offset: 0x745390 VA: 0x180746D90
	public void FadeFromBlack(TMP_Text Text, float fadeSpeed) { }

	// RVA: 0x747830 Offset: 0x745E30 VA: 0x180747830
	public void SetInvisible(Image image) { }

	// RVA: 0x747830 Offset: 0x745E30 VA: 0x180747830
	public void SetInvisible(TMP_Text Text) { }

	[IteratorStateMachine(typeof(CampaignCutscenesMediaHUD.<FadeCutscene>d__47))]
	// RVA: 0x746D00 Offset: 0x745300 VA: 0x180746D00
	private IEnumerator FadeCutscene(Image Previous, Image Next) { }

	[IteratorStateMachine(typeof(CampaignCutscenesMediaHUD.<AnimateScreenText>d__48))]
	// RVA: 0x7450B0 Offset: 0x7436B0 VA: 0x1807450B0
	private IEnumerator AnimateScreenText(float TimeUp) { }

	// RVA: 0x747980 Offset: 0x745F80 VA: 0x180747980 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x7453C0 Offset: 0x7439C0 VA: 0x1807453C0
	public Sprite DisplayLoadedSprite(AssetReference targetReference) { }

	[IteratorStateMachine(typeof(CampaignCutscenesMediaHUD.<LoadSprites>d__51))]
	// RVA: 0x747370 Offset: 0x745970 VA: 0x180747370
	private IEnumerator LoadSprites() { }

	// RVA: 0x747470 Offset: 0x745A70 VA: 0x180747470
	public void PlayCutscene() { }

	// RVA: 0x745130 Offset: 0x743730 VA: 0x180745130
	public void ClearLoadedSprites() { }

	[IteratorStateMachine(typeof(CampaignCutscenesMediaHUD.<DelayClearSprites>d__54))]
	// RVA: 0x745350 Offset: 0x743950 VA: 0x180745350
	private IEnumerator DelayClearSprites() { }

	// RVA: 0x745460 Offset: 0x743A60 VA: 0x180745460
	private void EndCutscene() { }

	[IteratorStateMachine(typeof(CampaignCutscenesMediaHUD.<PlayCutsceneWithDelay>d__56))]
	// RVA: 0x7473F0 Offset: 0x7459F0 VA: 0x1807473F0
	private IEnumerator PlayCutsceneWithDelay(float delay) { }

	// RVA: 0x7471A0 Offset: 0x7457A0 VA: 0x1807471A0
	public CampaignCutscene GetCutsecene(HashString cutsceneID, bool isStart) { }

	// RVA: 0x7473E0 Offset: 0x7459E0 VA: 0x1807473E0
	public void OnDestroy() { }

	// RVA: 0x748090 Offset: 0x746690 VA: 0x180748090
	public void .ctor() { }
}
