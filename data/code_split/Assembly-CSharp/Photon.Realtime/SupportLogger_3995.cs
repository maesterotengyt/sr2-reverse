// Namespace: Photon.Realtime
[DisallowMultipleComponent]
public class SupportLogger : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, IInRoomCallbacks, ILobbyCallbacks, IErrorInfoCallback // TypeDefIndex: 3995
{
	// Fields
	public bool LogTrafficStats; // 0x20
	private LoadBalancingClient client; // 0x28
	private Stopwatch startStopwatch; // 0x30
	private bool initialOnApplicationPauseSkipped; // 0x38
	private int pingMax; // 0x3C
	private int pingMin; // 0x40

	// Properties
	public LoadBalancingClient Client { get; set; }

	// Methods

	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public LoadBalancingClient get_Client() { }

	// RVA: 0x696420 Offset: 0x694A20 VA: 0x180696420
	public void set_Client(LoadBalancingClient value) { }

	// RVA: 0x6962D0 Offset: 0x6948D0 VA: 0x1806962D0
	protected void Start() { }

	// RVA: 0x6952A0 Offset: 0x6938A0 VA: 0x1806952A0
	protected void OnDestroy() { }

	// RVA: 0x694A60 Offset: 0x693060 VA: 0x180694A60
	protected void OnApplicationPause(bool pause) { }

	// RVA: 0x694BA0 Offset: 0x6931A0 VA: 0x180694BA0
	protected void OnApplicationQuit() { }

	// RVA: 0x696230 Offset: 0x694830 VA: 0x180696230
	public void StartLogStats() { }

	// RVA: 0x696360 Offset: 0x694960 VA: 0x180696360
	public void StopLogStats() { }

	// RVA: 0x696280 Offset: 0x694880 VA: 0x180696280
	private void StartTrackValues() { }

	// RVA: 0x6963A0 Offset: 0x6949A0 VA: 0x1806963A0
	private void StopTrackValues() { }

	// RVA: 0x693B40 Offset: 0x692140 VA: 0x180693B40
	private string GetFormattedTimestamp() { }

	// RVA: 0x6963E0 Offset: 0x6949E0 VA: 0x1806963E0
	private void TrackValues() { }

	// RVA: 0x694800 Offset: 0x692E00 VA: 0x180694800
	public void LogStats() { }

	// RVA: 0x693D40 Offset: 0x692340 VA: 0x180693D40
	private void LogBasics() { }

	// RVA: 0x694C30 Offset: 0x693230 VA: 0x180694C30 Slot: 4
	public void OnConnected() { }

	// RVA: 0x694BB0 Offset: 0x6931B0 VA: 0x180694BB0 Slot: 5
	public void OnConnectedToMaster() { }

	// RVA: 0x6955A0 Offset: 0x693BA0 VA: 0x1806955A0 Slot: 10
	public void OnFriendListUpdate(List<FriendInfo> friendList) { }

	// RVA: 0x695940 Offset: 0x693F40 VA: 0x180695940 Slot: 22
	public void OnJoinedLobby() { }

	// RVA: 0x695C00 Offset: 0x694200 VA: 0x180695C00 Slot: 23
	public void OnLeftLobby() { }

	// RVA: 0x694DB0 Offset: 0x6933B0 VA: 0x180694DB0 Slot: 12
	public void OnCreateRoomFailed(short returnCode, string message) { }

	// RVA: 0x695A10 Offset: 0x694010 VA: 0x180695A10 Slot: 13
	public void OnJoinedRoom() { }

	// RVA: 0x6957B0 Offset: 0x693DB0 VA: 0x1806957B0 Slot: 14
	public void OnJoinRoomFailed(short returnCode, string message) { }

	// RVA: 0x695620 Offset: 0x693C20 VA: 0x180695620 Slot: 15
	public void OnJoinRandomFailed(short returnCode, string message) { }

	// RVA: 0x694F40 Offset: 0x693540 VA: 0x180694F40 Slot: 11
	public void OnCreatedRoom() { }

	// RVA: 0x695C80 Offset: 0x694280 VA: 0x180695C80 Slot: 16
	public void OnLeftRoom() { }

	// RVA: 0x6953E0 Offset: 0x6939E0 VA: 0x1806953E0 Slot: 6
	public void OnDisconnected(DisconnectCause cause) { }

	// RVA: 0x696070 Offset: 0x694670 VA: 0x180696070 Slot: 7
	public void OnRegionListReceived(RegionHandler regionHandler) { }

	// RVA: 0x6960F0 Offset: 0x6946F0 VA: 0x1806960F0 Slot: 24
	public void OnRoomListUpdate(List<RoomInfo> roomList) { }

	// RVA: 0x695E50 Offset: 0x694450 VA: 0x180695E50 Slot: 17
	public void OnPlayerEnteredRoom(Player newPlayer) { }

	// RVA: 0x695F20 Offset: 0x694520 VA: 0x180695F20 Slot: 18
	public void OnPlayerLeftRoom(Player otherPlayer) { }

	// RVA: 0x6961B0 Offset: 0x6947B0 VA: 0x1806961B0 Slot: 19
	public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

	// RVA: 0x695FF0 Offset: 0x6945F0 VA: 0x180695FF0 Slot: 20
	public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps) { }

	// RVA: 0x695D80 Offset: 0x694380 VA: 0x180695D80 Slot: 21
	public void OnMasterClientSwitched(Player newMasterClient) { }

	// RVA: 0x6951D0 Offset: 0x6937D0 VA: 0x1806951D0 Slot: 8
	public void OnCustomAuthenticationResponse(Dictionary<string, object> data) { }

	// RVA: 0x695130 Offset: 0x693730 VA: 0x180695130 Slot: 9
	public void OnCustomAuthenticationFailed(string debugMessage) { }

	// RVA: 0x695D00 Offset: 0x694300 VA: 0x180695D00 Slot: 25
	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	// RVA: 0x695530 Offset: 0x693B30 VA: 0x180695530 Slot: 26
	public void OnErrorInfo(ErrorInfo errorInfo) { }

	// RVA: 0x633AA0 Offset: 0x6320A0 VA: 0x180633AA0
	public void .ctor() { }
}
