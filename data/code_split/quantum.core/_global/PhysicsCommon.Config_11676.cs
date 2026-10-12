// Namespace: 
[Serializable]
public class PhysicsCommon.Config // TypeDefIndex: 11676
{
	// Fields
	internal const int DEFAULT_ENTRIES_CAPACITY = 2048;
	internal const int DEFAULT_STATICS_CAPACITY = 1024;
	internal const int DEFAULT_QUERIES_CAPACITY = 1024;
	internal const int DEFAULT_QUERY_ITEMS_CAPACITY = 1024;
	internal const int DEFAULT_HITCOLLECTION_ITEMS_CAPACITY = 32;
	internal const int DEFAULT_BUCKETS_CAPACITY = 16;
	internal const int DEFAULT_ISLANDS_CAPACITY = 512;
	internal const int DEFAULT_MANIFOLDS_CAPACITY = 1024;
	internal const int DEFAULT_JOINTS_CAPACITY = 128;
	[Tooltip("Define the gravity of the physics simulation. For a 2D world set the y-component to zero.
Default is (0, -10, 0).")]
	public FPVector3 Gravity; // 0x10
	public PhysicsCommon.ConstraintsSolverType SolverType; // 0x28
	[Tooltip("The physics collision solver runs in sub-steps to improve quality.
Default is 4.")]
	public int SolverIterations; // 0x2C
	[Tooltip("The physics position constraint solver (used on Joint, for instance) runs in sub-steps to improve quality.
Default is 2.")]
	public int PositionSolverIterations; // 0x30
	[Tooltip("Enable the use of joints in the physics engines. If joints are not used, this can be disabled to reduce overhead.
Default is true.")]
	public bool UseJoints; // 0x34
	[Tooltip("Lock the angular velocity for dynamic bodies. Disabling this option leads not only to faster but also to more stable physics simulation for games that can use it.
Default is true.")]
	public bool UseAngularVelocity; // 0x35
	[Tooltip("Toggle the use of a vertical transform component for 2.5D worlds that have a simplified concept of height.
Default is true.")]
	public bool UseVerticalTransform; // 0x36
	[Tooltip("Allow a certain degree of penetration to improve the stability of the physics simulation.
Default is 0.01.")]
	public FP PenetrationAllowance; // 0x38
	[Tooltip("How much of the exceeding penetration (above allowance) should be corrected in a single frame.
0 = no correction,
1 = full correction.
Default is 0.5.")]
	public FP PenetrationCorrection; // 0x40
	[Tooltip("A physics body's linear velocity component (x, y or z, the latter only in the 3D Physics) is rounded to 0 if its absolute value is smaller than this minimum linear integration.
A small amount can increase the physics simulation stability and improve sleep detection.
Default is 0.")]
	public FP MinLinearIntegration; // 0x48
	[Tooltip("A physics body's angular velocity component (x, y or z in the 3D Physics and the amount relative to the vertical axis in the 2D Physics) is rounded to 0 if its absolute value is smaller than this minimum angular integration.
A small amount can increase the physics simulation stability and improve sleep detection.
Default is 0.")]
	public FP MinAngularIntegration; // 0x50
	[Header("GJK Config")]
	[Tooltip("Scales the GJK Voronoy Simplex space by shifting points' raw values. Consider increasing if working with small-scaled shapes.
Default is 0.")]
	public int SimplexMinBitShift; // 0x58
	[Tooltip("The GJK Voronoy Simplex space is scaled by progressively by shifting points' raw values up to this max value when the current instance becomes affine dependent, avoiding degenerate cases due to limited precision.
Default is 2.")]
	public int SimplexMaxBitShift; // 0x5C
	[Tooltip("The max number of iterations performed by the GJK algorithm while searching for a solution below ShapeCastHardTolerance.
Default is 16.")]
	public int ShapeCastMaxIterations; // 0x60
	[Tooltip("A GJK iteration result below this threshold is acceptable as a finishing condition.
In general, increasing the hard tolerance decreases the accuracy of the result, but reduces computational cost by requiring less iterations.
Default is 0.01.")]
	public FP ShapeCastHardTolerance; // 0x68
	[Tooltip("A GJK resolution that fails to find an acceptable result below ShapeCastHardTolerance after ShapeCastMaxIterations will still return positive if the best solution found is below this soft threshold.
Default is 0.05.")]
	public FP ShapeCastSoftTolerance; // 0x70
	[Header("Sleeping Config")]
	[Tooltip("Toggles the detection of physics bodies in a sleeping state.
If allowed, the simulation will skip forces and velocity integrations and collisions detection on physics bodies while they are asleep.
Default is false.")]
	public bool AllowSleeping; // 0x78
	[Tooltip("For how many seconds a physics body should stay under the linear and angular velocity sleeping thresholds before being put in a sleeping state.
Default is 0.5.")]
	public FP SleepTimeSec; // 0x80
	[Tooltip("Amount of linear velocity below which a physics body might be considered as standing still for sleeping detection.
Default is 0.02.")]
	public FP LinearSleepTolerance; // 0x88
	[Tooltip("Amount of angular velocity below which a physics body might be considered as standing still for sleeping detection.")]
	public FP AngularSleepToleranceInRad; // 0x90
	[Header("Continuous Collision Detection (CCD)")]
	[Tooltip("Allows CCD to be performed if the Physics Body has CCD enabled on its Config flags.
Default is false.")]
	public bool AllowCCD; // 0x98
	[Tooltip("If CCD is allowed, it will be performed on all Physics Bodies that have it enabled and have a linear velocity magnitude above this threshold.
Default is 3.")]
	public FP CCDLinearVelocityThreshold; // 0xA0
	[Tooltip("If CCD is allowed, it will be performed on all Physics Bodies that have it enabled and have a angular velocity magnitude above this threshold.
Default is 3.")]
	public FP CCDAngularVelocityThreshold; // 0xA8
	[Tooltip("The absolute distance value below which the Physics Bodies under CCD check can be considered as touching.
Default is 0.001.")]
	public FP CCDDistanceTolerance; // 0xB0
	[Tooltip("The maximum number of iterations performed by the CCD algorithm when computing the time of impact between two Physics Bodies.
Default is 16.")]
	public int MaxTimeOfImpactIterations; // 0xB8
	[Tooltip("The maximum number of iterations performed when computing the point in time when the distance between two Physics Bodies in a given separation axis is below the tolerance.
Default is 32.")]
	public int MaxRootFindingIterations; // 0xBC
	[Header("Default Capacities")]
	[DisplayName("Entries")]
	public int DefaultEntriesCapacity; // 0xC0
	[DisplayName("Statics")]
	public int DefaultStaticsCapacity; // 0xC4
	[DisplayName("Queries")]
	public int DefaultQueriesCapacity; // 0xC8
	[DisplayName("Query Items")]
	public int DefaultQueryItemsCapacity; // 0xCC
	[DisplayName("Hit Collection Items")]
	public int DefaultHitCollectionItemsCapacity; // 0xD0
	[DisplayName("Buckets")]
	public int DefaultBucketsCapacity; // 0xD4
	[DisplayName("Islands")]
	public int DefaultIslandsCapacity; // 0xD8
	[DisplayName("Manifolds")]
	public int DefaultManifoldsCapacity; // 0xDC
	[DisplayName("Joints")]
	public int DefaultJointsCapacity; // 0xE0
	[Header("Default Assets")]
	[Tooltip("")]
	public AssetRefPhysicsMaterial DefaultPhysicsMaterial; // 0xE8
	[Tooltip("")]
	public AssetRefCharacterController2DConfig DefaultCharacterController2D; // 0xF0
	[Tooltip("")]
	public AssetRefCharacterController3DConfig DefaultCharacterController3D; // 0xF8
	[Tooltip("")]
	[Header("Layers")]
	public string[] Layers; // 0x100
	[Tooltip("")]
	public int[] LayerMatrix; // 0x108

	// Methods

	// RVA: 0x221B080 Offset: 0x2219680 VA: 0x18221B080
	public void .ctor() { }
}
