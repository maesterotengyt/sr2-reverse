// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(CombatCharge))]
[Serializable]
public class CombatCharge_Prototype : PrototypeAdapter<CombatCharge_Prototype> // TypeDefIndex: 3881
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public QBoolean UseChargeMultiplier; // 0x18
	[HideInInspector]
	public int ChargeAttackMultiplierID; // 0x1C
	[HideInInspector]
	public FP ChargeAttackPower; // 0x20

	// Methods

	// RVA: 0x672B50 Offset: 0x671150 VA: 0x180672B50 Slot: 5
	public sealed override CombatCharge_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x672BF0 Offset: 0x6711F0 VA: 0x180672BF0
	public void .ctor() { }
}
