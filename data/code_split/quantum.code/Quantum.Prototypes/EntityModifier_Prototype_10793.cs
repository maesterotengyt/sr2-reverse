// Namespace: Quantum.Prototypes
[Prototype(typeof(EntityModifier))]
[Serializable]
public sealed class EntityModifier_Prototype : ComponentPrototype<EntityModifier> // TypeDefIndex: 10793
{
	// Fields
	public MapEntityId Entity; // 0x18
	public EntityModifierInfo_Prototype ModifierInfo; // 0x20

	// Methods

	// RVA: 0x2104070 Offset: 0x2102670 VA: 0x182104070 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2104200 Offset: 0x2102800 VA: 0x182104200
	public void Materialize(Frame frame, ref EntityModifier result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2104170 Offset: 0x2102770 VA: 0x182104170 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2104250 Offset: 0x2102850 VA: 0x182104250
	public void .ctor() { }
}
