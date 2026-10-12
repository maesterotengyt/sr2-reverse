// Namespace: Quantum.Prototypes
[Prototype(typeof(CollectorTreasure))]
[Serializable]
public sealed class CollectorTreasure_Prototype : ComponentPrototype<CollectorTreasure> // TypeDefIndex: 10769
{
	// Fields
	public int Value; // 0x18

	// Methods

	// RVA: 0x20FEA10 Offset: 0x20FD010 VA: 0x1820FEA10 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC8E0 Offset: 0x20FAEE0 VA: 0x1820FC8E0
	public void Materialize(Frame frame, ref CollectorTreasure result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FEAC0 Offset: 0x20FD0C0 VA: 0x1820FEAC0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FEB50 Offset: 0x20FD150 VA: 0x1820FEB50
	public void .ctor() { }
}
