// Namespace: Quantum.Prototypes
[Prototype(typeof(CollectorsTreasureSpawnArea))]
[Serializable]
public sealed class CollectorsTreasureSpawnArea_Prototype : ComponentPrototype<CollectorsTreasureSpawnArea> // TypeDefIndex: 10771
{
	// Fields
	public FPVector2 TopLeft; // 0x18
	public FPVector2 BottomRight; // 0x28

	// Methods

	// RVA: 0x20FF050 Offset: 0x20FD650 VA: 0x1820FF050 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF1B0 Offset: 0x20FD7B0 VA: 0x1820FF1B0
	public void Materialize(Frame frame, ref CollectorsTreasureSpawnArea result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF120 Offset: 0x20FD720 VA: 0x1820FF120 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FF1D0 Offset: 0x20FD7D0 VA: 0x1820FF1D0
	public void .ctor() { }
}
