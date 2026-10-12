// Namespace: Quantum.Prototypes
[Prototype(typeof(GameModeItemAutoTrigger))]
[Serializable]
public sealed class GameModeItemAutoTrigger_Prototype : ComponentPrototype<GameModeItemAutoTrigger> // TypeDefIndex: 10805
{
	// Fields
	[HideInInspector]
	public MapEntityId Entity; // 0x18
	public QString64 ItemToUse; // 0x1C

	// Methods

	// RVA: 0x2105C10 Offset: 0x2104210 VA: 0x182105C10 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2105DF0 Offset: 0x21043F0 VA: 0x182105DF0
	public void Materialize(Frame frame, ref GameModeItemAutoTrigger result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2105D60 Offset: 0x2104360 VA: 0x182105D60 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2105E40 Offset: 0x2104440 VA: 0x182105E40
	public void .ctor() { }
}
