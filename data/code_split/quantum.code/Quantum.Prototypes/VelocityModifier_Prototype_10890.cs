// Namespace: Quantum.Prototypes
[Prototype(typeof(VelocityModifier))]
[Serializable]
public sealed class VelocityModifier_Prototype : ComponentPrototype<VelocityModifier> // TypeDefIndex: 10890
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	public VelocityType_Prototype Type; // 0x20
	public VelocityOperation_Prototype OperationType; // 0x24
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

	// RVA: 0x2118E10 Offset: 0x2117410 VA: 0x182118E10 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2118FD0 Offset: 0x21175D0 VA: 0x182118FD0
	public void Materialize(Frame frame, ref VelocityModifier result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2118F40 Offset: 0x2117540 VA: 0x182118F40 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2119220 Offset: 0x2117820 VA: 0x182119220
	public void .ctor() { }
}
