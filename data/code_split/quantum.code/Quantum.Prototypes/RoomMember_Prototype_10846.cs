// Namespace: Quantum.Prototypes
[Prototype(typeof(RoomMember))]
[Serializable]
public sealed class RoomMember_Prototype : ComponentPrototype<RoomMember> // TypeDefIndex: 10846
{
	// Fields
	public MapEntityId ParentRoom; // 0x18

	// Methods

	// RVA: 0x210D850 Offset: 0x210BE50 VA: 0x18210D850 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCA90 Offset: 0x20FB090 VA: 0x1820FCA90
	public void Materialize(Frame frame, ref RoomMember result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D920 Offset: 0x210BF20 VA: 0x18210D920 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210D9B0 Offset: 0x210BFB0 VA: 0x18210D9B0
	public void .ctor() { }
}
