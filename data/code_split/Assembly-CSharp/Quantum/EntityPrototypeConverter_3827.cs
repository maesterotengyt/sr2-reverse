// Namespace: Quantum
public class EntityPrototypeConverter // TypeDefIndex: 3827
{
	// Fields
	public readonly EntityPrototype[] OrderedMapPrototypes; // 0x10
	public readonly EntityPrototype AssetPrototype; // 0x18
	public readonly MapData Map; // 0x20

	// Methods

	// RVA: 0x65AE30 Offset: 0x659430 VA: 0x18065AE30
	public void .ctor(MapData map, EntityPrototype[] orderedMapPrototypes) { }

	// RVA: 0x65AE80 Offset: 0x659480 VA: 0x18065AE80
	public void .ctor(EntityPrototype prototypeAsset) { }

	// RVA: 0x65A900 Offset: 0x658F00 VA: 0x18065A900
	public void Convert(EntityPrototype prototype, out MapEntityId result) { }

	// RVA: 0x65A9E0 Offset: 0x658FE0 VA: 0x18065A9E0
	public void Convert(EntityPrototypeRefWrapper prototype, out EntityPrototypeRef result) { }

	// RVA: 0x65AB40 Offset: 0x659140 VA: 0x18065AB40
	public void Convert(ComponentPrototypeRefWrapperBase prototype, out ComponentPrototypeRef_Prototype result) { }
}
