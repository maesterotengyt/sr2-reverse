// Namespace: 
public class CampaignDialogueMediaHUD : UIScreen // TypeDefIndex: 2886
{
	// Fields
	public CutsceneCharacterTextBox DialogueBox; // 0x58
	public CampaignDialogueData DialogueData; // 0x60
	public Transform CharacterRenderSpot; // 0x68
	public RectTransform CharacterSpot1; // 0x70
	public RectTransform CharacterSpot2; // 0x78
	public Animator GameModeScreenAnimator; // 0x80
	public float GameModeScreenTime; // 0x88
	public PauseHoldBar CancelHoldBar; // 0x90
	public Camera Camera; // 0x98
	public RawImage CharacterFrame; // 0xA0
	public TMP_Text GamemodeText; // 0xA8
	public AssetReference CampaignGameplayAudioBank; // 0xB0
	private CampaignDialogue currentDialogue; // 0xB8
	private int currentCharacterDialogueIndex; // 0xC0
	private bool IsDialogueActive; // 0xC4
	private bool isShowingLastDialogue; // 0xC5
	private bool LeftFrameInUse; // 0xC6
	private bool audioBanksLoaded; // 0xC7
	private bool showingGameModeScreen; // 0xC8
	private float GameModeScreenTimer; // 0xCC
	public LocalizedString CampaignRaceName; // 0xD0
	public LocalizedString EscapeRoomName; // 0xD8
	public LocalizedString BossFightName; // 0xE0
	public LocalizedString EndlessFalconName; // 0xE8
	public LocalizedString EndlessFrogName; // 0xF0
	public LocalizedString CampaignLapsRaceName; // 0xF8
	public LocalizedString CampaignHazardsRaceName; // 0x100
	public static CampaignDialogueMediaHUD.OnCharacterInstanced CharacterInstanced; // 0x0

	// Properties
	private CampaignManager campaignManager { get; }
	private AudioManager audioManager { get; }

	// Methods

	// RVA: 0x749DF0 Offset: 0x7483F0 VA: 0x180749DF0
	private CampaignManager get_campaignManager() { }

	// RVA: 0x749DA0 Offset: 0x7483A0 VA: 0x180749DA0
	private AudioManager get_audioManager() { }

	// RVA: 0x749780 Offset: 0x747D80 VA: 0x180749780 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x748AC0 Offset: 0x7470C0 VA: 0x180748AC0
	public void PlayCampaignDialogue() { }

	// RVA: 0x748420 Offset: 0x746A20 VA: 0x180748420
	public CampaignDialogue GetDialogue(HashString dialogueID) { }

	// RVA: 0x7485E0 Offset: 0x746BE0 VA: 0x1807485E0
	public void Load3DCharacterRender(HashString name, bool Left) { }

	// RVA: 0x7483B0 Offset: 0x7469B0 VA: 0x1807483B0
	private void EndDialogue() { }

	// RVA: 0x748F20 Offset: 0x747520 VA: 0x180748F20
	public void ShowGameModeScreen() { }

	// RVA: 0x749700 Offset: 0x747D00 VA: 0x180749700
	public void StartIntro() { }

	[IteratorStateMachine(typeof(CampaignDialogueMediaHUD.<WaitUntilShowAnimation>d__40))]
	// RVA: 0x749D30 Offset: 0x748330 VA: 0x180749D30
	private IEnumerator WaitUntilShowAnimation() { }

	[IteratorStateMachine(typeof(CampaignDialogueMediaHUD.<WaitUntilHideAnimation>d__41))]
	// RVA: 0x749CC0 Offset: 0x7482C0 VA: 0x180749CC0
	private IEnumerator WaitUntilHideAnimation() { }

	// RVA: 0x748260 Offset: 0x746860 VA: 0x180748260
	private void AudioBankLoaded(string identifier) { }

	// RVA: 0x5A1C80 Offset: 0x5A0280 VA: 0x1805A1C80
	public void .ctor() { }
}
