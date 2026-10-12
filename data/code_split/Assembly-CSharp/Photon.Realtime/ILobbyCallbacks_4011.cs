// Namespace: Photon.Realtime
public interface ILobbyCallbacks // TypeDefIndex: 4011
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnJoinedLobby();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnLeftLobby();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnRoomListUpdate(List<RoomInfo> roomList);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics);
}
