// Namespace: Quantum.Collections
internal struct UnsafeHashMap // TypeDefIndex: 12047
{
	// Fields
	private UnsafeHashCollection _collection; // 0x0
	private int _valueOffset; // 0x38

	// Properties
	public int Capacity { get; }

	// Methods

	// RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180
	public int get_Capacity() { }

	// RVA: 0x2214980 Offset: 0x2212F80 VA: 0x182214980
	public static void Clear(UnsafeHashMap* map) { }

	// RVA: -1 Offset: -1
	public static UnsafeHashMap* Allocate<K, V>(Native.Allocator allocator, int capacity, bool fixedSize = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC95AC0 Offset: 0xC940C0 VA: 0x180C95AC0
	|-UnsafeHashMap.Allocate<EntityRef, int>
	|
	|-RVA: 0xC95AF0 Offset: 0xC940F0 VA: 0x180C95AF0
	|-UnsafeHashMap.Allocate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2214580 Offset: 0x2212B80 VA: 0x182214580
	public static UnsafeHashMap* Allocate(Native.Allocator allocator, int capacity, int keyStride, int valStride, bool fixedSize = False) { }

	// RVA: 0x2214A60 Offset: 0x2213060 VA: 0x182214A60
	public static void Free(Native.Allocator allocator, UnsafeHashMap* set) { }

	// RVA: -1 Offset: -1
	public static void AddUnchecked<K, V>(Native.Allocator allocator, UnsafeHashMap* map, K key, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC957F0 Offset: 0xC93DF0 VA: 0x180C957F0
	|-UnsafeHashMap.AddUnchecked<EntityRef, int>
	|
	|-RVA: 0xC958C0 Offset: 0xC93EC0 VA: 0x180C958C0
	|-UnsafeHashMap.AddUnchecked<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetValue<K, V>(UnsafeHashMap* map, K key, out V val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC95B50 Offset: 0xC94150 VA: 0x180C95B50
	|-UnsafeHashMap.TryGetValue<EntityRef, int>
	|
	|-RVA: 0xC95C20 Offset: 0xC94220 VA: 0x180C95C20
	|-UnsafeHashMap.TryGetValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2214AE0 Offset: 0x22130E0 VA: 0x182214AE0
	private static void* GetValue(UnsafeHashMap* map, UnsafeHashCollection.Entry* entry) { }
}
