// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(StatusEffectsHolder))]
[Serializable]
public class StatusEffectsHolder_Prototype : PrototypeAdapter<StatusEffectsHolder_Prototype> // TypeDefIndex: 3931
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	[DynamicCollection]
	public RuntimeStatusEffect_Prototype[] ActiveStatusEffects; // 0x18

	// Methods

	// RVA: 0x6832A0 Offset: 0x6818A0 VA: 0x1806832A0 Slot: 5
	public sealed override StatusEffectsHolder_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6833E0 Offset: 0x6819E0 VA: 0x1806833E0
	public void .ctor() { }
}
