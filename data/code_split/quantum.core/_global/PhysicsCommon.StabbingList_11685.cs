// Namespace: 
internal struct PhysicsCommon.StabbingList // TypeDefIndex: 11685
{
	// Fields
	public PhysicsCommon.ActiveEntryList* Lists; // 0x0
	public int* StabbingNumbers; // 0x8
	public int Capacity; // 0x10
	public int Count; // 0x14
	public int EntriesCount; // 0x18
	public int EntriesPerList; // 0x1C

	// Methods

	// RVA: 0x221FD80 Offset: 0x221E380 VA: 0x18221FD80
	public void Free(Native.Allocator allocator) { }

	// RVA: 0x221FE90 Offset: 0x221E490 VA: 0x18221FE90
	public PhysicsCommon.ActiveEntryList* GetNextEntryList(int stabbingNumber) { }

	// RVA: 0x2220150 Offset: 0x221E750 VA: 0x182220150
	public int Stab(int stabbingPoint) { }

	// RVA: 0x221FEC0 Offset: 0x221E4C0 VA: 0x18221FEC0
	public void ResetAndEnsureCapacity(Native.Allocator allocator, int capacity, int listCapacity) { }
}
