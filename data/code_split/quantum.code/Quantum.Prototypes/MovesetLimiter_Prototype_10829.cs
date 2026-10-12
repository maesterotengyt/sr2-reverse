// Namespace: Quantum.Prototypes
[Prototype(typeof(MovesetLimiter))]
[Serializable]
public sealed class MovesetLimiter_Prototype : ComponentPrototype<MovesetLimiter> // TypeDefIndex: 10829
{
	// Fields
	public AssetRefMovesetLimiterData MovesetLimiterData; // 0x18
	[HideInInspector]
	[Dictionary]
	[DynamicCollection]
	public DictionaryEntry_Int32_MoveLimit_Prototype[] AvailableMoves; // 0x20

	// Methods

	// RVA: 0x2109700 Offset: 0x2107D00 VA: 0x182109700 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2109A10 Offset: 0x2108010 VA: 0x182109A10
	public void Materialize(Frame frame, ref MovesetLimiter result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2109980 Offset: 0x2107F80 VA: 0x182109980 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2109BD0 Offset: 0x21081D0 VA: 0x182109BD0
	public void .ctor() { }
}
