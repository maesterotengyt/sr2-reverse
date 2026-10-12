// Namespace: Quantum.Prototypes
[Prototype(typeof(Teams))]
[Serializable]
public sealed class Teams_Prototype : ComponentPrototype<Teams> // TypeDefIndex: 10882
{
	// Fields
	public int TeamIndex; // 0x18

	// Methods

	// RVA: 0x2113170 Offset: 0x2111770 VA: 0x182113170 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FC8E0 Offset: 0x20FAEE0 VA: 0x1820FC8E0
	public void Materialize(Frame frame, ref Teams result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113220 Offset: 0x2111820 VA: 0x182113220 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21132B0 Offset: 0x21118B0 VA: 0x1821132B0
	public void .ctor() { }
}
