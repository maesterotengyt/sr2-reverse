// Namespace: 
[Serializable]
public struct MeshCombiner.BlendShapeFrame // TypeDefIndex: 4141
{
	// Fields
	public string shapeName; // 0x0
	public float frameWeight; // 0x8
	public Vector3[] deltaVertices; // 0x10
	public Vector3[] deltaNormals; // 0x18
	public Vector3[] deltaTangents; // 0x20
	public int vertexOffset; // 0x28

	// Methods

	// RVA: 0x6CE4E0 Offset: 0x6CCAE0 VA: 0x1806CE4E0
	public void .ctor(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	// RVA: 0x6CE590 Offset: 0x6CCB90 VA: 0x1806CE590
	public void .ctor(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents, int vertexOffset) { }
}
