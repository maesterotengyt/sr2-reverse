// Namespace: Quantum.Prototypes
[Prototype(typeof(CollectorsGameModeManager))]
[Serializable]
public sealed class CollectorsGameModeManager_Prototype : ComponentPrototype<CollectorsGameModeManager> // TypeDefIndex: 10770
{
	// Fields
	public QBoolean MatchFinished; // 0x18
	public FP RemainingMatchTime; // 0x20
	public FP NextTreasureSpawnTimer; // 0x28
	[DynamicCollection]
	public int[] SpawnAreasUsed; // 0x30

	// Methods

	// RVA: 0x20FEB90 Offset: 0x20FD190 VA: 0x1820FEB90 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FEE70 Offset: 0x20FD470 VA: 0x1820FEE70
	public void Materialize(Frame frame, ref CollectorsGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FEDE0 Offset: 0x20FD3E0 VA: 0x1820FEDE0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FEFE0 Offset: 0x20FD5E0 VA: 0x1820FEFE0
	public void .ctor() { }
}
