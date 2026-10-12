// Namespace: Photon.Realtime
public class ConnectionCallbacksContainer : List<IConnectionCallbacks>, IConnectionCallbacks // TypeDefIndex: 4017
{
	// Fields
	private readonly LoadBalancingClient client; // 0x28

	// Methods

	// RVA: 0x686F70 Offset: 0x685570 VA: 0x180686F70
	public void .ctor(LoadBalancingClient client) { }

	// RVA: 0x6866D0 Offset: 0x684CD0 VA: 0x1806866D0 Slot: 35
	public void OnConnected() { }

	// RVA: 0x686530 Offset: 0x684B30 VA: 0x180686530 Slot: 36
	public void OnConnectedToMaster() { }

	// RVA: 0x686DB0 Offset: 0x6853B0 VA: 0x180686DB0 Slot: 38
	public void OnRegionListReceived(RegionHandler regionHandler) { }

	// RVA: 0x686BF0 Offset: 0x6851F0 VA: 0x180686BF0 Slot: 37
	public void OnDisconnected(DisconnectCause cause) { }

	// RVA: 0x686A30 Offset: 0x685030 VA: 0x180686A30 Slot: 39
	public void OnCustomAuthenticationResponse(Dictionary<string, object> data) { }

	// RVA: 0x686870 Offset: 0x684E70 VA: 0x180686870 Slot: 40
	public void OnCustomAuthenticationFailed(string debugMessage) { }
}
