// Namespace: 
internal struct PhysicsCommon.UnsafeBuffer // TypeDefIndex: 11674
{
	// Fields
	private int _count; // 0x0
	private int _capacity; // 0x4
	private int _stride; // 0x8
	private void* _buffer; // 0x10

	// Properties
	public int Count { get; set; }

	// Methods

	// RVA: 0xB72450 Offset: 0xB70A50 VA: 0x180B72450
	public int get_Count() { }

	// RVA: 0x93A640 Offset: 0x938C40 VA: 0x18093A640
	internal void set_Count(int value) { }

	// RVA: 0x2220F10 Offset: 0x221F510 VA: 0x182220F10
	private void .ctor(int stride) { }

	// RVA: -1 Offset: -1
	public static PhysicsCommon.UnsafeBuffer InitBuffer<T>(Native.Allocator allocator, int capacity = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEE2F0 Offset: 0xCEC8F0 VA: 0x180CEE2F0
	|-PhysicsCommon.UnsafeBuffer.InitBuffer<ConstraintData>
	|
	|-RVA: 0xCEE270 Offset: 0xCEC870 VA: 0x180CEE270
	|-PhysicsCommon.UnsafeBuffer.InitBuffer<ConstraintData>
	|
	|-RVA: 0xCEE3F0 Offset: 0xCEC9F0 VA: 0x180CEE3F0
	|-PhysicsCommon.UnsafeBuffer.InitBuffer<IntPtr>
	|
	|-RVA: 0xCEE470 Offset: 0xCECA70 VA: 0x180CEE470
	|-PhysicsCommon.UnsafeBuffer.InitBuffer<ManifoldData2D>
	|
	|-RVA: 0xCEE4F0 Offset: 0xCECAF0 VA: 0x180CEE4F0
	|-PhysicsCommon.UnsafeBuffer.InitBuffer<ManifoldData3D>
	|
	|-RVA: 0xCEE370 Offset: 0xCEC970 VA: 0x180CEE370
	|-PhysicsCommon.UnsafeBuffer.InitBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2220D40 Offset: 0x221F340 VA: 0x182220D40
	public static PhysicsCommon.UnsafeBuffer InitBuffer(int stride, Native.Allocator allocator, int capacity = 0) { }

	// RVA: -1 Offset: -1
	public bool IsInitialized<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEE5B0 Offset: 0xCECBB0 VA: 0x180CEE5B0
	|-PhysicsCommon.UnsafeBuffer.IsInitialized<IntPtr>
	|
	|-RVA: 0xCEE570 Offset: 0xCECB70 VA: 0x180CEE570
	|-PhysicsCommon.UnsafeBuffer.IsInitialized<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T* GetBuffer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<ConstraintData>
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<ConstraintData>
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<IntPtr>
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<ManifoldData3D>
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T* GetBuffer<T>(out int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEE1C0 Offset: 0xCEC7C0 VA: 0x180CEE1C0
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<IntPtr>
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<ManifoldData2D>
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<ManifoldData3D>
	|-PhysicsCommon.UnsafeBuffer.GetBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T* GetNextEntry<T>(Native.Allocator allocator, out int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEE240 Offset: 0xCEC840 VA: 0x180CEE240
	|-PhysicsCommon.UnsafeBuffer.GetNextEntry<ManifoldData3D>
	|-PhysicsCommon.UnsafeBuffer.GetNextEntry<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T* GetNextEntry<T>(Native.Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEE250 Offset: 0xCEC850 VA: 0x180CEE250
	|-PhysicsCommon.UnsafeBuffer.GetNextEntry<IntPtr>
	|-PhysicsCommon.UnsafeBuffer.GetNextEntry<ManifoldData2D>
	|-PhysicsCommon.UnsafeBuffer.GetNextEntry<ManifoldData3D>
	|-PhysicsCommon.UnsafeBuffer.GetNextEntry<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2220BD0 Offset: 0x221F1D0 VA: 0x182220BD0
	public void* GetNextEntry(Native.Allocator allocator, out int index) { }

	// RVA: -1 Offset: -1
	public PhysicsCommon.UnsafeBuffer.Iterator<T> GetIterator<T>(bool reverseOrder = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEE1D0 Offset: 0xCEC7D0 VA: 0x180CEE1D0
	|-PhysicsCommon.UnsafeBuffer.GetIterator<IntPtr>
	|-PhysicsCommon.UnsafeBuffer.GetIterator<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0xD8B990 Offset: 0xD89F90 VA: 0x180D8B990
	public void Reset() { }

	// RVA: 0x2220DD0 Offset: 0x221F3D0 VA: 0x182220DD0
	public void ResetAndClear(bool clearUsedCountOnly = False) { }

	// RVA: -1 Offset: -1
	public T* ResetAndEnsureCapacity<T>(Native.Allocator allocator, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEE5C0 Offset: 0xCECBC0 VA: 0x180CEE5C0
	|-PhysicsCommon.UnsafeBuffer.ResetAndEnsureCapacity<ConstraintData>
	|-PhysicsCommon.UnsafeBuffer.ResetAndEnsureCapacity<ConstraintData>
	|-PhysicsCommon.UnsafeBuffer.ResetAndEnsureCapacity<IntPtr>
	|-PhysicsCommon.UnsafeBuffer.ResetAndEnsureCapacity<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2220E60 Offset: 0x221F460 VA: 0x182220E60
	public void* ResetAndEnsureCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x2220B80 Offset: 0x221F180 VA: 0x182220B80
	public void Dispose(Native.Allocator allocator) { }
}
