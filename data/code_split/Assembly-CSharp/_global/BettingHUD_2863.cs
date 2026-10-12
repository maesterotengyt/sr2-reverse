// Namespace: 
public class BettingHUD : SRMonoBehaviour // TypeDefIndex: 2863
{
	// Fields
	public BetWinnerMessage RoundWinnerMessage; // 0x20
	public BetWinnerMessage MatchWinnerMessage; // 0x28
	public TMP_Text CurrencyText; // 0x30
	public TMP_Text MatchWin; // 0x38
	public TMP_Text RoundWin; // 0x40
	public ScreenFooterButton HideButton; // 0x48
	public ScreenFooterButton ConfirmButton; // 0x50
	public Image TimerFill; // 0x58
	public float MaxBetTime; // 0x60
	[Header("Side Panel")]
	public Animator SidePanelAnimator; // 0x68
	public UINavigator SidePanelNavigator; // 0x70
	public UINavigationElement RoundToggle; // 0x78
	public UINavigationElement MatchToggle; // 0x80
	[Header("Chips scroller")]
	public BettingAmountSelector BettingAmountSelector; // 0x88
	public List<BettingChipSelector> ChipSelectors; // 0x90
	public List<BettingCharacterContainer> BettingContainers; // 0x98
	public LocalizedString HideString; // 0xA0
	public LocalizedString ConfirmString; // 0xA8
	public LocalizedString WinBetString; // 0xB0
	[CompilerGenerated]
	private bool <MatchBetMode>k__BackingField; // 0xB8
	[CompilerGenerated]
	private bool <SidePanelActive>k__BackingField; // 0xB9
	private int selectedChip; // 0xBC
	private int sendBetIndex; // 0xC0
	private bool timerRunning; // 0xC4
	private float currentTimer; // 0xC8

	// Properties
	public bool MatchBetMode { get; set; }
	public bool SidePanelActive { get; set; }
	private StellarInputSystem inputSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7413E0 Offset: 0x73F9E0 VA: 0x1807413E0
	public bool get_MatchBetMode() { }

	[CompilerGenerated]
	// RVA: 0x741450 Offset: 0x73FA50 VA: 0x180741450
	public void set_MatchBetMode(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7413F0 Offset: 0x73F9F0 VA: 0x1807413F0
	public bool get_SidePanelActive() { }

	[CompilerGenerated]
	// RVA: 0x741460 Offset: 0x73FA60 VA: 0x180741460
	public void set_SidePanelActive(bool value) { }

	// RVA: 0x741400 Offset: 0x73FA00 VA: 0x180741400
	private StellarInputSystem get_inputSystem() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void Initialize() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void SetColor(StellarCharacterData characterData) { }

	// RVA: 0x7401E0 Offset: 0x73E7E0 VA: 0x1807401E0
	private void LockRoundBetting(EventShowIntroAnimation callback) { }

	// RVA: 0x740170 Offset: 0x73E770 VA: 0x180740170
	private void HandleTimerFinished() { }

	// RVA: 0x7402A0 Offset: 0x73E8A0 VA: 0x1807402A0
	private void MatchBetResult(int amount) { }

	// RVA: 0x7404E0 Offset: 0x73EAE0 VA: 0x1807404E0
	private void RoundBetResult(int amount) { }

	// RVA: 0x7408C0 Offset: 0x73EEC0 VA: 0x1807408C0
	public void SetRoundData() { }

	// RVA: 0x740F50 Offset: 0x73F550 VA: 0x180740F50
	public void Update() { }

	// RVA: 0x7405B0 Offset: 0x73EBB0 VA: 0x1807405B0
	public void SetMode(bool matchMode) { }

	// RVA: 0x740510 Offset: 0x73EB10 VA: 0x180740510
	public void SetBet(string playerId, int amount) { }

	// RVA: 0x740D30 Offset: 0x73F330 VA: 0x180740D30
	public void UpdateCurrencyDisplay() { }

	// RVA: 0x7405A0 Offset: 0x73EBA0 VA: 0x1807405A0
	public void SetChip(int amount) { }

	// RVA: 0x740160 Offset: 0x73E760 VA: 0x180740160
	public int GetChip() { }

	// RVA: 0x73FFA0 Offset: 0x73E5A0 VA: 0x18073FFA0
	public void ConfirmBets() { }

	// RVA: 0x7403E0 Offset: 0x73E9E0 VA: 0x1807403E0
	public void OpenSidePanel() { }

	// RVA: 0x73FF20 Offset: 0x73E520 VA: 0x18073FF20
	public void CloseSidePanel() { }

	// RVA: 0x7401D0 Offset: 0x73E7D0 VA: 0x1807401D0
	public void Hide() { }

	// RVA: 0x7402E0 Offset: 0x73E8E0 VA: 0x1807402E0
	private void OnDestroy() { }

	// RVA: 0x7413C0 Offset: 0x73F9C0 VA: 0x1807413C0
	public void .ctor() { }
}
