// Namespace: Photon.Realtime
internal class WebRpcCallbacksContainer : List<IWebRpcCallback>, IWebRpcCallback // TypeDefIndex: 4021
{
	// Fields
	private LoadBalancingClient client; // 0x28

	// Methods

	// RVA: 0x6A4B10 Offset: 0x6A3110 VA: 0x1806A4B10
	public void .ctor(LoadBalancingClient client) { }

	// RVA: 0x6A4970 Offset: 0x6A2F70 VA: 0x1806A4970 Slot: 35
	public void OnWebRpcResponse(OperationResponse response) { }
}
