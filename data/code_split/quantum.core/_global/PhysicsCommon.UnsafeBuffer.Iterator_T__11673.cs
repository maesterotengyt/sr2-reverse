// Namespace: 
public struct PhysicsCommon.UnsafeBuffer.Iterator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 11673
{
	// Fields
	private PhysicsCommon.UnsafeBuffer _ub; // 0x0
	private int _curIndex; // 0x0
	private readonly sbyte _inc; // 0x0

	// Properties
	public T* CurrentUnsafe { get; }
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(PhysicsCommon.UnsafeBuffer ub, bool reverseOrder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE780 Offset: 0xDCCD80 VA: 0x180DCE780
	|-PhysicsCommon.UnsafeBuffer.Iterator<IntPtr>..ctor
	|-PhysicsCommon.UnsafeBuffer.Iterator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE500 Offset: 0xDCCB00 VA: 0x180DCE500
	|-PhysicsCommon.UnsafeBuffer.Iterator<IntPtr>.MoveNext
	|-PhysicsCommon.UnsafeBuffer.Iterator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE520 Offset: 0xDCCB20 VA: 0x180DCE520
	|-PhysicsCommon.UnsafeBuffer.Iterator<IntPtr>.Reset
	|-PhysicsCommon.UnsafeBuffer.Iterator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1
	public T* get_CurrentUnsafe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE7B0 Offset: 0xDCCDB0 VA: 0x180DCE7B0
	|-PhysicsCommon.UnsafeBuffer.Iterator<IntPtr>.get_CurrentUnsafe
	|
	|-RVA: 0xDD10F0 Offset: 0xDCF6F0 VA: 0x180DD10F0
	|-PhysicsCommon.UnsafeBuffer.Iterator<__Il2CppFullySharedGenericStructType>.get_CurrentUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE810 Offset: 0xDCCE10 VA: 0x180DCE810
	|-PhysicsCommon.UnsafeBuffer.Iterator<IntPtr>.get_Current
	|
	|-RVA: 0xDD1190 Offset: 0xDCF790 VA: 0x180DD1190
	|-PhysicsCommon.UnsafeBuffer.Iterator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCE6B0 Offset: 0xDCCCB0 VA: 0x180DCE6B0
	|-PhysicsCommon.UnsafeBuffer.Iterator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xDD0C80 Offset: 0xDCF280 VA: 0x180DD0C80
	|-PhysicsCommon.UnsafeBuffer.Iterator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	|-PhysicsCommon.UnsafeBuffer.Iterator<IntPtr>.Dispose
	|-PhysicsCommon.UnsafeBuffer.Iterator<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}
