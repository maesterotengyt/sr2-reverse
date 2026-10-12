// Namespace: Photon.Realtime
internal class LobbyCallbacksContainer : List<ILobbyCallbacks>, ILobbyCallbacks // TypeDefIndex: 4020
{
	// Fields
	private readonly LoadBalancingClient client; // 0x28

	// Methods

	// RVA: 0x692270 Offset: 0x690870 VA: 0x180692270
	public void .ctor(LoadBalancingClient client) { }

	// RVA: 0x691BB0 Offset: 0x6901B0 VA: 0x180691BB0 Slot: 35
	public void OnJoinedLobby() { }

	// RVA: 0x691D50 Offset: 0x690350 VA: 0x180691D50 Slot: 36
	public void OnLeftLobby() { }

	// RVA: 0x6920B0 Offset: 0x6906B0 VA: 0x1806920B0 Slot: 37
	public void OnRoomListUpdate(List<RoomInfo> roomList) { }

	// RVA: 0x691EF0 Offset: 0x6904F0 VA: 0x180691EF0 Slot: 38
	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) { }
}
