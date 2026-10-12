// Namespace: Quantum
[Serializable]
public struct NavMeshVertex // TypeDefIndex: 11658
{
	// Fields
	public FPVector3 Point; // 0x0
	public int[] Borders; // 0x18

	// Methods

	// RVA: 0x221C940 Offset: 0x221AF40 VA: 0x18221C940
	public void Serialize(ByteStream stream, bool write) { }

	// RVA: 0x221C640 Offset: 0x221AC40 VA: 0x18221C640
	public static FPVector3 CalculateNormal(int vertexIndex, NavMesh navmesh, NavMeshRegionMask regionMask) { }
}
