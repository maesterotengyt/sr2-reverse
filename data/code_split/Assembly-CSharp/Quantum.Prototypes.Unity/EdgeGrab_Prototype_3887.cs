// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(EdgeGrab))]
[Serializable]
public class EdgeGrab_Prototype : PrototypeAdapter<EdgeGrab_Prototype> // TypeDefIndex: 3887
{
	// Fields
	public QBoolean Active; // 0x10
	[LocalReference]
	public EntityPrototype Entity; // 0x18
	[HideInInspector]
	[LocalReference]
	public EntityPrototype EdgeEntity; // 0x20
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

	// RVA: 0x6750F0 Offset: 0x6736F0 VA: 0x1806750F0 Slot: 5
	public sealed override EdgeGrab_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6751E0 Offset: 0x6737E0 VA: 0x1806751E0
	public void .ctor() { }
}
