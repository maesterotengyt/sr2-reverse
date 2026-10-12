// Namespace: Photon.Deterministic
[DefaultMember("Item")]
[Serializable]
public struct FPMatrix3x3 // TypeDefIndex: 17423
{
	// Fields
	public const int SIZE = 72;
	public FP M00; // 0x0
	public FP M10; // 0x8
	public FP M20; // 0x10
	public FP M01; // 0x18
	public FP M11; // 0x20
	public FP M21; // 0x28
	public FP M02; // 0x30
	public FP M12; // 0x38
	public FP M22; // 0x40

	// Properties
	public static FPMatrix3x3 Zero { get; }
	public FPMatrix3x3 Transposed { get; }

	// Methods

	// RVA: 0x20A4BF0 Offset: 0x20A31F0 VA: 0x1820A4BF0
	public static FPMatrix3x3 get_Zero() { }

	// RVA: 0x20A45B0 Offset: 0x20A2BB0 VA: 0x1820A45B0
	public static FPMatrix3x3 FromRows(FP m00, FP m01, FP m02, FP m10, FP m11, FP m12, FP m20, FP m21, FP m22) { }

	// RVA: 0x20A4560 Offset: 0x20A2B60 VA: 0x1820A4560
	public static FPMatrix3x3 FromColumns(FP m00, FP m10, FP m20, FP m01, FP m11, FP m21, FP m02, FP m12, FP m22) { }

	// RVA: 0x20A4B60 Offset: 0x20A3160 VA: 0x1820A4B60
	public FPMatrix3x3 get_Transposed() { }

	// RVA: 0x20A46B0 Offset: 0x20A2CB0 VA: 0x1820A46B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20A4600 Offset: 0x20A2C00 VA: 0x1820A4600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20A4C10 Offset: 0x20A3210 VA: 0x1820A4C10
	public static FPMatrix3x3 op_Addition(FPMatrix3x3 a, FPMatrix3x3 b) { }

	// RVA: 0x20A4CB0 Offset: 0x20A32B0 VA: 0x1820A4CB0
	public static FPMatrix3x3 op_Multiply(FPMatrix3x3 a, FPMatrix3x3 b) { }

	// RVA: 0x20A5320 Offset: 0x20A3920 VA: 0x1820A5320
	public static FPVector3 op_Multiply(FPMatrix3x3 m, FPVector3 vector) { }
}
