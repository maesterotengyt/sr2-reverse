// Namespace: Quantum
public struct VelocityModifier : IComponent // TypeDefIndex: 10063
{
	// Fields
	public QBoolean Active; // 0x0
	public VelocityModifierCondition ApplyXVelocityCondition; // 0x10
	public VelocityModifierCondition ApplyYVelocityCondition; // 0x14
	public QBoolean ChangeState; // 0x4
	public EntityRef Entity; // 0x20
	public FP MaxYClamp; // 0x28
	public VelocityOperation OperationType; // 0x18
	public QBoolean ResetMovesetLimiter; // 0x8
	[PtrQList(typeof(TargetStatePerEntity))]
	private Ptr TargetStatePerEntityPtr; // 0xC
	public VelocityType Type; // 0x1C
	public FP XVelocityModifier; // 0x30
	public FP YVelocityModifier; // 0x38

	// Properties
	public QListPtr<TargetStatePerEntity> TargetStatePerEntity { get; set; }

	// Methods

	// RVA: 0x214E1C0 Offset: 0x214C7C0 VA: 0x18214E1C0
	public QListPtr<TargetStatePerEntity> get_TargetStatePerEntity() { }

	// RVA: 0x1ED2120 Offset: 0x1ED0720 VA: 0x181ED2120
	public void set_TargetStatePerEntity(QListPtr<TargetStatePerEntity> value) { }

	// RVA: 0x214DD40 Offset: 0x214C340 VA: 0x18214DD40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20C9B80 Offset: 0x20C8180 VA: 0x1820C9B80
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x214DDD0 Offset: 0x214C3D0 VA: 0x18214DDD0
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x214DE50 Offset: 0x214C450 VA: 0x18214DE50
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x214DFF0 Offset: 0x214C5F0 VA: 0x18214DFF0
	public void Update(Frame frame, EntityRef entity) { }

	// RVA: 0x214DAD0 Offset: 0x214C0D0 VA: 0x18214DAD0
	public void ApplyVelocity(Frame frame, EntityRef otherEntity, bool impulse = False) { }
}
