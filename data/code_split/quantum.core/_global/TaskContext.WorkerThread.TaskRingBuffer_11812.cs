// Namespace: 
private struct TaskContext.WorkerThread.TaskRingBuffer // TypeDefIndex: 11812
{
	// Fields
	public int _head; // 0x0
	public int _tail; // 0x4
	public int _count; // 0x8
	public int _capacity; // 0xC
	public TaskStruct** _items; // 0x10

	// Methods

	// RVA: 0x2240790 Offset: 0x223ED90 VA: 0x182240790
	public void .ctor(TaskStruct** items, int capacity) { }

	// RVA: 0x2240770 Offset: 0x223ED70 VA: 0x182240770
	public void Push(TaskStruct* item) { }

	// RVA: 0x2240760 Offset: 0x223ED60 VA: 0x182240760
	public void Pop() { }
}
