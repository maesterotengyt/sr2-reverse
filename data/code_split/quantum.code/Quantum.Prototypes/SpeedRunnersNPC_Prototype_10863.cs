// Namespace: Quantum.Prototypes
[Prototype(typeof(SpeedRunnersNPC))]
[Serializable]
public sealed class SpeedRunnersNPC_Prototype : ComponentPrototype<SpeedRunnersNPC> // TypeDefIndex: 10863
{
	// Fields
	[HideInInspector]
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public RunningDirection_Prototype RunningDirection; // 0x1C
	[HideInInspector]
	[DynamicCollection]
	public ActionData_Prototype[] ActionData; // 0x20
	[HideInInspector]
	public FP UseCooldown; // 0x28
	[HideInInspector]
	public QBoolean JumpDodge; // 0x30
	[HideInInspector]
	public FP SlideDodgeFrames; // 0x38
	[HideInInspector]
	public FP SlideDodgeTriggerCooldownFrames; // 0x40
	[HideInInspector]
	public int DodgeChance; // 0x48
	[HideInInspector]
	public int ItemUses; // 0x4C
	[HideInInspector]
	public FPVector2 ItemPosition; // 0x50
	[HideInInspector]
	public FP ChangeDirectionDelay; // 0x60
	[HideInInspector]
	public RunningDirection_Prototype DelayDirection; // 0x68
	[HideInInspector]
	public RunningDirection_Prototype TemporaryDirection; // 0x6C
	[HideInInspector]
	public FP TemporaryDirectionFrames; // 0x70
	[HideInInspector]
	public FP UnFreezeSpeed; // 0x78
	[HideInInspector]
	public FP UnFreezeCooldown; // 0x80
	[HideInInspector]
	public QBoolean UnfreezeToggle; // 0x88
	[HideInInspector]
	public FP MaxSpeed; // 0x90
	[HideInInspector]
	public FP TackleChance; // 0x98
	[HideInInspector]
	public FP TackleCooldown; // 0xA0
	[HideInInspector]
	public FP TackleRunningCooldown; // 0xA8

	// Methods

	// RVA: 0x210FDF0 Offset: 0x210E3F0 VA: 0x18210FDF0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110020 Offset: 0x210E620 VA: 0x182110020
	public void Materialize(Frame frame, ref SpeedRunnersNPC result, in PrototypeMaterializationContext context) { }

	// RVA: 0x210FF90 Offset: 0x210E590 VA: 0x18210FF90 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2110250 Offset: 0x210E850 VA: 0x182110250
	public void .ctor() { }
}
