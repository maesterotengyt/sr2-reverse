// Namespace: Quantum
public struct CollisionInfo2D // TypeDefIndex: 11704
{
	// Fields
	private Map _map; // 0x0
	private bool _isStatic; // 0x8
	private bool _isInverse; // 0x9
	private CollisionManifold2D* _manifold; // 0x10
	private Entry2D* _entryA; // 0x18
	private Entry2D* _entryB; // 0x20
	public CollisionInfo2D.ContactPointIterator2D ContactPoints; // 0x28

	// Methods

	// RVA: 0x221A3F0 Offset: 0x22189F0 VA: 0x18221A3F0
	internal void .ctor(CollisionManifold2D* manifold, Entry2D* entryA, Entry2D* entryB, Map map, bool isStatic, bool isInverse) { }
}
