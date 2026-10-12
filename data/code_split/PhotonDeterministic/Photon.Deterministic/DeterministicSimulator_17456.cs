// Namespace: Photon.Deterministic
internal class DeterministicSimulator // TypeDefIndex: 17456
{
	// Fields
	private DeterministicSession _session; // 0x10
	private DeterministicFrame _stateVerified; // 0x18
	private DeterministicFrame _statePredicted; // 0x20
	private DeterministicFrame _statePredictedPrevious; // 0x28
	private DeterministicFrame _statePreviousUpdatePredicted; // 0x30
	private ulong _playerMask; // 0x38
	private ulong _playerMaskLocal; // 0x40
	private ulong _playerMaskRemote; // 0x48
	private DeterministicSimulator.InputFrame _inputFrameHead; // 0x50
	private int _inputFrameCounter; // 0x58
	private int _predictedFramesLastUpdate; // 0x5C
	private int _minFramesToVerify; // 0x60
	private bool _isStalling; // 0x64
	private Stack<DeterministicSimulator.InputFrame> _inputFramePool; // 0x68
	private Dictionary<int, DeterministicSimulator.InputFrame> _inputFrameLookup; // 0x70
	private double _deltaScale; // 0x78
	private double _timeAccumulated; // 0x80
	private bool _clockPaused; // 0x88
	private List<int> _predictPlayers; // 0x90
	private byte[][] _predictInput; // 0x98
	private DeterministicInputFlags[] _predictFlags; // 0xA0

	// Properties
	public bool Paused { get; set; }
	public int FramesRemaining { get; }
	public int FrameCounter { get; }
	public int FramesPredicted { get; }
	public double Accumulated { get; }
	public double DeltaTime { get; }
	public bool IsStalling { get; set; }
	public DeterministicFrame FramePredicted { get; }
	public DeterministicFrame FramePredictedPrevious { get; }
	public DeterministicFrame FramePreviousUpdatePredicted { get; }
	public DeterministicFrame FrameVerified { get; }

	// Methods

	// RVA: 0x997FB0 Offset: 0x9965B0 VA: 0x180997FB0
	public bool get_Paused() { }

	// RVA: 0x998030 Offset: 0x996630 VA: 0x180998030
	public void set_Paused(bool value) { }

	// RVA: 0x20BCAF0 Offset: 0x20BB0F0 VA: 0x1820BCAF0
	public int get_FramesRemaining() { }

	// RVA: 0x693B20 Offset: 0x692120 VA: 0x180693B20
	public int get_FrameCounter() { }

	// RVA: 0x5DC8E0 Offset: 0x5DAEE0 VA: 0x1805DC8E0
	public int get_FramesPredicted() { }

	// RVA: 0x908270 Offset: 0x906870 VA: 0x180908270
	public double get_Accumulated() { }

	// RVA: 0x20BCAB0 Offset: 0x20BB0B0 VA: 0x1820BCAB0
	public double get_DeltaTime() { }

	// RVA: 0x20BCB40 Offset: 0x20BB140 VA: 0x1820BCB40
	public bool get_IsStalling() { }

	// RVA: 0x20BCB50 Offset: 0x20BB150 VA: 0x1820BCB50
	internal void set_IsStalling(bool value) { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public DeterministicFrame get_FramePredicted() { }

	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public DeterministicFrame get_FramePredictedPrevious() { }

	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public DeterministicFrame get_FramePreviousUpdatePredicted() { }

	// RVA: 0x20BB380 Offset: 0x20B9980 VA: 0x1820BB380
	public DeterministicFrame GetVerifiedFrame(int tick) { }

	// RVA: 0x20BB160 Offset: 0x20B9760 VA: 0x1820BB160
	internal byte[] GetExtraErrorFrameDumpData(DeterministicFrame frame) { }

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public DeterministicFrame get_FrameVerified() { }

	// RVA: 0x20BCA70 Offset: 0x20BB070 VA: 0x1820BCA70
	public void .ctor(DeterministicSession session) { }

	// RVA: 0x20BB9F0 Offset: 0x20B9FF0 VA: 0x1820BB9F0
	public bool IsFrameVerified(int frame) { }

	// RVA: 0x20BA330 Offset: 0x20B8930 VA: 0x1820BA330
	public void AccumulateTime(double dt) { }

	// RVA: 0x20BA4E0 Offset: 0x20B8AE0 VA: 0x1820BA4E0
	public void AdjustClock(double dt) { }

	// RVA: 0x20BC9A0 Offset: 0x20BAFA0 VA: 0x1820BC9A0
	public bool StepFrameNumber(out int frame) { }

	// RVA: 0x20BC930 Offset: 0x20BAF30 VA: 0x1820BC930
	public bool StepFrameNumberDown(int count = 1) { }

	// RVA: 0x20BA970 Offset: 0x20B8F70 VA: 0x1820BA970
	public DeterministicFrame CreateStateFrame(IDisposable context, int number) { }

	// RVA: 0x20BB7D0 Offset: 0x20B9DD0 VA: 0x1820BB7D0
	public void InsertInput(DeterministicFrameInputTemp input) { }

	// RVA: 0x20BA700 Offset: 0x20B8D00 VA: 0x1820BA700
	public void CheckIsStalling(int maxVerifiedTicks) { }

	// RVA: 0x20BA900 Offset: 0x20B8F00 VA: 0x1820BA900
	private void CopyPreviousUpdatePredicted(DeterministicFrame fromState) { }

	// RVA: 0x20BC6D0 Offset: 0x20BACD0 VA: 0x1820BC6D0
	public void Simulate(int maxVerifiedTicks) { }

	// RVA: 0x20BBA10 Offset: 0x20BA010 VA: 0x1820BBA10
	public void OnGameStart() { }

	// RVA: 0x20BB450 Offset: 0x20B9A50 VA: 0x1820BB450
	public void Initialize(IDisposable context) { }

	// RVA: 0x20BC360 Offset: 0x20BA960 VA: 0x1820BC360
	public void Reset(DeterministicFrame frame, bool resetInputFrame) { }

	// RVA: 0x20BC2B0 Offset: 0x20BA8B0 VA: 0x1820BC2B0
	public void Reset(byte[] frameData, Nullable<int> frameNumber, bool resetInputFrame) { }

	// RVA: 0x20BBFC0 Offset: 0x20BA5C0 VA: 0x1820BBFC0
	private void ResetFrames(bool resetInputFrame) { }

	// RVA: 0x20BC5C0 Offset: 0x20BABC0 VA: 0x1820BC5C0
	private void Simulate(DeterministicSimulator.InputFrame f, DeterministicFrame state, bool predicted) { }

	// RVA: 0x20BBC90 Offset: 0x20BA290 VA: 0x1820BBC90
	private void PredictInput(DeterministicSimulator.InputFrame f) { }

	// RVA: 0x20BC0A0 Offset: 0x20BA6A0 VA: 0x1820BC0A0
	private void ResetInputFrameHead(int frame, bool resetInputFrame = False) { }

	// RVA: 0x20BC3A0 Offset: 0x20BA9A0 VA: 0x1820BC3A0
	private bool SimulateVerified(int maxTicks) { }

	// RVA: 0x20BA500 Offset: 0x20B8B00 VA: 0x1820BA500
	private void ApplyInputToStateFrame(DeterministicSimulator.InputFrame inputFrame, DeterministicFrame state, bool predicted) { }

	// RVA: 0x20BC1C0 Offset: 0x20BA7C0 VA: 0x1820BC1C0
	private void ResetStateFrame(DeterministicFrame target, DeterministicFrame source) { }

	// RVA: 0x20BB240 Offset: 0x20B9840 VA: 0x1820BB240
	private DeterministicSimulator.InputFrame GetInputFrame(int frame) { }

	// RVA: 0x20BA350 Offset: 0x20B8950 VA: 0x1820BA350
	private DeterministicSimulator.InputFrame AcquireInputFrame(int frame) { }

	// RVA: 0x20BBF00 Offset: 0x20BA500 VA: 0x1820BBF00
	private void ReleaseInputFrame(DeterministicSimulator.InputFrame f) { }

	// RVA: 0x20BAA70 Offset: 0x20B9070 VA: 0x1820BAA70
	private void DestroyAllInputFrames() { }

	// RVA: 0x20BAE60 Offset: 0x20B9460 VA: 0x1820BAE60
	public void Destroy() { }

	// RVA: 0x20BA820 Offset: 0x20B8E20 VA: 0x1820BA820
	public void ChecksumError(DeterministicTickChecksumError error) { }
}
