// Namespace: Quantum
[Serializable]
public struct StateGroup // TypeDefIndex: 10664
{
	// Fields
	[HideInInspector]
	public HashString Name; // 0x0
	[HideInInspector]
	public StateGroupEvent EventToReact; // 0x10
	[HideInInspector]
	public bool HasConditions; // 0x14
	[HideInInspector]
	public AdvancedConditionLogicalOperator LogicalOperator; // 0x18
	[HideInInspector]
	public AdvancedCondition[] Conditions; // 0x20
}
