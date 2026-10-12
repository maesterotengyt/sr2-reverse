// Namespace: 
internal struct PhysicsCommon.ActiveEntryList // TypeDefIndex: 11684
{
	// Fields
	public PhysicsCommon.ActiveEntry* Items; // 0x0
	public int* IndexLookup; // 0x8
	public int Capacity; // 0x10
	public int Count; // 0x14
	public int CountUnsorted; // 0x18

	// Methods

	// RVA: 0x22169A0 Offset: 0x2214FA0 VA: 0x1822169A0
	public void Free(Native.Allocator allocator) { }

	// RVA: 0x2216A20 Offset: 0x2215020 VA: 0x182216A20
	public void Remove(int entryIndex) { }

	// RVA: 0x2216790 Offset: 0x2214D90 VA: 0x182216790
	public void Add(PhysicsCommon.ActiveEntry entry, bool sorted = False) { }

	// RVA: 0x22167D0 Offset: 0x2214DD0 VA: 0x1822167D0
	public void CopyFrom(Native.Allocator allocator, PhysicsCommon.ActiveEntryList* from) { }

	// RVA: 0x2216560 Offset: 0x2214B60 VA: 0x182216560
	public void AddRange(Native.Allocator allocator, PhysicsCommon.ActiveEntryList* from) { }

	// RVA: 0x2216AF0 Offset: 0x22150F0 VA: 0x182216AF0
	public void ResetAndEnsureCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x2216BE0 Offset: 0x22151E0 VA: 0x182216BE0
	public void ResetCount() { }
}
