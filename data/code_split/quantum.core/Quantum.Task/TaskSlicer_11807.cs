// Namespace: Quantum.Task
public struct TaskSlicer // TypeDefIndex: 11807
{
	// Fields
	private AtomicInt* _indexer; // 0x0
	private TaskSlice* _slices; // 0x8
	private int _slicesCount; // 0x10

	// Methods

	// RVA: 0x2240820 Offset: 0x223EE20 VA: 0x182240820
	public void .ctor(AtomicInt* indexer, TaskSlice* slices, int slicesCount) { }

	// RVA: 0x22407D0 Offset: 0x223EDD0 VA: 0x1822407D0
	public bool Next(out TaskSlice slice) { }

	// RVA: 0x22407B0 Offset: 0x223EDB0 VA: 0x1822407B0
	public bool Next(int index, out TaskSlice slice) { }
}
