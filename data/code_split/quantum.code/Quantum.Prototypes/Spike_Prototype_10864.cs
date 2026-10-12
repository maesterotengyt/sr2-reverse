// Namespace: Quantum.Prototypes
[Prototype(typeof(Spike))]
[Serializable]
public sealed class Spike_Prototype : ComponentPrototype<Spike> // TypeDefIndex: 10864
{
	// Fields
	public SpikeDirection_Prototype Direction; // 0x18

	// Methods

	// RVA: 0x21102C0 Offset: 0x210E8C0 VA: 0x1821102C0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC8E0 Offset: 0x20FAEE0 VA: 0x1820FC8E0
	public void Materialize(Frame frame, ref Spike result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110370 Offset: 0x210E970 VA: 0x182110370 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2110400 Offset: 0x210EA00 VA: 0x182110400
	public void .ctor() { }
}
