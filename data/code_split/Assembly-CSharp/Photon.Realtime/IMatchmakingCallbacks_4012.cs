// Namespace: Photon.Realtime
public interface IMatchmakingCallbacks // TypeDefIndex: 4012
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnFriendListUpdate(List<FriendInfo> friendList);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCreatedRoom();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCreateRoomFailed(short returnCode, string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnJoinedRoom();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnJoinRoomFailed(short returnCode, string message);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnJoinRandomFailed(short returnCode, string message);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnLeftRoom();
}
