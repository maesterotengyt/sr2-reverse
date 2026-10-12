// Namespace: Quantum
public class Navigation : IDisposable // TypeDefIndex: 11654
{
	// Fields
	private Navigation.Updater _updater; // 0x10
	private const long AngularSpeedInstantRotationThreshold = 13107200;
	private const long Epsilon = 65;
	private const long FP_0_25 = 16384;
	private const long FP_0_50 = 32768;
	private const long FP_0_75 = 49152;

	// Methods

	// RVA: 0x21E28D0 Offset: 0x21E0ED0 VA: 0x1821E28D0
	internal void .ctor(Navigation.Config config, FrameContext context) { }

	// RVA: 0x21DEC20 Offset: 0x21DD220 VA: 0x1821DEC20 Slot: 4
	public void Dispose() { }

	// RVA: 0x21E2860 Offset: 0x21E0E60 VA: 0x1821E2860
	public TaskHandle Update(FrameBase frame, FP deltaTime, INavigationCallbacks callbacks, TaskHandle handle) { }

	// RVA: 0x21DEC60 Offset: 0x21DD260 VA: 0x1821DEC60
	internal static Navigation.ThreadLocal GetThreadLocal(FrameThreadSafe f) { }

	// RVA: 0x21E2530 Offset: 0x21E0B30 VA: 0x1821E2530
	private static void UpdatePathfinderWaypointDetection(FrameThreadSafe f, Navigation.Entry* entry, FPVector3 previousPosition, NavMeshAgentConfig config) { }

	// RVA: 0x21DF030 Offset: 0x21DD630 VA: 0x1821DF030
	private static void MoveEntityOverLink(FrameThreadSafe f, Navigation.Entry* entry, NavMeshAgentConfig config, FP deltaTime, long maxHeightDelta) { }

	// RVA: 0x21DF8F0 Offset: 0x21DDEF0 VA: 0x1821DF8F0
	private static void MoveEntity(FrameThreadSafe f, Navigation.Entry* entry, NavMeshAgentConfig config, FP deltaTime, long maxHeightDelta) { }

	// RVA: 0x21E2050 Offset: 0x21E0650 VA: 0x1821E2050
	private static bool TryGetVerticalPositionRaw(FrameThreadSafe f, Navigation.Entry* entry, Navigation.VerticalPositioningType verticalPositioningType, FPVector3 position, long heightRaw, ref NavMesh navmesh, ref Navigation.ThreadLocal threadLocal, out long result) { }

	// RVA: 0x21E2010 Offset: 0x21E0610 VA: 0x1821E2010
	private static FPVector3 ToVector3(FPVector2 position, Transform2DVertical* transform2DVertical) { }

	// RVA: 0x21DDA40 Offset: 0x21DC040 VA: 0x1821DDA40
	private static void ApplyToTransform(FPVector3 position, Transform2D* transform, Transform2DVertical* transform2DVertical) { }

	// RVA: 0x21E0BE0 Offset: 0x21DF1E0 VA: 0x1821E0BE0
	private static bool PreUpdate(FrameThreadSafe f, Navigation.Entry* entry, NavMeshAgentConfig config, NavMesh navmesh, FP deltaTime, long maxHeightDelta) { }

	// RVA: 0x21DECC0 Offset: 0x21DD2C0 VA: 0x1821DECC0
	internal static void LineOfSightLogic(FrameBase f, NavMeshPathfinder* pathfinderAgent, Navigation.Entry* entry, long sqrDistanceRaw, NavMeshAgentConfig config, NavMesh navmesh, Navigation.ThreadLocal threadLocal) { }

	// RVA: 0x21E23C0 Offset: 0x21E09C0 VA: 0x1821E23C0
	private static void UpdateDesiredVelocity(FrameBase f, Navigation.Entry* entry) { }

	// RVA: 0x21E1C20 Offset: 0x21E0220 VA: 0x1821E1C20
	private static bool SearchPath(FrameThreadSafe f, Navigation.PathFinder pf, NavMeshPathfinder* pathfinderAgent, Navigation.Entry* e, NavMeshAgentConfig config, NavMesh navmesh) { }

	// RVA: 0x21DE1D0 Offset: 0x21DC7D0 VA: 0x1821DE1D0
	private static void ComputeHRVO(FrameBase f, Navigation.Entry* a, Navigation.Entry* b, long radiusSum, ref Navigation.VelocityObstacle hrvoA, ref Navigation.VelocityObstacle hrvoB, FPVector2 desiredVelocity, FPVector2 otherDesiredVelocity, long maxHeightDelta, long voTruncationFactor) { }

	// RVA: 0x21E1550 Offset: 0x21DFB50 VA: 0x1821E1550
	private static void Quicksort(Navigation.VelocityCandidate[] A, int lo, int hi) { }

	// RVA: 0x21E18E0 Offset: 0x21DFEE0 VA: 0x1821E18E0
	private static FPVector2 RunAvoidanceOnAgent(FrameThreadSafe f, Navigation.Entry* entry, NavMeshAgentConfig config, FP deltaTime, ref FP desiredSpeed) { }

	// RVA: 0x21DDA70 Offset: 0x21DC070 VA: 0x1821DDA70
	private static bool CalculateAgentAvoidance(FrameThreadSafe f, Navigation.Entry* entry, NavMeshAgentConfig config, FP deltaTime, FPVector2 preferredVelocity, FP preferredSpeed, ref FPVector2 newVelocity) { }
}
