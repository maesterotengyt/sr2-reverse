// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(StateMachine))]
[Serializable]
public class StateMachine_Prototype : PrototypeAdapter<StateMachine_Prototype> // TypeDefIndex: 3929
{
	// Fields
	public QBoolean Active; // 0x10
	[LocalReference]
	public EntityPrototype Entity; // 0x18
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

	// RVA: 0x683050 Offset: 0x681650 VA: 0x180683050 Slot: 5
	public sealed override StateMachine_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6831A0 Offset: 0x6817A0 VA: 0x1806831A0
	public void .ctor() { }
}
