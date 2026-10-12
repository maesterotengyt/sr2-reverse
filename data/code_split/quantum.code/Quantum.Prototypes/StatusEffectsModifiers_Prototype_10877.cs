// Namespace: Quantum.Prototypes
[Prototype(typeof(StatusEffectsModifiers))]
[Serializable]
public sealed class StatusEffectsModifiers_Prototype : ComponentPrototype<StatusEffectsModifiers> // TypeDefIndex: 10877
{
	// Fields
	public MapEntityId Entity; // 0x18
	public FP OriginalScale; // 0x20
	public StatusEffectAttribute_Prototype KnockbackAttribute; // 0x28
	public StatusEffectAttribute_Prototype DamageAttribute; // 0x30
	public StatusEffectAttribute_Prototype ScaleAttribute; // 0x38
	[DynamicCollection]
	public StatusEffectAttributeModifier_Prototype[] KnockbackModifiers; // 0x40
	[DynamicCollection]
	public StatusEffectAttributeModifier_Prototype[] DamageModifiers; // 0x48
	[DynamicCollection]
	public StatusEffectAttributeModifier_Prototype[] ScaleModifiers; // 0x50

	// Methods

	// RVA: 0x21122D0 Offset: 0x21108D0 VA: 0x1821122D0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21124D0 Offset: 0x2110AD0 VA: 0x1821124D0
	public void Materialize(Frame frame, ref StatusEffectsModifiers result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2112440 Offset: 0x2110A40 VA: 0x182112440 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2112920 Offset: 0x2110F20 VA: 0x182112920
	public void .ctor() { }
}
