// Namespace: Quantum
public class MathUtils // TypeDefIndex: 10692
{
	// Properties
	public static FP SecondsToFrame { get; }
	public static FP FrameToSeconds { get; }

	// Methods

	// RVA: 0x20EF480 Offset: 0x20EDA80 VA: 0x1820EF480
	public static FP get_SecondsToFrame() { }

	// RVA: 0x20EF470 Offset: 0x20EDA70 VA: 0x1820EF470
	public static FP get_FrameToSeconds() { }

	// RVA: 0x20EF160 Offset: 0x20ED760 VA: 0x1820EF160
	public static int Random(Frame frame, int minInclusive, int maxInclusive) { }

	// RVA: 0x20EF1A0 Offset: 0x20ED7A0 VA: 0x1820EF1A0
	public static FP Random(Frame frame, FP minInclusive, FP maxInclusive) { }

	// RVA: 0x20EEF30 Offset: 0x20ED530 VA: 0x1820EEF30
	public static FPVector2 Ortho(FPVector2 vector) { }

	// RVA: 0x20EF1E0 Offset: 0x20ED7E0 VA: 0x1820EF1E0
	public static FPVector2 ReflectAway(FPVector2 vector, FPVector2 normal) { }

	// RVA: 0x20EEFA0 Offset: 0x20ED5A0 VA: 0x1820EEFA0
	public static FPVector2 ProjectPointOnSegment(FPVector2 segmentStart, FPVector2 segmentEnd, FPVector2 point, bool clamp = False) { }

	// RVA: 0x20EE0F0 Offset: 0x20EC6F0 VA: 0x1820EE0F0
	public static FPVector3 GlobalPoint(FPVector3 point, FPVector3 transformPosition, FPQuaternion transformRotation, FPVector3 transformScale) { }

	// RVA: 0x20EEB90 Offset: 0x20ED190 VA: 0x1820EEB90
	public static FPVector2 LocalToWorldPoint(Frame frame, EntityRef entity, Transform2D* transform, FPVector2 point, bool ignoreScale = False) { }

	// RVA: 0x20EF340 Offset: 0x20ED940 VA: 0x1820EF340
	public static FPVector2 RotatePointAroundPivot(FPVector2 point, FPVector2 pivot, FP angle) { }

	// RVA: 0x20EEED0 Offset: 0x20ED4D0 VA: 0x1820EEED0
	public static FP NormalizedAngle(FP angle) { }

	// RVA: 0x20EDF70 Offset: 0x20EC570 VA: 0x1820EDF70
	public static FP ClosestAngleDifference(FP angle1, FP angle2) { }

	// RVA: 0x20EDC20 Offset: 0x20EC220 VA: 0x1820EDC20
	public static FP AngleLinearInterpolation(FP angle1, FP angle2, FP t) { }

	// RVA: 0x20EE090 Offset: 0x20EC690 VA: 0x1820EE090
	public static FPVector2 GetDirectionFromAngle(FP angle) { }

	// RVA: 0x20EED70 Offset: 0x20ED370 VA: 0x1820EED70
	public static FP MoveTowards(FP current, FP target, FP maxDelta) { }

	// RVA: 0x20EECD0 Offset: 0x20ED2D0 VA: 0x1820EECD0
	public static FP MoveTowardsAngle(FP current, FP target, FP maxDelta) { }

	// RVA: 0x20EE030 Offset: 0x20EC630 VA: 0x1820EE030
	public static FP DeltaAngle(FP current, FP target) { }

	// RVA: 0x20EDBA0 Offset: 0x20EC1A0 VA: 0x1820EDBA0
	public static FP AngleBetweenPoints(FPVector2 from, FPVector2 to) { }

	// RVA: 0x20EDD80 Offset: 0x20EC380 VA: 0x1820EDD80
	public static bool BetweenVectors(FPVector2 vectorToCheck, FPVector2 limitA, FPVector2 limitB) { }

	// RVA: 0x20EE300 Offset: 0x20EC900 VA: 0x1820EE300
	public static bool IsAngleInRange(FP angle, FP start, FP end, bool invertX) { }

	// RVA: 0x20EF430 Offset: 0x20EDA30 VA: 0x1820EF430
	public static FP TruncFP(FP fp) { }

	// RVA: 0x20EEC90 Offset: 0x20ED290 VA: 0x1820EEC90
	public static FP MapRange(FP value, FP from1, FP from2, FP to1, FP to2) { }

	// RVA: 0x20EEDC0 Offset: 0x20ED3C0 VA: 0x1820EEDC0
	public static SimpleAABB MultiplyRect(SimpleAABB originalRect, FP multiplier) { }

	// RVA: 0x20EDE60 Offset: 0x20EC460 VA: 0x1820EDE60
	public static bool CapsulesIntersect(FPVector2 capsule1PointA, FPVector2 capsule1PointB, FP capsule1Radius, FPVector2 capsule2PointA, FPVector2 capsule2PointB, FP capsule2Radius) { }

	// RVA: 0x20EDED0 Offset: 0x20EC4D0 VA: 0x1820EDED0
	public static FPVector2 ClampVector(FPVector2 vector, FP length) { }

	// RVA: 0x20EE5B0 Offset: 0x20ECBB0 VA: 0x1820EE5B0
	private static FP LineDistance(FPVector2 a0, FPVector2 a1, FPVector2 b0, FPVector2 b1) { }

	// RVA: 0x20EE9D0 Offset: 0x20ECFD0 VA: 0x1820EE9D0
	public static FP LineToPointDistance(FPVector2 a0, FPVector2 b0, FPVector2 b1) { }

	// RVA: 0x20EEF60 Offset: 0x20ED560 VA: 0x1820EEF60
	public static FP PointToPointDistance(FPVector2 a0, FPVector2 b0) { }

	// RVA: 0x20EE2D0 Offset: 0x20EC8D0 VA: 0x1820EE2D0
	public static bool IntersectsExclusive(FPVector2 topLeft, FPVector2 bottomRight, FPVector2 point) { }

	// RVA: 0x20EE5A0 Offset: 0x20ECBA0 VA: 0x1820EE5A0
	public static bool IsPowerOfTwo(int num) { }

	// RVA: 0x20EE060 Offset: 0x20EC660 VA: 0x1820EE060
	public static int FindSetBitPosition(int num) { }
}
