// Namespace: 
public class ReportWindow : SRMonoBehaviour // TypeDefIndex: 3242
{
	// Fields
	public ReportWindow.OnReportWindowStateChanged ReportWindowStateChanged; // 0x20
	public Animator Animator; // 0x28
	public UINavigator UINavigator; // 0x30
	public UINavigationElement SendButton; // 0x38
	public StellarInputField TitleInput; // 0x40
	public StellarInputField EmailInput; // 0x48
	public StellarInputField DescriptionInput; // 0x50
	public StellarSelectorOption ReportTypeSelector; // 0x58
	public Animator TitleInputAnimator; // 0x60
	public Animator EmailInputAnimator; // 0x68
	public Animator DescriptionInputAnimator; // 0x70
	public float UploadCooldownSeconds; // 0x78
	public LocalizedString Feedback; // 0x80
	public LocalizedString BugReport; // 0x88
	private float lastUploadTime; // 0x90
	private bool active; // 0x94
	private bool sendPreviousReport; // 0x95
	private bool bugReport; // 0x96

	// Properties
	private StellarInputSystem inputSystem { get; }

	// Methods

	// RVA: 0x58BB50 Offset: 0x58A150 VA: 0x18058BB50
	private StellarInputSystem get_inputSystem() { }

	// RVA: 0x58B380 Offset: 0x589980 VA: 0x18058B380
	public void Initialize() { }

	// RVA: 0x58B600 Offset: 0x589C00 VA: 0x18058B600
	public void Show() { }

	// RVA: 0x58AF70 Offset: 0x589570 VA: 0x18058AF70
	public void DisableCaretRaycast() { }

	// RVA: 0x58B4A0 Offset: 0x589AA0 VA: 0x18058B4A0
	public void ReportTypeChanged(int option) { }

	// RVA: 0x58B170 Offset: 0x589770 VA: 0x18058B170
	public void Hide() { }

	// RVA: 0x58B910 Offset: 0x589F10 VA: 0x18058B910
	private void Update() { }

	// RVA: 0x58B4B0 Offset: 0x589AB0 VA: 0x18058B4B0
	public void SendReport() { }

	[IteratorStateMachine(typeof(ReportWindow.<ProcessReportSequence>d__28))]
	// RVA: 0x58B430 Offset: 0x589A30 VA: 0x18058B430
	private IEnumerator ProcessReportSequence() { }

	[IteratorStateMachine(typeof(ReportWindow.<CaptureScreenshotBytes>d__29))]
	// RVA: 0x58AED0 Offset: 0x5894D0 VA: 0x18058AED0
	private IEnumerator CaptureScreenshotBytes(string screenshotName, Action<byte[]> callback) { }

	[IteratorStateMachine(typeof(ReportWindow.<MoveFiles>d__30))]
	// RVA: 0x58B3C0 Offset: 0x5899C0 VA: 0x18058B3C0
	private IEnumerator MoveFiles() { }

	// RVA: 0x58B040 Offset: 0x589640 VA: 0x18058B040
	private string FormatReport(string title, string email, string desc, string log) { }

	// RVA: 0x58BB30 Offset: 0x58A130 VA: 0x18058BB30
	public void .ctor() { }
}
