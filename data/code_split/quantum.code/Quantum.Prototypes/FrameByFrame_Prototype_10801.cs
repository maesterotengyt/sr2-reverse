// Namespace: Quantum.Prototypes
[Prototype(typeof(FrameByFrame))]
[Serializable]
public sealed class FrameByFrame_Prototype : ComponentPrototype<FrameByFrame> // TypeDefIndex: 10801
{
	// Fields
	public QBoolean AdvancingFrame; // 0x18
	public FP AdvanceFrameDelta; // 0x20

	// Methods

	// RVA: 0x2105050 Offset: 0x2103650 VA: 0x182105050 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21051B0 Offset: 0x21037B0 VA: 0x1821051B0
	public void Materialize(Frame frame, ref FrameByFrame result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2105120 Offset: 0x2103720 VA: 0x182105120 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21051C0 Offset: 0x21037C0 VA: 0x1821051C0
	public void .ctor() { }
}
