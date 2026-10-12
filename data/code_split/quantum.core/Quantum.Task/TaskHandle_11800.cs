// Namespace: Quantum.Task
public struct TaskHandle // TypeDefIndex: 11800
{
	// Fields
	private readonly TaskStruct* _task; // 0x0
	private readonly bool _isRoot; // 0x8

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x22298A0 Offset: 0x2227EA0 VA: 0x1822298A0
	public bool get_IsValid() { }

	// RVA: 0xE03900 Offset: 0xE01F00 VA: 0x180E03900
	internal void .ctor(TaskStruct* task, bool isRoot) { }

	// RVA: 0x2229880 Offset: 0x2227E80 VA: 0x182229880
	public void AddDependency(TaskHandle other) { }
}
