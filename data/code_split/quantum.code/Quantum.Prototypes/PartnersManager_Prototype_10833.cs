// Namespace: Quantum.Prototypes
[Prototype(typeof(PartnersManager))]
[Serializable]
public sealed class PartnersManager_Prototype : ComponentPrototype<PartnersManager> // TypeDefIndex: 10833
{
	// Fields
	[DynamicCollection]
	public MapEntityId[] CharacterEntities; // 0x18
	public int CurrentCharacterIndex; // 0x20
	public QBoolean CharacterSwapAllowed; // 0x24
	public FP CharacterSwapCooldown; // 0x28

	// Methods

	// RVA: 0x210A3C0 Offset: 0x21089C0 VA: 0x18210A3C0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210A6B0 Offset: 0x2108CB0 VA: 0x18210A6B0
	public void Materialize(Frame frame, ref PartnersManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210A620 Offset: 0x2108C20 VA: 0x18210A620 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210A850 Offset: 0x2108E50 VA: 0x18210A850
	public void .ctor() { }
}
