// Namespace: Quantum
public struct SpeedRunnersNPC : IComponent // TypeDefIndex: 10039
{
	// Fields
	[HideInInspector]
	[PtrQList(typeof(ActionData))]
	private Ptr ActionDataPtr; // 0x10
	[HideInInspector]
	public FP ChangeDirectionDelay; // 0x28
	[HideInInspector]
	public RunningDirection DelayDirection; // 0x14
	[HideInInspector]
	public int DodgeChance; // 0x0
	[HideInInspector]
	public EntityRef Entity; // 0x20
	[HideInInspector]
	public FPVector2 ItemPosition; // 0x80
	[HideInInspector]
	public int ItemUses; // 0x4
	[HideInInspector]
	public QBoolean JumpDodge; // 0x8
	[HideInInspector]
	public FP MaxSpeed; // 0x30
	[HideInInspector]
	public RunningDirection RunningDirection; // 0x18
	[HideInInspector]
	public FP SlideDodgeFrames; // 0x38
	[HideInInspector]
	public FP SlideDodgeTriggerCooldownFrames; // 0x40
	[HideInInspector]
	public FP TackleChance; // 0x48
	[HideInInspector]
	public FP TackleCooldown; // 0x50
	[HideInInspector]
	public FP TackleRunningCooldown; // 0x58
	[HideInInspector]
	public RunningDirection TemporaryDirection; // 0x1C
	[HideInInspector]
	public FP TemporaryDirectionFrames; // 0x60
	[HideInInspector]
	public FP UnFreezeCooldown; // 0x68
	[HideInInspector]
	public FP UnFreezeSpeed; // 0x70
	[HideInInspector]
	public QBoolean UnfreezeToggle; // 0xC
	[HideInInspector]
	public FP UseCooldown; // 0x78

	// Properties
	public QListPtr<ActionData> ActionData { get; set; }

	// Methods

	// RVA: 0x2130440 Offset: 0x212EA40 VA: 0x182130440
	public QListPtr<ActionData> get_ActionData() { }

	// RVA: 0x520750 Offset: 0x51ED50 VA: 0x180520750
	public void set_ActionData(QListPtr<ActionData> value) { }

	// RVA: 0x212F380 Offset: 0x212D980 VA: 0x18212F380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212EB50 Offset: 0x212D150 VA: 0x18212EB50
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x212F610 Offset: 0x212DC10 VA: 0x18212F610
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x212FC20 Offset: 0x212E220 VA: 0x18212FC20
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x212F4C0 Offset: 0x212DAC0 VA: 0x18212F4C0
	public void Initialize(Frame frame, EntityRef entity, int facingDirection) { }

	// RVA: 0x2130390 Offset: 0x212E990 VA: 0x182130390
	public void Update(Frame frame, EntityRef entity) { }

	// RVA: 0x212F7C0 Offset: 0x212DDC0 VA: 0x18212F7C0
	public void SendInputs(Frame frame, Input input) { }

	// RVA: 0x212FFD0 Offset: 0x212E5D0 VA: 0x18212FFD0
	public void TacklePlayer(Frame frame) { }

	// RVA: 0x2130330 Offset: 0x212E930 VA: 0x182130330
	public void TriggerSlideDodge(Frame frame, int framesDuration) { }

	// RVA: 0x212EB60 Offset: 0x212D160 VA: 0x18212EB60
	public void ClearSlidingDodge() { }

	// RVA: 0x212F5C0 Offset: 0x212DBC0 VA: 0x18212F5C0
	public void JumpingDodge(Frame frame, bool active) { }

	// RVA: 0x212EB70 Offset: 0x212D170 VA: 0x18212EB70
	public bool EquipmentLogic(Frame frame, int Equipment) { }

	// RVA: 0x212F690 Offset: 0x212DC90 VA: 0x18212F690
	public void Reset(Frame frame) { }

	// RVA: 0x2130320 Offset: 0x212E920 VA: 0x182130320
	public void ToggleDirection(RunningDirection direction, int delay) { }

	// RVA: 0x212FE60 Offset: 0x212E460 VA: 0x18212FE60
	public void StartAction(Frame frame, int numberFrames, InputFlag action, VolumeMode volumeMode, int delay) { }
}
