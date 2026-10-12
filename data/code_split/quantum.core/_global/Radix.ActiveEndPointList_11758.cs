// Namespace: 
public struct Radix.ActiveEndPointList // TypeDefIndex: 11758
{
	// Fields
	public Radix.ActiveEndPoint* Items; // 0x0
	public int* IndexLookup; // 0x8
	public int Capacity; // 0x10
	public int Count; // 0x14

	// Methods

	// RVA: 0x2221C50 Offset: 0x2220250 VA: 0x182221C50
	public void Free(Native.Allocator allocator) { }

	// RVA: 0x2221CD0 Offset: 0x22202D0 VA: 0x182221CD0
	public void Remove(int entryIndex) { }

	// RVA: 0x2221C20 Offset: 0x2220220 VA: 0x182221C20
	public void Add(Radix.ActiveEndPoint endPoint) { }

	// RVA: 0x2221D20 Offset: 0x2220320 VA: 0x182221D20
	public void ResetAndEnsureCapacity(Native.Allocator allocator, int capacity) { }
}
