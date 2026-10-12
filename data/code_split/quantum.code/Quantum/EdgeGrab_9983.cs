// Namespace: Quantum
public struct EdgeGrab : IComponent // TypeDefIndex: 9983
{
	// Fields
	public QBoolean Active; // 0x4
	[HideInInspector]
	public SimpleAABB CurrentRect; // 0x40
	[HideInInspector]
	public EntityRef EdgeEntity; // 0x10
	[HideInInspector]
	public EdgeGrabCondition EdgeGrabCondition; // 0x0
	[HideInInspector]
	public FP EdgeGrabCooldown; // 0x20
	[HideInInspector]
	public FPVector2 EdgeHook; // 0x30
	public EntityRef Entity; // 0x18
	[HideInInspector]
	public FP GrabConditionVelocity; // 0x28
	[HideInInspector]
	public QBoolean Interpolate; // 0x8
	[HideInInspector]
	public SimpleAABB PreviousRect; // 0x60

	// Methods

	// RVA: 0x20E1450 Offset: 0x20DFA50 VA: 0x1820E1450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E16A0 Offset: 0x20DFCA0 VA: 0x1820E16A0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20E1670 Offset: 0x20DFC70 VA: 0x1820E1670
	internal void Initialize(Frame frame, EntityRef entity) { }

	// RVA: 0x20E17C0 Offset: 0x20DFDC0 VA: 0x1820E17C0
	internal void StartEdgeGrab(Frame frame, EdgeGrabRequest edgeGrabRequest) { }

	// RVA: 0x20E1940 Offset: 0x20DFF40 VA: 0x1820E1940
	internal void StopEdgeGrab(Frame frame) { }

	// RVA: 0x20E1530 Offset: 0x20DFB30 VA: 0x1820E1530
	internal FPVector2 GrabbedEdgePosition(Frame frame) { }

	// RVA: 0x20E15E0 Offset: 0x20DFBE0 VA: 0x1820E15E0
	internal EdgeSide GrabbedEdgeSide(Frame frame) { }
}
