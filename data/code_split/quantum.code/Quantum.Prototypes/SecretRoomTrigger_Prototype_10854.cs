// Namespace: Quantum.Prototypes
[Prototype(typeof(SecretRoomTrigger))]
[Serializable]
public sealed class SecretRoomTrigger_Prototype : ComponentPrototype<SecretRoomTrigger> // TypeDefIndex: 10854
{
	// Fields
	[HideInInspector]
	public int _empty_prototype_dummy_field_; // 0x18

	// Methods

	// RVA: 0x210DC40 Offset: 0x210C240 VA: 0x18210DC40 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void Materialize(Frame frame, ref SecretRoomTrigger result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210DCE0 Offset: 0x210C2E0 VA: 0x18210DCE0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210DD70 Offset: 0x210C370 VA: 0x18210DD70
	public void .ctor() { }
}
