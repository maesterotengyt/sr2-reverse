// Namespace: Quantum.Prototypes
[Prototype(typeof(NavMeshAvoidanceObstacle))]
[Serializable]
public sealed class NavMeshAvoidanceObstacle_Prototype : ComponentPrototype<NavMeshAvoidanceObstacle> // TypeDefIndex: 11901
{
	// Fields
	[Layer]
	public byte AvoidanceLayer; // 0x18
	public FP Radius; // 0x20
	public bool IsActive; // 0x28

	// Methods

	// RVA: 0x22747A0 Offset: 0x2272DA0 VA: 0x1822747A0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2274890 Offset: 0x2272E90 VA: 0x182274890
	public void Materialize(FrameBase frame, ref NavMeshAvoidanceObstacle result) { }

	// RVA: 0x2274860 Offset: 0x2272E60 VA: 0x182274860 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x22748D0 Offset: 0x2272ED0 VA: 0x1822748D0
	public void .ctor() { }
}
