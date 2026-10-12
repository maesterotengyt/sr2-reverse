// Namespace: Photon.Realtime
internal class ErrorInfoCallbacksContainer : List<IErrorInfoCallback>, IErrorInfoCallback // TypeDefIndex: 4022
{
	// Fields
	private LoadBalancingClient client; // 0x28

	// Methods

	// RVA: 0x687190 Offset: 0x685790 VA: 0x180687190
	public void .ctor(LoadBalancingClient client) { }

	// RVA: 0x686FF0 Offset: 0x6855F0 VA: 0x180686FF0 Slot: 35
	public void OnErrorInfo(ErrorInfo errorInfo) { }
}
