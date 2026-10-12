// Namespace: Quantum.Prototypes
[Prototype(typeof(StageBounds))]
[Serializable]
public sealed class StageBounds_Prototype : ComponentPrototype<StageBounds> // TypeDefIndex: 10865
{
	// Fields
	public FPVector2 TopLeft; // 0x18
	public FPVector2 BottomRight; // 0x28

	// Methods

	// RVA: 0x2110440 Offset: 0x210EA40 VA: 0x182110440 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF1B0 Offset: 0x20FD7B0 VA: 0x1820FF1B0
	public void Materialize(Frame frame, ref StageBounds result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110510 Offset: 0x210EB10 VA: 0x182110510 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21105A0 Offset: 0x210EBA0 VA: 0x1821105A0
	public void .ctor() { }
}
