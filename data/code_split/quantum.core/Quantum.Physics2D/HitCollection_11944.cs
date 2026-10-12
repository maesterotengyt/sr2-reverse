// Namespace: Quantum.Physics2D
[DefaultMember("Item")]
public struct HitCollection // TypeDefIndex: 11944
{
	// Fields
	private HitCollection.Modes _mode; // 0x0
	private Hit* _hits; // 0x8
	private int _count; // 0x10
	private int _capacity; // 0x14

	// Properties
	public int Count { get; set; }
	public Hit Item { get; }
	public Hit* HitsBuffer { get; }

	// Methods

	// RVA: 0x502900 Offset: 0x500F00 VA: 0x180502900
	public int get_Count() { }

	// RVA: 0x520750 Offset: 0x51ED50 VA: 0x180520750
	internal void set_Count(int value) { }

	// RVA: 0x22006B0 Offset: 0x21FECB0 VA: 0x1822006B0
	public Hit get_Item(int index) { }

	// RVA: 0x6AB5F0 Offset: 0x6A9BF0 VA: 0x1806AB5F0
	public Hit* get_HitsBuffer() { }

	// RVA: 0x2200640 Offset: 0x21FEC40 VA: 0x182200640
	internal void .ctor(int capacity, HitCollection.Modes mode, FrameContext context) { }

	// RVA: 0x2200580 Offset: 0x21FEB80 VA: 0x182200580
	public void Sort(FPVector2 point) { }

	// RVA: 0x2200550 Offset: 0x21FEB50 VA: 0x182200550
	public void SortCastDistance() { }

	// RVA: 0x2200170 Offset: 0x21FE770 VA: 0x182200170
	public void Free(Native.Allocator allocator) { }

	// RVA: 0x2200540 Offset: 0x21FEB40 VA: 0x182200540
	public void Reset() { }

	// RVA: 0x2200000 Offset: 0x21FE600 VA: 0x182200000
	public void Add(Hit hit, FrameContext context) { }

	// RVA: 0x2200070 Offset: 0x21FE670 VA: 0x182200070
	private void ExpandCapacity(int newCapacity, FrameContext context) { }

	// RVA: 0x2200380 Offset: 0x21FE980 VA: 0x182200380
	private void QuickSort(Hit* A, int lo, int hi) { }

	// RVA: 0x22001C0 Offset: 0x21FE7C0 VA: 0x1822001C0
	private void QuickSortCastDistance(Hit* hit, int lo, int hi) { }
}
