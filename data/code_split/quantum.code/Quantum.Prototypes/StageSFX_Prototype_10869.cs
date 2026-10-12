// Namespace: Quantum.Prototypes
[Prototype(typeof(StageSFX))]
[Serializable]
public sealed class StageSFX_Prototype : ComponentPrototype<StageSFX> // TypeDefIndex: 10869
{
	// Fields
	[DynamicCollection]
	public SFXToExecute_Prototype[] EventIDList; // 0x18
	public QBoolean UpdateSoundPosition; // 0x20
	public QBoolean PlayOnStart; // 0x24
	public StageExecutionMode_Prototype ExecutionMode; // 0x28

	// Methods

	// RVA: 0x2110A20 Offset: 0x210F020 VA: 0x182110A20 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110BA0 Offset: 0x210F1A0 VA: 0x182110BA0
	public void Materialize(Frame frame, ref StageSFX result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110B10 Offset: 0x210F110 VA: 0x182110B10 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2110E80 Offset: 0x210F480 VA: 0x182110E80
	public void .ctor() { }
}
