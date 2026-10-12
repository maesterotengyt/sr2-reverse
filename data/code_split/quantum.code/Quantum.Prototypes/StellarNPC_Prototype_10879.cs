// Namespace: Quantum.Prototypes
[Prototype(typeof(StellarNPC))]
[Serializable]
public sealed class StellarNPC_Prototype : ComponentPrototype<StellarNPC> // TypeDefIndex: 10879
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	public int Difficulty; // 0x20

	// Methods

	// RVA: 0x2112D80 Offset: 0x2111380 VA: 0x182112D80 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2112EF0 Offset: 0x21114F0 VA: 0x182112EF0
	public void Materialize(Frame frame, ref StellarNPC result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2112E60 Offset: 0x2111460 VA: 0x182112E60 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2112F10 Offset: 0x2111510 VA: 0x182112F10
	public void .ctor() { }
}
