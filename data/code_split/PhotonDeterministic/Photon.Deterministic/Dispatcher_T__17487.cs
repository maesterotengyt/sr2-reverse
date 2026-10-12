// Namespace: Photon.Deterministic
public class Dispatcher<T> // TypeDefIndex: 17487
{
	// Fields
	private readonly Dictionary<Type, Action<T>> _callbacks; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Bind<K>(Action<K> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A8F20 Offset: 0x9A7520 VA: 0x1809A8F20
	|-Dispatcher<object>.Bind<object>
	|
	|-RVA: 0x9A8DE0 Offset: 0x9A73E0 VA: 0x1809A8DE0
	|-Dispatcher<__Il2CppFullySharedGenericType>.Bind<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void DispatchNext(Queue<T> queue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AFCA0 Offset: 0x19AE2A0 VA: 0x1819AFCA0
	|-Dispatcher<object>.DispatchNext
	|
	|-RVA: 0x19AFD00 Offset: 0x19AE300 VA: 0x1819AFD00
	|-Dispatcher<__Il2CppFullySharedGenericType>.DispatchNext
	*/

	// RVA: -1 Offset: -1
	public void Dispatch(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B0190 Offset: 0x19AE790 VA: 0x1819B0190
	|-Dispatcher<object>.Dispatch
	|
	|-RVA: 0x19AFE10 Offset: 0x19AE410 VA: 0x1819AFE10
	|-Dispatcher<__Il2CppFullySharedGenericType>.Dispatch
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B0310 Offset: 0x19AE910 VA: 0x1819B0310
	|-Dispatcher<object>..ctor
	|
	|-RVA: 0x19B0390 Offset: 0x19AE990 VA: 0x1819B0390
	|-Dispatcher<__Il2CppFullySharedGenericType>..ctor
	*/
}
