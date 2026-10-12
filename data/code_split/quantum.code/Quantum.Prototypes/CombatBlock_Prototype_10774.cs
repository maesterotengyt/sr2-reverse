// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatBlock))]
[Serializable]
public sealed class CombatBlock_Prototype : ComponentPrototype<CombatBlock> // TypeDefIndex: 10774
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public QBoolean Blocking; // 0x1C
	[HideInInspector]
	public FP BlockFrames; // 0x20
	[HideInInspector]
	public FP BlockStamina; // 0x28
	[HideInInspector]
	public FP PerfectBlockLockFrames; // 0x30
	[HideInInspector]
	public FP PerfectBlockBufferFrames; // 0x38

	// Methods

	// RVA: 0x20FF410 Offset: 0x20FDA10 VA: 0x1820FF410 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF5D0 Offset: 0x20FDBD0 VA: 0x1820FF5D0
	public void Materialize(Frame frame, ref CombatBlock result, in PrototypeMaterializationContext context) { }

	// RVA: 0x20FF540 Offset: 0x20FDB40 VA: 0x1820FF540 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x20FF630 Offset: 0x20FDC30 VA: 0x1820FF630
	public void .ctor() { }
}
