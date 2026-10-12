// Namespace: Quantum
[Serializable]
public struct NavMeshTriangle // TypeDefIndex: 11657
{
	// Fields
	public int Vertex0; // 0x0
	public int Vertex1; // 0x4
	public int Vertex2; // 0x8
	public FPVector3 Center; // 0x10
	public FPVector3 Normal; // 0x28
	public NavMeshPortal[] Neighbors; // 0x40
	public int[] Links; // 0x48
	public int[] Borders; // 0x50
	public NavMeshRegionMask Regions; // 0x58
	public FP Cost; // 0x60

	// Methods

	// RVA: 0x221C3D0 Offset: 0x221A9D0 VA: 0x18221C3D0
	public void Serialize(ByteStream stream, bool write) { }
}
