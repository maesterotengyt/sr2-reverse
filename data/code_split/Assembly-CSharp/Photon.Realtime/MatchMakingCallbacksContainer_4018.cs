// Namespace: Photon.Realtime
public class MatchMakingCallbacksContainer : List<IMatchmakingCallbacks>, IMatchmakingCallbacks // TypeDefIndex: 4018
{
	// Fields
	private readonly LoadBalancingClient client; // 0x28

	// Methods

	// RVA: 0x692EB0 Offset: 0x6914B0 VA: 0x180692EB0
	public void .ctor(LoadBalancingClient client) { }

	// RVA: 0x6924B0 Offset: 0x690AB0 VA: 0x1806924B0 Slot: 36
	public void OnCreatedRoom() { }

	// RVA: 0x692B70 Offset: 0x691170 VA: 0x180692B70 Slot: 38
	public void OnJoinedRoom() { }

	// RVA: 0x6922F0 Offset: 0x6908F0 VA: 0x1806922F0 Slot: 37
	public void OnCreateRoomFailed(short returnCode, string message) { }

	// RVA: 0x6927F0 Offset: 0x690DF0 VA: 0x1806927F0 Slot: 40
	public void OnJoinRandomFailed(short returnCode, string message) { }

	// RVA: 0x6929B0 Offset: 0x690FB0 VA: 0x1806929B0 Slot: 39
	public void OnJoinRoomFailed(short returnCode, string message) { }

	// RVA: 0x692D10 Offset: 0x691310 VA: 0x180692D10 Slot: 41
	public void OnLeftRoom() { }

	// RVA: 0x692650 Offset: 0x690C50 VA: 0x180692650 Slot: 35
	public void OnFriendListUpdate(List<FriendInfo> friendList) { }
}
