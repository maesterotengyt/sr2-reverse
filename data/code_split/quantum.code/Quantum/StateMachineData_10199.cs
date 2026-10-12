// Namespace: Quantum
[Serializable]
public class StateMachineData : AssetObject // TypeDefIndex: 10199
{
	// Fields
	public AssetRefStateMachineData ParentStateMachine; // 0x20
	public StateMachineDataVariable[] Variables; // 0x28
	public AssetRefState[] States; // 0x30
	public HashString InitialState; // 0x38
	public HashString OnUpdateState; // 0x48
	[Space(5)]
	public StateNotificationMode OnDestroyNotificationMode; // 0x58
	[DrawIf("OnDestroyNotificationMode", 0, 1, 3)]
	public HashString OnDestroyState; // 0x60
	[CompilerGenerated]
	private Dictionary<int, State> <StateHashDict>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x78

	// Properties
	public Dictionary<int, State> StateHashDict { get; set; }
	public bool Initialized { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public Dictionary<int, State> get_StateHashDict() { }

	[CompilerGenerated]
	// RVA: 0x5DC940 Offset: 0x5DAF40 VA: 0x1805DC940
	public void set_StateHashDict(Dictionary<int, State> value) { }

	[CompilerGenerated]
	// RVA: 0x5BAA00 Offset: 0x5B9000 VA: 0x1805BAA00
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x5BAB60 Offset: 0x5B9160 VA: 0x1805BAB60
	public void set_Initialized(bool value) { }

	// RVA: 0x215C530 Offset: 0x215AB30 VA: 0x18215C530
	public void Init(Frame frame, bool force = False) { }

	// RVA: 0x215C480 Offset: 0x215AA80 VA: 0x18215C480
	private void CacheStates(Frame frame, bool force = False) { }

	// RVA: 0x215C760 Offset: 0x215AD60 VA: 0x18215C760
	public void RetrieveVariables(Frame frame, ref List<StateMachineDataVariable> variablesList) { }

	// RVA: 0x215C540 Offset: 0x215AB40 VA: 0x18215C540
	public void RetrieveStates(Frame frame, ref Dictionary<int, State> statesDict) { }

	// RVA: 0x215C920 Offset: 0x215AF20 VA: 0x18215C920
	public bool TryGetState(Frame frame, int stateHash, out State state) { }

	// RVA: 0x215CA40 Offset: 0x215B040 VA: 0x18215CA40
	public void .ctor() { }
}
