// Namespace: Quantum.Prototypes
[Prototype(typeof(StateMachine))]
[Serializable]
public sealed class StateMachine_Prototype : ComponentPrototype<StateMachine> // TypeDefIndex: 10871
{
	// Fields
	public QBoolean Active; // 0x18
	public MapEntityId Entity; // 0x1C
	public AssetRefStateMachineData StateMachineData; // 0x20
	[MaxStringByteCount(62, "Unicode")]
	[HideInInspector]
	public string CurrentStateName; // 0x28
	[HideInInspector]
	public int CurrentStateHash; // 0x30
	[HideInInspector]
	public int CurrentStateHashOverride; // 0x34
	[HideInInspector]
	public int PreviousStateHash; // 0x38
	[HideInInspector]
	public FP SpeedMultiplier; // 0x40
	[HideInInspector]
	public FP UpdateCooldown; // 0x48
	[HideInInspector]
	public FP TimeSinceLastUpdate; // 0x50
	[HideInInspector]
	public FP StateTime; // 0x58
	[HideInInspector]
	[DynamicCollection]
	public int[] UpdateExtraGroups; // 0x60
	[HideInInspector]
	[DynamicCollection]
	public AssetGuid[] ExecutedBehaviours; // 0x68
	[HideInInspector]
	[DynamicCollection]
	public AssetGuid[] FinishedBehaviours; // 0x70
	[HideInInspector]
	[DynamicCollection]
	public ScheduledBehaviour_Prototype[] ScheduledBehaviours; // 0x78
	[HideInInspector]
	[Dictionary]
	[DynamicCollection]
	public DictionaryEntry_QString128_FP_Prototype[] Values; // 0x80
	[HideInInspector]
	public int NextStateHash; // 0x88
	[HideInInspector]
	public int StateChangesInFrame; // 0x8C

	// Methods

	// RVA: 0x2111090 Offset: 0x210F690 VA: 0x182111090 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21112D0 Offset: 0x210F8D0 VA: 0x1821112D0
	public void Materialize(Frame frame, ref StateMachine result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2111240 Offset: 0x210F840 VA: 0x182111240 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2111A90 Offset: 0x2110090 VA: 0x182111A90
	public void .ctor() { }
}
