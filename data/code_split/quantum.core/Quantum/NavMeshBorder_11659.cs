// Namespace: Quantum
[Serializable]
public struct NavMeshBorder // TypeDefIndex: 11659
{
	// Fields
	public FPVector3 V0; // 0x0
	public FPVector3 V1; // 0x18
	public FPVector3 Normal; // 0x30
	public NavMeshRegionMask Regions; // 0x48
	public NavMeshRegionMask RegionsOffmesh; // 0x50

	// Methods

	// RVA: 0x221BC10 Offset: 0x221A210 VA: 0x18221BC10
	public void Serialize(ByteStream stream, bool write) { }
}
