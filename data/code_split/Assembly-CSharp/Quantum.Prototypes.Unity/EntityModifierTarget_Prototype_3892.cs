// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(EntityModifierTarget))]
[Serializable]
public class EntityModifierTarget_Prototype : PrototypeAdapter<EntityModifierTarget_Prototype> // TypeDefIndex: 3892
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] EntityModifiers; // 0x18
	[HideInInspector]
	[DynamicCollection]
	[LocalReference]
	public EntityPrototype[] PhysicsModifiers; // 0x20
	[HideInInspector]
	public EntityModifierInfo_Prototype EntityModifier; // 0x28
	[HideInInspector]
	public PhysicsModifierInfo_Prototype PhysicsModifier; // 0x30

	// Methods

	// RVA: 0x6753F0 Offset: 0x6739F0 VA: 0x1806753F0 Slot: 5
	public sealed override EntityModifierTarget_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6755C0 Offset: 0x673BC0 VA: 0x1806755C0
	public void .ctor() { }
}
