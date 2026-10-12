// Namespace: Quantum
public struct ComponentIterator<T> // TypeDefIndex: 11540
{
	// Fields
	private FrameBase _f; // 0x0
	private int _count; // 0x0
	private int _version; // 0x0
	private ComponentDataBuffer* _buffer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(FrameBase f, ComponentDataBuffer* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BBB10 Offset: 0x17BA110 VA: 0x1817BBB10
	|-ComponentIterator<MapEntityLink>..ctor
	|-ComponentIterator<View>..ctor
	|-ComponentIterator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ComponentIterator.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BB9A0 Offset: 0x17B9FA0 VA: 0x1817BB9A0
	|-ComponentIterator<MapEntityLink>.GetEnumerator
	|-ComponentIterator<View>.GetEnumerator
	|-ComponentIterator<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void VerifyVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BBA30 Offset: 0x17BA030 VA: 0x1817BBA30
	|-ComponentIterator<MapEntityLink>.VerifyVersion
	|-ComponentIterator<View>.VerifyVersion
	|-ComponentIterator<__Il2CppFullySharedGenericStructType>.VerifyVersion
	*/
}
