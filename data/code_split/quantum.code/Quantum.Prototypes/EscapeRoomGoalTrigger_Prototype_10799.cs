// Namespace: Quantum.Prototypes
[Prototype(typeof(EscapeRoomGoalTrigger))]
[Serializable]
public sealed class EscapeRoomGoalTrigger_Prototype : ComponentPrototype<EscapeRoomGoalTrigger> // TypeDefIndex: 10799
{
	// Fields
	public QString64 GoalID; // 0x18

	// Methods

	// RVA: 0x2104E80 Offset: 0x2103480 VA: 0x182104E80 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FDB90 Offset: 0x20FC190 VA: 0x1820FDB90
	public void Materialize(Frame frame, ref EscapeRoomGoalTrigger result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2104F50 Offset: 0x2103550 VA: 0x182104F50 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2104FE0 Offset: 0x21035E0 VA: 0x182104FE0
	public void .ctor() { }
}
