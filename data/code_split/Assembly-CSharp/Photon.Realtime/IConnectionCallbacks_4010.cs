// Namespace: Photon.Realtime
public interface IConnectionCallbacks // TypeDefIndex: 4010
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConnected();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConnectedToMaster();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDisconnected(DisconnectCause cause);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnRegionListReceived(RegionHandler regionHandler);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnCustomAuthenticationResponse(Dictionary<string, object> data);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnCustomAuthenticationFailed(string debugMessage);
}
