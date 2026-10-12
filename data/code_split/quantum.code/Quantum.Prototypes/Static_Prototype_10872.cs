// Namespace: Quantum.Prototypes
[Prototype(typeof(Static))]
[Serializable]
public sealed class Static_Prototype : ComponentPrototype<Static> // TypeDefIndex: 10872
{
	// Fields
	[HideInInspector]
	public int _empty_prototype_dummy_field_; // 0x18

	// Methods

	// RVA: 0x2111D20 Offset: 0x2110320 VA: 0x182111D20 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void Materialize(Frame frame, ref Static result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2111DC0 Offset: 0x21103C0 VA: 0x182111DC0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2111E50 Offset: 0x2110450 VA: 0x182111E50
	public void .ctor() { }
}
