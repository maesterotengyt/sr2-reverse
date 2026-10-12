// Namespace: Quantum
public class InputProvider : IDeterministicReplayProvider, IDeterministicRpcProvider, IDeterministicInputProvider // TypeDefIndex: 10283
{
	// Fields
	private int _playerCount; // 0x10
	private int _growSize; // 0x14
	private int _startFrame; // 0x18
	private DeterministicTickInputSet[] _inputs; // 0x20

	// Properties
	private int MaxFrame { get; }

	// Methods

	// RVA: 0x2173D40 Offset: 0x2172340 VA: 0x182173D40
	private int get_MaxFrame() { }

	// RVA: 0x2173BA0 Offset: 0x21721A0 VA: 0x182173BA0
	public void .ctor(DeterministicSessionConfig config, int capacity = 3600, int growSize = 0) { }

	// RVA: 0x2173C70 Offset: 0x2172270 VA: 0x182173C70
	public void .ctor(DeterministicTickInputSet[] inputList) { }

	// RVA: 0x2173C20 Offset: 0x2172220 VA: 0x182173C20
	public void .ctor(int playerCount, int startFrame, int capacity, int growSize) { }

	// RVA: 0x21736A0 Offset: 0x2171CA0 VA: 0x1821736A0
	public void Clear(int startFrame) { }

	// RVA: 0x2173950 Offset: 0x2171F50 VA: 0x182173950
	public void ImportFromList(DeterministicTickInputSet[] inputList) { }

	// RVA: 0x2173A20 Offset: 0x2172020 VA: 0x182173A20
	public void OnInputConfirmed(QuantumGame game, DeterministicFrameInputTemp input) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public void AddRpc(int player, byte[] data, bool command) { }

	// RVA: 0x2173620 Offset: 0x2171C20 VA: 0x182173620 Slot: 6
	public bool CanSimulate(int frame) { }

	// RVA: 0x2173860 Offset: 0x2171E60 VA: 0x182173860 Slot: 4
	public QTuple<byte[], bool> GetRpc(int frame, int player) { }

	// RVA: 0x2173790 Offset: 0x2171D90 VA: 0x182173790 Slot: 7
	public DeterministicFrameInputTemp GetInput(int frame, int player) { }

	// RVA: 0x2173B90 Offset: 0x2172190 VA: 0x182173B90
	private int ToIndex(int frame) { }

	// RVA: 0x2173430 Offset: 0x2171A30 VA: 0x182173430
	private void Allocate(int size) { }
}
