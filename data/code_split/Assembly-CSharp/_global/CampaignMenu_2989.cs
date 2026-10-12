// Namespace: 
public class CampaignMenu : MainMenuScreen // TypeDefIndex: 2989
{
	// Fields
	public UINavigator Navigator; // 0x90
	public UINavigator ChapterNavigator; // 0x98
	public Animator PanelAnimator; // 0xA0
	public Animator DifficultyContainerAnimator; // 0xA8
	public Animator DifficultyTooltipAnimator; // 0xB0
	public MenuPlayersHighlight PlayerHighlights; // 0xB8
	public ScreenFooterButton LeftButton; // 0xC0
	public ScreenFooterButton RightButton; // 0xC8
	public GameObject ChapterPanel; // 0xD0
	public Image SelectedActImage; // 0xD8
	public Image HoveredChapterImage; // 0xE0
	public GameObject LockedChapterObject; // 0xE8
	public GameObject BestTimeObject; // 0xF0
	public CampaignData CampaignData; // 0xF8
	public List<Image> DifficultyIcons; // 0x100
	public List<Animator> DifficultyIconAnimators; // 0x108
	public List<CampaignActOption> ActOptions; // 0x110
	public List<CampaignChapterOption> ChapterOptions; // 0x118
	public Sprite Filled; // 0x120
	public Sprite Blank; // 0x128
	public TMP_Text ChapterTitle; // 0x130
	public TMP_Text ActTitle; // 0x138
	public TMP_Text BestTimeText; // 0x140
	public TMP_Text TooltipDifficultyText; // 0x148
	public Image ChapterRank; // 0x150
	public LocalizedString ActsTitleString; // 0x158
	public AssetReference CampaignMenuAudioBank; // 0x160
	public Dictionary<object, CampaignCutscenesMediaHUD.SpriteAssetInfo> spritePool; // 0x168
	private List<ActStatus> ActInfo; // 0x170
	private int currentActIndex; // 0x178
	private bool selectingChapter; // 0x17C
	private CampaignActData currentActData; // 0x180
	public int currentDifficulty; // 0x188
	private bool audioBanksLoaded; // 0x18C
	private bool isTooltipVisible; // 0x18D
	private bool isTimerRunning; // 0x18E
	private float hideTimer; // 0x190

	// Properties
	private DataManager dataManager { get; }
	private SceneLoader sceneLoader { get; }
	private SaveManager saveManager { get; }
	private AudioManager audioManager { get; }

	// Methods

	// RVA: 0x7725D0 Offset: 0x770BD0 VA: 0x1807725D0
	private DataManager get_dataManager() { }

	// RVA: 0x772670 Offset: 0x770C70 VA: 0x180772670
	private SceneLoader get_sceneLoader() { }

	// RVA: 0x772620 Offset: 0x770C20 VA: 0x180772620
	private SaveManager get_saveManager() { }

	// RVA: 0x772580 Offset: 0x770B80 VA: 0x180772580
	private AudioManager get_audioManager() { }

	// RVA: 0x771550 Offset: 0x76FB50 VA: 0x180771550 Slot: 7
	public override void Show() { }

	// RVA: 0x76EE30 Offset: 0x76D430 VA: 0x18076EE30
	private void AudioBankLoaded(string identifier) { }

	// RVA: 0x772000 Offset: 0x770600 VA: 0x180772000 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x76FC50 Offset: 0x76E250 VA: 0x18076FC50
	public void CreateDatas() { }

	// RVA: 0x770270 Offset: 0x76E870 VA: 0x180770270
	public void InitializeChapters() { }

	[IteratorStateMachine(typeof(CampaignMenu.<LoadSprites>d__50))]
	// RVA: 0x7704D0 Offset: 0x76EAD0 VA: 0x1807704D0
	private IEnumerator LoadSprites() { }

	// RVA: 0x76F930 Offset: 0x76DF30 VA: 0x18076F930
	public void ClearLoadedSprites() { }

	[IteratorStateMachine(typeof(CampaignMenu.<DelayClearSprites>d__52))]
	// RVA: 0x76FF30 Offset: 0x76E530 VA: 0x18076FF30
	private IEnumerator DelayClearSprites() { }

	// RVA: 0x770D70 Offset: 0x76F370 VA: 0x180770D70
	public void SetActsUnlocked(List<CampaignActData> acts) { }

	// RVA: 0x770F30 Offset: 0x76F530 VA: 0x180770F30
	public bool SetChaptersUnlocked(CampaignActData act, int actIndex) { }

	// RVA: 0x770130 Offset: 0x76E730 VA: 0x180770130
	public void DisableUnusedChapters() { }

	// RVA: 0x770A70 Offset: 0x76F070 VA: 0x180770A70
	public void ResetChapters() { }

	// RVA: 0x76EF80 Offset: 0x76D580 VA: 0x18076EF80
	public void ChangeDifficulty(bool addDifficulty) { }

	// RVA: 0x7714B0 Offset: 0x76FAB0 VA: 0x1807714B0
	public void ShowDifficultyTooltip(string text) { }

	// RVA: 0x76FFA0 Offset: 0x76E5A0 VA: 0x18076FFA0
	public void DifficultyContainerColorChange(int difficulty) { }

	// RVA: 0x771420 Offset: 0x76FA20 VA: 0x180771420
	public void SetDifficulty(int difficulty) { }

	// RVA: 0x771DE0 Offset: 0x7703E0 VA: 0x180771DE0
	public void SwitchNavigator(int index) { }

	// RVA: 0x770540 Offset: 0x76EB40 VA: 0x180770540
	public void OnActSelected(int actIndex) { }

	// RVA: 0x770700 Offset: 0x76ED00 VA: 0x180770700
	public void OnChapterSelected(int chapterIndex) { }

	// RVA: 0x76F140 Offset: 0x76D740 VA: 0x18076F140
	public void ChapterStart(int chapterIndex) { }

	// RVA: 0x771EB0 Offset: 0x7704B0 VA: 0x180771EB0
	public void ToggleActsOptions(bool enabled) { }

	// RVA: 0x771FD0 Offset: 0x7705D0 VA: 0x180771FD0
	public void UpdateChapterTitle(string text) { }

	// RVA: 0x770BB0 Offset: 0x76F1B0 VA: 0x180770BB0
	public void ReturnToPreviousScreen() { }

	// RVA: 0x770CC0 Offset: 0x76F2C0 VA: 0x180770CC0
	public void SaveDificulty() { }

	// RVA: 0x772500 Offset: 0x770B00 VA: 0x180772500
	public void .ctor() { }
}
