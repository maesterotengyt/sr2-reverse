// Namespace: Quantum.Physics3D
[DefaultMember("Item")]
public struct HitCollection3D // TypeDefIndex: 11850
{
	// Fields
	private HitCollection3D.Modes _mode; // 0x0
	private Hit3D* _hits3D; // 0x8
	private int _count; // 0x10
	private int _capacity; // 0x14

	// Properties
	public int Count { get; set; }
	public Hit3D Item { get; }
	public Hit3D* HitsBuffer { get; }

	// Methods

	// RVA: 0x502900 Offset: 0x500F00 VA: 0x180502900
	public int get_Count() { }

	// RVA: 0x520750 Offset: 0x51ED50 VA: 0x180520750
	internal void set_Count(int value) { }

	// RVA: 0x2265300 Offset: 0x2263900 VA: 0x182265300
	public Hit3D get_Item(int index) { }

	// RVA: 0x6AB5F0 Offset: 0x6A9BF0 VA: 0x1806AB5F0
	public Hit3D* get_HitsBuffer() { }

	// RVA: 0x2265290 Offset: 0x2263890 VA: 0x182265290
	internal void .ctor(int capacity, HitCollection3D.Modes mode, FrameContext context) { }

	// RVA: 0x2265130 Offset: 0x2263730 VA: 0x182265130
	public void Sort(FPVector3 point) { }

	// RVA: 0x2265100 Offset: 0x2263700 VA: 0x182265100
	public void SortCastDistance() { }

	// RVA: 0x2200170 Offset: 0x21FE770 VA: 0x182200170
	public void Free(Native.Allocator allocator) { }

	// RVA: 0x2200540 Offset: 0x21FEB40 VA: 0x182200540
	public void Reset() { }

	// RVA: 0x2264B40 Offset: 0x2263140 VA: 0x182264B40
	public void Add(Hit3D hit, FrameContext context) { }

	// RVA: 0x2264BB0 Offset: 0x22631B0 VA: 0x182264BB0
	private void ExpandCapacity(int newCapacity, FrameContext context) { }

	// RVA: 0x2264EE0 Offset: 0x22634E0 VA: 0x182264EE0
	private void QuickSort(Hit3D* A, int lo, int hi) { }

	// RVA: 0x2264CC0 Offset: 0x22632C0 VA: 0x182264CC0
	private void QuickSortCastDistance(Hit3D* A, int lo, int hi) { }
}
