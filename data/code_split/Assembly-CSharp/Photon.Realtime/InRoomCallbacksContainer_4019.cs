// Namespace: Photon.Realtime
internal class InRoomCallbacksContainer : List<IInRoomCallbacks>, IInRoomCallbacks // TypeDefIndex: 4019
{
	// Fields
	private readonly LoadBalancingClient client; // 0x28

	// Methods

	// RVA: 0x687B50 Offset: 0x686150 VA: 0x180687B50
	public void .ctor(LoadBalancingClient client) { }

	// RVA: 0x687490 Offset: 0x685A90 VA: 0x180687490 Slot: 35
	public void OnPlayerEnteredRoom(Player newPlayer) { }

	// RVA: 0x687630 Offset: 0x685C30 VA: 0x180687630 Slot: 36
	public void OnPlayerLeftRoom(Player otherPlayer) { }

	// RVA: 0x687990 Offset: 0x685F90 VA: 0x180687990 Slot: 37
	public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) { }

	// RVA: 0x6877E0 Offset: 0x685DE0 VA: 0x1806877E0 Slot: 38
	public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProp) { }

	// RVA: 0x6872D0 Offset: 0x6858D0 VA: 0x1806872D0 Slot: 39
	public void OnMasterClientSwitched(Player newMasterClient) { }
}
