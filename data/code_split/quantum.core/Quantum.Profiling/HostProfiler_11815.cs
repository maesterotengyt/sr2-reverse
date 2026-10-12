// Namespace: Quantum.Profiling
public static class HostProfiler // TypeDefIndex: 11815
{
	// Fields
	private static Action<string> _profileStart; // 0x0
	private static Action _profileEnd; // 0x8
	private static Action<string, string> _profileThreadStart; // 0x10
	private static Action _profileThreadEnd; // 0x18

	// Methods

	// RVA: 0x223D4E0 Offset: 0x223BAE0 VA: 0x18223D4E0
	public static void Init(Action<string> start, Action end) { }

	// RVA: 0x223D450 Offset: 0x223BA50 VA: 0x18223D450
	public static void InitThread(Action<string, string> start, Action end) { }

	// RVA: 0x223D5D0 Offset: 0x223BBD0 VA: 0x18223D5D0
	public static void Start(string sample) { }

	// RVA: 0x223D400 Offset: 0x223BA00 VA: 0x18223D400
	public static void End() { }

	// RVA: 0x223D570 Offset: 0x223BB70 VA: 0x18223D570
	public static void StartDebug(string sample) { }

	// RVA: 0x223D3B0 Offset: 0x223B9B0 VA: 0x18223D3B0
	public static void EndDebug() { }
}
