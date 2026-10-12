// Namespace: Photon.Deterministic
internal class DeterministicNetwork : IDeterministicNetwork, IDeterministicRpcProvider // TypeDefIndex: 17501
{
	// Fields
	private ICommunicator _communicator; // 0x10
	private int[] _serverActorNr; // 0x18
	private double _lastSeenServerTime; // 0x20
	private List<DeterministicTickInput> _sendBuffer; // 0x28
	private LinkedList<DeterministicTickInput[]> _staggerBuffer; // 0x30
	private Queue<Message> _protocolMessageSendQueue; // 0x38
	private Queue<Message> _simulationMessageSendQueue; // 0x40
	private NetworkQueue<DeterministicTickInput> _inputReceiveQueue; // 0x48
	private DeterministicSession _session; // 0x50
	private Serializer _serializer; // 0x58
	private Dispatcher<Message> _dispatcher; // 0x60
	private BitStream _writeStream; // 0x68
	private BitStream _readStream; // 0x70
	private BitStream _inputWriteStream; // 0x78
	private byte[] _inputWriteStreamTemp; // 0x80
	private RingBuffer<DeterministicNetwork.NetworkSend> _inputWriteOffsets; // 0x88
	private DeterministicTickInput _inputWrite; // 0x90
	private List<DeterministicTickInput> _decodeResult; // 0x98
	private DeterministicTickInputDecoder _decoder; // 0xA0
	private Stopwatch _timer; // 0xA8
	private NetworkQueue<DeterministicNetwork.NetworkEvent> _eventQueue; // 0xB0

	// Properties
	public int RoundTripTime { get; }
	public NetworkQueue<DeterministicTickInput> InputReceiveQueue { get; }

	// Methods

	// RVA: 0x20B38E0 Offset: 0x20B1EE0 VA: 0x1820B38E0
	public void .ctor(DeterministicSession session, ICommunicator communicator) { }

	// RVA: 0x20B3FA0 Offset: 0x20B25A0 VA: 0x1820B3FA0 Slot: 4
	public int get_RoundTripTime() { }

	// RVA: 0x5C9FA0 Offset: 0x5C85A0 VA: 0x1805C9FA0 Slot: 5
	public NetworkQueue<DeterministicTickInput> get_InputReceiveQueue() { }

	// RVA: 0x20B3660 Offset: 0x20B1C60 VA: 0x1820B3660 Slot: 8
	public void SendLocalRtt(int rtt) { }

	// RVA: 0x20B30D0 Offset: 0x20B16D0 VA: 0x1820B30D0 Slot: 9
	public void SendLocalChecksum(int tick, ulong hash) { }

	// RVA: 0x20B3750 Offset: 0x20B1D50 VA: 0x1820B3750
	private void SendProtocolMessages() { }

	// RVA: 0x20B26D0 Offset: 0x20B0CD0 VA: 0x1820B26D0
	private void HandleProtocolEvent(DeterministicNetwork.NetworkEvent ev) { }

	// RVA: 0x20B2880 Offset: 0x20B0E80 VA: 0x1820B2880 Slot: 6
	public void Poll() { }

	// RVA: 0x20B2F80 Offset: 0x20B1580 VA: 0x1820B2F80 Slot: 12
	public void ResetInputState(int frame) { }

	// RVA: 0x20B3160 Offset: 0x20B1760 VA: 0x1820B3160 Slot: 10
	public void SendLocalInputs() { }

	// RVA: 0x20B2B20 Offset: 0x20B1120 VA: 0x1820B2B20 Slot: 11
	public void QueueLocalInput(DeterministicFrameInputTemp input) { }

	// RVA: 0x20B27C0 Offset: 0x20B0DC0 VA: 0x1820B27C0
	private void OnEventDataReceived(byte eventCode, byte[] data, int dataLength, object eventObject) { }

	// RVA: 0x20B2000 Offset: 0x20B0600 VA: 0x1820B2000
	private void DequeueNetworkRecvQueue() { }

	// RVA: 0x20B2330 Offset: 0x20B0930 VA: 0x1820B2330
	private void HandleInputEvent(DeterministicNetwork.NetworkEvent ev) { }

	// RVA: 0x20B22E0 Offset: 0x20B08E0 VA: 0x1820B22E0 Slot: 7
	public void Destroy() { }

	// RVA: 0x20B36F0 Offset: 0x20B1CF0 VA: 0x1820B36F0 Slot: 13
	public void SendProtocolMessage(Message msg) { }

	// RVA: 0x1128E00 Offset: 0x1127400 VA: 0x181128E00 Slot: 14
	public QTuple<byte[], bool> GetRpc(int frame, int player) { }

	// RVA: 0x20B1F30 Offset: 0x20B0530 VA: 0x1820B1F30 Slot: 15
	public void AddRpc(int player, byte[] data, bool command) { }
}
