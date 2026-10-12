// Namespace: Quantum.Physics3D
internal struct NarrowData3D // TypeDefIndex: 11886
{
	// Fields
	public FPVector3 Position; // 0x0
	public FPVector3 RotatedRight; // 0x18
	public FPVector3 RotatedUp; // 0x30
	public FPVector3 RotatedForward; // 0x48
	public FPQuaternion RotationInverse; // 0x60
	public CustomEdgesBox BoxEdges; // 0x80
	public CustomPlanesBox BoxPlanes; // 0x2C0
	public CustomEdgesBox BoxEdgesRotated; // 0x410
	public CustomPlanesBox BoxPlanesRotated; // 0x650

	// Methods

	// RVA: 0x2274290 Offset: 0x2272890 VA: 0x182274290
	public static void InitFromTransform(NarrowData3D* narrow, Entry3D* entry, FPVector3 tPos, FPQuaternion tRot, out bool useCachedRot, Nullable<FP> deltaTime) { }

	// RVA: 0x22702E0 Offset: 0x226E8E0 VA: 0x1822702E0
	public static void Init(NarrowData3D* narrow, Entry3D* entry, FPVector3 pos, FPQuaternion rot) { }
}
