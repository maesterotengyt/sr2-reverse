// Namespace: 
[Serializable]
public struct EntityPrototype.InitialNavMeshTargetInfo // TypeDefIndex: 2393
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	public Transform Target; // 0x8
	[DrawIf("Target", 0, 0, 2)]
	public FPVector3 Position; // 0x10
	public EntityPrototype.NavMeshSpec NavMesh; // 0x28
}
