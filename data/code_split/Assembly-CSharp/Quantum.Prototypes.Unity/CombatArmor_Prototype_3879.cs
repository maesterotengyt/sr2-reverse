// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CombatArmor))]
[Serializable]
public class CombatArmor_Prototype : PrototypeAdapter<CombatArmor_Prototype> // TypeDefIndex: 3879
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public FP Armor; // 0x18
	[HideInInspector]
	public QBoolean SuperArmor; // 0x20

	// Methods

	// RVA: 0x672990 Offset: 0x670F90 VA: 0x180672990 Slot: 5
	public sealed override CombatArmor_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672A20 Offset: 0x671020 VA: 0x180672A20
	public void .ctor() { }
}
