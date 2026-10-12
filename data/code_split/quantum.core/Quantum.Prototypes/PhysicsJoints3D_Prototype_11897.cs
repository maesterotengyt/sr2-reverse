// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsJoints3D))]
[Serializable]
public sealed class PhysicsJoints3D_Prototype : ComponentPrototype<PhysicsJoints3D>, IEntityPrototypeMaterializedListener // TypeDefIndex: 11897
{
	// Fields
	[DynamicCollection]
	public Joint3D_Prototype[] JointConfigs; // 0x18

	// Methods

	// RVA: 0x2275530 Offset: 0x2273B30 VA: 0x182275530 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2275700 Offset: 0x2273D00 VA: 0x182275700
	public void Materialize(FrameBase frame, ref PhysicsJoints3D result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2275840 Offset: 0x2273E40 VA: 0x182275840 Slot: 7
	public void OnEntityPrototypeMaterialized(FrameBase f, EntityRef entity, EntityPrototypeRef prototypeRef) { }

	// RVA: 0x22756D0 Offset: 0x2273CD0 VA: 0x1822756D0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2275AC0 Offset: 0x22740C0 VA: 0x182275AC0
	public void .ctor() { }
}
