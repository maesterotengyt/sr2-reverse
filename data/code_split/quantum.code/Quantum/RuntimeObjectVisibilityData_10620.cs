// Namespace: Quantum
[Serializable]
public class RuntimeObjectVisibilityData // TypeDefIndex: 10620
{
	// Fields
	public HashString RigID; // 0x10
	public HashString ObjectID; // 0x20
	public bool Visibility; // 0x30
	public bool HasConditions; // 0x31
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedConditionLogicalOperator LogicalOperator; // 0x34
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedCondition[] Conditions; // 0x38

	// Methods

	// RVA: 0x20F9630 Offset: 0x20F7C30 VA: 0x1820F9630
	public void .ctor() { }
}
