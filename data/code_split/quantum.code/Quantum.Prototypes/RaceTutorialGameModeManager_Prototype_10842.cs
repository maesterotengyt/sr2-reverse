// Namespace: Quantum.Prototypes
[Prototype(typeof(RaceTutorialGameModeManager))]
[Serializable]
public sealed class RaceTutorialGameModeManager_Prototype : ComponentPrototype<RaceTutorialGameModeManager> // TypeDefIndex: 10842
{
	// Fields
	public QBoolean IsInitialSection; // 0x18
	public QBoolean IsSuddenDeathPromptVisible; // 0x1C
	public QBoolean DisplayedSuddenDeathPrompt; // 0x20
	public QBoolean StartedFirstLap; // 0x24
	public int HighestLap; // 0x28

	// Methods

	// RVA: 0x210D090 Offset: 0x210B690 VA: 0x18210D090 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D200 Offset: 0x210B800 VA: 0x18210D200
	public void Materialize(Frame frame, ref RaceTutorialGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210D170 Offset: 0x210B770 VA: 0x18210D170 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x210D230 Offset: 0x210B830 VA: 0x18210D230
	public void .ctor() { }
}
