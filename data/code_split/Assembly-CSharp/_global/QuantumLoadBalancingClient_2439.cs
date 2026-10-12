// Namespace: 
public class QuantumLoadBalancingClient : LoadBalancingClient, IConnectionCallbacks // TypeDefIndex: 2439
{
	// Fields
	public static string BestRegionSummaryKey; // 0x0

	// Methods

	// RVA: 0x52F710 Offset: 0x52DD10 VA: 0x18052F710
	public void .ctor(ConnectionProtocol protocol = 0) { }

	// RVA: 0x52F540 Offset: 0x52DB40 VA: 0x18052F540 Slot: 25
	public virtual bool ConnectUsingSettings(AppSettings appSettings, string nickname) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 19
	public void OnConnected() { }

	// RVA: 0x52F610 Offset: 0x52DC10 VA: 0x18052F610 Slot: 20
	public void OnConnectedToMaster() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 21
	public void OnDisconnected(DisconnectCause cause) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 22
	public void OnRegionListReceived(RegionHandler regionHandler) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 23
	public void OnCustomAuthenticationResponse(Dictionary<string, object> data) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 24
	public void OnCustomAuthenticationFailed(string debugMessage) { }

	// RVA: 0x52F6A0 Offset: 0x52DCA0 VA: 0x18052F6A0
	private static void .cctor() { }
}
