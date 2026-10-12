// Namespace: Quantum
public abstract class PrototypeAdapter<PrototypeType> : PrototypeAdapter // TypeDefIndex: 3814
{
	// Properties
	public sealed override Type PrototypedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public sealed override Type get_PrototypedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD8B270 Offset: 0xD89870 VA: 0x180D8B270
	|-PrototypeAdapter<object>.get_PrototypedType
	|-PrototypeAdapter<__Il2CppFullySharedGenericType>.get_PrototypedType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PrototypeType Convert(EntityPrototypeConverter converter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PrototypeAdapter<__Il2CppFullySharedGenericType>.Convert
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	|-PrototypeAdapter<object>..ctor
	|-PrototypeAdapter<__Il2CppFullySharedGenericType>..ctor
	*/
}
