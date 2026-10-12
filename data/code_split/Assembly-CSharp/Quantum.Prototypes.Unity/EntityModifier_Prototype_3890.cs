// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(EntityModifier))]
[Serializable]
public class EntityModifier_Prototype : PrototypeAdapter<EntityModifier_Prototype> // TypeDefIndex: 3890
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public EntityModifierInfo_Prototype ModifierInfo; // 0x18

	// Methods

	// RVA: 0x675640 Offset: 0x673C40 VA: 0x180675640 Slot: 5
	public sealed override EntityModifier_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6756E0 Offset: 0x673CE0 VA: 0x1806756E0
	public void .ctor() { }
}
