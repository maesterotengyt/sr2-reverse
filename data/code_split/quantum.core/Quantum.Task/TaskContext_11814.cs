// Namespace: Quantum.Task
public class TaskContext // TypeDefIndex: 11814
{
	// Fields
	private const int TASK_CAN_NOT_RUN = 0;
	private const int TASK_CAN_RUN = 1;
	private const int TASK_DONE = 2;
	private const int MAX_TASK_DELEGATES = 1024;
	private TaskStruct* _tasks; // 0x10
	private int _tasksCount; // 0x18
	private TaskContext.TasksDone _tasksDone; // 0x1C
	private TaskStruct*[] _taskRoots; // 0xA0
	private int _taskRootsCount; // 0xA8
	private bool _running; // 0xAC
	private int _taskDelegatesCount; // 0xB0
	private TaskContext.TaskDelegateReference[] _taskDelegates; // 0xB8
	private TaskContext.WorkerThread[] _threads; // 0xC0
	private Action[] _threadsActions; // 0xC8
	private ProfilerContext _profilerContext; // 0xD0
	private Profiler _profilerMainThread; // 0xD8
	private FrameBase _frame; // 0xE0
	private FrameContext _frameContext; // 0xE8

	// Properties
	public int ThreadCount { get; }
	public int SlicePerThreadMaxCount { get; }
	public int TaskCount { get; }

	// Methods

	// RVA: 0x2240740 Offset: 0x223ED40 VA: 0x182240740
	public int get_ThreadCount() { }

	// RVA: 0x2240720 Offset: 0x223ED20 VA: 0x182240720
	public int get_SlicePerThreadMaxCount() { }

	// RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180
	public int get_TaskCount() { }

	// RVA: 0x2240290 Offset: 0x223E890 VA: 0x182240290
	public void .ctor(Native.Allocator allocator, DeterministicPlatformInfo platformInfo, ProfilerContext profilerContext, FrameContext frameContext) { }

	// RVA: 0x22400D0 Offset: 0x223E6D0 VA: 0x1822400D0
	public TaskSlicer SlicePerThread(int arrayCount, TaskSlice* slices) { }

	// RVA: 0x22401B0 Offset: 0x223E7B0 VA: 0x1822401B0
	public TaskSlicer SlicePerThread(AtomicInt* arrayIndexer, int arrayCount, TaskSlice* slices) { }

	// RVA: 0x223F420 Offset: 0x223DA20 VA: 0x18223F420
	public void BeginFrame(FrameBase frame) { }

	// RVA: 0x223F560 Offset: 0x223DB60 VA: 0x18223F560
	private void ClearAndCompleteTaskRecursive(int i) { }

	// RVA: 0x223F780 Offset: 0x223DD80 VA: 0x18223F780
	public void EndFrame() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal void SimulationBegin() { }

	// RVA: 0x223FFF0 Offset: 0x223E5F0 VA: 0x18223FFF0
	internal void SimulationEnd() { }

	// RVA: 0x223F720 Offset: 0x223DD20 VA: 0x18223F720
	internal void Dispose() { }

	// RVA: 0x223FDF0 Offset: 0x223E3F0 VA: 0x18223FDF0
	public void RegisterDelegate(TaskDelegate taskDelegate, string name, ref TaskDelegateHandle taskDelegateHandle) { }

	// RVA: 0x223EFC0 Offset: 0x223D5C0 VA: 0x18223EFC0
	public TaskHandle AddSingletonTask(TaskDelegateHandle taskHandle, void* taskArg) { }

	// RVA: 0x223EF50 Offset: 0x223D550 VA: 0x18223EF50
	public TaskHandle AddSingletonTask(TaskDelegateHandle taskHandle, void* taskArg, TaskHandle dependancy) { }

	// RVA: 0x223F290 Offset: 0x223D890 VA: 0x18223F290
	public TaskHandle AddThreadedTask(TaskDelegateHandle taskHandle, void* taskArg) { }

	// RVA: 0x223F340 Offset: 0x223D940 VA: 0x18223F340
	public TaskHandle AddThreadedTask(TaskDelegateHandle taskHandle, void* taskArg, TaskHandle dependancy) { }

	// RVA: 0x223EE90 Offset: 0x223D490 VA: 0x18223EE90
	public TaskHandle AddMainThreadTask(TaskDelegateHandle taskHandle, void* taskArg, TaskHandle dependancy) { }

	// RVA: 0x223EF00 Offset: 0x223D500 VA: 0x18223EF00
	public TaskHandle AddRootTask() { }

	// RVA: 0x223F010 Offset: 0x223D610 VA: 0x18223F010
	private TaskHandle AddTask(TaskDelegateHandle taskDelegateHandle, void* taskArg, int taskSize, int maxSlices, bool mainThread, bool root) { }

	// RVA: 0x223F5E0 Offset: 0x223DBE0 VA: 0x18223F5E0
	private void CompleteTask(TaskStruct* task) { }

	// RVA: 0x223F480 Offset: 0x223DA80 VA: 0x18223F480
	private int CanTaskRun(TaskStruct* task, int thread) { }
}
