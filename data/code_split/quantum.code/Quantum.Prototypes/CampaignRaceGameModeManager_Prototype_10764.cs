// Namespace: Quantum.Prototypes
[Prototype(typeof(CampaignRaceGameModeManager))]
[Serializable]
public sealed class CampaignRaceGameModeManager_Prototype : ComponentPrototype<CampaignRaceGameModeManager> // TypeDefIndex: 10764
{
	// Fields
	public QBoolean MatchCompleted; // 0x18
	public QBoolean HasDialogue; // 0x1C
	public QBoolean StartedTimer; // 0x20
	public FP CurrentMatchTimer; // 0x28

	// Methods

	// RVA: 0x20FDC00 Offset: 0x20FC200 VA: 0x1820FDC00 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FDD80 Offset: 0x20FC380 VA: 0x1820FDD80
	public void Materialize(Frame frame, ref CampaignRaceGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FDCF0 Offset: 0x20FC2F0 VA: 0x1820FDCF0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FDDA0 Offset: 0x20FC3A0 VA: 0x1820FDDA0
	public void .ctor() { }
}
