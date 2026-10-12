// Namespace: Photon.Deterministic
public class DeterministicTickInputDecoder // TypeDefIndex: 17471
{
	// Fields
	private SortedList<int, DeterministicTickInputDecoder.TrackingData> _tracking; // 0x10
	private List<DeterministicTickInputDecoder.TrackingData> _inputsMissing; // 0x18
	private List<int> _ticksMissing; // 0x20
	private ulong _playerMask; // 0x28
	private int _playerCount; // 0x30
	private int _finishedTick; // 0x34
	private int _completedHighestTick; // 0x38
	private Serializer _serializer; // 0x40
	private Stopwatch _timer; // 0x48
	private DeterministicSession _session; // 0x50

	// Methods

	// RVA: 0x20BDA40 Offset: 0x20BC040 VA: 0x1820BDA40
	public void .ctor(Serializer serializer, DeterministicSession session, int finishedTick) { }

	// RVA: 0x20BD830 Offset: 0x20BBE30 VA: 0x1820BD830
	public void ResetInputState(int tick) { }

	// RVA: 0x20BCF50 Offset: 0x20BB550 VA: 0x1820BCF50
	public InputMissing CreateInputMissing(double rtt, int maxRequestFrame) { }

	// RVA: 0x20BD4F0 Offset: 0x20BBAF0 VA: 0x1820BD4F0
	public DeterministicTickInputEncodeHeader Decode(BitStream stream, List<DeterministicTickInput> result) { }

	// RVA: 0x20BD7C0 Offset: 0x20BBDC0 VA: 0x1820BD7C0
	private double GetTime() { }

	// RVA: 0x20BD8C0 Offset: 0x20BBEC0 VA: 0x1820BD8C0
	private void UpdateTrackingData(int tick, bool complete, ulong received) { }

	// RVA: 0x20BCB60 Offset: 0x20BB160 VA: 0x1820BCB60
	private DeterministicTickInputDecoder.TrackingData CalculateTrackingData(DeterministicTickInputDecoder.TrackingData data, bool complete, ulong received) { }

	// RVA: 0x20BCB90 Offset: 0x20BB190 VA: 0x1820BCB90
	private void CheckForCompletedTicks() { }

	// RVA: 0x20BCCE0 Offset: 0x20BB2E0 VA: 0x1820BCCE0
	private void CheckForMissingInputs() { }
}
