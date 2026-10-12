// Namespace: Quantum.Physics3D
internal struct FPVector3RawInt // TypeDefIndex: 11883
{
	// Fields
	public const int SIZE = 12;
	public const int ALIGNMENT = 4;
	public int RawIntX; // 0x0
	public int RawIntY; // 0x4
	public int RawIntZ; // 0x8

	// Methods

	// RVA: 0x22735D0 Offset: 0x2271BD0 VA: 0x1822735D0
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x21C57A0 Offset: 0x21C3DA0 VA: 0x1821C57A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22736E0 Offset: 0x2271CE0 VA: 0x1822736E0
	public static FPVector3 op_Explicit(FPVector3RawInt raw) { }

	// RVA: 0x22736C0 Offset: 0x2271CC0 VA: 0x1822736C0
	public static FPVector3RawInt op_Explicit(FPVector3 fp) { }
}
