// Namespace: Quantum.Physics3D
internal struct FPQuaternionRawInt // TypeDefIndex: 11884
{
	// Fields
	public const int SIZE = 16;
	public int RawIntX; // 0x0
	public int RawIntY; // 0x4
	public int RawIntZ; // 0x8
	public int RawIntW; // 0xC

	// Methods

	// RVA: 0x2273450 Offset: 0x2271A50 VA: 0x182273450
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x2273430 Offset: 0x2271A30 VA: 0x182273430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2273580 Offset: 0x2271B80 VA: 0x182273580
	public static FPQuaternion op_Explicit(FPQuaternionRawInt raw) { }

	// RVA: 0x22735B0 Offset: 0x2271BB0 VA: 0x1822735B0
	public static FPQuaternionRawInt op_Explicit(FPQuaternion fp) { }
}
