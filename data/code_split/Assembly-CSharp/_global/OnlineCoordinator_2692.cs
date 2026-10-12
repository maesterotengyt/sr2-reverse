// Namespace: 
public class OnlineCoordinator : SRMonoBehaviour // TypeDefIndex: 2692
{
	// Fields
	public OnlineCoordinator.OnJoinLobbyFinish JoinLobbyFinish; // 0x20
	public OnlineCoordinator.OnCreatingLobbyFinish CreatingLobbyFinish; // 0x28
	public LocalizedString JoiningLobbyString; // 0x30
	public LocalizedString LeavingLobbyString; // 0x38
	public LocalizedString CreatingLobbyString; // 0x40
	public LocalizedString ChangingRegionString; // 0x48
	public LocalizedString ConnectingToServersString; // 0x50
	[CompilerGenerated]
	private string <CurrentRulesetName>k__BackingField; // 0x58
	private bool showMessage; // 0x60
	private CreateLobbyMessage createLobbyMessageType; // 0x64
	private LeavingLobbyMessage leavingLobbyMessageType; // 0x68

	// Properties
	public string CurrentRulesetName { get; set; }
	private OnlineProperties properties { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5B45B0 Offset: 0x5B2BB0 VA: 0x1805B45B0
	public string get_CurrentRulesetName() { }

	[CompilerGenerated]
	// RVA: 0x5B45D0 Offset: 0x5B2BD0 VA: 0x1805B45D0
	public void set_CurrentRulesetName(string value) { }

	// RVA: 0x71BAE0 Offset: 0x71A0E0 VA: 0x18071BAE0
	private OnlineProperties get_properties() { }

	// RVA: 0x71AE80 Offset: 0x719480 VA: 0x18071AE80
	public void StartLobbyCreationProcess(OnlineLobbyType lobbyType, bool publicLobby, bool hiddenPassword, int maxPlayers, MatchRules matchRules, CreateLobbyMessage messageType = 1) { }

	[IteratorStateMachine(typeof(OnlineCoordinator.<CreateLobbyRoutine>d__19))]
	// RVA: 0x7191A0 Offset: 0x7177A0 VA: 0x1807191A0
	private IEnumerator CreateLobbyRoutine(OnlineLobbyType lobbyType, bool publicLobby, bool hiddenPassword, int maxPlayers, MatchRules matchRules) { }

	// RVA: 0x71B1D0 Offset: 0x7197D0 VA: 0x18071B1D0
	public void StartTournamentRoomCreationProcess(int maxPlayers, string roomID, MatchRules matchRules) { }

	[IteratorStateMachine(typeof(OnlineCoordinator.<CreateTournamentLobbyRoutine>d__21))]
	// RVA: 0x719A10 Offset: 0x718010 VA: 0x180719A10
	private IEnumerator CreateTournamentLobbyRoutine(OnlineLobbyType lobbyType, bool publicLobby, bool hiddenPassword, int maxPlayers, MatchRules matchRules, string roomID) { }

	// RVA: 0x719240 Offset: 0x717840 VA: 0x180719240
	public void CreateLobby(string roomID, string password, OnlineLobbyType lobbyType, int maxPlayers, MatchRules matchRules, bool lobbyVisible, bool hiddenPassword) { }

	// RVA: 0x71A260 Offset: 0x718860 VA: 0x18071A260
	private void LobbyCreationResult(bool success) { }

	// RVA: 0x718F30 Offset: 0x717530 VA: 0x180718F30
	private void ConfirmOnCreatingLobbyAlert(string popUpID) { }

	// RVA: 0x719CF0 Offset: 0x7182F0 VA: 0x180719CF0
	public void JoinLobbyWithPhotonRoomID(string photonRoomID, string lobbyRegion = "", bool showPopup = True, OnlineLobbyType lobbyType = 0) { }

	[IteratorStateMachine(typeof(OnlineCoordinator.<JoinLobbyWithPhotonRoomIDRoutine>d__26))]
	// RVA: 0x719C50 Offset: 0x718250 VA: 0x180719C50
	private IEnumerator JoinLobbyWithPhotonRoomIDRoutine(string photonRoomID, string lobbyRegion = "", OnlineLobbyType lobbyType = 0, bool showPopup = True) { }

	// RVA: 0x719EA0 Offset: 0x7184A0 VA: 0x180719EA0
	public void JoinLobbyWithPlatformLobbyID(string platformLobbyID) { }

	[IteratorStateMachine(typeof(OnlineCoordinator.<JoinLobbyWithPlatformLobbyIDRoutine>d__28))]
	// RVA: 0x719E10 Offset: 0x718410 VA: 0x180719E10
	private IEnumerator JoinLobbyWithPlatformLobbyIDRoutine(string platformLobbyID) { }

	// RVA: 0x71A660 Offset: 0x718C60 VA: 0x18071A660
	private void LobbyJoinResult(bool success, string errorCode) { }

	// RVA: 0x719080 Offset: 0x717680 VA: 0x180719080
	private void ConfirmOnErrorJoiningLobby(string popUpID) { }

	// RVA: 0x71A010 Offset: 0x718610 VA: 0x18071A010
	public void LeaveLobby(LeavingLobbyMessage message = 1) { }

	[IteratorStateMachine(typeof(OnlineCoordinator.<LeaveLobbyRoutine>d__32))]
	// RVA: 0x719FA0 Offset: 0x7185A0 VA: 0x180719FA0
	private IEnumerator LeaveLobbyRoutine() { }

	// RVA: 0x71A8D0 Offset: 0x718ED0 VA: 0x18071A8D0
	private void LobbyLeft() { }

	// RVA: 0x71ABD0 Offset: 0x7191D0 VA: 0x18071ABD0
	public void Reconnect(bool showMessage = True) { }

	// RVA: 0x718DF0 Offset: 0x7173F0 VA: 0x180718DF0
	public void ChangeRegion(bool showMessage = True) { }

	// RVA: 0x718CB0 Offset: 0x7172B0 VA: 0x180718CB0
	public void ChangeCrossplay(bool showMessage = True) { }

	[IteratorStateMachine(typeof(OnlineCoordinator.<ReconnectRoutine>d__37))]
	// RVA: 0x71AB60 Offset: 0x719160 VA: 0x18071AB60
	private IEnumerator ReconnectRoutine() { }

	// RVA: 0x71AD10 Offset: 0x719310 VA: 0x18071AD10
	private void Reconnected(bool success, string errorIDs) { }

	// RVA: 0x719AC0 Offset: 0x7180C0 VA: 0x180719AC0
	public void DisconnectFromServers() { }

	[IteratorStateMachine(typeof(OnlineCoordinator.<DisconnectRoutine>d__40))]
	// RVA: 0x719BE0 Offset: 0x7181E0 VA: 0x180719BE0
	private IEnumerator DisconnectRoutine() { }

	// RVA: 0x71AAC0 Offset: 0x7190C0 VA: 0x18071AAC0
	private bool PlatformLobbyNeeded(OnlineLobbyType lobbyType = 0) { }

	// RVA: 0x71B4C0 Offset: 0x719AC0 VA: 0x18071B4C0
	public void UpdatePlayersData() { }

	// RVA: 0x71B370 Offset: 0x719970 VA: 0x18071B370
	public Ruleset SyncOnlineRules() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
