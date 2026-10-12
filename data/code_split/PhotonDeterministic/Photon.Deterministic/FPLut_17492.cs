// Namespace: Photon.Deterministic
public static class FPLut // TypeDefIndex: 17492
{
	// Fields
	public static int[] sqrt_aprox_lut; // 0x0
	public static long[] asin_lut; // 0x8
	public static long[] acos_lut; // 0x10
	public static long[] atan_lut; // 0x18
	public static long[] sin_cos_lut; // 0x20
	public static long[] tan_lut; // 0x28
	public static uint[] log2_approx_lut; // 0x30
	public static long[] exp_integral_lut; // 0x38

	// Properties
	public static bool IsLoaded { get; }

	// Methods

	// RVA: 0x20BE4D0 Offset: 0x20BCAD0 VA: 0x1820BE4D0
	public static bool get_IsLoaded() { }

	// RVA: 0x20BE260 Offset: 0x20BC860 VA: 0x1820BE260
	public static void Init(LutProvider lutProvider) { }

	// RVA: 0x20BE160 Offset: 0x20BC760 VA: 0x1820BE160
	private static void InitSmallLut() { }

	// RVA: -1 Offset: -1
	private static void Load<T>(LutProvider lutProvider, string path, ref T[] lut) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB450D0 Offset: 0xB436D0 VA: 0x180B450D0
	|-FPLut.Load<int>
	|
	|-RVA: 0xB45180 Offset: 0xB43780 VA: 0x180B45180
	|-FPLut.Load<long>
	|
	|-RVA: 0xB45000 Offset: 0xB43600 VA: 0x180B45000
	|-FPLut.Load<__Il2CppFullySharedGenericStructType>
	*/
}
