// Namespace: Quantum.Prototypes
[Prototype(typeof(StageHazardSpawnArea))]
[Serializable]
public sealed class StageHazardSpawnArea_Prototype : ComponentPrototype<StageHazardSpawnArea> // TypeDefIndex: 10868
{
	// Fields
	public FPVector2 TopLeft; // 0x18
	public FPVector2 BottomRight; // 0x28
	public HazardSpawnDirection_Prototype SpawnDirection; // 0x38

	// Methods

	// RVA: 0x2110830 Offset: 0x210EE30 VA: 0x182110830 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21109C0 Offset: 0x210EFC0 VA: 0x1821109C0
	public void Materialize(Frame frame, ref StageHazardSpawnArea result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2110930 Offset: 0x210EF30 VA: 0x182110930 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21109E0 Offset: 0x210EFE0 VA: 0x1821109E0
	public void .ctor() { }
}
