// Namespace: Photon.Deterministic
[Serializable]
public struct FPVector2 : IEquatable<FPVector2> // TypeDefIndex: 17424
{
	// Fields
	public const int SIZE = 16;
	public FP X; // 0x0
	public FP Y; // 0x8

	// Properties
	public FPVector3 XYY { get; }
	public static FPVector2 Zero { get; }
	public static FPVector2 One { get; }
	public static FPVector2 Right { get; }
	public static FPVector2 Left { get; }
	public static FPVector2 Up { get; }
	public static FPVector2 Down { get; }
	public static FPVector2 MinValue { get; }
	public static FPVector2 MaxValue { get; }
	public FP Magnitude { get; }
	public FP SqrMagnitude { get; }
	public FPVector2 Normalized { get; }
	public FPVector3 XOY { get; }

	// Methods

	// RVA: 0x20A8910 Offset: 0x20A6F10 VA: 0x1820A8910
	public static FPVector2 Normalize(FPVector2 value) { }

	// RVA: 0x20A89B0 Offset: 0x20A6FB0 VA: 0x1820A89B0
	public static FPVector2 Normalize(FPVector2 value, out FP magnitude) { }

	// RVA: 0x20A9520 Offset: 0x20A7B20 VA: 0x1820A9520
	public FPVector3 get_XYY() { }

	// RVA: 0x20A8560 Offset: 0x20A6B60 VA: 0x1820A8560
	public static FP Distance(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A8530 Offset: 0x20A6B30 VA: 0x1820A8530
	public static FP DistanceSquared(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A8590 Offset: 0x20A6B90 VA: 0x1820A8590
	public static FP Dot(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A90F0 Offset: 0x20A76F0 VA: 0x1820A90F0
	public static FPVector2 Rotate(FPVector2 vector, FP radians) { }

	// RVA: 0x20A90B0 Offset: 0x20A76B0 VA: 0x1820A90B0
	public static FPVector2 Rotate(FPVector2 vector, FP sin, FP cos) { }

	// RVA: 0x20A8510 Offset: 0x20A6B10 VA: 0x1820A8510
	public static FP Cross(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A8510 Offset: 0x20A6B10 VA: 0x1820A8510
	internal static long CrossRaw(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A9070 Offset: 0x20A7670 VA: 0x1820A9070
	public static FPVector2 Reflect(FPVector2 vector, FPVector2 normal) { }

	// RVA: 0x20A84D0 Offset: 0x20A6AD0 VA: 0x1820A84D0
	public static FPVector2 Clamp(FPVector2 value, FPVector2 min, FPVector2 max) { }

	// RVA: 0x20A87E0 Offset: 0x20A6DE0 VA: 0x1820A87E0
	public static FPVector2 Lerp(FPVector2 start, FPVector2 end, FP t) { }

	// RVA: 0x20A88B0 Offset: 0x20A6EB0 VA: 0x1820A88B0
	public static FPVector2 Max(FPVector2 value1, FPVector2 value2) { }

	// RVA: 0x20A88E0 Offset: 0x20A6EE0 VA: 0x1820A88E0
	public static FPVector2 Min(FPVector2 value1, FPVector2 value2) { }

	// RVA: 0x20A7DC0 Offset: 0x20A63C0 VA: 0x1820A7DC0
	public static FPVector2 CalculateLeft(FPVector2 vector) { }

	// RVA: 0x20A8770 Offset: 0x20A6D70 VA: 0x1820A8770
	public bool IsLeftOf(FPVector2 vector) { }

	// RVA: 0x20A8510 Offset: 0x20A6B10 VA: 0x1820A8510
	public static FP Determinant(FPVector2 v1, FPVector2 v2) { }

	// RVA: 0x20A8CF0 Offset: 0x20A72F0 VA: 0x1820A8CF0
	public static FP Radians(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A8C80 Offset: 0x20A7280 VA: 0x1820A8C80
	public static FP RadiansSkipNormalize(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A8B10 Offset: 0x20A7110 VA: 0x1820A8B10
	public static FP RadiansSigned(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A8A60 Offset: 0x20A7060 VA: 0x1820A8A60
	public static FP RadiansSignedSkipNormalize(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A8700 Offset: 0x20A6D00 VA: 0x1820A8700
	public static bool IsClockWise(FPVector2[] vertices) { }

	// RVA: 0x20A8830 Offset: 0x20A6E30 VA: 0x1820A8830
	public static void MakeCounterClockWise(FPVector2[] vertices) { }

	// RVA: 0x20A86B0 Offset: 0x20A6CB0 VA: 0x1820A86B0
	public static void FlipWindingOrder(FPVector2[] vertices) { }

	// RVA: 0x20A8320 Offset: 0x20A6920 VA: 0x1820A8320
	public static FPVector2[] CalculatePolygonNormals(FPVector2[] vertices) { }

	// RVA: 0x20A8E30 Offset: 0x20A7430 VA: 0x1820A8E30
	public static FPVector2[] RecenterPolygon(FPVector2[] vertices) { }

	// RVA: 0x20A7DE0 Offset: 0x20A63E0 VA: 0x1820A7DE0
	public static FP CalculatePolygonArea(FPVector2[] vertices) { }

	// RVA: 0x20A7E70 Offset: 0x20A6470 VA: 0x1820A7E70
	public static FPVector2 CalculatePolygonCentroid(FPVector2[] vertices) { }

	// RVA: 0x20A7FF0 Offset: 0x20A65F0 VA: 0x1820A7FF0
	public static FP CalculatePolygonInertiaFactor(FPVector2[] vertices) { }

	// RVA: 0x20A8140 Offset: 0x20A6740 VA: 0x1820A8140
	public static FPVector2 CalculatePolygonLocalSupport(FPVector2* vertices, int verticesCount, ref FPVector2 localDir) { }

	// RVA: 0x20A8450 Offset: 0x20A6A50 VA: 0x1820A8450
	public static FP CalculatePolygonRadius(FPVector2[] vertices) { }

	// RVA: 0x900DB0 Offset: 0x8FF3B0 VA: 0x180900DB0
	public static bool op_Equality(FPVector2 a, FPVector2 b) { }

	// RVA: 0x900DD0 Offset: 0x8FF3D0 VA: 0x180900DD0
	public static bool op_Inequality(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A9660 Offset: 0x20A7C60 VA: 0x1820A9660
	public static FPVector2 op_UnaryNegation(FPVector2 v) { }

	// RVA: 0x20A9540 Offset: 0x20A7B40 VA: 0x1820A9540
	public static FPVector2 op_Addition(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A9640 Offset: 0x20A7C40 VA: 0x1820A9640
	public static FPVector2 op_Subtraction(FPVector2 a, FPVector2 b) { }

	// RVA: 0x20A95C0 Offset: 0x20A7BC0 VA: 0x1820A95C0
	public static FPVector2 op_Multiply(FPVector2 v, FP s) { }

	// RVA: 0x20A95F0 Offset: 0x20A7BF0 VA: 0x1820A95F0
	public static FPVector2 op_Multiply(FP s, FPVector2 v) { }

	// RVA: 0x20A9620 Offset: 0x20A7C20 VA: 0x1820A9620
	public static FPVector2 op_Multiply(FPVector2 v, int s) { }

	// RVA: 0x20A9590 Offset: 0x20A7B90 VA: 0x1820A9590
	public static FPVector2 op_Division(FPVector2 v, FP s) { }

	// RVA: 0x20A9560 Offset: 0x20A7B60 VA: 0x1820A9560
	public static FPVector2 op_Division(FPVector2 v, int s) { }

	// RVA: 0x1128E00 Offset: 0x1127400 VA: 0x181128E00
	public static FPVector2 get_Zero() { }

	// RVA: 0x20A9480 Offset: 0x20A7A80 VA: 0x1820A9480
	public static FPVector2 get_One() { }

	// RVA: 0x20A94A0 Offset: 0x20A7AA0 VA: 0x1820A94A0
	public static FPVector2 get_Right() { }

	// RVA: 0x20A9360 Offset: 0x20A7960 VA: 0x1820A9360
	public static FPVector2 get_Left() { }

	// RVA: 0x20A94E0 Offset: 0x20A7AE0 VA: 0x1820A94E0
	public static FPVector2 get_Up() { }

	// RVA: 0x20A9340 Offset: 0x20A7940 VA: 0x1820A9340
	public static FPVector2 get_Down() { }

	// RVA: 0x20A93D0 Offset: 0x20A79D0 VA: 0x1820A93D0
	public static FPVector2 get_MinValue() { }

	// RVA: 0x20A93B0 Offset: 0x20A79B0 VA: 0x1820A93B0
	public static FPVector2 get_MaxValue() { }

	// RVA: 0x20A9200 Offset: 0x20A7800 VA: 0x1820A9200
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x20A9380 Offset: 0x20A7980 VA: 0x1820A9380
	public FP get_Magnitude() { }

	// RVA: 0x20A94C0 Offset: 0x20A7AC0 VA: 0x1820A94C0
	public FP get_SqrMagnitude() { }

	// RVA: 0x20A93F0 Offset: 0x20A79F0 VA: 0x1820A93F0
	public FPVector2 get_Normalized() { }

	// RVA: 0x20A9320 Offset: 0x20A7920 VA: 0x1820A9320
	public void .ctor(int x, int y) { }

	// RVA: 0x900DA0 Offset: 0x8FF3A0 VA: 0x180900DA0
	public void .ctor(FP x, FP y) { }

	// RVA: 0x20A9500 Offset: 0x20A7B00 VA: 0x1820A9500
	public FPVector3 get_XOY() { }

	// RVA: 0x20A85B0 Offset: 0x20A6BB0 VA: 0x1820A85B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20A8670 Offset: 0x20A6C70 VA: 0x1820A8670 Slot: 4
	public bool Equals(FPVector2 other) { }

	// RVA: 0x20A86C0 Offset: 0x20A6CC0 VA: 0x1820A86C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20A9240 Offset: 0x20A7840 VA: 0x1820A9240 Slot: 3
	public override string ToString() { }
}
