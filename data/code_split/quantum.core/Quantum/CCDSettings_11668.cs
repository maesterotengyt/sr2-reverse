// Namespace: Quantum
public struct CCDSettings // TypeDefIndex: 11668
{
	// Fields
	public const int SIZE = 40;
	private int _allowCCD; // 0x0
	public int MaxTimeOfImpactIterations; // 0x4
	public int MaxRootFindingIterations; // 0x8
	private int _padding; // 0xC
	public FP CCDDistanceTolerance; // 0x10
	internal FP _linearVelocityThresholdSqr; // 0x18
	internal FP _angularVelocityThresholdSqr; // 0x20

	// Properties
	public bool AllowCCD { get; }
	public FP LinearVelocityThreshold { set; }
	public FP AngularVelocityThreshold { get; set; }

	// Methods

	// RVA: 0x2218130 Offset: 0x2216730 VA: 0x182218130
	public void .ctor(PhysicsCommon.Config config) { }

	// RVA: 0x2213CF0 Offset: 0x22122F0 VA: 0x182213CF0
	public bool get_AllowCCD() { }

	// RVA: 0x22182D0 Offset: 0x22168D0 VA: 0x1822182D0
	public void set_LinearVelocityThreshold(FP value) { }

	// RVA: 0x2218250 Offset: 0x2216850 VA: 0x182218250
	public FP get_AngularVelocityThreshold() { }

	// RVA: 0x2218260 Offset: 0x2216860 VA: 0x182218260
	public void set_AngularVelocityThreshold(FP value) { }

	// RVA: 0x2218030 Offset: 0x2216630 VA: 0x182218030
	public static void Serialize(CCDSettings* ptr, FrameSerializer serializer) { }
}
