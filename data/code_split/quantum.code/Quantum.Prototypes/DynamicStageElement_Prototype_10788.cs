// Namespace: Quantum.Prototypes
[Prototype(typeof(DynamicStageElement))]
[Serializable]
public sealed class DynamicStageElement_Prototype : ComponentPrototype<DynamicStageElement> // TypeDefIndex: 10788
{
	// Fields
	public QBoolean Active; // 0x18
	public LoopMode_Prototype LoopMode; // 0x1C
	public QBoolean BackwardsMode; // 0x20
	public FP CurrentFrame; // 0x28
	public AssetRefTransformKeyFramesData TransformKeyFramesData; // 0x30

	// Methods

	// RVA: 0x2102E70 Offset: 0x2101470 VA: 0x182102E70 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2103000 Offset: 0x2101600 VA: 0x182103000
	public void Materialize(Frame frame, ref DynamicStageElement result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2102F70 Offset: 0x2101570 VA: 0x182102F70 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2103030 Offset: 0x2101630 VA: 0x182103030
	public void .ctor() { }
}
