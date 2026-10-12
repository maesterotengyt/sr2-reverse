// Namespace: Quantum
[Serializable]
public class State : AssetObject // TypeDefIndex: 10200
{
	// Fields
	[ReadOnly]
	public HashString Name; // 0x20
	public HashString MoveName; // 0x30
	public HashString[] AdditionalExecutedMoves; // 0x40
	[HideInInspector]
	public StateLogicChacheData LogicCacheData; // 0x48
	[CompilerGenerated]
	private StateBehaviour[] <Behaviours>k__BackingField; // 0x58
	[CompilerGenerated]
	private Dictionary<AssetGuid, StateBehaviour> <BehavioursDict>k__BackingField; // 0x60
	[CompilerGenerated]
	private Dictionary<int, List<StateBehaviour>> <GroupsDict>k__BackingField; // 0x68
	[CompilerGenerated]
	private Dictionary<int, int> <GroupIndexes>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x78

	// Properties
	public StateBehaviour[] Behaviours { get; set; }
	public Dictionary<AssetGuid, StateBehaviour> BehavioursDict { get; set; }
	public Dictionary<int, List<StateBehaviour>> GroupsDict { get; set; }
	public Dictionary<int, int> GroupIndexes { get; set; }
	public bool Initialized { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5B45B0 Offset: 0x5B2BB0 VA: 0x1805B45B0
	public StateBehaviour[] get_Behaviours() { }

	[CompilerGenerated]
	// RVA: 0x5B45D0 Offset: 0x5B2BD0 VA: 0x1805B45D0
	public void set_Behaviours(StateBehaviour[] value) { }

	[CompilerGenerated]
	// RVA: 0x5818A0 Offset: 0x57FEA0 VA: 0x1805818A0
	public Dictionary<AssetGuid, StateBehaviour> get_BehavioursDict() { }

	[CompilerGenerated]
	// RVA: 0x5B45C0 Offset: 0x5B2BC0 VA: 0x1805B45C0
	public void set_BehavioursDict(Dictionary<AssetGuid, StateBehaviour> value) { }

	[CompilerGenerated]
	// RVA: 0x5A5150 Offset: 0x5A3750 VA: 0x1805A5150
	public Dictionary<int, List<StateBehaviour>> get_GroupsDict() { }

	[CompilerGenerated]
	// RVA: 0x54C4A0 Offset: 0x54AAA0 VA: 0x18054C4A0
	public void set_GroupsDict(Dictionary<int, List<StateBehaviour>> value) { }

	[CompilerGenerated]
	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public Dictionary<int, int> get_GroupIndexes() { }

	[CompilerGenerated]
	// RVA: 0x5DC940 Offset: 0x5DAF40 VA: 0x1805DC940
	public void set_GroupIndexes(Dictionary<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x5BAA00 Offset: 0x5B9000 VA: 0x1805BAA00
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x5BAB60 Offset: 0x5B9160 VA: 0x1805BAB60
	public void set_Initialized(bool value) { }

	// RVA: 0x215E660 Offset: 0x215CC60 VA: 0x18215E660
	public void Init(Frame frame) { }

	// RVA: 0x215CAC0 Offset: 0x215B0C0 VA: 0x18215CAC0
	public void Enter(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215EB10 Offset: 0x215D110 VA: 0x18215EB10
	public void Update(Frame frame, CachedEntityData entityData, int stateFrame) { }

	// RVA: 0x215E5E0 Offset: 0x215CBE0 VA: 0x18215E5E0
	public void Exit(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215DE10 Offset: 0x215C410 VA: 0x18215DE10
	public void ExecuteStateGroup(Frame frame, CachedEntityData entityData, HashString groupName, StateGroupExecutionMode executionMode = 1) { }

	// RVA: 0x215D900 Offset: 0x215BF00 VA: 0x18215D900
	public void ExecuteEventGroup(Frame frame, CachedEntityData entityData, StateGroupEvent groupEvent) { }

	// RVA: 0x215CDB0 Offset: 0x215B3B0 VA: 0x18215CDB0
	private void ExecuteBehavioursEnter(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215D510 Offset: 0x215BB10 VA: 0x18215D510
	private void ExecuteBehavioursUpdate(Frame frame, CachedEntityData entityData, int currentFrame) { }

	// RVA: 0x215DA20 Offset: 0x215C020 VA: 0x18215DA20
	private void ExecuteScheduledBehaviours(Frame frame, CachedEntityData entityData, int currentFrame) { }

	// RVA: 0x215D1A0 Offset: 0x215B7A0 VA: 0x18215D1A0
	private void ExecuteBehavioursExit(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215EC20 Offset: 0x215D220 VA: 0x18215EC20
	public void .ctor() { }
}
