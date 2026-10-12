// Namespace: Quantum
[Serializable]
public struct TriangleCCW // TypeDefIndex: 11730
{
	// Fields
	public FPVector3 A; // 0x0
	public FPVector3 B; // 0x18
	public FPVector3 C; // 0x30
	public FPVector3 CenterToA; // 0x48
	public FPVector3 CenterToB; // 0x60
	public FPVector3 CenterToC; // 0x78
	public FP MaxY; // 0x90
	public FP MinY; // 0x98
	public FP BroadRadius; // 0xA0
	public FPVector3 EdgeA; // 0xA8
	public FPVector3 EdgeB; // 0xC0
	public FPVector3 EdgeC; // 0xD8
	public FP LengthEdgeA; // 0xF0
	public FP LengthEdgeB; // 0xF8
	public FP LengthEdgeC; // 0x100
	public FPVector3 Normal; // 0x108
	public FPVector3 InverseNormal; // 0x120
	public FPVector3 Center; // 0x138
	public int StaticDataIndex; // 0x150

	// Methods

	// RVA: 0x2229E80 Offset: 0x2228480 VA: 0x182229E80
	public void ComputeNormal() { }

	// RVA: 0x222AAE0 Offset: 0x22290E0 VA: 0x18222AAE0
	public void Serialize(ByteStream stream, bool write, bool serializeTrianglesMetadata = False) { }

	// RVA: 0x222A5F0 Offset: 0x2228BF0 VA: 0x18222A5F0
	public FPVector3 Min3() { }

	// RVA: 0x222A530 Offset: 0x2228B30 VA: 0x18222A530
	public FPVector3 Max3() { }

	// RVA: 0x222A6B0 Offset: 0x2228CB0 VA: 0x18222A6B0
	public bool RayIntersectsTriangle(ref FPVector3 origin, FPVector3 dir, out FPVector3 intersectionPoint, out FP normalizedDist) { }

	// RVA: 0x222A400 Offset: 0x2228A00 VA: 0x18222A400
	public void GetSupportOffset(FPVector3 worldDir, out FPVector3 supportOffset) { }
}
