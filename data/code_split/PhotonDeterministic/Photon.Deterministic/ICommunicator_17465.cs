// Namespace: Photon.Deterministic
public interface ICommunicator // TypeDefIndex: 17465
{
	// Properties
	public abstract int RoundTripTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_RoundTripTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Service();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDestroy();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void DisposeEventObject(object obj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RaiseEvent(byte eventCode, byte[] message, int messageLength, bool reliable, int[] toPlayers);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddEventListener(OnEventReceived onEventReceived);
}
