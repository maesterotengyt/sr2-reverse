// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsBody3D))]
[Serializable]
public sealed class PhysicsBody3D_Prototype : ComponentPrototype<PhysicsBody3D> // TypeDefIndex: 11905
{
	// Fields
	public const int BODY_PROTOTYPE_VERSION = 2;
	[HideInInspector]
	public int Version; // 0x18
	public PhysicsBody3D.ConfigFlagsWrapper Config; // 0x1C
	public FP Mass; // 0x20
	public FP Drag; // 0x28
	public FP AngularDrag; // 0x30
	public FPVector3 CenterOfMass; // 0x38
	public RotationFreezeFlags_Wrapper RotationFreeze; // 0x50
	public NullableFP GravityScale; // 0x58

	// Methods

	// RVA: 0x227C850 Offset: 0x227AE50 VA: 0x18227C850
	public void Materialize(FrameBase frame, ref PhysicsBody3D result) { }

	// RVA: 0x227C5B0 Offset: 0x227ABB0 VA: 0x18227C5B0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227C820 Offset: 0x227AE20 VA: 0x18227C820 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227C950 Offset: 0x227AF50 VA: 0x18227C950
	public void .ctor() { }
}
