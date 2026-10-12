// Namespace: Quantum.Prototypes
[Prototype(typeof(TrainingGameModeManager))]
[Serializable]
public sealed class TrainingGameModeManager_Prototype : ComponentPrototype<TrainingGameModeManager> // TypeDefIndex: 10884
{
	// Fields
	public QBoolean StartedFirstLap; // 0x18
	public int HighestLap; // 0x1C
	public FP LapTime; // 0x20

	// Methods

	// RVA: 0x21134B0 Offset: 0x2111AB0 VA: 0x1821134B0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113610 Offset: 0x2111C10 VA: 0x182113610
	public void Materialize(Frame frame, ref TrainingGameModeManager result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2113580 Offset: 0x2111B80 VA: 0x182113580 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2113630 Offset: 0x2111C30 VA: 0x182113630
	public void .ctor() { }
}
