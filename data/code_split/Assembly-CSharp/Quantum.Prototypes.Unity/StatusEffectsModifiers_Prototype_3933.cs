// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(StatusEffectsModifiers))]
[Serializable]
public class StatusEffectsModifiers_Prototype : PrototypeAdapter<StatusEffectsModifiers_Prototype> // TypeDefIndex: 3933
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public FP OriginalScale; // 0x18
	public StatusEffectAttribute_Prototype KnockbackAttribute; // 0x20
	public StatusEffectAttribute_Prototype DamageAttribute; // 0x28
	public StatusEffectAttribute_Prototype ScaleAttribute; // 0x30
	[DynamicCollection]
	public StatusEffectAttributeModifier_Prototype[] KnockbackModifiers; // 0x38
	[DynamicCollection]
	public StatusEffectAttributeModifier_Prototype[] DamageModifiers; // 0x40
	[DynamicCollection]
	public StatusEffectAttributeModifier_Prototype[] ScaleModifiers; // 0x48

	// Methods

	// RVA: 0x683450 Offset: 0x681A50 VA: 0x180683450 Slot: 5
	public sealed override StatusEffectsModifiers_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x683550 Offset: 0x681B50 VA: 0x180683550
	public void .ctor() { }
}
