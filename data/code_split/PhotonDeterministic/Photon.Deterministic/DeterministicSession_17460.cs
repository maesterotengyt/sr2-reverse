// Namespace: Photon.Deterministic
public class DeterministicSession // TypeDefIndex: 17460
{
	// Fields
	internal List<FrameSnapshot> _snapshots; // 0x10
	internal byte[] _frameData; // 0x18
	internal int _initialTick; // 0x20
	private byte[] _runtimeConfig; // 0x28
	private byte[] _runtimeConfigLocal; // 0x30
	private DeterministicSessionConfig _sessionConfig; // 0x38
	private DeterministicSessionConfig _sessionConfigLocal; // 0x40
	private HashSet<int> _localPlayersSet; // 0x48
	private IDisposable _frameContext; // 0x50
	internal IDeterministicNetwork _network; // 0x58
	private IDeterministicRpcProvider _rpcProvider; // 0x60
	private IDeterministicInputProvider _inputProvider; // 0x68
	private int _simulatorInputOffset; // 0x70
	private int _simulatorInputOffsetPrevious; // 0x74
	private DeterministicSimulator _simulator; // 0x78
	private DeterministicTickChecksumError _checksumError; // 0x80
	private DeterministicCommandSerializer _commandSerializer; // 0x88
	private DeterministicGameMode _mode; // 0x90
	private DeterministicSessionState _state; // 0x94
	private DeltaClock _deltaClock; // 0x98
	private Stopwatch _syncClockTimer; // 0xA0
	private Stopwatch _statsUpdateTimer; // 0xA8
	private Stopwatch _rttSyncTimer; // 0xB0
	private bool _lockstep; // 0xB8
	private bool _disableInterpolatableStates; // 0xB9
	private bool _reconnect; // 0xBA
	private double _serverTimeReceived; // 0xC0
	private double _serverTimeAdjusted; // 0xC8
	private double _lastRttSync; // 0xD0
	private double _timeScale; // 0xD8
	private List<double> _clientRttAvg; // 0xE0
	private List<double> _serverTimeAvgDiff; // 0xE8
	private int _maxClientRtt; // 0xF0
	private int[] _localPlayerIndices; // 0xF8
	private DeterministicStats _stats; // 0x100
	private IDeterministicGame _game; // 0x108
	private IDeterministicReplayProvider _replayProvider; // 0x110
	private DeterministicPlatformInfo _platformInfo; // 0x118
	private DeterministicTickInput.Pool _inputPool; // 0x120
	private Dictionary<int, ChecksumErrorFrameDump> _checksumErrorFrameDumps; // 0x128
	private int _maxVerifiedTicksPerUpdate; // 0x130
	private double _spectatingOffsetSec; // 0x138
	[CompilerGenerated]
	private IDisposable <Runner>k__BackingField; // 0x140

	// Properties
	public int MaxVerifiedTicksPerUpdate { get; }
	public byte[] RuntimeConfig { get; }
	public DeterministicStats Stats { get; }
	public IDeterministicGame Game { get; }
	public DeterministicFrame FramePredicted { get; }
	public DeterministicFrame FramePredictedPrevious { get; }
	public DeterministicFrame FrameVerified { get; }
	public DeterministicFrame PreviousUpdateFramePredicted { get; }
	public DeterministicSessionConfig SessionConfig { get; }
	public double AccumulatedTime { get; }
	public int InitialTick { get; }
	public int[] LocalPlayerIndices { get; }
	public int PlayerCount { get; }
	public int RollbackWindow { get; }
	public int PredictedFrames { get; }
	public FP DeltaTime { get; }
	public double DeltaTimeDouble { get; }
	public DeterministicGameMode GameMode { get; }
	public bool IsOnline { get; }
	public bool IsSpectating { get; }
	public bool IsStalling { get; }
	public bool IsPaused { get; }
	public bool IsLockstep { get; }
	public bool IsPredicted { get; }
	public bool IsReplay { get; }
	public bool IsInterpolatable { get; }
	internal DeterministicSessionState State { get; }
	public IDeterministicReplayProvider ReplayProvider { get; }
	public DeterministicPlatformInfo PlatformInfo { get; }
	public DeterministicCommandSerializer CommandSerializer { get; }
	public IDisposable Runner { get; set; }
	private int ClockAdjustmentAccumulationMax { get; }
	internal int NextFrame { get; }
	public DeterministicTickInput.Pool InputPool { get; }

	// Methods

	// RVA: 0x1CA2B60 Offset: 0x1CA1160 VA: 0x181CA2B60
	internal void OnProtocolRttUpdate(int Rtt) { }

	// RVA: 0x20B6750 Offset: 0x20B4D50 VA: 0x1820B6750
	internal void OnProtocolRuntimeConfig(RuntimeConfig msg) { }

	// RVA: 0x20B67F0 Offset: 0x20B4DF0 VA: 0x1820B67F0
	internal void OnProtocolSessionConfig(SessionConfig msg) { }

	// RVA: 0x20B6890 Offset: 0x20B4E90 VA: 0x1820B6890
	internal void OnProtocolSimulationStart(SimulationStart msg) { }

	// RVA: 0x20B6280 Offset: 0x20B4880 VA: 0x1820B6280
	internal void OnProtocolDisconnect(Disconnect msg) { }

	// RVA: 0x20B5C00 Offset: 0x20B4200 VA: 0x1820B5C00
	internal void OnProtocolChecksumError(TickChecksumError msg) { }

	// RVA: 0x20B62F0 Offset: 0x20B48F0 VA: 0x1820B62F0
	internal void OnProtocolFrameSnapshotRequest(FrameSnapshotRequest msg) { }

	// RVA: 0x20B6460 Offset: 0x20B4A60 VA: 0x1820B6460
	internal void OnProtocolFrameSnapshot(FrameSnapshot msg) { }

	// RVA: 0x20B7F80 Offset: 0x20B6580 VA: 0x1820B7F80
	private void SendSnapshot(int referenceTick) { }

	// RVA: 0x20B6ED0 Offset: 0x20B54D0 VA: 0x1820B6ED0
	internal void OnTickChecksumErrorFrameDump(TickChecksumErrorFrameDump msg) { }

	// RVA: 0x20B6140 Offset: 0x20B4740 VA: 0x1820B6140
	internal void OnProtocolClockCorrect(double ServerSeconds, double ServerTimeScale) { }

	// RVA: 0x20B65C0 Offset: 0x20B4BC0 VA: 0x1820B65C0
	internal void OnProtocolJoined(Joined msg) { }

	// RVA: 0x873CA0 Offset: 0x8722A0 VA: 0x180873CA0
	public int get_MaxVerifiedTicksPerUpdate() { }

	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public byte[] get_RuntimeConfig() { }

	// RVA: 0x502360 Offset: 0x500960 VA: 0x180502360
	public DeterministicStats get_Stats() { }

	// RVA: 0x7A8180 Offset: 0x7A6780 VA: 0x1807A8180
	public IDeterministicGame get_Game() { }

	// RVA: 0x20B9E00 Offset: 0x20B8400 VA: 0x1820B9E00
	public DeterministicFrame get_FramePredicted() { }

	// RVA: 0x20B9DE0 Offset: 0x20B83E0 VA: 0x1820B9DE0
	public DeterministicFrame get_FramePredictedPrevious() { }

	// RVA: 0x20B9E20 Offset: 0x20B8420 VA: 0x1820B9E20
	public DeterministicFrame get_FrameVerified() { }

	// RVA: 0x20B9F40 Offset: 0x20B8540 VA: 0x1820B9F40
	public DeterministicFrame get_PreviousUpdateFramePredicted() { }

	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public DeterministicSessionConfig get_SessionConfig() { }

	// RVA: 0x20B9D50 Offset: 0x20B8350 VA: 0x1820B9D50
	public double get_AccumulatedTime() { }

	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_InitialTick() { }

	// RVA: 0x691600 Offset: 0x68FC00 VA: 0x180691600
	public int[] get_LocalPlayerIndices() { }

	// RVA: 0x20B9F00 Offset: 0x20B8500 VA: 0x1820B9F00
	public int get_PlayerCount() { }

	// RVA: 0x20B9F60 Offset: 0x20B8560 VA: 0x1820B9F60
	public int get_RollbackWindow() { }

	// RVA: 0x20B9F20 Offset: 0x20B8520 VA: 0x1820B9F20
	public int get_PredictedFrames() { }

	// RVA: 0x20B9DC0 Offset: 0x20B83C0 VA: 0x1820B9DC0
	public FP get_DeltaTime() { }

	// RVA: 0x20B9D90 Offset: 0x20B8390 VA: 0x1820B9D90
	public double get_DeltaTimeDouble() { }

	// RVA: 0x54C340 Offset: 0x54A940 VA: 0x18054C340
	public DeterministicGameMode get_GameMode() { }

	// RVA: 0x20B9E50 Offset: 0x20B8450 VA: 0x1820B9E50
	public bool get_IsOnline() { }

	// RVA: 0x20B9EB0 Offset: 0x20B84B0 VA: 0x1820B9EB0
	public bool get_IsSpectating() { }

	// RVA: 0x20B9EC0 Offset: 0x20B84C0 VA: 0x1820B9EC0
	public bool get_IsStalling() { }

	// RVA: 0x20B9E70 Offset: 0x20B8470 VA: 0x1820B9E70
	public bool get_IsPaused() { }

	// RVA: 0x7413E0 Offset: 0x73F9E0 VA: 0x1807413E0
	public bool get_IsLockstep() { }

	// RVA: 0x20B9E90 Offset: 0x20B8490 VA: 0x1820B9E90
	public bool get_IsPredicted() { }

	// RVA: 0x20B9EA0 Offset: 0x20B84A0 VA: 0x1820B9EA0
	public bool get_IsReplay() { }

	// RVA: 0x20B9E40 Offset: 0x20B8440 VA: 0x1820B9E40
	public bool get_IsInterpolatable() { }

	// RVA: 0x891640 Offset: 0x88FC40 VA: 0x180891640
	internal DeterministicSessionState get_State() { }

	// RVA: 0x691700 Offset: 0x68FD00 VA: 0x180691700
	public IDeterministicReplayProvider get_ReplayProvider() { }

	// RVA: 0x502340 Offset: 0x500940 VA: 0x180502340
	public DeterministicPlatformInfo get_PlatformInfo() { }

	// RVA: 0x531670 Offset: 0x52FC70 VA: 0x180531670
	public DeterministicCommandSerializer get_CommandSerializer() { }

	[CompilerGenerated]
	// RVA: 0x7A8100 Offset: 0x7A6700 VA: 0x1807A8100
	public IDisposable get_Runner() { }

	[CompilerGenerated]
	// RVA: 0x11171C0 Offset: 0x11157C0 VA: 0x1811171C0
	public void set_Runner(IDisposable value) { }

	// RVA: 0x20B9D70 Offset: 0x20B8370 VA: 0x1820B9D70
	private int get_ClockAdjustmentAccumulationMax() { }

	// RVA: 0x20B9EE0 Offset: 0x20B84E0 VA: 0x1820B9EE0
	internal int get_NextFrame() { }

	// RVA: 0x7A8190 Offset: 0x7A6790 VA: 0x1807A8190
	public DeterministicTickInput.Pool get_InputPool() { }

	// RVA: 0x20B9420 Offset: 0x20B7A20 VA: 0x1820B9420
	public void .ctor(DeterministicSessionArgs args) { }

	// RVA: 0x20B59F0 Offset: 0x20B3FF0 VA: 0x1820B59F0
	public void GetLocalConfigs(out DeterministicSessionConfig sessionConfig, out byte[] runtimeConfig) { }

	// RVA: 0x20B5340 Offset: 0x20B3940 VA: 0x1820B5340
	internal Dispatcher<Message> CreateNetworkMessageDispatcher() { }

	// RVA: 0x20B5A30 Offset: 0x20B4030 VA: 0x1820B5A30
	public bool IsFrameVerified(int frame) { }

	// RVA: 0x20B5A50 Offset: 0x20B4050 VA: 0x1820B5A50
	public bool IsLocalPlayer(int player) { }

	// RVA: 0x20B7C10 Offset: 0x20B6210 VA: 0x1820B7C10
	public void SendCommand(int player, DeterministicCommand command) { }

	// RVA: 0x20B80E0 Offset: 0x20B66E0 VA: 0x1820B80E0
	public void SetPlayerData(int player, byte[] data) { }

	// RVA: 0x20B5AB0 Offset: 0x20B40B0 VA: 0x1820B5AB0
	public void Join(string id, int playerSlots) { }

	// RVA: 0x20B56F0 Offset: 0x20B3CF0 VA: 0x1820B56F0
	public void Destroy() { }

	// RVA: 0x20B9400 Offset: 0x20B7A00 VA: 0x1820B9400
	public void Update(Nullable<double> deltaTime) { }

	// RVA: 0x20B58B0 Offset: 0x20B3EB0 VA: 0x1820B58B0
	private double FramesAsSeconds(int frames) { }

	// RVA: 0x20B5BF0 Offset: 0x20B41F0 VA: 0x1820B5BF0
	private double MillisecondsAsSeconds(double milliseconds) { }

	// RVA: 0x20B81E0 Offset: 0x20B67E0 VA: 0x1820B81E0
	private static double SumList(List<double> list) { }

	// RVA: 0x20B7410 Offset: 0x20B5A10 VA: 0x1820B7410
	private void PerformClockAdjustment() { }

	// RVA: 0x20B58F0 Offset: 0x20B3EF0 VA: 0x1820B58F0
	private double GetDeltaTime(Nullable<double> deltaTime) { }

	// RVA: 0x20B7A30 Offset: 0x20B6030 VA: 0x1820B7A30
	public void ResetReplay(DeterministicFrame frame) { }

	// RVA: 0x20B7BF0 Offset: 0x20B61F0 VA: 0x1820B7BF0
	public void Resync(byte[] frameData, int frameNumber) { }

	// RVA: 0x20B7A80 Offset: 0x20B6080 VA: 0x1820B7A80
	private void Reset(byte[] frameData, int frameNumber, bool resetInputFrame) { }

	// RVA: 0x20B7B90 Offset: 0x20B6190 VA: 0x1820B7B90
	private void Reset(DeterministicFrame frame, bool resetInputFrame) { }

	// RVA: 0x20B6CE0 Offset: 0x20B52E0 VA: 0x1820B6CE0
	private void OnReset() { }

	// RVA: 0x20B7770 Offset: 0x20B5D70 VA: 0x1820B7770
	private void PushReceivedInputsIntoSimulator() { }

	// RVA: 0x20B8EB0 Offset: 0x20B74B0 VA: 0x1820B8EB0
	private void UpdateSimulation(Nullable<double> deltaTime) { }

	// RVA: 0x20B8450 Offset: 0x20B6A50 VA: 0x1820B8450
	private void UpdateSimulationInner() { }

	// RVA: 0x20B52D0 Offset: 0x20B38D0 VA: 0x1820B52D0
	private void CallOnUpdateDone() { }

	// RVA: 0x20B92D0 Offset: 0x20B78D0 VA: 0x1820B92D0
	private void UpdateStats() { }

	// RVA: 0x20B51E0 Offset: 0x20B37E0 VA: 0x1820B51E0
	private int CalculateInputOffset() { }

	// RVA: 0x20B8260 Offset: 0x20B6860 VA: 0x1820B8260
	private void UpdateFrameOffset() { }
}
