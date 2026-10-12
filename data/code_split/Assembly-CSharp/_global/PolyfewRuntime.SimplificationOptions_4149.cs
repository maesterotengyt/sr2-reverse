// Namespace: 
[Serializable]
public class PolyfewRuntime.SimplificationOptions // TypeDefIndex: 4149
{
	// Fields
	public float simplificationStrength; // 0x10
	public bool simplifyMeshLossless; // 0x14
	public bool enableSmartlinking; // 0x15
	public bool recalculateNormals; // 0x16
	public bool preserveUVSeamEdges; // 0x17
	public bool preserveUVFoldoverEdges; // 0x18
	public bool preserveBorderEdges; // 0x19
	public bool regardPreservationSpheres; // 0x1A
	public List<PolyfewRuntime.PreservationSphere> preservationSpheres; // 0x20
	public bool regardCurvature; // 0x28
	public int maxIterations; // 0x2C
	public float aggressiveness; // 0x30
	public bool useEdgeSort; // 0x34

	// Methods

	// RVA: 0x6E0F80 Offset: 0x6DF580 VA: 0x1806E0F80
	public void .ctor() { }

	// RVA: 0x6E1010 Offset: 0x6DF610 VA: 0x1806E1010
	public void .ctor(float simplificationStrength, bool simplifyOptimal, bool enableSmartlink, bool recalculateNormals, bool preserveUVSeamEdges, bool preserveUVFoldoverEdges, bool preserveBorderEdges, bool regardToleranceSphere, List<PolyfewRuntime.PreservationSphere> preservationSpheres, bool regardCurvature, int maxIterations, float aggressiveness, bool useEdgeSort) { }
}
