// Namespace: Quantum.Prototypes
[Prototype(typeof(KinematicBody))]
[Serializable]
public sealed class KinematicBody_Prototype : ComponentPrototype<KinematicBody> // TypeDefIndex: 10821
{
	// Fields
	public QBoolean Active; // 0x18
	public FPVector2 Velocity; // 0x20

	// Methods

	// RVA: 0x2108230 Offset: 0x2106830 VA: 0x182108230 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21083A0 Offset: 0x21069A0 VA: 0x1821083A0
	public void Materialize(Frame frame, ref KinematicBody result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108310 Offset: 0x2106910 VA: 0x182108310 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21083B0 Offset: 0x21069B0 VA: 0x1821083B0
	public void .ctor() { }
}
