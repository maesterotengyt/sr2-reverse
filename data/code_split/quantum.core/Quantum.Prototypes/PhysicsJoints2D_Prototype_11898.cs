// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsJoints2D))]
[Serializable]
public sealed class PhysicsJoints2D_Prototype : ComponentPrototype<PhysicsJoints2D>, IEntityPrototypeMaterializedListener // TypeDefIndex: 11898
{
	// Fields
	[DynamicCollection]
	public Joint2D_Prototype[] JointConfigs; // 0x18

	// Methods

	// RVA: 0x2275000 Offset: 0x2273600 VA: 0x182275000 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x22751A0 Offset: 0x22737A0 VA: 0x1822751A0
	public void Materialize(FrameBase frame, ref PhysicsJoints2D result, in PrototypeMaterializationContext context) { }

	// RVA: 0x22752B0 Offset: 0x22738B0 VA: 0x1822752B0 Slot: 7
	public void OnEntityPrototypeMaterialized(FrameBase f, EntityRef entity, EntityPrototypeRef prototypeRef) { }

	// RVA: 0x2275170 Offset: 0x2273770 VA: 0x182275170 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x22754C0 Offset: 0x2273AC0 VA: 0x1822754C0
	public void .ctor() { }
}
