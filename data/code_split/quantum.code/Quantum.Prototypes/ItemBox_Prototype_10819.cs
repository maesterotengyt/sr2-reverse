// Namespace: Quantum.Prototypes
[Prototype(typeof(ItemBox))]
[Serializable]
public sealed class ItemBox_Prototype : ComponentPrototype<ItemBox> // TypeDefIndex: 10819
{
	// Fields
	public QString64 ForcedItem; // 0x18

	// Methods

	// RVA: 0x2107DF0 Offset: 0x21063F0 VA: 0x182107DF0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FDB90 Offset: 0x20FC190 VA: 0x1820FDB90
	public void Materialize(Frame frame, ref ItemBox result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2107EC0 Offset: 0x21064C0 VA: 0x182107EC0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2107F50 Offset: 0x2106550 VA: 0x182107F50
	public void .ctor() { }
}
