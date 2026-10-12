// Namespace: Quantum.Prototypes
[Prototype(typeof(BreakableGlass))]
[Serializable]
public sealed class BreakableGlass_Prototype : ComponentPrototype<BreakableGlass> // TypeDefIndex: 10759
{
	// Fields
	public FP VelocityToBreak; // 0x18
	public QBoolean IsRestorable; // 0x20
	public int FramesToRestore; // 0x24
	public QString64 GoalOnBreak; // 0x28

	// Methods

	// RVA: 0x20FCED0 Offset: 0x20FB4D0 VA: 0x1820FCED0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FD080 Offset: 0x20FB680 VA: 0x1820FD080
	public void Materialize(Frame frame, ref BreakableGlass result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FCFF0 Offset: 0x20FB5F0 VA: 0x1820FCFF0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FD0C0 Offset: 0x20FB6C0 VA: 0x1820FD0C0
	public void .ctor() { }
}
