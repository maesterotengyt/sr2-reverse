// Namespace: 
internal struct Heap.Bin // TypeDefIndex: 12055
{
	// Fields
	public const int FIELDS = 4;
	public const int SIZE = 16;
	public Ptr Head; // 0x0
	public Ptr Tail; // 0x4
	public int BlockSize; // 0x8
	public int PageCount; // 0xC

	// Methods

	// RVA: 0x2214EA0 Offset: 0x22134A0 VA: 0x182214EA0
	public void .ctor(int words) { }

	// RVA: 0x2214B00 Offset: 0x2213100 VA: 0x182214B00 Slot: 3
	public override string ToString() { }
}
