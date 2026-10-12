// Namespace: Quantum.Prototypes
[Prototype(typeof(NonDeterministicAnimation))]
[Serializable]
public sealed class NonDeterministicAnimation_Prototype : ComponentPrototype<NonDeterministicAnimation> // TypeDefIndex: 10830
{
	// Fields
	[MaxStringByteCount(126, "Unicode")]
	public string AnimationTrigger; // 0x18
	public StageExecutionMode_Prototype ExecutionMode; // 0x20

	// Methods

	// RVA: 0x2109CF0 Offset: 0x21082F0 VA: 0x182109CF0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2109F20 Offset: 0x2108520 VA: 0x182109F20
	public void Materialize(Frame frame, ref NonDeterministicAnimation result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2109E90 Offset: 0x2108490 VA: 0x182109E90 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2109F90 Offset: 0x2108590 VA: 0x182109F90
	public void .ctor() { }
}
