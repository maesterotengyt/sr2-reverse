// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsCollider3D))]
[Serializable]
public sealed class PhysicsCollider3D_Prototype : ComponentPrototype<PhysicsCollider3D> // TypeDefIndex: 11908
{
	// Fields
	public Shape3DConfig ShapeConfig; // 0x18
	[Layer]
	public int Layer; // 0x20
	public bool IsTrigger; // 0x24
	public AssetRefPhysicsMaterial PhysicsMaterial; // 0x28

	// Methods

	// RVA: 0x227D410 Offset: 0x227BA10 VA: 0x18227D410
	public void Materialize(FrameBase frame, ref PhysicsCollider3D result) { }

	// RVA: 0x227D140 Offset: 0x227B740 VA: 0x18227D140 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x227D3E0 Offset: 0x227B9E0 VA: 0x18227D3E0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x227D600 Offset: 0x227BC00 VA: 0x18227D600
	public void .ctor() { }
}
