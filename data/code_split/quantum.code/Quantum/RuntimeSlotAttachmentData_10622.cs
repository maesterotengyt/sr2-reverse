// Namespace: Quantum
[Serializable]
public class RuntimeSlotAttachmentData // TypeDefIndex: 10622
{
	// Fields
	public HashString RigID; // 0x10
	public HashString PropID; // 0x20
	public TargetSlot Slot; // 0x30
	public bool HasConditions; // 0x34
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedConditionLogicalOperator LogicalOperator; // 0x38
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedCondition[] Conditions; // 0x40

	// Methods

	// RVA: 0x20F9690 Offset: 0x20F7C90 VA: 0x1820F9690
	public void .ctor() { }
}
