// Namespace: Quantum
public struct StateMachine : IComponent // TypeDefIndex: 10046
{
	// Fields
	public QBoolean Active; // 0x14
	[HideInInspector]
	public int CurrentStateHash; // 0x0
	[HideInInspector]
	public int CurrentStateHashOverride; // 0x4
	[HideInInspector]
	public QString64 CurrentStateName; // 0x60
	public EntityRef Entity; // 0x38
	[HideInInspector]
	[PtrQHashSet(typeof(AssetGuid))]
	private Ptr ExecutedBehavioursPtr; // 0x18
	[HideInInspector]
	[PtrQHashSet(typeof(AssetGuid))]
	private Ptr FinishedBehavioursPtr; // 0x1C
	[HideInInspector]
	public int NextStateHash; // 0x8
	[HideInInspector]
	public int PreviousStateHash; // 0xC
	[HideInInspector]
	[PtrQList(typeof(ScheduledBehaviour))]
	private Ptr ScheduledBehavioursPtr; // 0x20
	[HideInInspector]
	public FP SpeedMultiplier; // 0x40
	[HideInInspector]
	public int StateChangesInFrame; // 0x10
	public AssetRefStateMachineData StateMachineData; // 0x30
	[HideInInspector]
	public FP StateTime; // 0x48
	[HideInInspector]
	public FP TimeSinceLastUpdate; // 0x50
	[HideInInspector]
	public FP UpdateCooldown; // 0x58
	[HideInInspector]
	[PtrQList(typeof(int))]
	private Ptr UpdateExtraGroupsPtr; // 0x24
	[HideInInspector]
	[PtrQDictionary(typeof(QString128), typeof(FP))]
	private Ptr ValuesPtr; // 0x28

	// Properties
	public QHashSetPtr<AssetGuid> ExecutedBehaviours { get; set; }
	public QHashSetPtr<AssetGuid> FinishedBehaviours { get; set; }
	public QListPtr<ScheduledBehaviour> ScheduledBehaviours { get; set; }
	public QListPtr<int> UpdateExtraGroups { get; set; }
	public QDictionaryPtr<QString128, FP> Values { get; set; }

	// Methods

	// RVA: 0x2132FB0 Offset: 0x21315B0 VA: 0x182132FB0
	public QHashSetPtr<AssetGuid> get_ExecutedBehaviours() { }

	// RVA: 0x6A4F50 Offset: 0x6A3550 VA: 0x1806A4F50
	public void set_ExecutedBehaviours(QHashSetPtr<AssetGuid> value) { }

	// RVA: 0x2132FF0 Offset: 0x21315F0 VA: 0x182132FF0
	public QHashSetPtr<AssetGuid> get_FinishedBehaviours() { }

	// RVA: 0x667A40 Offset: 0x666040 VA: 0x180667A40
	public void set_FinishedBehaviours(QHashSetPtr<AssetGuid> value) { }

	// RVA: 0x2133030 Offset: 0x2131630 VA: 0x182133030
	public QListPtr<ScheduledBehaviour> get_ScheduledBehaviours() { }

	// RVA: 0x667A20 Offset: 0x666020 VA: 0x180667A20
	public void set_ScheduledBehaviours(QListPtr<ScheduledBehaviour> value) { }

	// RVA: 0x2133070 Offset: 0x2131670 VA: 0x182133070
	public QListPtr<int> get_UpdateExtraGroups() { }

	// RVA: 0x847EC0 Offset: 0x8464C0 VA: 0x180847EC0
	public void set_UpdateExtraGroups(QListPtr<int> value) { }

	// RVA: 0x21330B0 Offset: 0x21316B0 VA: 0x1821330B0
	public QDictionaryPtr<QString128, FP> get_Values() { }

	// RVA: 0x51AE50 Offset: 0x519450 VA: 0x18051AE50
	public void set_Values(QDictionaryPtr<QString128, FP> value) { }

	// RVA: 0x2132020 Offset: 0x2130620 VA: 0x182132020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2131530 Offset: 0x212FB30 VA: 0x182131530
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2132580 Offset: 0x2130B80 VA: 0x182132580
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x2132600 Offset: 0x2130C00 VA: 0x182132600
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2132300 Offset: 0x2130900 VA: 0x182132300
	public void Initialize(Frame frame, EntityRef entity, AssetRefStateMachineData stateMachineDataRef) { }

	// RVA: 0x2132B40 Offset: 0x2131140 VA: 0x182132B40
	public void Update(Frame frame) { }

	// RVA: 0x2131410 Offset: 0x212FA10 VA: 0x182131410
	public void ChangeState(Frame frame, int stateHash, bool changeImmediately = False) { }

	// RVA: 0x2131540 Offset: 0x212FB40 VA: 0x182131540
	private void EvaluateStateChange(Frame frame) { }

	// RVA: 0x2130DA0 Offset: 0x212F3A0 VA: 0x182130DA0
	private void ChangeStateInternal(Frame frame, int nextStateHash) { }

	// RVA: 0x2132380 Offset: 0x2130980 VA: 0x182132380
	public bool IsStateAvailable(Frame frame, int nextStateHash) { }

	// RVA: 0x21321B0 Offset: 0x21307B0 VA: 0x1821321B0
	public FP GetVariable(Frame frame, string valueName) { }

	// RVA: 0x2132A00 Offset: 0x2131000 VA: 0x182132A00
	public void SetVariable(Frame frame, string valueName, FP value) { }

	// RVA: 0x2132140 Offset: 0x2130740 VA: 0x182132140
	public FP GetValue(Frame frame, StateMachineVariable variable) { }

	// RVA: 0x2132970 Offset: 0x2130F70 VA: 0x182132970
	public void SetValue(Frame frame, StateMachineVariable variable, FP value) { }

	// RVA: 0x2131560 Offset: 0x212FB60 VA: 0x182131560
	public void ExecuteEventGroup(Frame frame, StateGroupEvent groupEvent) { }

	// RVA: 0x2131990 Offset: 0x212FF90 VA: 0x182131990
	public void ExecuteGroup(Frame frame, HashString groupName, StateGroupExecutionMode executionMode) { }

	// RVA: 0x2131A60 Offset: 0x2130060 VA: 0x182131A60
	public void ExecuteGroup(Frame frame, int groupHash, StateGroupExecutionMode executionMode) { }

	// RVA: 0x21317B0 Offset: 0x212FDB0 VA: 0x1821317B0
	public void ExecuteGroup(Frame frame, CachedEntityData cachedEntityData, HashString groupName, StateGroupExecutionMode executionMode) { }

	// RVA: 0x2132510 Offset: 0x2130B10 VA: 0x182132510
	public void NotifyStateEvent(Frame frame, StateNotificationMode notificationMode, int stateHash, out bool changedState, out bool executedState) { }

	// RVA: 0x2131D00 Offset: 0x2130300 VA: 0x182131D00
	public void ExecuteStateFromHash(Frame frame, int stateHash) { }

	// RVA: 0x2131B50 Offset: 0x2130150 VA: 0x182131B50
	private void ExecuteStateFromHash(Frame frame, int stateHash, StateMachineData stateMachineData, CachedEntityData entityData) { }

	// RVA: 0x2132010 Offset: 0x2130610 VA: 0x182132010
	public int GetCurrentStateHash() { }

	// RVA: 0x2132130 Offset: 0x2130730 VA: 0x182132130
	public int GetStateFrame() { }

	// RVA: 0x2132350 Offset: 0x2130950 VA: 0x182132350
	public bool IsStateActive(int stateIndex) { }
}
