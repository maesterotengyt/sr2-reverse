// Namespace: 
public class RegularPauseMenu : PauseMenu // TypeDefIndex: 3219
{
	// Fields
	public Animator StandardCharacterHUDAnimator; // 0x78
	public Animator ExtendedCharacterHUDAnimator; // 0x80
	public ScreenFooter Footer; // 0x88
	public Volume PauseEffect; // 0x90
	public CanvasGroup RoundWinnerBanner; // 0x98
	public EmotesManager EmotesManager; // 0xA0
	public PauseMenuConditionalElement[] ConditionalElements; // 0xA8
	public bool IsPauseActive; // 0xB0
	[SerializeField]
	private GameObject ReportBugButton; // 0xB8
	[Header("Camera Settings")]
	public CinemachineVirtualCamera PauseCamera; // 0xC0
	public float CameraZoomOffset; // 0xC8
	public float BlendTime; // 0xCC
	private float defaultBlendTime; // 0xD0

	// Properties
	protected MainMenu mainMenu { get; }
	private UIManager uiManager { get; }
	private OnlineManager onlineManager { get; }
	private DataManager dataManager { get; }

	// Methods

	// RVA: 0x58ADD0 Offset: 0x5893D0 VA: 0x18058ADD0
	protected MainMenu get_mainMenu() { }

	// RVA: 0x58AE80 Offset: 0x589480 VA: 0x18058AE80
	private UIManager get_uiManager() { }

	// RVA: 0x58AE30 Offset: 0x589430 VA: 0x18058AE30
	private OnlineManager get_onlineManager() { }

	// RVA: 0x58AD80 Offset: 0x589380 VA: 0x18058AD80
	private DataManager get_dataManager() { }

	// RVA: 0x589B10 Offset: 0x588110 VA: 0x180589B10 Slot: 4
	public override void Initialize() { }

	// RVA: 0x589FA0 Offset: 0x5885A0 VA: 0x180589FA0
	public void Restart() { }

	// RVA: 0x58A0C0 Offset: 0x5886C0 VA: 0x18058A0C0
	public void ReturnToMainMenu() { }

	// RVA: 0x58A850 Offset: 0x588E50 VA: 0x18058A850
	public void ShowLeaveRaceWarning() { }

	// RVA: 0x58A890 Offset: 0x588E90 VA: 0x18058A890
	public void ShowRestartRaceWarning() { }

	// RVA: 0x58A870 Offset: 0x588E70 VA: 0x18058A870
	public void ShowPlayerList() { }

	// RVA: 0x58A830 Offset: 0x588E30 VA: 0x18058A830
	public void ShowGameAdjustment() { }

	// RVA: 0x58A8B0 Offset: 0x588EB0 VA: 0x18058A8B0
	public void ShowSettings() { }

	// RVA: 0x5897A0 Offset: 0x587DA0 VA: 0x1805897A0
	public void HideSubPanel() { }

	// RVA: 0x589C40 Offset: 0x588240 VA: 0x180589C40
	public void ReportBug() { }

	// RVA: 0x589DE0 Offset: 0x5883E0 VA: 0x180589DE0
	public void ReportWindowsClosed(bool isActive) { }

	// RVA: 0x58A8D0 Offset: 0x588ED0 VA: 0x18058A8D0 Slot: 7
	public override void Show() { }

	// RVA: 0x5897B0 Offset: 0x587DB0 VA: 0x1805897B0 Slot: 8
	public override void Hide() { }

	[IteratorStateMachine(typeof(RegularPauseMenu.<ResetDefautTimeBlend>d__34))]
	// RVA: 0x589F30 Offset: 0x588530 VA: 0x180589F30
	private IEnumerator ResetDefautTimeBlend() { }

	// RVA: 0x58AC10 Offset: 0x589210 VA: 0x18058AC10
	private void UpdatePauseCamera() { }

	// RVA: 0x58AD10 Offset: 0x589310 VA: 0x18058AD10
	public void .ctor() { }
}
