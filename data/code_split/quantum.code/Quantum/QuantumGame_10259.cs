// Namespace: Quantum
public class QuantumGame : IDeterministicGame // TypeDefIndex: 10259
{
	// Fields
	private DeterministicFrameRingBuffer _checksumSnapshotBuffer; // 0x10
	private DeterministicFrameRingBuffer _instantReplaySnapshotBuffer; // 0x18
	private bool _instantReplaySnapshotsRecording; // 0x20
	private int _commonSnapshotInterval; // 0x24
	private int _instantReplaySnapshotInterval; // 0x28
	[CompilerGenerated]
	private Action<ProfilerContextData> ProfilerSampleGenerated; // 0x30
	[CompilerGenerated]
	private readonly QuantumGame.FramesContainer <Frames>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly QuantumGame.ConfigurationsContainer <Configurations>k__BackingField; // 0x40
	[CompilerGenerated]
	private DeterministicSession <Session>k__BackingField; // 0x48
	[CompilerGenerated]
	private float <InterpolationFactor>k__BackingField; // 0x50
	[CompilerGenerated]
	private InstantReplaySettings <InstantReplayConfig>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly IAssetSerializer <AssetSerializer>k__BackingField; // 0x68
	[CompilerGenerated]
	private readonly int <HeapExtraCount>k__BackingField; // 0x70
	private byte[] _inputStreamReadZeroArray; // 0x78
	private IResourceManager _resourceManager; // 0x80
	private ICallbackDispatcher _callbackDispatcher; // 0x88
	private IEventDispatcher _eventDispatcher; // 0x90
	private FrameSerializer _inputSerializerRead; // 0x98
	private FrameSerializer _inputSerializerWrite; // 0xA0
	private SystemBase[] _systemsRoot; // 0xA8
	private SystemBase[] _systemsAll; // 0xB0
	private FrameContext _context; // 0xB8
	private TypeRegistry _typeRegistry; // 0xC0
	private bool _polledInputInThisSimulation; // 0xC8
	private DynamicAssetDB _initialDynamicAssets; // 0xD0
	private int _flags; // 0xD8
	[CompilerGenerated]
	private InputProvider <RecordedInputs>k__BackingField; // 0xE0
	[CompilerGenerated]
	private ChecksumFile <RecordedChecksums>k__BackingField; // 0xE8
	private ChecksumFile _checksumsToVerify; // 0xF0
	private Dictionary<EventKey, bool> _eventsTriggered; // 0xF8
	private Queue<EventKey> _eventsConfirmationQueue; // 0x100
	private CallbackChecksumComputed _callbackChecksumComputed; // 0x108
	private CallbackChecksumError _callbackChecksumError; // 0x110
	private CallbackChecksumErrorFrameDump _callbackChecksumErrorFrameDump; // 0x118
	private CallbackEventCanceled _callbackEventCanceled; // 0x120
	private CallbackEventConfirmed _callbackEventConfirmed; // 0x128
	private CallbackGameDestroyed _callbackGameDestroyed; // 0x130
	private CallbackGameStarted _callbackGameStarted; // 0x138
	private CallbackGameResynced _callbackGameResynced; // 0x140
	private CallbackInputConfirmed _callbackInputConfirmed; // 0x148
	private CallbackPollInput _callbackPollInput; // 0x150
	private CallbackSimulateFinished _callbackSimulateFinished; // 0x158
	private CallbackUpdateView _callbackUpdateView; // 0x160
	private CallbackPluginDisconnect _callbackPluginDisconnect; // 0x168

	// Properties
	public QuantumGame.FramesContainer Frames { get; }
	public QuantumGame.ConfigurationsContainer Configurations { get; }
	public DeterministicSession Session { get; set; }
	public float InterpolationFactor { get; set; }
	public InstantReplaySettings InstantReplayConfig { get; set; }
	public IAssetSerializer AssetSerializer { get; }
	public int HeapExtraCount { get; }
	public InputProvider RecordedInputs { get; set; }
	public ChecksumFile RecordedChecksums { get; set; }

	// Methods

	// RVA: 0x2159810 Offset: 0x2157E10 VA: 0x182159810
	private void SnapshotsOnDestroy() { }

	// RVA: 0x2159870 Offset: 0x2157E70 VA: 0x182159870
	private void SnapshotsOnSimulateFinished(DeterministicFrame state) { }

	// RVA: 0x21595F0 Offset: 0x2157BF0 VA: 0x1821595F0
	private int SnapshotsCreateBuffers(int simulationRate, int checksumInterval, FP checksumTimeWindow, int replayInterval, FP replayTimeWindow) { }

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public QuantumGame.FramesContainer get_Frames() { }

	[CompilerGenerated]
	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	public QuantumGame.ConfigurationsContainer get_Configurations() { }

	[CompilerGenerated]
	// RVA: 0x5C9FA0 Offset: 0x5C85A0 VA: 0x1805C9FA0 Slot: 4
	public DeterministicSession get_Session() { }

	[CompilerGenerated]
	// RVA: 0x58D130 Offset: 0x58B730 VA: 0x18058D130
	private void set_Session(DeterministicSession value) { }

	[CompilerGenerated]
	// RVA: 0x1C9EE40 Offset: 0x1C9D440 VA: 0x181C9EE40
	public float get_InterpolationFactor() { }

	[CompilerGenerated]
	// RVA: 0x2159F30 Offset: 0x2158530 VA: 0x182159F30
	private void set_InterpolationFactor(float value) { }

	[CompilerGenerated]
	// RVA: 0x2159F10 Offset: 0x2158510 VA: 0x182159F10
	public InstantReplaySettings get_InstantReplayConfig() { }

	[CompilerGenerated]
	// RVA: 0x2159F20 Offset: 0x2158520 VA: 0x182159F20
	private void set_InstantReplayConfig(InstantReplaySettings value) { }

	[CompilerGenerated]
	// RVA: 0x5A5150 Offset: 0x5A3750 VA: 0x1805A5150
	public IAssetSerializer get_AssetSerializer() { }

	[CompilerGenerated]
	// RVA: 0x70CE10 Offset: 0x70B410 VA: 0x18070CE10
	public int get_HeapExtraCount() { }

	// RVA: 0x2159CF0 Offset: 0x21582F0 VA: 0x182159CF0
	public void .ctor(in QuantumGame.StartParameters startParams) { }

	// RVA: 0x7C2770 Offset: 0x7C0D70 VA: 0x1807C2770
	public int[] GetLocalPlayers() { }

	// RVA: 0x2159480 Offset: 0x2157A80 VA: 0x182159480
	public void SendCommand(DeterministicCommand command) { }

	// RVA: 0x2159530 Offset: 0x2157B30 VA: 0x182159530
	public void SendPlayerData(int player, RuntimePlayer data) { }

	// RVA: 0x2157970 Offset: 0x2155F70 VA: 0x182157970 Slot: 13
	public void OnDestroy() { }

	// RVA: 0x2155410 Offset: 0x2153A10 VA: 0x182155410
	public Frame CreateFrame() { }

	// RVA: 0x21590C0 Offset: 0x21576C0 VA: 0x1821590C0 Slot: 10
	private DeterministicFrame Photon.Deterministic.IDeterministicGame.CreateFrame(IDisposable context) { }

	// RVA: 0x2155EC0 Offset: 0x21544C0 VA: 0x182155EC0 Slot: 11
	public DeterministicFrame GetVerifiedFrame(int tick) { }

	// RVA: 0x2154640 Offset: 0x2152C40 VA: 0x182154640 Slot: 9
	public IDisposable CreateFrameContext() { }

	// RVA: 0x2157D00 Offset: 0x2156300 VA: 0x182157D00 Slot: 27
	public virtual void OnGameStart(DeterministicFrame f) { }

	// RVA: 0x2157AB0 Offset: 0x21560B0 VA: 0x182157AB0 Slot: 28
	public virtual void OnGameResync() { }

	// RVA: 0x2158170 Offset: 0x2156770 VA: 0x182158170 Slot: 29
	public virtual DeterministicFrameInputTemp OnLocalInput(int frame, int player) { }

	// RVA: 0x2158670 Offset: 0x2156C70 VA: 0x182158670 Slot: 30
	public virtual void OnSimulate(DeterministicFrame state) { }

	// RVA: 0x2158550 Offset: 0x2156B50 VA: 0x182158550 Slot: 31
	public virtual void OnSimulateFinished(DeterministicFrame state) { }

	// RVA: 0x2158CE0 Offset: 0x21572E0 VA: 0x182158CE0 Slot: 32
	public virtual void OnUpdateDone() { }

	// RVA: 0x2154130 Offset: 0x2152730 VA: 0x182154130 Slot: 14
	public void AssignSession(DeterministicSession session) { }

	// RVA: 0x2157960 Offset: 0x2155F60 VA: 0x182157960 Slot: 33
	public virtual void OnChecksumError(DeterministicTickChecksumError error, DeterministicFrame[] frames) { }

	// RVA: 0x21578D0 Offset: 0x2155ED0 VA: 0x1821578D0 Slot: 34
	public virtual void OnChecksumComputed(int frame, ulong checksum) { }

	// RVA: 0x2158CB0 Offset: 0x21572B0 VA: 0x182158CB0 Slot: 35
	public virtual void OnSimulationEnd() { }

	// RVA: 0x2158C80 Offset: 0x2157280 VA: 0x182158C80 Slot: 36
	public virtual void OnSimulationBegin() { }

	// RVA: 0x21580F0 Offset: 0x21566F0 VA: 0x1821580F0 Slot: 37
	public virtual void OnInputConfirmed(DeterministicFrameInputTemp input) { }

	// RVA: 0x2157950 Offset: 0x2155F50 VA: 0x182157950 Slot: 38
	public virtual void OnChecksumErrorFrameDump(int actorId, int frameNumber, DeterministicSessionConfig sessionConfig, byte[] runtimeConfig, byte[] frameData, byte[] extraData) { }

	// RVA: 0x21584C0 Offset: 0x2156AC0 VA: 0x1821584C0 Slot: 39
	public virtual void OnPluginDisconnect(string reason) { }

	// RVA: 0xC97F70 Offset: 0xC96570 VA: 0x180C97F70 Slot: 6
	public int GetInputInMemorySize() { }

	// RVA: 0x21559C0 Offset: 0x2153FC0 VA: 0x1821559C0 Slot: 5
	public int GetInputSerializedFixedSize() { }

	// RVA: 0x21563F0 Offset: 0x21549F0 VA: 0x1821563F0
	private void InitSystems(DeterministicFrame df) { }

	// RVA: 0x2155510 Offset: 0x2153B10 VA: 0x182155510 Slot: 7
	public void DeserializeInputInto(int player, byte[] data, byte* buffer) { }

	// RVA: 0x2154030 Offset: 0x2152630 VA: 0x182154030
	private void ApplyInputs(Frame f) { }

	// RVA: 0x2157870 Offset: 0x2155E70 VA: 0x182157870
	private void LogSimulationException(Exception exn) { }

	// RVA: 0x2155770 Offset: 0x2153D70 VA: 0x182155770 Slot: 12
	public byte[] GetExtraErrorFrameDumpData(DeterministicFrame frame) { }

	// RVA: 0x2154550 Offset: 0x2152B50 VA: 0x182154550
	public void CheckTrackedHeapAllocations() { }

	[CompilerGenerated]
	// RVA: 0x7A80E0 Offset: 0x7A66E0 VA: 0x1807A80E0
	public InputProvider get_RecordedInputs() { }

	[CompilerGenerated]
	// RVA: 0x818FF0 Offset: 0x8175F0 VA: 0x180818FF0
	private void set_RecordedInputs(InputProvider value) { }

	[CompilerGenerated]
	// RVA: 0x7A8080 Offset: 0x7A6680 VA: 0x1807A8080
	public ChecksumFile get_RecordedChecksums() { }

	[CompilerGenerated]
	// RVA: 0x1CB3160 Offset: 0x1CB1760 VA: 0x181CB3160
	private void set_RecordedChecksums(ChecksumFile value) { }

	// RVA: 0x2155A50 Offset: 0x2154050 VA: 0x182155A50
	public Frame GetInstantReplaySnapshot(int frame) { }

	// RVA: 0x2155D50 Offset: 0x2154350 VA: 0x182155D50
	public void GetInstantReplaySnapshots(int startFrame, int endFrame, List<Frame> frames) { }

	// RVA: 0x2159430 Offset: 0x2157A30 VA: 0x182159430
	private void ReplayToolsOnInputConfirmed(DeterministicFrameInputTemp input) { }

	// RVA: 0x21593C0 Offset: 0x21579C0 VA: 0x1821593C0
	private void ReplayToolsOnGameResync() { }

	// RVA: 0x2159340 Offset: 0x2157940 VA: 0x182159340
	private void ReplayToolsOnChecksumComputed(int frame, ulong checksum) { }

	// RVA: 0x2159A20 Offset: 0x2158020 VA: 0x182159A20
	public void StartRecordingInput(Nullable<int> startFrame) { }

	// RVA: 0x2159970 Offset: 0x2157F70 VA: 0x182159970
	public void StartRecordingChecksums() { }

	// RVA: 0x2159C60 Offset: 0x2158260 VA: 0x182159C60
	public void StartVerifyingChecksums(ChecksumFile checksums) { }

	// RVA: 0x2159BB0 Offset: 0x21581B0 VA: 0x182159BB0
	public void StartRecordingInstantReplaySnapshots() { }

	// RVA: 0x2156310 Offset: 0x2154910 VA: 0x182156310
	private void InitEventInvoker(int size) { }

	// RVA: 0x2159210 Offset: 0x2157810 VA: 0x182159210
	private void RaiseEvent(EventBase evnt) { }

	// RVA: 0x2154430 Offset: 0x2152A30 VA: 0x182154430
	private void CancelPendingEvents() { }

	// RVA: 0x2156720 Offset: 0x2154D20 VA: 0x182156720
	private void InvokeEvents() { }

	// RVA: 0x2155FB0 Offset: 0x21545B0 VA: 0x182155FB0
	public void InitCallbacks() { }

	// RVA: 0x2157160 Offset: 0x2155760 VA: 0x182157160
	public void InvokeOnDestroy() { }

	// RVA: 0x2157330 Offset: 0x2155930 VA: 0x182157330
	private void InvokeOnGameStart() { }

	// RVA: 0x21572D0 Offset: 0x21558D0 VA: 0x1821572D0
	private void InvokeOnGameResync() { }

	// RVA: 0x2157520 Offset: 0x2155B20 VA: 0x182157520
	private QTuple<Input, DeterministicInputFlags> InvokeOnPollInput(int frame, int player, bool isFirstInThisUpdate) { }

	// RVA: 0x21577F0 Offset: 0x2155DF0 VA: 0x1821577F0
	private void InvokeOnUpdateView() { }

	// RVA: 0x2157680 Offset: 0x2155C80 VA: 0x182157680
	public void InvokeOnSimulateFinished(DeterministicFrame state) { }

	// RVA: 0x2157030 Offset: 0x2155630 VA: 0x182157030
	public void InvokeOnChecksumError(DeterministicTickChecksumError error, DeterministicFrame[] frames) { }

	// RVA: 0x2156C40 Offset: 0x2155240 VA: 0x182156C40
	public void InvokeOnChecksumComputed(int frame, ulong checksum) { }

	// RVA: 0x2157390 Offset: 0x2155990 VA: 0x182157390
	public void InvokeOnInputConfirmed(DeterministicFrameInputTemp input) { }

	// RVA: 0x2156CE0 Offset: 0x21552E0 VA: 0x182156CE0
	public void InvokeOnChecksumErrorFrameDump(int actorId, int frameNumber, DeterministicSessionConfig sessionConfig, byte[] runtimeConfig, byte[] frameData, byte[] extraData) { }

	// RVA: 0x21571C0 Offset: 0x21557C0 VA: 0x1821571C0
	private void InvokeOnEvent(EventKey key, bool confirmed) { }

	// RVA: 0x2157490 Offset: 0x2155A90 VA: 0x182157490
	public void InvokeOnPluginDisconnect(string reason) { }
}
