// Namespace: 
public class ChatBoxManager : SRMonoBehaviour // TypeDefIndex: 2914
{
	// Fields
	public UltimateChatBox ChatBox; // 0x20
	public CanvasGroup CanvasGroup; // 0x28
	public ProfanityList ProfanityList; // 0x30
	public ScreenFooterButton FooterButton; // 0x38
	public LocalizedString CloseButtonString; // 0x40
	public RectTransform ClosePrompt; // 0x48
	public StellarCharacterData LocalCharacterData; // 0x50
	public UltimateChatBox.DisplayConfig DefaultMatchConfig; // 0x1D0
	public UltimateChatBox.DisplayConfig CharacterSelectConfig; // 0x208
	public UltimateChatBox.DisplayConfig MainMenuConfig; // 0x240
	[CompilerGenerated]
	private GameObject <ChatPrompt>k__BackingField; // 0x278
	[CompilerGenerated]
	private Image <PromptBackground>k__BackingField; // 0x280
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x288
	public UltimateChatBox.ChatStyle ReceivedMessageStyle; // 0x290
	public UltimateChatBox.ChatStyle LocalMessageStyle; // 0x298
	private string localPlayerNickname; // 0x2A0
	private bool isActive; // 0x2A8
	private bool pauseInputEnable; // 0x2A9
	private bool initialized; // 0x2AA
	private bool startingRound; // 0x2AB
	private bool isLocalPlayerKO; // 0x2AC

	// Properties
	public GameObject ChatPrompt { get; set; }
	public Image PromptBackground { get; set; }
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x758960 Offset: 0x756F60 VA: 0x180758960
	public GameObject get_ChatPrompt() { }

	[CompilerGenerated]
	// RVA: 0x758980 Offset: 0x756F80 VA: 0x180758980
	public void set_ChatPrompt(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x758970 Offset: 0x756F70 VA: 0x180758970
	public Image get_PromptBackground() { }

	[CompilerGenerated]
	// RVA: 0x7589A0 Offset: 0x756FA0 VA: 0x1807589A0
	public void set_PromptBackground(Image value) { }

	[CompilerGenerated]
	// RVA: 0x6A39D0 Offset: 0x6A1FD0 VA: 0x1806A39D0
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x6A46E0 Offset: 0x6A2CE0 VA: 0x1806A46E0
	public void set_IsPlaying(bool value) { }

	// RVA: 0x757C80 Offset: 0x756280 VA: 0x180757C80
	private bool IsChatAllowedAndEnabled() { }

	// RVA: 0x757820 Offset: 0x755E20 VA: 0x180757820
	public void Initialize() { }

	// RVA: 0x757490 Offset: 0x755A90 VA: 0x180757490
	public void EnableChatBox() { }

	// RVA: 0x757DB0 Offset: 0x7563B0 VA: 0x180757DB0
	public void NotifyRaceRoundStart(EventRoundStart callback) { }

	// RVA: 0x757DA0 Offset: 0x7563A0 VA: 0x180757DA0
	public void NotifyRaceEnd(EventNotifyRaceEnd callback) { }

	[IteratorStateMachine(typeof(ChatBoxManager.<StartingRoundTimer>d__35))]
	// RVA: 0x758250 Offset: 0x756850 VA: 0x180758250
	public IEnumerator StartingRoundTimer() { }

	// RVA: 0x758320 Offset: 0x756920 VA: 0x180758320
	private void Update() { }

	// RVA: 0x757E40 Offset: 0x756440 VA: 0x180757E40
	public void OnCharacterKnockout(EventCharacterKnockout callback) { }

	// RVA: 0x758130 Offset: 0x756730 VA: 0x180758130
	private void OnResetRaceRound(EventOnResetRaceRound callback) { }

	[AsyncStateMachine(typeof(ChatBoxManager.<OnInputFieldSubmitted>d__39))]
	// RVA: 0x758060 Offset: 0x756660 VA: 0x180758060
	private void OnInputFieldSubmitted(string message) { }

	[AsyncStateMachine(typeof(ChatBoxManager.<AddMessage>d__40))]
	// RVA: 0x756F20 Offset: 0x755520 VA: 0x180756F20
	private void AddMessage(PlayerChatMessage playerMessage) { }

	[AsyncStateMachine(typeof(ChatBoxManager.<CanCommunicateWithUser>d__41))]
	// RVA: 0x757000 Offset: 0x755600 VA: 0x180757000
	private Task<bool> CanCommunicateWithUser(string nickname) { }

	// RVA: 0x7582C0 Offset: 0x7568C0 VA: 0x1807582C0
	public void UpdateDisplayConfig(UltimateChatBox.DisplayConfig config) { }

	[AsyncStateMachine(typeof(ChatBoxManager.<SendChatMessageAsync>d__43))]
	// RVA: 0x758140 Offset: 0x756740 VA: 0x180758140
	private Task SendChatMessageAsync(string playerID, string message) { }

	[AsyncStateMachine(typeof(ChatBoxManager.<FilterMessageAsync>d__44))]
	// RVA: 0x757700 Offset: 0x755D00 VA: 0x180757700
	private Task<string> FilterMessageAsync(string message) { }

	// RVA: 0x757120 Offset: 0x755720 VA: 0x180757120
	private string CensorMessage(string message) { }

	// RVA: 0x757E80 Offset: 0x756480 VA: 0x180757E80
	private void OnDestroy() { }

	// RVA: 0x7573B0 Offset: 0x7559B0 VA: 0x1807573B0
	public void DisableChatBox(bool forced = False) { }

	// RVA: 0x758820 Offset: 0x756E20 VA: 0x180758820
	public void .ctor() { }
}
