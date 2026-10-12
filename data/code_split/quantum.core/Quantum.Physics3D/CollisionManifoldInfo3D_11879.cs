// Namespace: Quantum.Physics3D
internal struct CollisionManifoldInfo3D // TypeDefIndex: 11879
{
	// Fields
	public CollisionManifold3D* Manifold; // 0x0
	public Entry3D* EntryA; // 0x8
	public Entry3D* EntryB; // 0x10
	public TriangleCCW* Tri; // 0x18

	// Methods

	// RVA: 0x2271DF0 Offset: 0x22703F0 VA: 0x182271DF0
	public void InvertEntries(Scene3D* scene) { }
}
