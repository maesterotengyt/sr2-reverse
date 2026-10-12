// Namespace: Photon.Deterministic
[DefaultMember("Item")]
[Serializable]
public struct FPMatrix4x4 // TypeDefIndex: 17433
{
	// Fields
	public FP M00; // 0x0
	public FP M10; // 0x8
	public FP M20; // 0x10
	public FP M30; // 0x18
	public FP M01; // 0x20
	public FP M11; // 0x28
	public FP M21; // 0x30
	public FP M31; // 0x38
	public FP M02; // 0x40
	public FP M12; // 0x48
	public FP M22; // 0x50
	public FP M32; // 0x58
	public FP M03; // 0x60
	public FP M13; // 0x68
	public FP M23; // 0x70
	public FP M33; // 0x78

	// Methods

	// RVA: 0x20A5D30 Offset: 0x20A4330 VA: 0x1820A5D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x20A54D0 Offset: 0x20A3AD0 VA: 0x1820A54D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20A55F0 Offset: 0x20A3BF0 VA: 0x1820A55F0
	public FPVector3 MultiplyPoint3x4(FPVector3 point) { }

	// RVA: 0x20A5890 Offset: 0x20A3E90 VA: 0x1820A5890
	public static FPMatrix4x4 TRS(FPVector3 pos, FPQuaternion q, FPVector3 s) { }

	// RVA: 0x20A56F0 Offset: 0x20A3CF0 VA: 0x1820A56F0
	public static FPMatrix4x4 Rotate(FPQuaternion q) { }
}
