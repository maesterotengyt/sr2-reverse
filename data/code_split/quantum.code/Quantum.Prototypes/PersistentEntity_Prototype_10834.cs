// Namespace: Quantum.Prototypes
[Prototype(typeof(PersistentEntity))]
[Serializable]
public sealed class PersistentEntity_Prototype : ComponentPrototype<PersistentEntity> // TypeDefIndex: 10834
{
	// Fields
	[HideInInspector]
	public int _empty_prototype_dummy_field_; // 0x18

	// Methods

	// RVA: 0x210A8C0 Offset: 0x2108EC0 VA: 0x18210A8C0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void Materialize(Frame frame, ref PersistentEntity result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210A960 Offset: 0x2108F60 VA: 0x18210A960 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210A9F0 Offset: 0x2108FF0 VA: 0x18210A9F0
	public void .ctor() { }
}
