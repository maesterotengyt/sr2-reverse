// Namespace: Photon.Deterministic
[Serializable]
public struct FPVector3 : IEquatable<FPVector3> // TypeDefIndex: 17425
{
	// Fields
	public const int SIZE = 24;
	public FP X; // 0x0
	public FP Y; // 0x8
	public FP Z; // 0x10

	// Properties
	public FPVector2 XY { get; }
	public FPVector2 XZ { get; }
	public static FPVector3 Zero { get; }
	public static FPVector3 Left { get; }
	public static FPVector3 Right { get; }
	public static FPVector3 Up { get; }
	public static FPVector3 Down { get; }
	public static FPVector3 Back { get; }
	public static FPVector3 Forward { get; }
	public static FPVector3 One { get; }
	public FP SqrMagnitude { get; }
	public FP Magnitude { get; }
	public FPVector3 Normalized { get; }

	// Methods

	// RVA: 0x20A9F30 Offset: 0x20A8530 VA: 0x1820A9F30
	public static FPVector3 Normalize(FPVector3 value) { }

	// RVA: 0x20AA060 Offset: 0x20A8660 VA: 0x1820AA060
	public static FPVector3 Normalize(FPVector3 value, out FP magnitude) { }

	// RVA: 0x20AA4E0 Offset: 0x20A8AE0 VA: 0x1820AA4E0
	public FPVector2 get_XY() { }

	// RVA: 0x20AA500 Offset: 0x20A8B00 VA: 0x1820AA500
	public FPVector2 get_XZ() { }

	// RVA: 0x20A9E50 Offset: 0x20A8450 VA: 0x1820A9E50
	public static FPVector3 Min(FPVector3 value1, FPVector3 value2) { }

	// RVA: 0x20A9D70 Offset: 0x20A8370 VA: 0x1820A9D70
	public static FPVector3 Max(FPVector3 value1, FPVector3 value2) { }

	// RVA: 0x20A9AF0 Offset: 0x20A80F0 VA: 0x1820A9AF0
	public static FP Distance(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20A9AA0 Offset: 0x20A80A0 VA: 0x1820A9AA0
	public static FP DistanceSquared(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20A9990 Offset: 0x20A7F90 VA: 0x1820A9990
	public static FPVector3 Cross(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20A9B40 Offset: 0x20A8140 VA: 0x1820A9B40
	public static FP Dot(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20A9680 Offset: 0x20A7C80 VA: 0x1820A9680
	public static FP Angle(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20AA600 Offset: 0x20A8C00 VA: 0x1820AA600
	public static bool op_Equality(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20AA670 Offset: 0x20A8C70 VA: 0x1820AA670
	public static bool op_Inequality(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20AA7B0 Offset: 0x20A8DB0 VA: 0x1820AA7B0
	public static FPVector3 op_UnaryNegation(FPVector3 v) { }

	// RVA: 0x20AA6E0 Offset: 0x20A8CE0 VA: 0x1820AA6E0
	public static FPVector3 op_Multiply(FPVector3 v, FP s) { }

	// RVA: 0x20AA720 Offset: 0x20A8D20 VA: 0x1820AA720
	public static FPVector3 op_Multiply(FP s, FPVector3 v) { }

	// RVA: 0x20AA560 Offset: 0x20A8B60 VA: 0x1820AA560
	public static FPVector3 op_Division(FPVector3 v, FP s) { }

	// RVA: 0x20AA5B0 Offset: 0x20A8BB0 VA: 0x1820AA5B0
	public static FPVector3 op_Division(FPVector3 v, int s) { }

	// RVA: 0x20AA770 Offset: 0x20A8D70 VA: 0x1820AA770
	public static FPVector3 op_Subtraction(FPVector3 a, FPVector3 b) { }

	// RVA: 0x20AA520 Offset: 0x20A8B20 VA: 0x1820AA520
	public static FPVector3 op_Addition(FPVector3 a, FPVector3 b) { }

	// RVA: 0x14A0710 Offset: 0x149ED10 VA: 0x1814A0710
	public static FPVector3 get_Zero() { }

	// RVA: 0x20AA3A0 Offset: 0x20A89A0 VA: 0x1820AA3A0
	public static FPVector3 get_Left() { }

	// RVA: 0x20AA470 Offset: 0x20A8A70 VA: 0x1820AA470
	public static FPVector3 get_Right() { }

	// RVA: 0x20AA4C0 Offset: 0x20A8AC0 VA: 0x1820AA4C0
	public static FPVector3 get_Up() { }

	// RVA: 0x20AA360 Offset: 0x20A8960 VA: 0x1820AA360
	public static FPVector3 get_Down() { }

	// RVA: 0x20AA340 Offset: 0x20A8940 VA: 0x1820AA340
	public static FPVector3 get_Back() { }

	// RVA: 0x20AA380 Offset: 0x20A8980 VA: 0x1820AA380
	public static FPVector3 get_Forward() { }

	// RVA: 0x20AA450 Offset: 0x20A8A50 VA: 0x1820AA450
	public static FPVector3 get_One() { }

	// RVA: 0x20AA1B0 Offset: 0x20A87B0 VA: 0x1820AA1B0
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x20AA490 Offset: 0x20A8A90 VA: 0x1820AA490
	public FP get_SqrMagnitude() { }

	// RVA: 0x20AA3C0 Offset: 0x20A89C0 VA: 0x1820AA3C0
	public FP get_Magnitude() { }

	// RVA: 0x20AA400 Offset: 0x20A8A00 VA: 0x1820AA400
	public FPVector3 get_Normalized() { }

	// RVA: 0x20AA310 Offset: 0x20A8910 VA: 0x1820AA310
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x15CDF50 Offset: 0x15CC550 VA: 0x1815CDF50
	public void .ctor(FP x, FP y, FP z) { }

	// RVA: 0x20AA200 Offset: 0x20A8800 VA: 0x1820AA200 Slot: 3
	public override string ToString() { }

	// RVA: 0x20A9B70 Offset: 0x20A8170 VA: 0x1820A9B70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20A9C80 Offset: 0x20A8280 VA: 0x1820A9C80 Slot: 4
	public bool Equals(FPVector3 other) { }

	// RVA: 0x20A9D20 Offset: 0x20A8320 VA: 0x1820A9D20 Slot: 2
	public override int GetHashCode() { }
}
