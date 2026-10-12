// Namespace: Quantum.Prototypes
[Prototype(typeof(CombatTech))]
[Serializable]
public sealed class CombatTech_Prototype : ComponentPrototype<CombatTech> // TypeDefIndex: 10781
{
	// Fields
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public QBoolean DetectTechLock; // 0x1C
	[HideInInspector]
	public FP TechLockFrames; // 0x20
	[HideInInspector]
	public FP TechBufferFrames; // 0x28

	// Methods

	// RVA: 0x2100120 Offset: 0x20FE720 VA: 0x182100120 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21002B0 Offset: 0x20FE8B0 VA: 0x1821002B0
	public void Materialize(Frame frame, ref CombatTech result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2100220 Offset: 0x20FE820 VA: 0x182100220 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2100300 Offset: 0x20FE900 VA: 0x182100300
	public void .ctor() { }
}
