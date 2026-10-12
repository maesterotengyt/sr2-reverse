// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatCharge))]
[Serializable]
public sealed class CombatCharge_Prototype : ComponentPrototype<CombatCharge> // TypeDefIndex: 10775
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public QBoolean UseChargeMultiplier; // 0x1C
	[HideInInspector]
	public int ChargeAttackMultiplierID; // 0x20
	[HideInInspector]
	public FP ChargeAttackPower; // 0x28

	// Methods

	// RVA: 0x20FF670 Offset: 0x20FDC70 VA: 0x1820FF670 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF800 Offset: 0x20FDE00 VA: 0x1820FF800
	public void Materialize(Frame frame, ref CombatCharge result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF770 Offset: 0x20FDD70 VA: 0x1820FF770 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FF850 Offset: 0x20FDE50 VA: 0x1820FF850
	public void .ctor() { }
}
