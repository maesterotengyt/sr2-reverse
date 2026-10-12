// Namespace: 
public abstract class EntityComponentBase<TPrototype> : EntityComponentBase // TypeDefIndex: 2318
{
	// Fields
	[FormerlySerializedAs("prototype")]
	public TPrototype Prototype; // 0x0

	// Properties
	public override Type PrototypeType { get; }
	[Obsolete("Use Prototype field")]
	public TPrototype prototype { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override Type get_PrototypeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD8B270 Offset: 0xD89870 VA: 0x180D8B270
	|-EntityComponentBase<object>.get_PrototypeType
	*/

	// RVA: -1 Offset: -1
	public TPrototype get_prototype() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	|-EntityComponentBase<object>.get_prototype
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override ComponentPrototype CreatePrototype(EntityPrototypeConverter converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	|-EntityComponentBase<object>.CreatePrototype
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C4050 Offset: 0x19C2650 VA: 0x1819C4050
	|-EntityComponentBase<object>..ctor
	*/
}
