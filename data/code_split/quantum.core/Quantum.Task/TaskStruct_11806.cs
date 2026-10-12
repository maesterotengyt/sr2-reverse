// Namespace: Quantum.Task
internal struct TaskStruct // TypeDefIndex: 11806
{
	// Fields
	public const int MAX_SLICES = 32;
	public const int MAX_TASKS = 1024;
	public const int MAX_CHILDREN = 8;
	public const int MAX_PARENTS = 8;
	public const int DEPS_WORD_BIT_SIZE = 32;
	public const int DEPS_WORD_COUNT = 32;
	public int Id; // 0x0
	public int Callback; // 0x4
	[FixedBuffer(typeof(int), 32)]
	public TaskStruct.<Dependencies>e__FixedBuffer Dependencies; // 0x8
	[FixedBuffer(typeof(int), 8)]
	public TaskStruct.<Parents>e__FixedBuffer Parents; // 0x88
	public int ParentsCount; // 0xA8
	[FixedBuffer(typeof(int), 8)]
	public TaskStruct.<Children>e__FixedBuffer Children; // 0xAC
	public int ChildrenCount; // 0xCC
	public void* Arg; // 0xD0
	public int SlicesCount; // 0xD8
	public bool MainThread; // 0xDC
	public bool Root; // 0xDD
	public AtomicInt SlicesTaken; // 0xE0
	public AtomicInt SlicesCompleted; // 0xE4
	[FixedBuffer(typeof(int), 64)]
	public TaskStruct.<Slices>e__FixedBuffer Slices; // 0xE8

	// Methods

	// RVA: 0x2240970 Offset: 0x223EF70 VA: 0x182240970
	public static void ClearDependencies(TaskStruct* task) { }

	// RVA: 0x2240830 Offset: 0x223EE30 VA: 0x182240830
	public static void AddDependancy(TaskStruct* task, TaskStruct* dependancy) { }

	// RVA: 0x2240AE0 Offset: 0x223F0E0 VA: 0x182240AE0
	public static bool TryTakeSlice(TaskStruct* task, out int start, out int count) { }

	// RVA: 0x2240A60 Offset: 0x223F060 VA: 0x182240A60
	public static bool CompleteSlice(TaskStruct* task) { }
}
