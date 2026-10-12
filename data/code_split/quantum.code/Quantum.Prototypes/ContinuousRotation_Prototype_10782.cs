// Namespace: Quantum.Prototypes
[Prototype(typeof(ContinuousRotation))]
[Serializable]
public sealed class ContinuousRotation_Prototype : ComponentPrototype<ContinuousRotation> // TypeDefIndex: 10782
{
	// Fields
	public QBoolean Active; // 0x18
	public FP InitialRotation; // 0x20
	public FP RotationSpeed; // 0x28

	// Methods

	// RVA: 0x2101010 Offset: 0x20FF610 VA: 0x182101010 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2101180 Offset: 0x20FF780 VA: 0x182101180
	public void Materialize(Frame frame, ref ContinuousRotation result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21010F0 Offset: 0x20FF6F0 VA: 0x1821010F0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21011A0 Offset: 0x20FF7A0 VA: 0x1821011A0
	public void .ctor() { }
}
