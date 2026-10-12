// Namespace: Quantum
[Serializable]
public class EntityPrototypeContainer : IComparer<ComponentPrototype> // TypeDefIndex: 11584
{
	// Fields
	public ComponentPrototype[] Components; // 0x10
	private AtomicInt _sortState; // 0x18
	private const int SortState_Unsorted = 0;
	private const int SortState_Sorting = 1;
	private const int SortState_Sorted = 2;
	internal bool HasAnyListeners; // 0x1C

	// Methods

	// RVA: 0x21CCA70 Offset: 0x21CB070 VA: 0x1821CCA70
	internal void EnsureIsSorted() { }

	// RVA: 0x21CCBA0 Offset: 0x21CB1A0 VA: 0x1821CCBA0
	public void SetDirty() { }

	// RVA: 0x21CCBC0 Offset: 0x21CB1C0 VA: 0x1821CCBC0 Slot: 4
	private int System.Collections.Generic.IComparer<Quantum.ComponentPrototype>.Compare(ComponentPrototype x, ComponentPrototype y) { }

	// RVA: 0x21CCC60 Offset: 0x21CB260 VA: 0x1821CCC60
	public void .ctor() { }
}
