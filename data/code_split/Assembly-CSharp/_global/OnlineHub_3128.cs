// Namespace: 
public class OnlineHub : MainMenuScreen // TypeDefIndex: 3128
{
	// Fields
	public LocalizedString ConnectingString; // 0x90
	public LocalizedString OnlineString; // 0x98
	public LocalizedString GameModeString; // 0xA0
	private bool connecting; // 0xA8
	private Coroutine connectingTimeoutCoroutine; // 0xB0
	private const float ConnectionTimeoutSeconds = 7;

	// Properties
	private UIManager uiManager { get; }
	private SaveManager saveManager { get; }
	private OnlineManager onlineManager { get; }

	// Methods

	// RVA: 0x5769C0 Offset: 0x574FC0 VA: 0x1805769C0
	private UIManager get_uiManager() { }

	// RVA: 0x576970 Offset: 0x574F70 VA: 0x180576970
	private SaveManager get_saveManager() { }

	// RVA: 0x576920 Offset: 0x574F20 VA: 0x180576920
	private OnlineManager get_onlineManager() { }

	// RVA: 0x575680 Offset: 0x573C80 VA: 0x180575680 Slot: 5
	public override void Load() { }

	// RVA: 0x575560 Offset: 0x573B60 VA: 0x180575560 Slot: 6
	public override void LoadFinished() { }

	// RVA: 0x5758A0 Offset: 0x573EA0 VA: 0x1805758A0
	private void OnAuthenticationCheckFinished(bool isAuthenticated) { }

	// RVA: 0x576060 Offset: 0x574660 VA: 0x180576060
	private void OnServerInfoRequestFinished() { }

	// RVA: 0x575AC0 Offset: 0x5740C0 VA: 0x180575AC0
	private void OnCrossplayRecheckDone() { }

	// RVA: 0x5766C0 Offset: 0x574CC0 VA: 0x1805766C0
	private void StartConnecting() { }

	[IteratorStateMachine(typeof(OnlineHub.<ConnectionTimeoutRoutine>d__18))]
	// RVA: 0x575160 Offset: 0x573760 VA: 0x180575160
	private IEnumerator ConnectionTimeoutRoutine() { }

	// RVA: 0x574BF0 Offset: 0x5731F0 VA: 0x180574BF0
	private void ConnectOnlineResult(bool success, string errorID) { }

	// RVA: 0x576430 Offset: 0x574A30 VA: 0x180576430 Slot: 7
	public override void Show() { }

	// RVA: 0x575370 Offset: 0x573970 VA: 0x180575370
	private void JoinLobbyFinish(bool success, string errorCode) { }

	// RVA: 0x574A30 Offset: 0x573030 VA: 0x180574A30
	private void ConfirmPressedOnAlert(string popUpID) { }

	// RVA: 0x576880 Offset: 0x574E80 VA: 0x180576880 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x575CE0 Offset: 0x5742E0 VA: 0x180575CE0
	private void OnPlayerSignOut() { }

	// RVA: 0x5751D0 Offset: 0x5737D0 VA: 0x1805751D0 Slot: 12
	public override void Disable() { }

	// RVA: 0x576910 Offset: 0x574F10 VA: 0x180576910
	public void .ctor() { }
}
