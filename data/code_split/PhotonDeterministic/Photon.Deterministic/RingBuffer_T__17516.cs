// Namespace: Photon.Deterministic
[DefaultMember("Item")]
internal class RingBuffer<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 17516
{
	// Fields
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _count; // 0x0
	private int _version; // 0x0
	private readonly T[] _array; // 0x0
	private readonly bool _overwrite; // 0x0

	// Properties
	public int Count { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67D180 Offset: 0x67B780 VA: 0x18067D180
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Count
	|-RingBuffer<DeterministicNetwork.NetworkSend>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391AC0 Offset: 0x13900C0 VA: 0x181391AC0
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_IsFull
	|-RingBuffer<DeterministicNetwork.NetworkSend>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391AB0 Offset: 0x13900B0 VA: 0x181391AB0
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_IsEmpty
	|-RingBuffer<DeterministicNetwork.NetworkSend>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391B70 Offset: 0x1390170 VA: 0x181391B70
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x1391AF0 Offset: 0x13900F0 VA: 0x181391AF0
	|-RingBuffer<DeterministicNetwork.NetworkSend>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391C60 Offset: 0x1390260 VA: 0x181391C60
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x1391DE0 Offset: 0x13903E0 VA: 0x181391DE0
	|-RingBuffer<DeterministicNetwork.NetworkSend>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int size, bool overwrite) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391A40 Offset: 0x1390040 VA: 0x181391A40
	|-RingBuffer<__Il2CppFullySharedGenericType>..ctor
	|-RingBuffer<DeterministicNetwork.NetworkSend>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13917E0 Offset: 0x138FDE0 VA: 0x1813917E0
	|-RingBuffer<__Il2CppFullySharedGenericType>.Push
	|
	|-RVA: 0x13916A0 Offset: 0x138FCA0 VA: 0x1813916A0
	|-RingBuffer<DeterministicNetwork.NetworkSend>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391360 Offset: 0x138F960 VA: 0x181391360
	|-RingBuffer<__Il2CppFullySharedGenericType>.Pop
	|
	|-RVA: 0x13915F0 Offset: 0x138FBF0 VA: 0x1813915F0
	|-RingBuffer<DeterministicNetwork.NetworkSend>.Pop
	*/

	[IteratorStateMachine(typeof(RingBuffer.<GetEnumerator>d__23<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391290 Offset: 0x138F890 VA: 0x181391290
	|-RingBuffer<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x1391200 Offset: 0x138F800 VA: 0x181391200
	|-RingBuffer<DeterministicNetwork.NetworkSend>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134B1E0 Offset: 0x13497E0 VA: 0x18134B1E0
	|-RingBuffer<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13919A0 Offset: 0x138FFA0 VA: 0x1813919A0
	|-RingBuffer<DeterministicNetwork.NetworkSend>.System.Collections.IEnumerable.GetEnumerator
	*/
}
