// Namespace: Quantum.Prototypes
[Prototype(typeof(MechanicTutorialGoalTrigger))]
[Serializable]
public sealed class MechanicTutorialGoalTrigger_Prototype : ComponentPrototype<MechanicTutorialGoalTrigger> // TypeDefIndex: 10826
{
	// Fields
	public QString64 GoalID; // 0x18
	public FP RequiredHorizontalVelocity; // 0x58
	public QBoolean UseAbsoluteHorizontal; // 0x60
	public FP RequiredVerticalVelocity; // 0x68
	public QBoolean UseAbsoluteVertical; // 0x70
	public FP RequiredTotalVelocity; // 0x78
	public QString64 RequiredState; // 0x80
	public QString64 RequiredPreviousState; // 0xC0

	// Methods

	// RVA: 0x2109110 Offset: 0x2107710 VA: 0x182109110 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21093F0 Offset: 0x21079F0 VA: 0x1821093F0
	public void Materialize(Frame frame, ref MechanicTutorialGoalTrigger result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2109360 Offset: 0x2107960 VA: 0x182109360 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21094B0 Offset: 0x2107AB0 VA: 0x1821094B0
	public void .ctor() { }
}
