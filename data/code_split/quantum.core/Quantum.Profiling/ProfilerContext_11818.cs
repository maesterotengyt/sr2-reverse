// Namespace: Quantum.Profiling
public class ProfilerContext // TypeDefIndex: 11818
{
	// Fields
	private long _frequency; // 0x10
	private int _simulationCounter; // 0x18
	private readonly object _lock; // 0x20
	private readonly Profiler[] _taskThreadProfilers; // 0x28
	private readonly List<Profiler> _allProfilers; // 0x30
	private readonly List<double> _frameTimes; // 0x38

	// Methods

	// RVA: 0x223E5A0 Offset: 0x223CBA0 VA: 0x18223E5A0
	public void .ctor() { }

	// RVA: 0x223DF90 Offset: 0x223C590 VA: 0x18223DF90
	internal Profiler CreateProfilerForTaskThread(int taskThreadIndex, string name) { }

	// RVA: 0x223E590 Offset: 0x223CB90 VA: 0x18223E590
	public void SimulationBegin() { }

	// RVA: 0x223E450 Offset: 0x223CA50 VA: 0x18223E450
	public void Reset() { }

	// RVA: 0x223E260 Offset: 0x223C860 VA: 0x18223E260
	public ProfilerContextData CreateReport(int frame, bool isVerified) { }

	// RVA: 0x1E1A220 Offset: 0x1E18820 VA: 0x181E1A220
	public Profiler GetProfilerForTaskThread(int taskThreadIndex) { }

	// RVA: 0x223E0A0 Offset: 0x223C6A0 VA: 0x18223E0A0
	private Profiler CreateProfiler(string name) { }
}
