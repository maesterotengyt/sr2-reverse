// Namespace: Photon.Deterministic
[Serializable]
public struct FPQuaternion // TypeDefIndex: 17437
{
	// Fields
	private const long RAW_180 = 11796480;
	private const long RAW_360 = 23592960;
	public const int SIZE = 32;
	public FP X; // 0x0
	public FP Y; // 0x8
	public FP Z; // 0x10
	public FP W; // 0x18

	// Properties
	public static FPQuaternion Identity { get; }
	public FPQuaternion Normalized { get; }
	public FPQuaternion Inverted { get; }
	public FPQuaternion Conjugated { get; }
	private long MagnitudeSqrRaw { get; }
	public FPVector3 AsEuler { get; }

	// Methods

	// RVA: 0x20A6C30 Offset: 0x20A5230 VA: 0x1820A6C30
	public static FPQuaternion Product(FPQuaternion left, FPQuaternion right) { }

	// RVA: 0x20A6640 Offset: 0x20A4C40 VA: 0x1820A6640
	public static FPQuaternion Conjugate(FPQuaternion value) { }

	// RVA: 0x20A6AC0 Offset: 0x20A50C0 VA: 0x1820A6AC0
	public static bool IsIdentity(FPQuaternion value) { }

	// RVA: 0x20A6680 Offset: 0x20A4C80 VA: 0x1820A6680
	public static FPQuaternion CreateFromYawPitchRoll(FP yaw, FP pitch, FP roll) { }

	// RVA: 0x20A6D90 Offset: 0x20A5390 VA: 0x1820A6D90
	public static FPQuaternion RotateTowards(FPQuaternion from, FPQuaternion to, FP maxDegreesDelta) { }

	// RVA: 0x20A6950 Offset: 0x20A4F50 VA: 0x1820A6950
	public static FPQuaternion Euler(FPVector3 eulerAngles) { }

	// RVA: 0x20A64D0 Offset: 0x20A4AD0 VA: 0x1820A64D0
	public static FPQuaternion AngleAxis(FP angle, FPVector3 axis) { }

	// RVA: 0x20A69C0 Offset: 0x20A4FC0 VA: 0x1820A69C0
	public static FPQuaternion Inverse(FPQuaternion value) { }

	// RVA: 0x20A6B10 Offset: 0x20A5110 VA: 0x1820A6B10
	public static FPQuaternion Normalize(FPQuaternion value) { }

	// RVA: 0x20A7230 Offset: 0x20A5830 VA: 0x1820A7230
	internal static FPVector3 ToEulerZXY(FPQuaternion value) { }

	// RVA: 0x20A7AB0 Offset: 0x20A60B0 VA: 0x1820A7AB0
	public static FPQuaternion op_Multiply(FPQuaternion left, FPQuaternion right) { }

	// RVA: 0x20A7C20 Offset: 0x20A6220 VA: 0x1820A7C20
	public static FPVector3 op_Multiply(FPQuaternion quat, FPVector3 point) { }

	// RVA: 0x20A78C0 Offset: 0x20A5EC0 VA: 0x1820A78C0
	public static FPQuaternion get_Identity() { }

	// RVA: 0x20A71D0 Offset: 0x20A57D0 VA: 0x1820A71D0
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x20A79E0 Offset: 0x20A5FE0 VA: 0x1820A79E0
	public FPQuaternion get_Normalized() { }

	// RVA: 0x20A78E0 Offset: 0x20A5EE0 VA: 0x1820A78E0
	public FPQuaternion get_Inverted() { }

	// RVA: 0x20A7890 Offset: 0x20A5E90 VA: 0x1820A7890
	public FPQuaternion get_Conjugated() { }

	// RVA: 0x20A79A0 Offset: 0x20A5FA0 VA: 0x1820A79A0
	private long get_MagnitudeSqrRaw() { }

	// RVA: 0x20A7840 Offset: 0x20A5E40 VA: 0x1820A7840
	public FPVector3 get_AsEuler() { }

	// RVA: 0x20A75D0 Offset: 0x20A5BD0 VA: 0x1820A75D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20A4220 Offset: 0x20A2820 VA: 0x1820A4220 Slot: 2
	public override int GetHashCode() { }
}
