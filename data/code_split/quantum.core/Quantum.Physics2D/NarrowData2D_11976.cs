// Namespace: Quantum.Physics2D
internal struct NarrowData2D // TypeDefIndex: 11976
{
	// Fields
	public const int SIZE = 32;
	public FPVector2 Position; // 0x0
	public FP RotSin; // 0x10
	public FP RotCos; // 0x18

	// Methods

	// RVA: 0x2211A60 Offset: 0x2210060 VA: 0x182211A60
	public static void InitFromTransform(NarrowData2D* narrow, Entry2D* entry, FPVector2 tPos, FP tRot, Nullable<FP> deltaTime) { }
}
