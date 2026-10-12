// Namespace: Quantum.Prototypes
[Prototype(typeof(CharacterController3D))]
[Serializable]
public sealed class CharacterController3D_Prototype : ComponentPrototype<CharacterController3D> // TypeDefIndex: 11910
{
	// Fields
	public AssetRefCharacterController3DConfig Config; // 0x18

	// Methods

	// RVA: 0x2278820 Offset: 0x2276E20 VA: 0x182278820
	public void Materialize(FrameBase frame, ref CharacterController3D result) { }

	// RVA: 0x2278700 Offset: 0x2276D00 VA: 0x182278700 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x22787F0 Offset: 0x2276DF0 VA: 0x1822787F0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2278890 Offset: 0x2276E90 VA: 0x182278890
	public void .ctor() { }
}
