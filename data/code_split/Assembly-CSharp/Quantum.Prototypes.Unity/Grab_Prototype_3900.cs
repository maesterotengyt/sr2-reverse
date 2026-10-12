// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Grab))]
[Serializable]
public class Grab_Prototype : PrototypeAdapter<Grab_Prototype> // TypeDefIndex: 3900
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
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
	[LocalReference]
	public EntityPrototype GrabbedEntity; // 0x50
	[HideInInspector]
	[LocalReference]
	public EntityPrototype GrabberEntity; // 0x58
	[HideInInspector]
	public int JointID; // 0x60
	[HideInInspector]
	public FPVector3 GrabJointPosition; // 0x68
	[HideInInspector]
	public FPVector3 GrabJointRotation; // 0x80
	[HideInInspector]
	public FPVector2 ThrowDirection; // 0x98
	[HideInInspector]
	public QBoolean StrongThrow; // 0xA8
	[HideInInspector]
	public QBoolean StrongUse; // 0xAC

	// Methods

	// RVA: 0x677380 Offset: 0x675980 VA: 0x180677380 Slot: 5
	public sealed override Grab_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6774D0 Offset: 0x675AD0 VA: 0x1806774D0
	public void .ctor() { }
}
