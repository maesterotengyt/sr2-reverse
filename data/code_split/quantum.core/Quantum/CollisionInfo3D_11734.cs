// Namespace: Quantum
public struct CollisionInfo3D // TypeDefIndex: 11734
{
	// Fields
	private Map _map; // 0x0
	private TriangleMesh _sceneMesh; // 0x8
	private bool _isStatic; // 0x10
	private bool _isMesh; // 0x11
	private bool _isInverse; // 0x12
	private CollisionManifold3D* _manifold; // 0x18
	private Entry3D* _entryA; // 0x20
	private Entry3D* _entryB; // 0x28
	public CollisionInfo3D.ContactPointIterator3D ContactPoints; // 0x30
	public CollisionInfo3D.TriangleCollisionIterator MeshTriangleCollisions; // 0x50

	// Methods

	// RVA: 0x2222F20 Offset: 0x2221520 VA: 0x182222F20
	internal void .ctor(CollisionManifold3D* manifold, Entry3D* entryA, Entry3D* entryB, TriangleMesh sceneMesh, Map map, bool isStatic, bool isInverse, bool isMesh, CollisionManifold3D* triManifolds) { }
}
