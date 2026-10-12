// Namespace: Quantum
[Serializable]
public struct MapStaticCollider3D // TypeDefIndex: 11776
{
	// Fields
	public FPQuaternion Rotation; // 0x0
	public FPVector3 Position; // 0x20
	public AssetRefPhysicsMaterial PhysicsMaterial; // 0x38
	public Shape3DType ShapeType; // 0x40
	public FP SphereRadius; // 0x48
	public FPVector3 BoxExtents; // 0x50
	public bool SmoothSphereMeshCollisions; // 0x68
	public StaticColliderData StaticData; // 0x70
	[Obsolete("Use 'StaticData.MutableMode' instead.")]
	public MapStaticCollider3D.MutableModes MutableMode; // 0xA0
}
