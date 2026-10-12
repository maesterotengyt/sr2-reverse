// Namespace: Quantum
[IsReadOnly]
public struct PrototypeMaterializationContext // TypeDefIndex: 11575
{
	// Fields
	public readonly EntityRef Entity; // 0x0
	public readonly EntityPrototypeRef EntityPrototypeRef; // 0x8
	public readonly int ComponentTypeIndex; // 0x18
	public readonly EntityPrototypeContainer EntityPrototypeContainer; // 0x20
	private readonly EntityRef[] _entities; // 0x28

	// Methods

	// RVA: 0x21D6CA0 Offset: 0x21D52A0 VA: 0x1821D6CA0
	internal void .ctor(EntityRef entity, EntityPrototypeRef prototypeRef, EntityPrototypeContainer container, int componentIndex, EntityRef[] entities) { }

	// RVA: 0x21D6C30 Offset: 0x21D5230 VA: 0x1821D6C30
	public bool TryGetEntityRef(MapEntityId id, out EntityRef entityRef) { }
}
