// Namespace: Quantum
public struct PhysicsSceneSettings // TypeDefIndex: 11751
{
	// Fields
	internal PhysicsSceneSettings.PhysicsSceneSettingsFlags _flags; // 0x0
	public PhysicsCommon.ConstraintsSolverType SolverType; // 0x1
	private short _padding; // 0x2
	public ushort SolverIterations; // 0x4
	public ushort PositionSolverIterations; // 0x6
	private const int LAYER_START = 8;
	public const int LAYER_COUNT = 32;
	[FixedBuffer(typeof(int), 32)]
	public PhysicsSceneSettings.<Layers>e__FixedBuffer Layers; // 0x8
	private const int FIRST_FP = 136;
	public FP PenetrationAllowance; // 0x88
	public FP PenetrationCorrection; // 0x90
	public FP MinLinearIntegration; // 0x98
	public FP MinAngularIntegration; // 0xA0
	public FP SleepTimeSec; // 0xA8
	public FP LinearSleepTolerance; // 0xB0
	public FP AngularSleepToleranceInRad; // 0xB8
	public FPVector3 Gravity; // 0xC0
	public Transform2DVertical DefaultVerticalTransform; // 0xD8
	public GJKSettings GJKSettings; // 0xE8
	public CCDSettings CCDSettings; // 0x100
	public const int SIZE = 296;

	// Properties
	public bool AllowSleeping { get; set; }
	public bool UseVerticalTransform { set; }
	public bool UseAngularVelocity { set; }
	public bool UseJoints { get; set; }

	// Methods

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	public bool get_AllowSleeping() { }

	// RVA: 0x2227D10 Offset: 0x2226310 VA: 0x182227D10
	public void set_AllowSleeping(bool value) { }

	// RVA: 0x2227D70 Offset: 0x2226370 VA: 0x182227D70
	public void set_UseVerticalTransform(bool value) { }

	// RVA: 0x2227D30 Offset: 0x2226330 VA: 0x182227D30
	public void set_UseAngularVelocity(bool value) { }

	// RVA: 0x2227D00 Offset: 0x2226300 VA: 0x182227D00
	public bool get_UseJoints() { }

	// RVA: 0x2227D50 Offset: 0x2226350 VA: 0x182227D50
	public void set_UseJoints(bool value) { }

	// RVA: 0x2227820 Offset: 0x2225E20 VA: 0x182227820
	public static void Init(PhysicsSceneSettings* settings, PhysicsCommon.Config config) { }

	// RVA: 0x22277C0 Offset: 0x2225DC0 VA: 0x1822277C0
	public void InitLayers(PhysicsCommon.Config config) { }

	// RVA: 0x2227A50 Offset: 0x2226050 VA: 0x182227A50
	public static void Serialize(PhysicsSceneSettings* ptr, FrameSerializer serializer) { }
}
