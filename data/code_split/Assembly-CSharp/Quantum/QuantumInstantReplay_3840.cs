// Namespace: Quantum
public sealed class QuantumInstantReplay : IDisposable // TypeDefIndex: 3840
{
	// Fields
	public const int InitalFramesToSimulation = 4;
	private bool _loop; // 0x10
	private QuantumRunner _replayRunner; // 0x18
	private DeterministicFrameRingBuffer _rewindSnapshots; // 0x20
	[CompilerGenerated]
	private readonly int <StartFrame>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly int <EndFrame>k__BackingField; // 0x2C
	[CompilerGenerated]
	private readonly QuantumGame <LiveGame>k__BackingField; // 0x30

	// Properties
	public int StartFrame { get; }
	public int CurrentFrame { get; }
	public int EndFrame { get; }
	public bool CanSeek { get; }
	public bool IsRunning { get; }
	public QuantumGame LiveGame { get; }
	public QuantumGame ReplayGame { get; }
	public float NormalizedTime { get; }

	// Methods

	// RVA: 0x668400 Offset: 0x666A00 VA: 0x180668400
	public void .ctor(QuantumGame liveGame, float length, QuantumInstantReplaySeekMode seekMode = 0, bool loop = False) { }

	[CompilerGenerated]
	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public int get_StartFrame() { }

	// RVA: 0x668D50 Offset: 0x667350 VA: 0x180668D50
	public int get_CurrentFrame() { }

	[CompilerGenerated]
	// RVA: 0x668D90 Offset: 0x667390 VA: 0x180668D90
	public int get_EndFrame() { }

	// RVA: 0x668D30 Offset: 0x667330 VA: 0x180668D30
	public bool get_CanSeek() { }

	// RVA: 0x668DA0 Offset: 0x6673A0 VA: 0x180668DA0
	public bool get_IsRunning() { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public QuantumGame get_LiveGame() { }

	// RVA: 0x668E60 Offset: 0x667460 VA: 0x180668E60
	public QuantumGame get_ReplayGame() { }

	// RVA: 0x668DE0 Offset: 0x6673E0 VA: 0x180668DE0
	public float get_NormalizedTime() { }

	// RVA: 0x667A50 Offset: 0x666050 VA: 0x180667A50 Slot: 4
	public void Dispose() { }

	// RVA: 0x668120 Offset: 0x666720 VA: 0x180668120
	public void SeekFrame(int frameNumber) { }

	// RVA: 0x668260 Offset: 0x666860 VA: 0x180668260
	public void SeekNormalizedTime(float normalizedTime) { }

	// RVA: 0x668300 Offset: 0x666900 VA: 0x180668300
	public bool Update(float deltaTime) { }

	// RVA: 0x667AB0 Offset: 0x6660B0 VA: 0x180667AB0
	private void FastForward(int frameNumber) { }

	// RVA: 0x6680C0 Offset: 0x6666C0 VA: 0x1806680C0
	private static double GetDeltaTime(int frames, int simulationRate) { }
}
