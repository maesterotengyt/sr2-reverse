// Namespace: Quantum
[Serializable]
public abstract class ComponentPrototype : IPrototype // TypeDefIndex: 11544
{
	// Fields
	private int _componentTypeId; // 0x10

	// Properties
	public abstract Type ComponentType { get; }
	public int ComponentTypeId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ComponentType();

	// RVA: 0x21C73F0 Offset: 0x21C59F0 VA: 0x1821C73F0
	public int get_ComponentTypeId() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Dispatch(ComponentPrototypeVisitorBase visitor);

	// RVA: 0x21C71A0 Offset: 0x21C57A0 VA: 0x1821C71A0
	public static Type PrototypeTypeToComponentType(Type prototypeType) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
