// Namespace: Quantum.Prototypes
[Prototype(typeof(EntityModifierTarget))]
[Serializable]
public sealed class EntityModifierTarget_Prototype : ComponentPrototype<EntityModifierTarget> // TypeDefIndex: 10795
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	[DynamicCollection]
	public MapEntityId[] EntityModifiers; // 0x20
	[HideInInspector]
	[DynamicCollection]
	public MapEntityId[] PhysicsModifiers; // 0x28
	[HideInInspector]
	public EntityModifierInfo_Prototype EntityModifier; // 0x30
	[HideInInspector]
	public PhysicsModifierInfo_Prototype PhysicsModifier; // 0x38

	// Methods

	// RVA: 0x2103B30 Offset: 0x2102130 VA: 0x182103B30 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2103CF0 Offset: 0x21022F0 VA: 0x182103CF0
	public void Materialize(Frame frame, ref EntityModifierTarget result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2103C60 Offset: 0x2102260 VA: 0x182103C60 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2103FE0 Offset: 0x21025E0 VA: 0x182103FE0
	public void .ctor() { }
}
