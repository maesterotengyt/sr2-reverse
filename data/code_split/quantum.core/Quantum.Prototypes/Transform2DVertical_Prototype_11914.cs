// Namespace: Quantum.Prototypes
[Prototype(typeof(Transform2DVertical))]
[Serializable]
public sealed class Transform2DVertical_Prototype : ComponentPrototype<Transform2DVertical> // TypeDefIndex: 11914
{
	// Fields
	public FP Position; // 0x18
	public FP Height; // 0x20

	// Methods

	// RVA: 0x227EE90 Offset: 0x227D490 VA: 0x18227EE90 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2103A40 Offset: 0x2102040 VA: 0x182103A40
	public void Materialize(FrameBase frame, ref Transform2DVertical result) { }

	// RVA: 0x227EF10 Offset: 0x227D510 VA: 0x18227EF10 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227EF40 Offset: 0x227D540 VA: 0x18227EF40
	public void .ctor() { }
}
