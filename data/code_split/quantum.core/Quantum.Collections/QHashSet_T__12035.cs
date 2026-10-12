// Namespace: Quantum.Collections
public struct QHashSet<T> // TypeDefIndex: 12035
{
	// Fields
	private QHashCollection* _hashCollection; // 0x0
	private IFrameHeap _heap; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IFrameHeap heap, QHashCollection* hashCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124C190 Offset: 0x124A790 VA: 0x18124C190
	|-QHashSet<AssetGuid>..ctor
	|-QHashSet<int>..ctor
	|-QHashSet<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static QHashSetPtr<T> op_Implicit(QHashSet<T> hashSet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124C2A0 Offset: 0x124A8A0 VA: 0x18124C2A0
	|-QHashSet<AssetGuid>.op_Implicit
	|
	|-RVA: 0x124C1A0 Offset: 0x124A7A0 VA: 0x18124C1A0
	|-QHashSet<int>.op_Implicit
	|
	|-RVA: 0x124C220 Offset: 0x124A820 VA: 0x18124C220
	|-QHashSet<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	internal void Free() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124C090 Offset: 0x124A690 VA: 0x18124C090
	|-QHashSet<AssetGuid>.Free
	|
	|-RVA: 0x124C010 Offset: 0x124A610 VA: 0x18124C010
	|-QHashSet<int>.Free
	|
	|-RVA: 0x124C110 Offset: 0x124A710 VA: 0x18124C110
	|-QHashSet<__Il2CppFullySharedGenericStructType>.Free
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124BF70 Offset: 0x124A570 VA: 0x18124BF70
	|-QHashSet<AssetGuid>.Contains
	|
	|-RVA: 0x124BCE0 Offset: 0x124A2E0 VA: 0x18124BCE0
	|-QHashSet<int>.Contains
	|
	|-RVA: 0x124BD80 Offset: 0x124A380 VA: 0x18124BD80
	|-QHashSet<__Il2CppFullySharedGenericStructType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124BC20 Offset: 0x124A220 VA: 0x18124BC20
	|-QHashSet<AssetGuid>.Clear
	|
	|-RVA: 0x124BCA0 Offset: 0x124A2A0 VA: 0x18124BCA0
	|-QHashSet<int>.Clear
	|
	|-RVA: 0x124BC60 Offset: 0x124A260 VA: 0x18124BC60
	|-QHashSet<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x124B7B0 Offset: 0x1249DB0 VA: 0x18124B7B0
	|-QHashSet<AssetGuid>.Add
	|
	|-RVA: 0x124BB30 Offset: 0x124A130 VA: 0x18124BB30
	|-QHashSet<int>.Add
	|
	|-RVA: 0x124B8A0 Offset: 0x1249EA0 VA: 0x18124B8A0
	|-QHashSet<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public static QHashSet<T> Allocate<THeap>(THeap heap, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF440 Offset: 0x9ADA40 VA: 0x1809AF440
	|-QHashSet<AssetGuid>.Allocate<object>
	|
	|-RVA: 0x9AF4C0 Offset: 0x9ADAC0 VA: 0x1809AF4C0
	|-QHashSet<int>.Allocate<object>
	|
	|-RVA: 0x9AF2C0 Offset: 0x9AD8C0 VA: 0x1809AF2C0
	|-QHashSet<__Il2CppFullySharedGenericStructType>.Allocate<__Il2CppFullySharedGenericType>
	*/
}
