// Namespace: Photon.Deterministic
public class LocalInputProvider : IDeterministicInputProvider, IDeterministicRpcProvider // TypeDefIndex: 17477
{
	// Fields
	private IDeterministicGame _game; // 0x10
	private Dictionary<int, Queue<QTuple<byte[], bool>>> _rpcQueues; // 0x18

	// Methods

	// RVA: 0x20BEB80 Offset: 0x20BD180 VA: 0x1820BEB80
	public void .ctor(IDeterministicGame game) { }

	// RVA: 0x534CD0 Offset: 0x5332D0 VA: 0x180534CD0 Slot: 4
	public bool CanSimulate(int frame) { }

	// RVA: 0x20BE970 Offset: 0x20BCF70 VA: 0x1820BE970 Slot: 5
	public DeterministicFrameInputTemp GetInput(int frame, int player) { }

	// RVA: 0x20BEAE0 Offset: 0x20BD0E0 VA: 0x1820BEAE0 Slot: 6
	public QTuple<byte[], bool> GetRpc(int frame, int player) { }

	// RVA: 0x20BE690 Offset: 0x20BCC90 VA: 0x1820BE690 Slot: 7
	public void AddRpc(int player, byte[] data, bool command) { }

	// RVA: 0x20BEA00 Offset: 0x20BD000 VA: 0x1820BEA00
	private Queue<QTuple<byte[], bool>> GetRpcQueue(int player) { }
}
