// Namespace: 
public class MainMenuScreen : UIScreen // TypeDefIndex: 3113
{
	// Fields
	public CinemachineVirtualCamera DefaultVirtualCamera; // 0x58
	public string DefaultCameraMovementSFX; // 0x60
	public MainMenuScreen.MainMenuCameraTransition[] Transitions; // 0x68
	public MainMenuWorldScreen WorldUI; // 0x70
	private int currentCameraIndex; // 0x78
	private MainMenuScreen.MainMenuCameraTransition currentTransition; // 0x80

	// Properties
	public MainMenu MainMenu { get; }
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x566B40 Offset: 0x565140 VA: 0x180566B40
	public MainMenu get_MainMenu() { }

	// RVA: 0x566BA0 Offset: 0x5651A0 VA: 0x180566BA0
	private OnlineManager get_onlineManager() { }

	// RVA: 0x565C70 Offset: 0x564270 VA: 0x180565C70 Slot: 4
	public override void Initialize() { }

	// RVA: 0x565D00 Offset: 0x564300 VA: 0x180565D00 Slot: 5
	public override void Load() { }

	[IteratorStateMachine(typeof(MainMenuScreen.<FinishTransitionCoroutine>d__12))]
	// RVA: 0x565890 Offset: 0x563E90 VA: 0x180565890
	private IEnumerator FinishTransitionCoroutine(float time) { }

	[IteratorStateMachine(typeof(MainMenuScreen.<EnableNextCamera>d__13))]
	// RVA: 0x565810 Offset: 0x563E10 VA: 0x180565810
	private IEnumerator EnableNextCamera(float time) { }

	// RVA: 0x5667E0 Offset: 0x564DE0 VA: 0x1805667E0 Slot: 7
	public override void Show() { }

	// RVA: 0x566B00 Offset: 0x565100 VA: 0x180566B00 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x566230 Offset: 0x564830 VA: 0x180566230
	public void PhotomRoomInfoUpdate() { }

	// RVA: 0x565910 Offset: 0x563F10 VA: 0x180565910 Slot: 8
	public override void Hide() { }

	// RVA: 0x5666D0 Offset: 0x564CD0 VA: 0x1805666D0
	public void SetCameraTransition(string transitionID) { }

	// RVA: 0x5665A0 Offset: 0x564BA0 VA: 0x1805665A0 Slot: 13
	public virtual void ReturnToPreviousScreen(string screen = "Undefined", string cameraTransition = "") { }

	// RVA: 0x566A50 Offset: 0x565050 VA: 0x180566A50 Slot: 9
	public override void TogglePanel(bool panelEnabled) { }

	// RVA: 0x559550 Offset: 0x557B50 VA: 0x180559550
	public void .ctor() { }
}
