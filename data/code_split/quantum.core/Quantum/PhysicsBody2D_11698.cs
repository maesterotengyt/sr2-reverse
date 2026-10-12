// Namespace: Quantum
public struct PhysicsBody2D : IComponent // TypeDefIndex: 11698
{
	// Fields
	public const int SIZE = 120;
	private const int DRAG_PRECISION = 10;
	internal PhysicsBody2D.ConfigFlags Config; // 0x0
	internal PhysicsCommon.PhysicsBodyStatus Status; // 0x1
	private short _padding; // 0x2
	private ushort _drag; // 0x4
	private ushort _angularDrag; // 0x6
	internal int _massInverseRawInt; // 0x8
	internal int _gravityScaleRawInt; // 0xC
	private const int FIRST_FP_OFFSET = 16;
	internal FP InertiaInverse; // 0x10
	public FP AngularVelocity; // 0x18
	private FP _torque; // 0x20
	internal FP SleepTime; // 0x28
	internal FP LastRotation; // 0x30
	private const int FIRST_FPVECTOR2_OFFSET = 56;
	public FPVector2 Velocity; // 0x38
	private FPVector2 _force; // 0x48
	internal FPVector2 LastPosition; // 0x58
	public FPVector2 CenterOfMass; // 0x68

	// Properties
	public FPVector2 Force { get; }
	public FP Torque { get; }
	public bool Enabled { get; }
	public bool IsSleeping { get; }
	public FP Drag { get; set; }
	public FP AngularDrag { get; set; }
	public bool UseContinuousCollisionDetection { get; }
	public FP Mass { get; }
	public bool IsKinematic { get; set; }

	// Methods

	// RVA: 0x221CFB0 Offset: 0x221B5B0 VA: 0x18221CFB0
	public FPVector2 get_Force() { }

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public FP get_Torque() { }

	// RVA: 0x221CFA0 Offset: 0x221B5A0 VA: 0x18221CFA0
	public bool get_Enabled() { }

	// RVA: 0x221CFC0 Offset: 0x221B5C0 VA: 0x18221CFC0
	public bool get_IsSleeping() { }

	// RVA: 0x221CF90 Offset: 0x221B590 VA: 0x18221CF90
	public FP get_Drag() { }

	// RVA: 0x221D010 Offset: 0x221B610 VA: 0x18221D010
	public void set_Drag(FP value) { }

	// RVA: 0x221CF80 Offset: 0x221B580 VA: 0x18221CF80
	public FP get_AngularDrag() { }

	// RVA: 0x221D000 Offset: 0x221B600 VA: 0x18221D000
	public void set_AngularDrag(FP value) { }

	// RVA: 0x221CFF0 Offset: 0x221B5F0 VA: 0x18221CFF0
	public bool get_UseContinuousCollisionDetection() { }

	// RVA: 0x221CFD0 Offset: 0x221B5D0 VA: 0x18221CFD0
	public FP get_Mass() { }

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	public bool get_IsKinematic() { }

	// RVA: 0x221D020 Offset: 0x221B620 VA: 0x18221D020
	public void set_IsKinematic(bool value) { }

	// RVA: 0x221C9F0 Offset: 0x221AFF0 VA: 0x18221C9F0
	internal void InitBody(FP bodyMass, FP drag, FP angularDrag, PhysicsBody2D.ConfigFlags bodyConfig, Nullable<FPVector2> centerOfMass, NullableFP gravityScale) { }

	// RVA: 0x221CC20 Offset: 0x221B220 VA: 0x18221CC20
	public void ResetInertia(FrameBase frame, EntityRef entity) { }

	// RVA: 0x221CB80 Offset: 0x221B180 VA: 0x18221CB80
	public void ResetCenterOfMass(FrameBase f, EntityRef entity) { }

	// RVA: 0x221C9D0 Offset: 0x221AFD0 VA: 0x18221C9D0
	public void ClearForce() { }

	// RVA: 0x221C9E0 Offset: 0x221AFE0 VA: 0x18221C9E0
	public void ClearTorque() { }

	// RVA: 0x221CF60 Offset: 0x221B560 VA: 0x18221CF60
	internal void WakeUpInternal() { }

	// RVA: 0x221CD90 Offset: 0x221B390 VA: 0x18221CD90
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x221CAD0 Offset: 0x221B0D0 VA: 0x18221CAD0
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
