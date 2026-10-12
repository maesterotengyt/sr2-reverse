// Namespace: Quantum
[Obsolete]
public class QuantumInstantReplayLegacy // TypeDefIndex: 3841
{
	// Fields
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <ReplayLength>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <PlaybackSpeed>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <StartFrame>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <EndFrame>k__BackingField; // 0x20
	[CompilerGenerated]
	private Action<QuantumGame> OnReplayStarted; // 0x28
	[CompilerGenerated]
	private Action<QuantumGame> OnReplayStopped; // 0x30
	public const int InitalFramesToSimulation = 4;
	private QuantumGame _liveGame; // 0x38
	private QuantumRunner _replayRunner; // 0x40
	private DeterministicFrameRingBuffer _rewindSnapshots; // 0x48
	private bool _loop; // 0x50

	// Properties
	public bool IsRunning { get; set; }
	public float ReplayLength { get; set; }
	public float PlaybackSpeed { get; set; }
	public QuantumGame LiveGame { get; }
	public QuantumGame ReplayGame { get; }
	public int StartFrame { get; set; }
	public int EndFrame { get; set; }
	public bool CanSeek { get; }
	public float NormalizedTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x537B50 Offset: 0x536150 VA: 0x180537B50
	public bool get_IsRunning() { }

	[CompilerGenerated]
	// RVA: 0x667A30 Offset: 0x666030 VA: 0x180667A30
	private void set_IsRunning(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6678A0 Offset: 0x665EA0 VA: 0x1806678A0
	public float get_ReplayLength() { }

	[CompilerGenerated]
	// RVA: 0x5A3940 Offset: 0x5A1F40 VA: 0x1805A3940
	public void set_ReplayLength(float value) { }

	[CompilerGenerated]
	// RVA: 0x667880 Offset: 0x665E80 VA: 0x180667880
	public float get_PlaybackSpeed() { }

	[CompilerGenerated]
	// RVA: 0x5A3960 Offset: 0x5A1F60 VA: 0x1805A3960
	public void set_PlaybackSpeed(float value) { }

	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public QuantumGame get_LiveGame() { }

	// RVA: 0x667890 Offset: 0x665E90 VA: 0x180667890
	public QuantumGame get_ReplayGame() { }

	[CompilerGenerated]
	// RVA: 0x6678B0 Offset: 0x665EB0 VA: 0x1806678B0
	public int get_StartFrame() { }

	[CompilerGenerated]
	// RVA: 0x667A40 Offset: 0x666040 VA: 0x180667A40
	private void set_StartFrame(int value) { }

	[CompilerGenerated]
	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_EndFrame() { }

	[CompilerGenerated]
	// RVA: 0x667A20 Offset: 0x666020 VA: 0x180667A20
	private void set_EndFrame(int value) { }

	// RVA: 0x667790 Offset: 0x665D90 VA: 0x180667790
	public bool get_CanSeek() { }

	// RVA: 0x6677C0 Offset: 0x665DC0 VA: 0x1806677C0
	public float get_NormalizedTime() { }

	[CompilerGenerated]
	// RVA: 0x667630 Offset: 0x665C30 VA: 0x180667630
	public void add_OnReplayStarted(Action<QuantumGame> value) { }

	[CompilerGenerated]
	// RVA: 0x6678C0 Offset: 0x665EC0 VA: 0x1806678C0
	public void remove_OnReplayStarted(Action<QuantumGame> value) { }

	[CompilerGenerated]
	// RVA: 0x6676E0 Offset: 0x665CE0 VA: 0x1806676E0
	public void add_OnReplayStopped(Action<QuantumGame> value) { }

	[CompilerGenerated]
	// RVA: 0x667970 Offset: 0x665F70 VA: 0x180667970
	public void remove_OnReplayStopped(Action<QuantumGame> value) { }

	// RVA: 0x6675F0 Offset: 0x665BF0 VA: 0x1806675F0
	public void .ctor(QuantumGame game) { }

	// RVA: 0x666AB0 Offset: 0x6650B0 VA: 0x180666AB0
	public void Shutdown() { }

	// RVA: 0x6674E0 Offset: 0x665AE0 VA: 0x1806674E0
	public void Update() { }

	// RVA: 0x666B10 Offset: 0x665110 VA: 0x180666B10
	public void StartInstantReplay(QuantumInstantReplaySeekMode seekMode = 0, bool loop = False) { }

	// RVA: 0x666A10 Offset: 0x665010 VA: 0x180666A10
	public void SeekNormalizedTime(float seek) { }

	// RVA: 0x666880 Offset: 0x664E80 VA: 0x180666880
	public void SeekFrame(int frameNumber) { }

	// RVA: 0x667400 Offset: 0x665A00 VA: 0x180667400
	public void StopInstantReplay() { }

	// RVA: 0x666750 Offset: 0x664D50 VA: 0x180666750
	private void FastForwardSimulation(int frameNumber) { }
}
