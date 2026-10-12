// Namespace: Quantum.Prototypes
[Prototype(typeof(EndlessGameModeManager))]
[Serializable]
public sealed class EndlessGameModeManager_Prototype : ComponentPrototype<EndlessGameModeManager> // TypeDefIndex: 10790
{
	// Fields
	public FP DistanceRunned; // 0x18
	public FP SpawnedPlataforms; // 0x20
	[HideInInspector]
	public FP RandomPlataformIndex; // 0x28
	[DynamicCollection]
	public MapEntityId[] Plataforms; // 0x30
	public QBoolean HasDialogue; // 0x38

	// Methods

	// RVA: 0x21033E0 Offset: 0x21019E0 VA: 0x1821033E0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21036E0 Offset: 0x2101CE0 VA: 0x1821036E0
	public void Materialize(Frame frame, ref EndlessGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2103650 Offset: 0x2101C50 VA: 0x182103650 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2103880 Offset: 0x2101E80 VA: 0x182103880
	public void .ctor() { }
}
