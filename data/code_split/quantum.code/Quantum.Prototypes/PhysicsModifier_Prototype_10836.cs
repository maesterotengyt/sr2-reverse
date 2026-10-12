// Namespace: Quantum.Prototypes
[Prototype(typeof(PhysicsModifier))]
[Serializable]
public sealed class PhysicsModifier_Prototype : ComponentPrototype<PhysicsModifier> // TypeDefIndex: 10836
{
	// Fields
	public MapEntityId Entity; // 0x18
	public PhysicsModifierInfo_Prototype ModifierInfo; // 0x20

	// Methods

	// RVA: 0x210B2A0 Offset: 0x21098A0 VA: 0x18210B2A0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210B460 Offset: 0x2109A60 VA: 0x18210B460
	public void Materialize(Frame frame, ref PhysicsModifier result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210B3D0 Offset: 0x21099D0 VA: 0x18210B3D0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210B4C0 Offset: 0x2109AC0 VA: 0x18210B4C0
	public void .ctor() { }
}
