// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(VelocityModifier))]
[Serializable]
public class VelocityModifier_Prototype : PrototypeAdapter<VelocityModifier_Prototype> // TypeDefIndex: 3941
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
	public VelocityType_Prototype Type; // 0x1C
	public VelocityOperation_Prototype OperationType; // 0x20
	public FP XVelocityModifier; // 0x28
	public FP YVelocityModifier; // 0x30
	public FP MaxYClamp; // 0x38
	public VelocityModifierCondition_Prototype ApplyXVelocityCondition; // 0x40
	public VelocityModifierCondition_Prototype ApplyYVelocityCondition; // 0x44
	public QBoolean ResetMovesetLimiter; // 0x48
	public QBoolean ChangeState; // 0x4C
	[DynamicCollection]
	public TargetStatePerEntity_Prototype[] TargetStatePerEntity; // 0x50

	// Methods

	// RVA: 0x684C80 Offset: 0x683280 VA: 0x180684C80 Slot: 5
	public sealed override VelocityModifier_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x684D60 Offset: 0x683360 VA: 0x180684D60
	public void .ctor() { }
}
