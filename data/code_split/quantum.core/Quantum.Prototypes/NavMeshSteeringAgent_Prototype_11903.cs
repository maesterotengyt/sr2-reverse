// Namespace: Quantum.Prototypes
[Prototype(typeof(NavMeshSteeringAgent))]
[Serializable]
public sealed class NavMeshSteeringAgent_Prototype : ComponentPrototype<NavMeshSteeringAgent> // TypeDefIndex: 11903
{
	// Fields
	public bool OverrideMaxSpeed; // 0x18
	public bool OverrideAcceleration; // 0x19
	public FP MaxSpeed; // 0x20
	public FP Acceleration; // 0x28

	// Methods

	// RVA: 0x2274E40 Offset: 0x2273440 VA: 0x182274E40 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2274F70 Offset: 0x2273570 VA: 0x182274F70
	private void PostMaterialize(FrameBase frame, ref NavMeshSteeringAgent result) { }

	// RVA: 0x2274F40 Offset: 0x2273540 VA: 0x182274F40 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2274FC0 Offset: 0x22735C0 VA: 0x182274FC0
	public void .ctor() { }
}
