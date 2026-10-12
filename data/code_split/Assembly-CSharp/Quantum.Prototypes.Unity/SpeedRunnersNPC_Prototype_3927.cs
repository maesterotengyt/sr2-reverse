// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(SpeedRunnersNPC))]
[Serializable]
public class SpeedRunnersNPC_Prototype : PrototypeAdapter<SpeedRunnersNPC_Prototype> // TypeDefIndex: 3927
{
	// Fields
	[HideInInspector]
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	[HideInInspector]
	public RunningDirection_Prototype RunningDirection; // 0x18
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

	// RVA: 0x682CE0 Offset: 0x6812E0 VA: 0x180682CE0 Slot: 5
	public sealed override SpeedRunnersNPC_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x682E30 Offset: 0x681430 VA: 0x180682E30
	public void .ctor() { }
}
