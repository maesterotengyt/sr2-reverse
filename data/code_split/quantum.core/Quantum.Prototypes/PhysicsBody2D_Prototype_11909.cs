// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsBody2D))]
[Serializable]
public sealed class PhysicsBody2D_Prototype : ComponentPrototype<PhysicsBody2D> // TypeDefIndex: 11909
{
	// Fields
	public const int BODY_PROTOTYPE_VERSION = 2;
	[HideInInspector]
	public int Version; // 0x18
	public PhysicsBody2D.ConfigFlagsWrapper Config; // 0x1C
	public FP Mass; // 0x20
	public FP Drag; // 0x28
	public FP AngularDrag; // 0x30
	public FPVector2 CenterOfMass; // 0x38
	public NullableFP GravityScale; // 0x48

	// Methods

	// RVA: 0x227C440 Offset: 0x227AA40 VA: 0x18227C440
	public void Materialize(FrameBase frame, ref PhysicsBody2D result) { }

	// RVA: 0x227C220 Offset: 0x227A820 VA: 0x18227C220 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227C410 Offset: 0x227AA10 VA: 0x18227C410 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227C520 Offset: 0x227AB20 VA: 0x18227C520
	public void .ctor() { }
}
