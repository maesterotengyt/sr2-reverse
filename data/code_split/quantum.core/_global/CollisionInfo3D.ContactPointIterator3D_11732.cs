// Namespace: 
public struct CollisionInfo3D.ContactPointIterator3D // TypeDefIndex: 11732
{
	// Fields
	private CollisionManifold3D* _rootManifold; // 0x0
	private CollisionManifold3D* _currentManifold; // 0x8
	private CollisionManifold3D* _triManifolds; // 0x10
	private int _currentContactIndex; // 0x18
	private bool _isMesh; // 0x1C
	private bool _isInverse; // 0x1D

	// Methods

	// RVA: 0x2224180 Offset: 0x2222780 VA: 0x182224180
	internal void .ctor(CollisionManifold3D* manifold, bool isInverse, bool isMesh, CollisionManifold3D* triManifolds) { }
}
