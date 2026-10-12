// Namespace: Photon.Deterministic
internal interface IDeterministicNetwork // TypeDefIndex: 17506
{
	// Properties
	public abstract int RoundTripTime { get; }
	public abstract NetworkQueue<DeterministicTickInput> InputReceiveQueue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_RoundTripTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract NetworkQueue<DeterministicTickInput> get_InputReceiveQueue();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Poll();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Destroy();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SendLocalRtt(int rtt);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SendLocalChecksum(int tick, ulong checksum);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendLocalInputs();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void QueueLocalInput(DeterministicFrameInputTemp input);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ResetInputState(int frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SendProtocolMessage(Message msg);
}
