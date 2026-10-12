// Namespace: Photon.Deterministic
[DefaultMember("Item")]
[Serializable]
public struct FPMatrix2x2 // TypeDefIndex: 17422
{
	// Fields
	public FP M00; // 0x0
	public FP M10; // 0x8
	public FP M01; // 0x10
	public FP M11; // 0x18

	// Properties
	public FP Determinant { get; }
	public static FPMatrix2x2 Zero { get; }

	// Methods

	// RVA: 0x20A4540 Offset: 0x20A2B40 VA: 0x1820A4540
	public FP get_Determinant() { }

	// RVA: 0x14AA070 Offset: 0x14A8670 VA: 0x1814AA070
	public static FPMatrix2x2 get_Zero() { }

	// RVA: 0x20A4280 Offset: 0x20A2880 VA: 0x1820A4280
	public FPVector2 MultiplyVector(FPVector2 v) { }

	// RVA: 0x20A42D0 Offset: 0x20A28D0 VA: 0x1820A42D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20A4220 Offset: 0x20A2820 VA: 0x1820A4220 Slot: 2
	public override int GetHashCode() { }
}
