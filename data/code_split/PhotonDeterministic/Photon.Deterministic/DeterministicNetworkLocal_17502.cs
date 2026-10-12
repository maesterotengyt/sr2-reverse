// Namespace: Photon.Deterministic
internal class DeterministicNetworkLocal : IDeterministicNetwork // TypeDefIndex: 17502
{
	// Fields
	private RttUpdate _rttUpdate; // 0x10
	private DeterministicSession _session; // 0x18
	private Dispatcher<Message> _outDispatcher; // 0x20
	private Dispatcher<Message> _inDispatcher; // 0x28
	private NetworkQueue<DeterministicTickInput> _inputReceiveQueue; // 0x30
	private Queue<Message> _inQueue; // 0x38
	private Queue<Message> _outQueue; // 0x40

	// Properties
	public int RoundTripTime { get; }
	public NetworkQueue<DeterministicTickInput> InputReceiveQueue { get; }

	// Methods

	// RVA: 0x81E2E0 Offset: 0x81C8E0 VA: 0x18081E2E0 Slot: 4
	public int get_RoundTripTime() { }

	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090 Slot: 5
	public NetworkQueue<DeterministicTickInput> get_InputReceiveQueue() { }

	// RVA: 0x20B1D20 Offset: 0x20B0320 VA: 0x1820B1D20
	public void .ctor(DeterministicSession session) { }

	// RVA: 0x20B1C00 Offset: 0x20B0200 VA: 0x1820B1C00 Slot: 6
	public void Poll() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 12
	public void ResetInputState(int frame) { }

	// RVA: 0x20B1CC0 Offset: 0x20B02C0 VA: 0x1820B1CC0 Slot: 13
	public void SendProtocolMessage(Message msg) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public void Destroy() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public void SendLocalInputs() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 11
	public void QueueLocalInput(DeterministicFrameInputTemp input) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public void SendLocalRtt(int rtt) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public void SendLocalChecksum(int tick, ulong checksum) { }

	// RVA: 0x20B1A60 Offset: 0x20B0060 VA: 0x1820B1A60
	private void OnJoin(Join join) { }
}
