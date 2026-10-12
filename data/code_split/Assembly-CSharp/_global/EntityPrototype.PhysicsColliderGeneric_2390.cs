// Namespace: 
[Serializable]
public struct EntityPrototype.PhysicsColliderGeneric // TypeDefIndex: 2390
{
	// Fields
	public bool IsTrigger; // 0x0
	public AssetRefPhysicsMaterial Material; // 0x8
	public Component SourceCollider; // 0x10
	[HideInInspector]
	public bool IsEnabled; // 0x18
	public Shape2DConfig Shape2D; // 0x20
	public Shape3DConfig Shape3D; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	[Layer]
	public int Layer; // 0x30
	public CallbackFlags_Wrapper CallbackFlags; // 0x34
}
