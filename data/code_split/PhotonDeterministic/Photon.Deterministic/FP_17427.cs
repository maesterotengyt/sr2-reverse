// Namespace: Photon.Deterministic
[Serializable]
public struct FP : IEquatable<FP>, IComparable<FP> // TypeDefIndex: 17427
{
	// Fields
	public const int SIZE = 8;
	private const int FRACTIONS_COUNT = 5;
	public const long RAW_ONE = 65536;
	public const long RAW_ZERO = 0;
	public const int Precision = 16;
	public const int Bits = 64;
	public const long MulRound = 0;
	public const int MulShift = 16;
	public const int MulShiftTrunc = 16;
	internal const bool UsesRoundedConstants = False;
	public long RawValue; // 0x0

	// Properties
	public static FP MinValue { get; }
	public static FP MaxValue { get; }
	public static FP UseableMin { get; }
	public static FP UseableMax { get; }
	public static FP Pi { get; }
	public static FP PiTimes2 { get; }
	public static FP PiOver2 { get; }
	public static FP Deg2Rad { get; }
	public static FP Rad2Deg { get; }
	public static FP _0 { get; }
	public static FP _1 { get; }
	public static FP _2 { get; }
	public static FP _3 { get; }
	public static FP _4 { get; }
	public static FP _5 { get; }
	public static FP _6 { get; }
	public static FP _10 { get; }
	public static FP _100 { get; }
	public static FP _1000 { get; }
	public static FP _0_01 { get; }
	public static FP _0_02 { get; }
	public static FP _0_10 { get; }
	public static FP _0_20 { get; }
	public static FP _0_25 { get; }
	public static FP _0_50 { get; }
	public static FP _0_05 { get; }
	public static FP _0_33 { get; }
	public static FP Minus_1 { get; }
	public static FP _1_01 { get; }
	public static FP _1_20 { get; }
	public static FP _1_50 { get; }
	public static FP EN1 { get; }
	public static FP EN2 { get; }
	public static FP EN3 { get; }
	public static FP EN4 { get; }
	public static FP Epsilon { get; }
	public int AsInt { get; }
	public float AsFloat { get; }
	public double AsDouble { get; }

	// Methods

	// RVA: 0x20AAB40 Offset: 0x20A9140 VA: 0x1820AAB40
	public static FP get_MinValue() { }

	// RVA: 0x20AAB30 Offset: 0x20A9130 VA: 0x1820AAB30
	public static FP get_MaxValue() { }

	// RVA: 0x20AABA0 Offset: 0x20A91A0 VA: 0x1820AABA0
	public static FP get_UseableMin() { }

	// RVA: 0x1FBFF60 Offset: 0x1FBE560 VA: 0x181FBFF60
	public static FP get_UseableMax() { }

	// RVA: 0x20AAB80 Offset: 0x20A9180 VA: 0x1820AAB80
	public static FP get_Pi() { }

	// RVA: 0x20AAB70 Offset: 0x20A9170 VA: 0x1820AAB70
	public static FP get_PiTimes2() { }

	// RVA: 0x20AAB60 Offset: 0x20A9160 VA: 0x1820AAB60
	public static FP get_PiOver2() { }

	// RVA: 0x20AAAF0 Offset: 0x20A90F0 VA: 0x1820AAAF0
	public static FP get_Deg2Rad() { }

	// RVA: 0x20AAB90 Offset: 0x20A9190 VA: 0x1820AAB90
	public static FP get_Rad2Deg() { }

	// RVA: 0x81E2E0 Offset: 0x81C8E0 VA: 0x18081E2E0
	public static FP get__0() { }

	// RVA: 0x20AAC60 Offset: 0x20A9260 VA: 0x1820AAC60
	public static FP get__1() { }

	// RVA: 0x20AAC70 Offset: 0x20A9270 VA: 0x1820AAC70
	public static FP get__2() { }

	// RVA: 0x20AAC80 Offset: 0x20A9280 VA: 0x1820AAC80
	public static FP get__3() { }

	// RVA: 0x20AAC90 Offset: 0x20A9290 VA: 0x1820AAC90
	public static FP get__4() { }

	// RVA: 0x20AACA0 Offset: 0x20A92A0 VA: 0x1820AACA0
	public static FP get__5() { }

	// RVA: 0x20AACB0 Offset: 0x20A92B0 VA: 0x1820AACB0
	public static FP get__6() { }

	// RVA: 0x20AAC20 Offset: 0x20A9220 VA: 0x1820AAC20
	public static FP get__10() { }

	// RVA: 0x20AAC10 Offset: 0x20A9210 VA: 0x1820AAC10
	public static FP get__100() { }

	// RVA: 0x20AAC00 Offset: 0x20A9200 VA: 0x1820AAC00
	public static FP get__1000() { }

	// RVA: 0x20AAB10 Offset: 0x20A9110 VA: 0x1820AAB10
	public static FP get__0_01() { }

	// RVA: 0x20AABB0 Offset: 0x20A91B0 VA: 0x1820AABB0
	public static FP get__0_02() { }

	// RVA: 0x20AAB00 Offset: 0x20A9100 VA: 0x1820AAB00
	public static FP get__0_10() { }

	// RVA: 0x20AABD0 Offset: 0x20A91D0 VA: 0x1820AABD0
	public static FP get__0_20() { }

	// RVA: 0x20AABE0 Offset: 0x20A91E0 VA: 0x1820AABE0
	public static FP get__0_25() { }

	// RVA: 0x1988610 Offset: 0x1986C10 VA: 0x181988610
	public static FP get__0_50() { }

	// RVA: 0x20AABC0 Offset: 0x20A91C0 VA: 0x1820AABC0
	public static FP get__0_05() { }

	// RVA: 0x20AABF0 Offset: 0x20A91F0 VA: 0x1820AABF0
	public static FP get__0_33() { }

	// RVA: 0x20AAB50 Offset: 0x20A9150 VA: 0x1820AAB50
	public static FP get_Minus_1() { }

	// RVA: 0x20AAC30 Offset: 0x20A9230 VA: 0x1820AAC30
	public static FP get__1_01() { }

	// RVA: 0x20AAC40 Offset: 0x20A9240 VA: 0x1820AAC40
	public static FP get__1_20() { }

	// RVA: 0x20AAC50 Offset: 0x20A9250 VA: 0x1820AAC50
	public static FP get__1_50() { }

	// RVA: 0x20AAB00 Offset: 0x20A9100 VA: 0x1820AAB00
	public static FP get_EN1() { }

	// RVA: 0x20AAB10 Offset: 0x20A9110 VA: 0x1820AAB10
	public static FP get_EN2() { }

	// RVA: 0x20AAB20 Offset: 0x20A9120 VA: 0x1820AAB20
	public static FP get_EN3() { }

	// RVA: 0xCD5AA0 Offset: 0xCD40A0 VA: 0x180CD5AA0
	public static FP get_EN4() { }

	// RVA: 0x20AAB20 Offset: 0x20A9120 VA: 0x1820AAB20
	public static FP get_Epsilon() { }

	// RVA: 0x20AAEB0 Offset: 0x20A94B0 VA: 0x1820AAEB0
	public static FP op_UnaryNegation(FP a) { }

	// RVA: 0xC97950 Offset: 0xC95F50 VA: 0x180C97950
	public static FP op_Addition(FP a, FP b) { }

	// RVA: 0x20AACD0 Offset: 0x20A92D0 VA: 0x1820AACD0
	public static FP op_Addition(FP a, int b) { }

	// RVA: 0x20AACC0 Offset: 0x20A92C0 VA: 0x1820AACC0
	public static FP op_Addition(int a, FP b) { }

	// RVA: 0x20AAE90 Offset: 0x20A9490 VA: 0x1820AAE90
	public static FP op_Subtraction(FP a, FP b) { }

	// RVA: 0x20AAE80 Offset: 0x20A9480 VA: 0x1820AAE80
	public static FP op_Subtraction(FP a, int b) { }

	// RVA: 0x20AAEA0 Offset: 0x20A94A0 VA: 0x1820AAEA0
	public static FP op_Subtraction(int a, FP b) { }

	// RVA: 0x20AA920 Offset: 0x20A8F20 VA: 0x1820AA920
	public static FP op_Multiply(FP a, FP b) { }

	// RVA: 0x20AAE70 Offset: 0x20A9470 VA: 0x1820AAE70
	public static FP op_Multiply(FP a, int b) { }

	// RVA: 0x20AAE60 Offset: 0x20A9460 VA: 0x1820AAE60
	public static FP op_Multiply(int a, FP b) { }

	// RVA: 0x20AACE0 Offset: 0x20A92E0 VA: 0x1820AACE0
	public static FP op_Division(FP a, FP b) { }

	// RVA: 0x20AAD00 Offset: 0x20A9300 VA: 0x1820AAD00
	public static FP op_Division(FP a, int b) { }

	// RVA: 0x20AACF0 Offset: 0x20A92F0 VA: 0x1820AACF0
	public static FP op_Division(int a, FP b) { }

	// RVA: 0x20AAE50 Offset: 0x20A9450 VA: 0x1820AAE50
	public static FP op_Modulus(FP a, FP b) { }

	// RVA: 0x20AAE10 Offset: 0x20A9410 VA: 0x1820AAE10
	public static FP op_Modulus(FP a, int b) { }

	// RVA: 0x20AAE30 Offset: 0x20A9430 VA: 0x1820AAE30
	public static FP op_Modulus(int a, FP b) { }

	// RVA: 0x1F58D80 Offset: 0x1F57380 VA: 0x181F58D80
	public static bool op_LessThan(FP a, FP b) { }

	// RVA: 0x20AAE00 Offset: 0x20A9400 VA: 0x1820AAE00
	public static bool op_LessThan(FP a, int b) { }

	// RVA: 0x20AADF0 Offset: 0x20A93F0 VA: 0x1820AADF0
	public static bool op_LessThan(int a, FP b) { }

	// RVA: 0x1F58D70 Offset: 0x1F57370 VA: 0x181F58D70
	public static bool op_LessThanOrEqual(FP a, FP b) { }

	// RVA: 0x20AADE0 Offset: 0x20A93E0 VA: 0x1820AADE0
	public static bool op_LessThanOrEqual(FP a, int b) { }

	// RVA: 0x1F58D60 Offset: 0x1F57360 VA: 0x181F58D60
	public static bool op_GreaterThan(FP a, FP b) { }

	// RVA: 0x20AAD90 Offset: 0x20A9390 VA: 0x1820AAD90
	public static bool op_GreaterThan(FP a, int b) { }

	// RVA: 0x20AAD80 Offset: 0x20A9380 VA: 0x1820AAD80
	public static bool op_GreaterThan(int a, FP b) { }

	// RVA: 0x1F58D50 Offset: 0x1F57350 VA: 0x181F58D50
	public static bool op_GreaterThanOrEqual(FP a, FP b) { }

	// RVA: 0x20AAD60 Offset: 0x20A9360 VA: 0x1820AAD60
	public static bool op_GreaterThanOrEqual(FP a, int b) { }

	// RVA: 0x20AAD70 Offset: 0x20A9370 VA: 0x1820AAD70
	public static bool op_GreaterThanOrEqual(int a, FP b) { }

	// RVA: 0x93BBD0 Offset: 0x93A1D0 VA: 0x18093BBD0
	public static bool op_Equality(FP a, FP b) { }

	// RVA: 0x20AAD20 Offset: 0x20A9320 VA: 0x1820AAD20
	public static bool op_Equality(FP a, int b) { }

	// RVA: 0x20AAD10 Offset: 0x20A9310 VA: 0x1820AAD10
	public static bool op_Equality(int a, FP b) { }

	// RVA: 0x6264D0 Offset: 0x624AD0 VA: 0x1806264D0
	public static bool op_Inequality(FP a, FP b) { }

	// RVA: 0x20AADC0 Offset: 0x20A93C0 VA: 0x1820AADC0
	public static bool op_Inequality(FP a, int b) { }

	// RVA: 0x20AADD0 Offset: 0x20A93D0 VA: 0x1820AADD0
	public static bool op_Inequality(int a, FP b) { }

	// RVA: 0x20AADA0 Offset: 0x20A93A0 VA: 0x1820AADA0
	public static FP op_Implicit(int value) { }

	// RVA: 0x20AADB0 Offset: 0x20A93B0 VA: 0x1820AADB0
	public static FP op_Implicit(sbyte value) { }

	// RVA: 0x20AAD30 Offset: 0x20A9330 VA: 0x1820AAD30
	public static int op_Explicit(FP value) { }

	// RVA: 0x20AAD40 Offset: 0x20A9340 VA: 0x1820AAD40
	public static float op_Explicit(FP value) { }

	// RVA: 0x20AAAE0 Offset: 0x20A90E0 VA: 0x1820AAAE0
	public int get_AsInt() { }

	// RVA: 0x20AAAC0 Offset: 0x20A90C0 VA: 0x1820AAAC0
	public float get_AsFloat() { }

	// RVA: 0x20AAAA0 Offset: 0x20A90A0 VA: 0x1820AAAA0
	public double get_AsDouble() { }

	// RVA: 0x20AA930 Offset: 0x20A8F30 VA: 0x1820AA930
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x93BBC0 Offset: 0x93A1C0 VA: 0x18093BBC0
	internal void .ctor(long v) { }

	// RVA: 0x20AA7F0 Offset: 0x20A8DF0 VA: 0x1820AA7F0 Slot: 5
	public int CompareTo(FP other) { }

	// RVA: 0x93B7B0 Offset: 0x939DB0 VA: 0x18093B7B0 Slot: 4
	public bool Equals(FP other) { }

	// RVA: 0x20AA800 Offset: 0x20A8E00 VA: 0x1820AA800 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20AA910 Offset: 0x20A8F10 VA: 0x1820AA910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20AAA30 Offset: 0x20A9030 VA: 0x1820AAA30 Slot: 3
	public override string ToString() { }

	// RVA: 0x20AA890 Offset: 0x20A8E90 VA: 0x1820AA890
	public static FP FromFloat_UNSAFE(float value) { }

	// RVA: 0x62D6F0 Offset: 0x62BCF0 VA: 0x18062D6F0
	public static FP FromRaw(long value) { }

	// RVA: 0x20AA920 Offset: 0x20A8F20 VA: 0x1820AA920
	public static FP MulTruncate(FP x, FP y) { }
}
