// Namespace: Quantum.Prototypes
[Prototype(typeof(StageTimeline))]
[Serializable]
public sealed class StageTimeline_Prototype : ComponentPrototype<StageTimeline> // TypeDefIndex: 10870
{
	// Fields
	public FP StageFrameTime; // 0x18
	public FP FrameCheckInterval; // 0x20

	// Methods

	// RVA: 0x2110EF0 Offset: 0x210F4F0 VA: 0x182110EF0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2111040 Offset: 0x210F640 VA: 0x182111040
	public void Materialize(Frame frame, ref StageTimeline result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110FB0 Offset: 0x210F5B0 VA: 0x182110FB0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2111050 Offset: 0x210F650 VA: 0x182111050
	public void .ctor() { }
}
