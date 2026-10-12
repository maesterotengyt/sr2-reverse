// Namespace: 
internal struct Heap.Page // TypeDefIndex: 12057
{
	// Fields
	public const int FIELDS = 10;
	public const int SIZE = 40;
	public int Bin; // 0x0
	public int Index; // 0x4
	public Heap.PageFlags Flags; // 0x8
	public int Reserved; // 0xC
	public int Committed; // 0x10
	public int Allocated; // 0x14
	public int BlockSize; // 0x18
	public Ptr BlockFree; // 0x1C
	public Ptr Prev; // 0x20
	public Ptr Next; // 0x24

	// Methods

	// RVA: 0x2215900 Offset: 0x2213F00 VA: 0x182215900 Slot: 3
	public override string ToString() { }
}
