// Namespace: 
public class ResultScreen : UIScreen // TypeDefIndex: 3253
{
	// Fields
	public ScreenFooter ResultScreenFooter; // 0x58
	public LevelUpScreen LevelUpScreen; // 0x60
	public WinnerScreen WinnerScreen; // 0x68
	public GameObject WinnerSpeechBubble; // 0x70
	public GameObject TutorialBackground; // 0x78

	// Properties
	private OnlineManager onlineManager { get; }
	private UIManager uiManager { get; }
	private SaveManager saveManager { get; }

	// Methods

	// RVA: 0x5A1C90 Offset: 0x5A0290 VA: 0x1805A1C90
	private OnlineManager get_onlineManager() { }

	// RVA: 0x5A1D30 Offset: 0x5A0330 VA: 0x1805A1D30
	private UIManager get_uiManager() { }

	// RVA: 0x5A1CE0 Offset: 0x5A02E0 VA: 0x1805A1CE0
	private SaveManager get_saveManager() { }

	// RVA: 0x5A1320 Offset: 0x59F920 VA: 0x1805A1320
	private void Start() { }

	// RVA: 0x5A1010 Offset: 0x59F610 VA: 0x1805A1010
	private void OnAuthenticationCheckFinished(bool isAuthenticated) { }

	// RVA: 0x5A11D0 Offset: 0x59F7D0 VA: 0x1805A11D0
	private void OnPostRatingCompleted() { }

	// RVA: 0x5A1C40 Offset: 0x5A0240 VA: 0x1805A1C40 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x5A1C80 Offset: 0x5A0280 VA: 0x1805A1C80
	public void .ctor() { }
}
