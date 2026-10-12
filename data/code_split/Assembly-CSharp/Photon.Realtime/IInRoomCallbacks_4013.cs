// Namespace: Photon.Realtime
public interface IInRoomCallbacks // TypeDefIndex: 4013
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPlayerEnteredRoom(Player newPlayer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPlayerLeftRoom(Player otherPlayer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnMasterClientSwitched(Player newMasterClient);
}
