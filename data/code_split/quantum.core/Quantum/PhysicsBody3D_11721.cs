// Namespace: Quantum
public struct PhysicsBody3D : IComponent // TypeDefIndex: 11721
{
	// Fields
	public const int SIZE = 184;
	private const int DRAG_PRECISION = 10;
	internal PhysicsBody3D.ConfigFlags Config; // 0x0
	public RotationFreezeFlags RotationFreeze; // 0x1
	internal PhysicsCommon.PhysicsBodyStatus Status; // 0x2
	private byte _padding1; // 0x3
	private ushort _drag; // 0x4
	private ushort _angularDrag; // 0x6
	internal int _sleepTimeRawInt; // 0x8
	internal int _massInverseRawInt; // 0xC
	internal int _gravityScaleRawInt; // 0x10
	private int _padding2; // 0x14
	private const int FirstVector3RawInt = 24;
	internal FPVector3RawInt _inertiaTensorInverse; // 0x18
	internal FPVector3RawInt _centerOfMass; // 0x24
	internal FPVector3RawInt _angularImpulse; // 0x30
	internal FPVector3RawInt _lastPosition; // 0x3C
	internal FPQuaternionRawInt _lastRotation; // 0x48
	private const int FirstVector3 = 88;
	private FPVector3 _force; // 0x58
	private FPVector3 _torque; // 0x70
	public FPVector3 Velocity; // 0x88
	public FPVector3 AngularVelocity; // 0xA0

	// Properties
	public FPVector3 Force { get; }
	public FPVector3 Torque { get; }
	public bool Enabled { get; }
	public bool IsSleeping { get; }
	public bool UseContinuousCollisionDetection { get; }
	public FP Drag { get; set; }
	public FP AngularDrag { get; set; }
	public FPVector3 CenterOfMass { get; }
	public bool IsKinematic { get; set; }

	// Methods

	// RVA: 0x221DAE0 Offset: 0x221C0E0 VA: 0x18221DAE0
	public FPVector3 get_Force() { }

	// RVA: 0x221DB10 Offset: 0x221C110 VA: 0x18221DB10
	public FPVector3 get_Torque() { }

	// RVA: 0x221DAD0 Offset: 0x221C0D0 VA: 0x18221DAD0
	public bool get_Enabled() { }

	// RVA: 0x221DB00 Offset: 0x221C100 VA: 0x18221DB00
	public bool get_IsSleeping() { }

	// RVA: 0x221DB30 Offset: 0x221C130 VA: 0x18221DB30
	public bool get_UseContinuousCollisionDetection() { }

	// RVA: 0x221CF90 Offset: 0x221B590 VA: 0x18221CF90
	public FP get_Drag() { }

	// RVA: 0x221D010 Offset: 0x221B610 VA: 0x18221D010
	public void set_Drag(FP value) { }

	// RVA: 0x221CF80 Offset: 0x221B580 VA: 0x18221CF80
	public FP get_AngularDrag() { }

	// RVA: 0x221D000 Offset: 0x221B600 VA: 0x18221D000
	public void set_AngularDrag(FP value) { }

	// RVA: 0x221DA80 Offset: 0x221C080 VA: 0x18221DA80
	public FPVector3 get_CenterOfMass() { }

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	public bool get_IsKinematic() { }

	// RVA: 0x221DB40 Offset: 0x221C140 VA: 0x18221DB40
	public void set_IsKinematic(bool value) { }

	// RVA: 0x221D400 Offset: 0x221BA00 VA: 0x18221D400
	internal void InitBody(FP bodyMass, FP drag, FP angularDrag, PhysicsBody3D.ConfigFlags bodyConfig, RotationFreezeFlags rotationFlags, Nullable<FPVector3> centerOfMass, NullableFP gravityScale) { }

	// RVA: 0x221D6A0 Offset: 0x221BCA0 VA: 0x18221D6A0
	public void ResetInertia(FrameBase frame, EntityRef entity) { }

	// RVA: 0x221D5D0 Offset: 0x221BBD0 VA: 0x18221D5D0
	public void ResetCenterOfMass(FrameBase f, EntityRef entity) { }

	// RVA: 0x221D060 Offset: 0x221B660 VA: 0x18221D060
	public void ClearForce() { }

	// RVA: 0x221D070 Offset: 0x221B670 VA: 0x18221D070
	public void ClearTorque() { }

	// RVA: 0x221D090 Offset: 0x221B690 VA: 0x18221D090
	internal void GetWorldInertiaTensorInverse(FPQuaternion q, out FPMatrix3x3 m) { }

	// RVA: 0x221DA60 Offset: 0x221C060 VA: 0x18221DA60
	internal void WakeUpInternal() { }

	// RVA: 0x221D830 Offset: 0x221BE30 VA: 0x18221D830
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x221D570 Offset: 0x221BB70 VA: 0x18221D570
	internal static void OnAdded(FrameBase f, EntityRef entity, void* component) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	internal static void OnRemoved(FrameBase f, EntityRef entity, void* component) { }
}
