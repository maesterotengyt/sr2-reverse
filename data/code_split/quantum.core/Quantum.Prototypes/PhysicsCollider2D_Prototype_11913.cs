// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsCollider2D))]
[Serializable]
public sealed class PhysicsCollider2D_Prototype : ComponentPrototype<PhysicsCollider2D> // TypeDefIndex: 11913
{
	// Fields
	public Shape2DConfig ShapeConfig; // 0x18
	[Layer]
	public int Layer; // 0x20
	public bool IsTrigger; // 0x24
	public AssetRefPhysicsMaterial PhysicsMaterial; // 0x28

	// Methods

	// RVA: 0x227CF40 Offset: 0x227B540 VA: 0x18227CF40
	public void Materialize(FrameBase frame, ref PhysicsCollider2D result) { }

	// RVA: 0x227CCE0 Offset: 0x227B2E0 VA: 0x18227CCE0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227CF10 Offset: 0x227B510 VA: 0x18227CF10 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227D100 Offset: 0x227B700 VA: 0x18227D100
	public void .ctor() { }
}
