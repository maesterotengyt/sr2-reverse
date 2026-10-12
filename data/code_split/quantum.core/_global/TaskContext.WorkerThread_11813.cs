// Namespace: 
private class TaskContext.WorkerThread // TypeDefIndex: 11813
{
	// Fields
	private readonly TaskContext _context; // 0x10
	private readonly Profiler _profiler; // 0x18
	private readonly int _threadIndex; // 0x20

	// Methods

	// RVA: 0x2241790 Offset: 0x223FD90 VA: 0x182241790
	public void .ctor(TaskContext context, bool isMainThread, int threadIndex, DeterministicPlatformInfo platformInfo) { }

	// RVA: 0x2241130 Offset: 0x223F730 VA: 0x182241130
	public void ExecuteGraph() { }

	// RVA: 0x2241170 Offset: 0x223F770 VA: 0x182241170
	public static void TaskExecuteGraph(TaskContext context, int thread, Profiler profiler) { }
}
