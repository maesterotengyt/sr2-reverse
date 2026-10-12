// Namespace: Quantum.Prototypes
[Prototype(typeof(CharacterController2D))]
[Serializable]
public sealed class CharacterController2D_Prototype : ComponentPrototype<CharacterController2D> // TypeDefIndex: 11902
{
	// Fields
	public AssetRefCharacterController2DConfig Config; // 0x18

	// Methods

	// RVA: 0x2271B60 Offset: 0x2270160 VA: 0x182271B60
	public void Materialize(FrameBase frame, ref CharacterController2D result) { }

	// RVA: 0x2271A40 Offset: 0x2270040 VA: 0x182271A40 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2271B30 Offset: 0x2270130 VA: 0x182271B30 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2271BD0 Offset: 0x22701D0 VA: 0x182271BD0
	public void .ctor() { }
}
