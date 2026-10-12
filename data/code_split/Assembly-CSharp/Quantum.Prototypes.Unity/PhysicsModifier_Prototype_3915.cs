// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PhysicsModifier))]
[Serializable]
public class PhysicsModifier_Prototype : PrototypeAdapter<PhysicsModifier_Prototype> // TypeDefIndex: 3915
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public PhysicsModifierInfo_Prototype ModifierInfo; // 0x18

	// Methods

	// RVA: 0x67C790 Offset: 0x67AD90 VA: 0x18067C790 Slot: 5
	public sealed override PhysicsModifier_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x67C830 Offset: 0x67AE30 VA: 0x18067C830
	public void .ctor() { }
}
