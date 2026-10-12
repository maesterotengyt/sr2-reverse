// Namespace: Quantum
[Serializable]
public abstract class StateBehaviour : AssetObject // TypeDefIndex: 10201
{
	// Fields
	public bool Enabled; // 0x20
	public bool HasConditions; // 0x21
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedConditionLogicalOperator LogicalOperator; // 0x24
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedCondition[] Conditions; // 0x28
	[HideInInspector]
	public HashString GroupName; // 0x30
	[Space(10)]
	public BehaviourTargetEntity TargetEntity; // 0x40
	[DrawIf("TargetEntity", 1, 0, 3)]
	public HashString TargetIndexParameterID; // 0x48
	[Space(10)]
	public int StartFrame; // 0x58
	protected bool HasUpdateLogic; // 0x5C

	// Methods

	// RVA: 0x1E629D0 Offset: 0x1E60FD0 VA: 0x181E629D0 Slot: 6
	public virtual int GetEndFrame() { }

	// RVA: 0x215ACD0 Offset: 0x21592D0 VA: 0x18215ACD0
	public void Enter(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215B200 Offset: 0x2159800 VA: 0x18215B200
	public void Execute(Frame frame, CachedEntityData stateMachineOwner) { }

	// RVA: 0x215BCA0 Offset: 0x215A2A0 VA: 0x18215BCA0
	public void Update(Frame frame, CachedEntityData entityData, int currentFrame) { }

	// RVA: 0x215B530 Offset: 0x2159B30 VA: 0x18215B530
	public void Exit(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215B050 Offset: 0x2159650 VA: 0x18215B050
	private bool EvaluateCondition(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x215BA00 Offset: 0x215A000 VA: 0x18215BA00
	private bool HasReachedEndFrame(int currentFrame) { }

	// RVA: 0x215BB00 Offset: 0x215A100 VA: 0x18215BB00
	protected void MarkAsExecuted(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215B930 Offset: 0x2159F30 VA: 0x18215B930
	private bool HasBeenExecuted(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215BBD0 Offset: 0x215A1D0 VA: 0x18215BBD0
	protected void MarkAsFinished(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215BA30 Offset: 0x215A030 VA: 0x18215BA30
	private bool IsFinished(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x215B100 Offset: 0x2159700 VA: 0x18215B100
	protected void ExecuteGroup(Frame frame, CachedEntityData targetEntityData, ExecuteGroupEvent GroupToExecute) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData);

	// RVA: 0x215C420 Offset: 0x215AA20 VA: 0x18215C420
	protected void .ctor() { }
}
