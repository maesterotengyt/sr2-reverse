// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatDI))]
[Serializable]
public sealed class CombatDI_Prototype : ComponentPrototype<CombatDI> // TypeDefIndex: 10776
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public QBoolean CalculateDI; // 0x1C
	[HideInInspector]
	public FP DIAngle; // 0x20
	[HideInInspector]
	public FPVector2 SDI; // 0x28
	[HideInInspector]
	public int TriggeredSDIs; // 0x38

	// Methods

	// RVA: 0x20FF890 Offset: 0x20FDE90 VA: 0x1820FF890 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FFA40 Offset: 0x20FE040 VA: 0x1820FFA40
	public void Materialize(Frame frame, ref CombatDI result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF9B0 Offset: 0x20FDFB0 VA: 0x1820FF9B0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FFA90 Offset: 0x20FE090 VA: 0x1820FFA90
	public void .ctor() { }
}
