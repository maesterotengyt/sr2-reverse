// Namespace: Photon.Deterministic
public struct FPMath // TypeDefIndex: 17431
{
	// Methods

	// RVA: 0x20A3E50 Offset: 0x20A2450 VA: 0x1820A3E50
	public static FP Sin(FP rad) { }

	// RVA: 0x20A2FC0 Offset: 0x20A15C0 VA: 0x1820A2FC0
	public static FP Cos(FP rad) { }

	// RVA: 0x20A3D80 Offset: 0x20A2380 VA: 0x1820A3D80
	public static void SinCos(FP rad, out FP sin, out FP cos) { }

	// RVA: 0x20A3CB0 Offset: 0x20A22B0 VA: 0x1820A3CB0
	public static void SinCosRaw(FP rad, out long sinRaw, out long cosRaw) { }

	// RVA: 0x20A4150 Offset: 0x20A2750 VA: 0x1820A4150
	public static FP Tan(FP rad) { }

	// RVA: 0x20A2C60 Offset: 0x20A1260 VA: 0x1820A2C60
	public static FP Asin(FP value) { }

	// RVA: 0x20A2B60 Offset: 0x20A1160 VA: 0x1820A2B60
	public static FP Acos(FP value) { }

	// RVA: 0x20A2D80 Offset: 0x20A1380 VA: 0x1820A2D80
	public static FP Atan(FP value) { }

	// RVA: 0x20A2CF0 Offset: 0x20A12F0 VA: 0x1820A2CF0
	public static FP Atan2(FP y, FP x) { }

	// RVA: 0x20A3C90 Offset: 0x20A2290 VA: 0x1820A3C90
	public static FP Sign(FP value) { }

	// RVA: 0x20A3C70 Offset: 0x20A2270 VA: 0x1820A3C70
	public static FP SignZero(FP value) { }

	// RVA: 0x20A3C50 Offset: 0x20A2250 VA: 0x1820A3C50
	public static int SignInt(FP value) { }

	// RVA: 0x20A3B40 Offset: 0x20A2140 VA: 0x1820A3B40
	public static int NextPowerOfTwo(int value) { }

	// RVA: 0x20A2B50 Offset: 0x20A1150 VA: 0x1820A2B50
	public static FP Abs(FP value) { }

	// RVA: 0x20A3C20 Offset: 0x20A2220 VA: 0x1820A3C20
	public static FP Round(FP value) { }

	// RVA: 0x20A3C00 Offset: 0x20A2200 VA: 0x1820A3C00
	public static int RoundToInt(FP value) { }

	// RVA: 0x20A31D0 Offset: 0x20A17D0 VA: 0x1820A31D0
	public static FP Floor(FP value) { }

	// RVA: 0x20A31D0 Offset: 0x20A17D0 VA: 0x1820A31D0
	public static long FloorRaw(long value) { }

	// RVA: 0x20A2EF0 Offset: 0x20A14F0 VA: 0x1820A2EF0
	public static FP Ceiling(FP value) { }

	// RVA: 0x20A2ED0 Offset: 0x20A14D0 VA: 0x1820A2ED0
	public static int CeilToInt(FP value) { }

	// RVA: 0x20A3900 Offset: 0x20A1F00 VA: 0x1820A3900
	public static FP Max(FP val1, FP val2) { }

	// RVA: 0x20A3960 Offset: 0x20A1F60 VA: 0x1820A3960
	public static FP Min(FP val1, FP val2) { }

	// RVA: 0x20A3910 Offset: 0x20A1F10 VA: 0x1820A3910
	public static FP Min(FP[] numbers) { }

	// RVA: 0x20A3970 Offset: 0x20A1F70 VA: 0x1820A3970
	public static FP Min(FP a, FP b, FP c) { }

	// RVA: 0x20A38E0 Offset: 0x20A1EE0 VA: 0x1820A38E0
	public static FP Max(FP a, FP b, FP c) { }

	// RVA: 0x20A2F60 Offset: 0x20A1560 VA: 0x1820A2F60
	public static FP Clamp(FP value, FP min, FP max) { }

	// RVA: 0x20A2F10 Offset: 0x20A1510 VA: 0x1820A2F10
	public static FP Clamp01(FP value) { }

	// RVA: 0x20A2F80 Offset: 0x20A1580 VA: 0x1820A2F80
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x20A2FA0 Offset: 0x20A15A0 VA: 0x1820A2FA0
	public static long Clamp(long value, long min, long max) { }

	// RVA: 0x20A2F30 Offset: 0x20A1530 VA: 0x1820A2F30
	public static FP ClampUseable(FP value) { }

	// RVA: 0x20A3BD0 Offset: 0x20A21D0 VA: 0x1820A3BD0
	public static FP Repeat(FP t, FP length) { }

	// RVA: 0x20A3BD0 Offset: 0x20A21D0 VA: 0x1820A3BD0
	internal static long RepeatRaw(long t, long length) { }

	// RVA: 0x20A3450 Offset: 0x20A1A50 VA: 0x1820A3450
	public static FP LerpRadians(FP start, FP end, FP t) { }

	// RVA: 0x20A34F0 Offset: 0x20A1AF0 VA: 0x1820A34F0
	public static FP Lerp(FP start, FP end, FP t) { }

	// RVA: 0x20A34E0 Offset: 0x20A1AE0 VA: 0x1820A34E0
	public static FP LerpUnclamped(FP start, FP end, FP t) { }

	// RVA: 0x20A3410 Offset: 0x20A1A10 VA: 0x1820A3410
	public static FP InverseLerp(FP start, FP end, FP value) { }

	// RVA: 0x20A33F0 Offset: 0x20A19F0 VA: 0x1820A33F0
	public static FP InverseLerpUnclamped(FP start, FP end, FP value) { }

	// RVA: 0x20A3EF0 Offset: 0x20A24F0 VA: 0x1820A3EF0
	public static FP SmoothStep(FP start, FP end, FP t) { }

	// RVA: 0x20A4140 Offset: 0x20A2740 VA: 0x1820A4140
	public static FP Sqrt(FP value) { }

	// RVA: 0x20A3F70 Offset: 0x20A2570 VA: 0x1820A3F70
	public static long SqrtRaw(long x) { }

	// RVA: 0x20A31E0 Offset: 0x20A17E0 VA: 0x1820A31E0
	internal static FPMath.ExponentMantisaPair GetSqrtExponentMantissa(ulong x) { }

	// RVA: 0x20A3350 Offset: 0x20A1950 VA: 0x1820A3350
	public static FP Hermite(FP value1, FP tangent1, FP value2, FP tangent2, FP t) { }

	// RVA: 0x20A3990 Offset: 0x20A1F90 VA: 0x1820A3990
	public static long ModuloClamped(long a, long n) { }

	// RVA: 0x20A3A70 Offset: 0x20A2070 VA: 0x1820A3A70
	public static FP ModuloClamped(FP a, FP n) { }

	// RVA: 0x20A2BF0 Offset: 0x20A11F0 VA: 0x1820A2BF0
	public static long AngleBetweenRadiansRaw(long source, long target) { }

	// RVA: 0x20A3880 Offset: 0x20A1E80 VA: 0x1820A3880
	public static FP Log2(FP value) { }

	// RVA: 0x20A3530 Offset: 0x20A1B30 VA: 0x1820A3530
	public static FP Log10(FP value) { }

	// RVA: 0x20A38A0 Offset: 0x20A1EA0 VA: 0x1820A38A0
	public static FP Log(FP value, FP logBase) { }

	// RVA: 0x20A3560 Offset: 0x20A1B60 VA: 0x1820A3560
	private static int Log2FloorToIntRaw(long x) { }

	// RVA: 0x20A3680 Offset: 0x20A1C80 VA: 0x1820A3680
	private static long Log2RawAdditionalPrecision(long x) { }

	// RVA: 0x20A3060 Offset: 0x20A1660 VA: 0x1820A3060
	public static FP Exp(FP x) { }
}
