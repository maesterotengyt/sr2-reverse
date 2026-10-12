// Namespace: Quantum
internal class SynchronizedQueue<T> // TypeDefIndex: 11517
{
	// Fields
	private object _lock; // 0x0
	private Queue<T> _r; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Enqueue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1413FD0 Offset: 0x14125D0 VA: 0x181413FD0
	|-SynchronizedQueue<object>.Enqueue
	|
	|-RVA: 0x1414090 Offset: 0x1412690 VA: 0x181414090
	|-SynchronizedQueue<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414390 Offset: 0x1412990 VA: 0x181414390
	|-SynchronizedQueue<object>.TryDequeue
	|
	|-RVA: 0x14141E0 Offset: 0x14127E0 VA: 0x1814141E0
	|-SynchronizedQueue<__Il2CppFullySharedGenericType>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414580 Offset: 0x1412B80 VA: 0x181414580
	|-SynchronizedQueue<object>..ctor
	|
	|-RVA: 0x14144B0 Offset: 0x1412AB0 VA: 0x1814144B0
	|-SynchronizedQueue<__Il2CppFullySharedGenericType>..ctor
	*/
}
