// Namespace: Platforms.Xbox
public class MicrosoftStoreOnlineSystem : StellarPlatformOnlineSystem // TypeDefIndex: 3758
{
	// Fields
	private MicrosoftStoreSystem _xboxSystem; // 0x20
	private string photonRoomID; // 0x28
	private string lobbyRegion; // 0x30
	private bool lobbyType; // 0x38
	private MicrosoftStoreOnlineSystem.OnlineState currentState; // 0x3C
	private readonly string endpointURL; // 0x40
	private string XSTSToken; // 0x48
	public string LobbySessionTemplate; // 0x50
	public string GameSessionTemplate; // 0x58
	private bool MPM_Initialized; // 0x60
	private bool recheckCrossplayOnly; // 0x61
	private Action recheckCrossplayCallback; // 0x68
	private bool recheckCommunicationsOnly; // 0x70
	private Action recheckCommunicationsCallback; // 0x78
	public bool userMPMAdded; // 0x80
	private bool joinByInvite; // 0x81
	private bool isAuthorized; // 0x82
	private bool checkCrossPlay; // 0x83
	private bool checkCommunications; // 0x84
	private string inviteRoom; // 0x88
	private bool connecting; // 0x90
	private string pendingInviteUrl; // 0x98
	private bool checkingMultiplayer; // 0xA0
	private bool validatePermission; // 0xA1
	private int _authRetryCount; // 0xA4
	private const int MaxAuthRetries = 3;
	private const int AuthRetryDelayMs = 2000;
	private Coroutine authTimeoutCoroutine; // 0xA8
	private const float AuthTimeoutSeconds = 30;
	private static readonly WaitForSeconds WaitForResumeCheck; // 0x0
	private static readonly WaitForSeconds WaitForAuthTimeout; // 0x8
	private bool isActivityReady; // 0xB0

	// Methods

	// RVA: 0x6456B0 Offset: 0x643CB0 VA: 0x1806456B0
	public void Init(MicrosoftStoreSystem xboxSystem) { }

	// RVA: 0x647780 Offset: 0x645D80 VA: 0x180647780
	private void StartAuthTimeout() { }

	// RVA: 0x643840 Offset: 0x641E40 VA: 0x180643840
	private void CancelAuthTimeout() { }

	[IteratorStateMachine(typeof(MicrosoftStoreOnlineSystem.<AuthTimeoutRoutine>d__36))]
	// RVA: 0x643260 Offset: 0x641860 VA: 0x180643260
	private IEnumerator AuthTimeoutRoutine() { }

	// RVA: 0x644C30 Offset: 0x643230 VA: 0x180644C30
	public void EventNotifier(bool flag, string message = "") { }

	// RVA: 0x644AD0 Offset: 0x6430D0 VA: 0x180644AD0
	public void DisableCrossplaySettings() { }

	// RVA: 0x644960 Offset: 0x642F60 VA: 0x180644960
	public void DisableChatSettings() { }

	// RVA: 0x643E90 Offset: 0x642490 VA: 0x180643E90
	public void ClearFlags() { }

	// RVA: 0x648160 Offset: 0x646760 VA: 0x180648160
	public void Update() { }

	// RVA: 0x646730 Offset: 0x644D30 VA: 0x180646730
	private void ProcessOnlineEvents(XblMultiplayerEvent[] multiplayerEvents) { }

	// RVA: 0x643B40 Offset: 0x642140 VA: 0x180643B40 Slot: 4
	public override bool CheckInternetConnection() { }

	// RVA: 0x643F40 Offset: 0x642540 VA: 0x180643F40 Slot: 5
	public override void ConnectOnline() { }

	// RVA: 0x642FA0 Offset: 0x6415A0 VA: 0x180642FA0
	public void AddRecentPlayers(SavedPlayerData[] savedPlayers) { }

	// RVA: 0x646510 Offset: 0x644B10 VA: 0x180646510
	private void OnMultiplayerPrivilegeChecked() { }

	// RVA: 0x646430 Offset: 0x644A30 VA: 0x180646430
	private void OnCrossPlayPrivilegeChecked() { }

	// RVA: 0x646350 Offset: 0x644950 VA: 0x180646350
	private void OnCommunicationsPrivilegeChecked() { }

	// RVA: 0x643AB0 Offset: 0x6420B0 VA: 0x180643AB0
	public bool CheckCrossplayPrivilege() { }

	// RVA: 0x646E20 Offset: 0x645420 VA: 0x180646E20 Slot: 15
	public override void RecheckCrossplayWithUI(Action onDone) { }

	// RVA: 0x6439B0 Offset: 0x641FB0 VA: 0x1806439B0
	public bool CheckCommunicationsPrivilege() { }

	// RVA: 0x646D70 Offset: 0x645370 VA: 0x180646D70
	public void RecheckCommunicationsWithUI(Action onDone) { }

	[AsyncStateMachine(typeof(MicrosoftStoreOnlineSystem.<ValidateMultiplayerAccess>d__53))]
	// RVA: 0x648810 Offset: 0x646E10 VA: 0x180648810
	public void ValidateMultiplayerAccess() { }

	// RVA: 0x646640 Offset: 0x644C40 VA: 0x180646640
	public void OnResume() { }

	[IteratorStateMachine(typeof(MicrosoftStoreOnlineSystem.<CheckConnectionAfterResume>d__55))]
	// RVA: 0x643A40 Offset: 0x642040 VA: 0x180643A40
	private IEnumerator CheckConnectionAfterResume() { }

	// RVA: 0x643890 Offset: 0x641E90 VA: 0x180643890
	private void CheckAuthCode() { }

	// RVA: 0x647040 Offset: 0x645640 VA: 0x180647040
	private void RequestAuthToken() { }

	[AsyncStateMachine(typeof(MicrosoftStoreOnlineSystem.<RetryAuthTokenAsync>d__58))]
	// RVA: 0x6471E0 Offset: 0x6457E0 VA: 0x1806471E0
	private void RetryAuthTokenAsync() { }

	// RVA: 0x6432D0 Offset: 0x6418D0 VA: 0x1806432D0 Slot: 14
	public override void AuthenticateBraincloud() { }

	// RVA: 0x647420 Offset: 0x645A20 VA: 0x180647420 Slot: 6
	public override AuthenticationValues SetupPhotonAuthentication() { }

	// RVA: 0x643CA0 Offset: 0x6422A0 VA: 0x180643CA0
	private void CheckNewVersion() { }

	[AsyncStateMachine(typeof(MicrosoftStoreOnlineSystem.<FilterTextAsync>d__62))]
	// RVA: 0x644F60 Offset: 0x643560 VA: 0x180644F60
	public Task<string> FilterTextAsync(string text) { }

	// RVA: 0x645250 Offset: 0x643850 VA: 0x180645250
	private Player GetPlayerFromNickname(string nickname) { }

	[AsyncStateMachine(typeof(MicrosoftStoreOnlineSystem.<CanCommunicateWithUser>d__64))]
	// RVA: 0x643720 Offset: 0x641D20 VA: 0x180643720
	public Task<bool> CanCommunicateWithUser(string nickname) { }

	// RVA: 0x644170 Offset: 0x642770 VA: 0x180644170 Slot: 7
	public override void CreateOnlineLobby(bool publicLobby) { }

	// RVA: 0x6440D0 Offset: 0x6426D0 VA: 0x1806440D0
	private void CreateGameSession() { }

	// RVA: 0x647FE0 Offset: 0x6465E0 VA: 0x180647FE0 Slot: 10
	public override void UpdatePhotonRoomID(string newPhotonRoomID) { }

	// RVA: 0x6451D0 Offset: 0x6437D0 VA: 0x1806451D0 Slot: 11
	public override string GetPhotonRoomID() { }

	// RVA: 0x645150 Offset: 0x643750 VA: 0x180645150 Slot: 12
	public override string GetLobbyRegion() { }

	// RVA: 0x6475A0 Offset: 0x645BA0 VA: 0x1806475A0 Slot: 13
	public override void ShowInvitationMenu() { }

	// RVA: 0x645080 Offset: 0x643680 VA: 0x180645080
	private string GetInviteData() { }

	// RVA: 0x6458F0 Offset: 0x643EF0 VA: 0x1806458F0
	public void InviteReceived(IntPtr ptr, string inviteURL) { }

	// RVA: 0x644DB0 Offset: 0x6433B0 VA: 0x180644DB0
	private void FallbackToMPSD(string decodedUrl) { }

	// RVA: 0x645EB0 Offset: 0x6444B0 VA: 0x180645EB0 Slot: 8
	public override void JoinOnlineLobby(string platformLobbyID) { }

	// RVA: 0x647290 Offset: 0x645890 VA: 0x180647290
	private void SetSessionProperties() { }

	// RVA: 0x6453E0 Offset: 0x6439E0 VA: 0x1806453E0
	private InvitationData GetSessionProperties() { }

	// RVA: 0x644500 Offset: 0x642B00 VA: 0x180644500
	private void CreateXboxActivity(bool isPrivate) { }

	// RVA: 0x6447B0 Offset: 0x642DB0 VA: 0x1806447B0
	private void DeleteXboxActivity() { }

	// RVA: 0x646ED0 Offset: 0x6454D0 VA: 0x180646ED0
	private void RemoveUser() { }

	// RVA: 0x646290 Offset: 0x644890 VA: 0x180646290 Slot: 9
	public override void LeaveOnlineLobby() { }

	// RVA: 0x648990 Offset: 0x646F90 VA: 0x180648990
	public void .ctor() { }

	// RVA: 0x6488C0 Offset: 0x646EC0 VA: 0x1806488C0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x647D30 Offset: 0x646330 VA: 0x180647D30
	private void <RequestAuthToken>b__57_0(int hresult, XUserGetTokenAndSignatureUtf16Data tokenAndSignature) { }

	[CompilerGenerated]
	// RVA: 0x647820 Offset: 0x645E20 VA: 0x180647820
	private void <AuthenticateBraincloud>b__59_0(int hresult, XUserGetTokenAndSignatureUtf16Data tokenAndSignature) { }

	[CompilerGenerated]
	// RVA: 0x6479A0 Offset: 0x645FA0 VA: 0x1806479A0
	private void <AuthenticateBraincloud>b__59_2(int status, int code, string error, object cbObject) { }

	[CompilerGenerated]
	// RVA: 0x647A60 Offset: 0x646060 VA: 0x180647A60
	private void <CheckNewVersion>b__61_0(int hresult, XStorePackageUpdate[] packageUpdates) { }

	[CompilerGenerated]
	// RVA: 0x647F30 Offset: 0x646530 VA: 0x180647F30
	private void <ShowInvitationMenu>b__70_0(int hresult) { }

	[CompilerGenerated]
	// RVA: 0x647C40 Offset: 0x646240 VA: 0x180647C40
	private void <CreateXboxActivity>b__77_0(int hresult) { }
}
