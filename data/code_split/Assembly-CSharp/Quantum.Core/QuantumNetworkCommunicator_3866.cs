// Namespace: Quantum.Core
public class QuantumNetworkCommunicator : ICommunicator // TypeDefIndex: 3866
{
	// Fields
	public QuantumNetworkCommunicator.QuitBehaviour ThisQuitBehaviour; // 0x10
	private readonly ByteArraySlice _sendSlice; // 0x18
	private readonly RaiseEventOptions _eventOptions; // 0x20
	private readonly LoadBalancingClient _loadBalancingClient; // 0x28
	private readonly Dictionary<byte, object> _parameters; // 0x30
	private Action<EventData> _lastEventCallback; // 0x38

	// Properties
	public bool IsConnected { get; }
	public int RoundTripTime { get; }
	public byte LocalPLayerId { get; }

	// Methods

	// RVA: 0x67E3B0 Offset: 0x67C9B0 VA: 0x18067E3B0 Slot: 10
	public bool get_IsConnected() { }

	// RVA: 0x67E400 Offset: 0x67CA00 VA: 0x18067E400 Slot: 4
	public int get_RoundTripTime() { }

	// RVA: 0x67E3D0 Offset: 0x67C9D0 VA: 0x18067E3D0 Slot: 11
	public byte get_LocalPLayerId() { }

	// RVA: 0x67E1D0 Offset: 0x67C7D0 VA: 0x18067E1D0
	internal void .ctor(LoadBalancingClient loadBalancingClient, QuantumNetworkCommunicator.QuitBehaviour quitBehavior) { }

	// RVA: 0x67DF40 Offset: 0x67C540 VA: 0x18067DF40 Slot: 7
	public void DisposeEventObject(object obj) { }

	// RVA: 0x67E050 Offset: 0x67C650 VA: 0x18067E050 Slot: 8
	public void RaiseEvent(byte eventCode, byte[] message, int messageLength, bool reliable, int[] toPlayers) { }

	// RVA: 0x67DE30 Offset: 0x67C430 VA: 0x18067DE30 Slot: 9
	public void AddEventListener(OnEventReceived onEventReceived) { }

	// RVA: 0x67E1B0 Offset: 0x67C7B0 VA: 0x18067E1B0 Slot: 5
	public void Service() { }

	// RVA: 0x67E160 Offset: 0x67C760 VA: 0x18067E160 Slot: 12
	public void RemoveEventListener() { }

	// RVA: 0x67DFB0 Offset: 0x67C5B0 VA: 0x18067DFB0 Slot: 6
	public void OnDestroy() { }
}
