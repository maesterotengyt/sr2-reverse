// Namespace: 
public class PhotonCallbacks : IOnEventCallback, IConnectionCallbacks, IInRoomCallbacks, ILobbyCallbacks, IMatchmakingCallbacks // TypeDefIndex: 3387
{
	// Properties
	private StellarOnlineSystem onlineSystem { get; }
	private NetworkClient client { get; }

	// Methods

	// RVA: 0x5CF9A0 Offset: 0x5CDFA0 VA: 0x1805CF9A0
	private StellarOnlineSystem get_onlineSystem() { }

	// RVA: 0x5CF950 Offset: 0x5CDF50 VA: 0x1805CF950
	private NetworkClient get_client() { }

	// RVA: 0x5CED30 Offset: 0x5CD330 VA: 0x1805CED30
	public void Initialization() { }

	// RVA: 0x5CECC0 Offset: 0x5CD2C0 VA: 0x1805CECC0
	public void Clean() { }

	// RVA: 0x5CF030 Offset: 0x5CD630 VA: 0x1805CF030 Slot: 27
	public virtual void OnEvent(EventData photonEvent) { }

	// RVA: 0x5CEDF0 Offset: 0x5CD3F0 VA: 0x1805CEDF0 Slot: 6
	public void OnConnectedToMaster() { }

	// RVA: 0x5CF6B0 Offset: 0x5CDCB0 VA: 0x1805CF6B0 Slot: 8
	public void OnRegionListReceived(RegionHandler regionHandler) { }

	// RVA: 0x5CEEE0 Offset: 0x5CD4E0 VA: 0x1805CEEE0 Slot: 7
	public void OnDisconnected(DisconnectCause cause) { }

	// RVA: 0x5CF180 Offset: 0x5CD780 VA: 0x1805CF180 Slot: 28
	public virtual void OnJoinedLobby() { }

	// RVA: 0x5CF1D0 Offset: 0x5CD7D0 VA: 0x1805CF1D0 Slot: 29
	public virtual void OnJoinedRoom() { }

	// RVA: 0x5CF0E0 Offset: 0x5CD6E0 VA: 0x1805CF0E0 Slot: 30
	public virtual void OnJoinRoomFailed(short returnCode, string message) { }

	// RVA: 0x5CEE40 Offset: 0x5CD440 VA: 0x1805CEE40 Slot: 31
	public virtual void OnCreateRoomFailed(short returnCode, string message) { }

	// RVA: 0x5CF240 Offset: 0x5CD840 VA: 0x1805CF240 Slot: 32
	public virtual void OnLeftRoom() { }

	// RVA: 0x5CF290 Offset: 0x5CD890 VA: 0x1805CF290 Slot: 15
	public void OnMasterClientSwitched(Player newMasterClient) { }

	// RVA: 0x5CF3F0 Offset: 0x5CD9F0 VA: 0x1805CF3F0 Slot: 33
	public virtual void OnPlayerEnteredRoom(Player newPlayer) { }

	// RVA: 0x5CF550 Offset: 0x5CDB50 VA: 0x1805CF550 Slot: 34
	public virtual void OnPlayerLeftRoom(Player otherPlayer) { }

	// RVA: 0x5CF660 Offset: 0x5CDC60 VA: 0x1805CF660 Slot: 35
	public virtual void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps) { }

	// RVA: 0x5CF710 Offset: 0x5CDD10 VA: 0x1805CF710 Slot: 36
	public virtual void OnRoomListUpdate(List<RoomInfo> roomList) { }

	// RVA: 0x5CF8D0 Offset: 0x5CDED0 VA: 0x1805CF8D0 Slot: 37
	public virtual void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public void OnConnected() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public void OnCustomAuthenticationResponse(Dictionary<string, object> data) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public void OnCustomAuthenticationFailed(string debugMessage) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 38
	public virtual void OnLeftLobby() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 39
	public virtual void OnCreatedRoom() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 40
	public virtual void OnJoinRandomFailed(short returnCode, string message) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 41
	public virtual void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 42
	public virtual void OnFriendListUpdate(List<FriendInfo> friendList) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
