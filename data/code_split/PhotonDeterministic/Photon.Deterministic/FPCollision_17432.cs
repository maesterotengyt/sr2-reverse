// Namespace: Photon.Deterministic
public struct FPCollision // TypeDefIndex: 17432
{
	// Methods

	// RVA: 0x20A19E0 Offset: 0x209FFE0 VA: 0x1820A19E0
	public static FPVector3 ClosestPointOnSegment(FPVector3 point, FPVector3 p1, FPVector3 p2) { }

	// RVA: 0x20A1CF0 Offset: 0x20A02F0 VA: 0x1820A1CF0
	public static FPVector2 ClosestPointOnSegment(FPVector2 point, FPVector2 p1, FPVector2 p2) { }

	// RVA: 0x20A2650 Offset: 0x20A0C50 VA: 0x1820A2650
	public static bool TriangleContainsPointExclusive(FPVector3 pt, FPVector3 v0, FPVector3 v1, FPVector3 v2) { }

	// RVA: 0x20A2A70 Offset: 0x20A1070 VA: 0x1820A2A70
	public static bool TriangleContainsPointInclusive(FPVector2 pt, FPVector2 v0, FPVector2 v1, FPVector2 v2) { }

	// RVA: 0x20A2860 Offset: 0x20A0E60 VA: 0x1820A2860
	public static bool TriangleContainsPointInclusive(FPVector3 pt, FPVector3 v0, FPVector3 v1, FPVector3 v2) { }

	// RVA: 0x20A0C50 Offset: 0x209F250 VA: 0x1820A0C50
	public static bool CircleIntersectsCircle(FPVector2 a_origin, FP a_radius, FPVector2 b_origin, FP b_radius) { }

	// RVA: 0x20A2260 Offset: 0x20A0860 VA: 0x1820A2260
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2) { }

	// RVA: 0x20A24A0 Offset: 0x20A0AA0 VA: 0x1820A24A0
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2, out FPVector2 point, out FP distance) { }

	// RVA: 0x20A2320 Offset: 0x20A0920 VA: 0x1820A2320
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2, out FPVector2 point, out FP distance, out FP normalizedDist) { }

	// RVA: 0x20A2130 Offset: 0x20A0730 VA: 0x1820A2130
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2, out FPVector2 point) { }

	// RVA: 0x20A20C0 Offset: 0x20A06C0 VA: 0x1820A20C0
	public static bool LineIntersectsCircle(FPVector2 p1, FPVector2 p2, FPVector2 position, FP radius, bool ignoreIfStartPointInside = False) { }

	// RVA: 0x20A1E20 Offset: 0x20A0420 VA: 0x1820A1E20
	public static bool LineIntersectsCircle(FPVector2 p1, FPVector2 p2, FPVector2 position, FP radius, out FPVector2 point, bool ignoreIfStartPointInside = False) { }

	// RVA: 0x20A1E80 Offset: 0x20A0480 VA: 0x1820A1E80
	public static bool LineIntersectsCircle(FPVector2 p1, FPVector2 p2, FPVector2 position, FP radius, out FPVector2 point, out FP normalizedDist, bool ignoreIfStartPointInside = False) { }

	// RVA: 0x20A0C90 Offset: 0x209F290 VA: 0x1820A0C90
	public static FP ClosestDistanceToTriangle(FPVector3 p, FPVector3 a, FPVector3 b, FPVector3 c, out FPVector3 closestPoint, out FPVector3 barycentricCoordinates) { }
}
