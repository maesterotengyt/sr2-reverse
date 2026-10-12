// Namespace: 
private class Navigation.ActiveHeap // TypeDefIndex: 11653
{
	// Fields
	private int _size; // 0x10
	private int _heapLength; // 0x14
	private Navigation.ActiveVertex** _heap; // 0x18
	private Native.Allocator _allocator; // 0x20

	// Properties
	public int Size { get; }

	// Methods

	// RVA: 0x2217110 Offset: 0x2215710 VA: 0x182217110
	public int get_Size() { }

	// RVA: 0x22170A0 Offset: 0x22156A0 VA: 0x1822170A0
	public void .ctor(Native.Allocator allocator, int capacity = 1024) { }

	// RVA: 0x2216BF0 Offset: 0x22151F0 VA: 0x182216BF0
	public void Clear() { }

	// RVA: 0x2217000 Offset: 0x2215600 VA: 0x182217000
	public void Update(Navigation.ActiveVertex* node) { }

	// RVA: 0x2216E90 Offset: 0x2215490 VA: 0x182216E90
	public void Push(Navigation.ActiveVertex* node) { }

	// RVA: 0x2216D70 Offset: 0x2215370 VA: 0x182216D70
	public Navigation.ActiveVertex* Pop() { }

	// RVA: 0x2216C60 Offset: 0x2215260 VA: 0x182216C60
	private void ExpandHeap() { }

	// RVA: 0x2216D20 Offset: 0x2215320 VA: 0x182216D20
	public void Free() { }
}
