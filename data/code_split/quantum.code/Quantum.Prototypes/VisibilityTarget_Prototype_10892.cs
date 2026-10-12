// Namespace: Quantum.Prototypes
[Prototype(typeof(VisibilityTarget))]
[Serializable]
public sealed class VisibilityTarget_Prototype : ComponentPrototype<VisibilityTarget> // TypeDefIndex: 10892
{
	// Fields
	[HideInInspector]
	public MapEntityId Entity; // 0x18
	[HideInInspector]
	public QBoolean Visible; // 0x1C
	[HideInInspector]
	public QBoolean BoundsInitialized; // 0x20
	public SimpleAABB_Prototype Bounds; // 0x28
	public QBoolean UseTriggerAsBounds; // 0x30
	public QBoolean AlterStateMachine; // 0x34
	public int StateMachineUpdateCooldown; // 0x38
	public QBoolean AlterPhysicsBody; // 0x3C
	public QBoolean AlterKinematicBody; // 0x40
	public QBoolean AlterTrigger; // 0x44
	public QBoolean AlterCombat; // 0x48

	// Methods

	// RVA: 0x21194F0 Offset: 0x2117AF0 VA: 0x1821194F0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21196F0 Offset: 0x2117CF0 VA: 0x1821196F0
	public void Materialize(Frame frame, ref VisibilityTarget result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2119660 Offset: 0x2117C60 VA: 0x182119660 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2119790 Offset: 0x2117D90 VA: 0x182119790
	public void .ctor() { }
}
