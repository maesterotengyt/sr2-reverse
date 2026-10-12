// Namespace: Quantum.Prototypes
[Prototype(typeof(EnergyBar))]
[Serializable]
public sealed class EnergyBar_Prototype : ComponentPrototype<EnergyBar> // TypeDefIndex: 10791
{
	// Fields
	[HideInInspector]
	public FP CurrentEnergy; // 0x18
	[HideInInspector]
	public FP MaxEnergy; // 0x20

	// Methods

	// RVA: 0x21038F0 Offset: 0x2101EF0 VA: 0x1821038F0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2103A40 Offset: 0x2102040 VA: 0x182103A40
	public void Materialize(Frame frame, ref EnergyBar result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21039B0 Offset: 0x2101FB0 VA: 0x1821039B0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2103A50 Offset: 0x2102050 VA: 0x182103A50
	public void .ctor() { }
}
