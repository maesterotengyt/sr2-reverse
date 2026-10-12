// Namespace: Quantum
[Serializable]
public class AdvancedCondition // TypeDefIndex: 10623
{
	// Fields
	public EntityVariable Target; // 0x10
	public EntityVariable Value; // 0x18
	public AdvancedConditionComparer Comparer; // 0x20

	// Methods

	// RVA: 0x20E5960 Offset: 0x20E3F60 VA: 0x1820E5960
	public bool Evaluate(Frame frame, CachedEntityData entityData) { }

	// RVA: 0x20E5830 Offset: 0x20E3E30 VA: 0x1820E5830
	public static bool EvaluateMultiple(Frame frame, CachedEntityData entityData, AdvancedConditionLogicalOperator logicalOperator, AdvancedCondition[] conditions) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
