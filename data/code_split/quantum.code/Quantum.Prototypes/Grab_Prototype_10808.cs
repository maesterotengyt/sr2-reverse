// Namespace: Quantum.Prototypes
[Prototype(typeof(Grab))]
[Serializable]
public sealed class Grab_Prototype : ComponentPrototype<Grab> // TypeDefIndex: 10808
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	public AssetRefGrabData GrabData; // 0x20
	[HideInInspector]
	public GrabbedAction_Prototype GrabbedAction; // 0x28
	[HideInInspector]
	public GrabMode_Prototype GrabMode; // 0x2C
	[HideInInspector]
	public GrabDirection_Prototype GrabDirection; // 0x30
	[HideInInspector]
	public QBoolean CanBeGrabbed; // 0x34
	[HideInInspector]
	public QBoolean GrabbableOnlyByOwner; // 0x38
	[HideInInspector]
	public GrabState_Prototype GrabState; // 0x3C
	[HideInInspector]
	public QBoolean CanEscapeGrab; // 0x40
	[HideInInspector]
	public FP RemainingFramesToEscape; // 0x48
	[HideInInspector]
	public MapEntityId GrabbedEntity; // 0x50
	[HideInInspector]
	public MapEntityId GrabberEntity; // 0x54
	[HideInInspector]
	public int JointID; // 0x58
	[HideInInspector]
	public FPVector3 GrabJointPosition; // 0x60
	[HideInInspector]
	public FPVector3 GrabJointRotation; // 0x78
	[HideInInspector]
	public FPVector2 ThrowDirection; // 0x90
	[HideInInspector]
	public QBoolean StrongThrow; // 0xA0
	[HideInInspector]
	public QBoolean StrongUse; // 0xA4

	// Methods

	// RVA: 0x21065D0 Offset: 0x2104BD0 VA: 0x1821065D0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x21068D0 Offset: 0x2104ED0 VA: 0x1821068D0
	public void Materialize(Frame frame, ref Grab result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2106840 Offset: 0x2104E40 VA: 0x182106840 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x21069C0 Offset: 0x2104FC0 VA: 0x1821069C0
	public void .ctor() { }
}
