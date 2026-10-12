// Namespace: Quantum
public sealed class DispatchableHandler<T> : MulticastDelegate // TypeDefIndex: 11556
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4FB4B0 Offset: 0x4F9AB0 VA: 0x1804FB4B0
	|-DispatchableHandler<object>..ctor
	|
	|-RVA: 0x19AF920 Offset: 0x19ADF20 VA: 0x1819AF920
	|-DispatchableHandler<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4FA990 Offset: 0x4F8F90 VA: 0x1804FA990
	|-DispatchableHandler<object>.Invoke
	|-DispatchableHandler<__Il2CppFullySharedGenericType>.Invoke
	*/
}
