// Namespace: Quantum.Physics2D
internal struct CollisionManifoldInfo2D // TypeDefIndex: 11972
{
	// Fields
	public CollisionManifold2D* Manifold; // 0x0
	public Entry2D* EntryA; // 0x8
	public Entry2D* EntryB; // 0x10

	// Methods

	// RVA: 0x15CDF50 Offset: 0x15CC550 VA: 0x1815CDF50
	public void .ctor(CollisionManifold2D* m, Entry2D* entryA, Entry2D* entryB) { }

	// RVA: 0x22077F0 Offset: 0x2205DF0 VA: 0x1822077F0
	public void InvertEntries(Scene2D* scene) { }
}
