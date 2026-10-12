// Namespace: Quantum.Prototypes
[Prototype(typeof(Transform3D))]
[Serializable]
public sealed class Transform3D_Prototype : ComponentPrototype<Transform3D> // TypeDefIndex: 11916
{
	// Fields
	public FPVector3 Position; // 0x18
	[Degrees]
	public FPVector3 Rotation; // 0x30

	// Methods

	// RVA: 0x227F0B0 Offset: 0x227D6B0 VA: 0x18227F0B0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227F1F0 Offset: 0x227D7F0 VA: 0x18227F1F0
	public void Materialize(FrameBase frame, ref Transform3D result) { }

	// RVA: 0x227F1C0 Offset: 0x227D7C0 VA: 0x18227F1C0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227F250 Offset: 0x227D850 VA: 0x18227F250
	public void .ctor() { }
}
