// Namespace: Quantum.Prototypes
[Prototype(typeof(Laser))]
[Serializable]
public sealed class Laser_Prototype : ComponentPrototype<Laser> // TypeDefIndex: 10822
{
	// Fields
	public FP InitialRotation; // 0x18
	public LaserDirection_Prototype RotationDirection; // 0x20

	// Methods

	// RVA: 0x21083F0 Offset: 0x21069F0 VA: 0x1821083F0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2108550 Offset: 0x2106B50 VA: 0x182108550
	public void Materialize(Frame frame, ref Laser result, in PrototypeMaterializationContext context) { }

	// RVA: 0x21084C0 Offset: 0x2106AC0 VA: 0x1821084C0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2108560 Offset: 0x2106B60 VA: 0x182108560
	public void .ctor() { }
}
