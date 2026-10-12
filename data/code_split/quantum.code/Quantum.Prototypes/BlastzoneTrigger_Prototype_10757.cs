// Namespace: Quantum.Prototypes
[Prototype(typeof(BlastzoneTrigger))]
[Serializable]
public sealed class BlastzoneTrigger_Prototype : ComponentPrototype<BlastzoneTrigger> // TypeDefIndex: 10757
{
	// Fields
	public MapEntityId RespawnPoint; // 0x18

	// Methods

	// RVA: 0x20FC930 Offset: 0x20FAF30 VA: 0x1820FC930 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCA90 Offset: 0x20FB090 VA: 0x1820FCA90
	public void Materialize(Frame frame, ref BlastzoneTrigger result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCA00 Offset: 0x20FB000 VA: 0x1820FCA00 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FCAA0 Offset: 0x20FB0A0 VA: 0x1820FCAA0
	public void .ctor() { }
}
