// Namespace: Quantum.Prototypes
[Prototype(typeof(EdgeGrab))]
[Serializable]
public sealed class EdgeGrab_Prototype : ComponentPrototype<EdgeGrab> // TypeDefIndex: 10789
{
	// Fields
	public QBoolean Active; // 0x18
	public MapEntityId Entity; // 0x1C
	[HideInInspector]
	public MapEntityId EdgeEntity; // 0x20
	[HideInInspector]
	public FP EdgeGrabCooldown; // 0x28
	[HideInInspector]
	public EdgeGrabCondition_Prototype EdgeGrabCondition; // 0x30
	[HideInInspector]
	public FP GrabConditionVelocity; // 0x38
	[HideInInspector]
	public FPVector2 EdgeHook; // 0x40
	[HideInInspector]
	public QBoolean Interpolate; // 0x50
	[HideInInspector]
	public SimpleAABB_Prototype CurrentRect; // 0x58
	[HideInInspector]
	public SimpleAABB_Prototype PreviousRect; // 0x60

	// Methods

	// RVA: 0x2103070 Offset: 0x2101670 VA: 0x182103070 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21032E0 Offset: 0x21018E0 VA: 0x1821032E0
	public void Materialize(Frame frame, ref EdgeGrab result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2103250 Offset: 0x2101850 VA: 0x182103250 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21033A0 Offset: 0x21019A0 VA: 0x1821033A0
	public void .ctor() { }
}
