// Namespace: Quantum.Prototypes
[Prototype(typeof(Transform2D))]
[Serializable]
public sealed class Transform2D_Prototype : ComponentPrototype<Transform2D> // TypeDefIndex: 11917
{
	// Fields
	public FPVector2 Position; // 0x18
	[Degrees]
	public FP Rotation; // 0x28

	// Methods

	// RVA: 0x227EF80 Offset: 0x227D580 VA: 0x18227EF80 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227F050 Offset: 0x227D650 VA: 0x18227F050
	public void Materialize(FrameBase frame, ref Transform2D result) { }

	// RVA: 0x227F020 Offset: 0x227D620 VA: 0x18227F020 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227F070 Offset: 0x227D670 VA: 0x18227F070
	public void .ctor() { }
}
