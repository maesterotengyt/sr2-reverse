// Namespace: Quantum.Collections
internal struct UnsafeHashCollection // TypeDefIndex: 12046
{
	// Fields
	public UnsafeHashCollection.Entry** Buckets; // 0x0
	public UnsafeHashCollection.Entry* FreeHead; // 0x8
	public UnsafeBuffer Entries; // 0x10
	public int UsedCount; // 0x28
	public int FreeCount; // 0x2C
	public int KeyOffset; // 0x30

	// Methods

	// RVA: 0x2214520 Offset: 0x2212B20 VA: 0x182214520
	public static void Free(Native.Allocator allocator, UnsafeHashCollection* collection) { }

	// RVA: -1 Offset: -1
	public static UnsafeHashCollection.Entry* Find<T>(UnsafeHashCollection* collection, T value, int valueHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC953F0 Offset: 0xC939F0 VA: 0x180C953F0
	|-UnsafeHashCollection.Find<EntityRef>
	|
	|-RVA: 0xC95490 Offset: 0xC93A90 VA: 0x180C95490
	|-UnsafeHashCollection.Find<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static UnsafeHashCollection.Entry* Insert<T>(Native.Allocator allocator, UnsafeHashCollection* collection, T value, int valueHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC955F0 Offset: 0xC93BF0 VA: 0x180C955F0
	|-UnsafeHashCollection.Insert<EntityRef>
	|
	|-RVA: 0xC956A0 Offset: 0xC93CA0 VA: 0x180C956A0
	|-UnsafeHashCollection.Insert<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2213FE0 Offset: 0x22125E0 VA: 0x182213FE0
	public static void Clear(UnsafeHashCollection* collection) { }

	// RVA: 0x22140C0 Offset: 0x22126C0 VA: 0x1822140C0
	private static void Expand(Native.Allocator allocator, UnsafeHashCollection* collection) { }
}
