// Namespace: 
[RequireComponent(typeof(EntityPrototype))]
public abstract class EntityComponentBase : MonoBehaviour // TypeDefIndex: 2317
{
	// Fields
	private const string ExpectedTypeNamePrefix = "EntityComponent";

	// Properties
	public abstract Type PrototypeType { get; }
	public Type ComponentType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_PrototypeType();

	// RVA: 0x50D960 Offset: 0x50BF60 VA: 0x18050D960
	public Type get_ComponentType() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void Refresh() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ComponentPrototype CreatePrototype(EntityPrototypeConverter converter);

	// RVA: 0x50D6D0 Offset: 0x50BCD0 VA: 0x18050D6D0
	public static Type UnityComponentTypeToQuantumPrototypeType(Type type) { }

	// RVA: 0x50D6B0 Offset: 0x50BCB0 VA: 0x18050D6B0
	public static Type UnityComponentTypeToQuantumComponentType(Type type) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	protected void .ctor() { }
}
