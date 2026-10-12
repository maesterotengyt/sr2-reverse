// Namespace: Quantum
[Serializable]
public class TerrainCollider : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11493
{
	// Fields
	[HideInInspector]
	public FP[] HeightMap; // 0x20
	[HideInInspector]
	public ulong[] HoleMask; // 0x28
	private const int HoleMaskBitsPerBlock = 64;
	public FPVector3 Position; // 0x30
	public FPVector3 Scale; // 0x48
	public int Resolution; // 0x60
	public AssetRefPhysicsMaterial PhysicsMaterial; // 0x68
	private TriangleCCW[] _triangles; // 0x70

	// Properties
	public TriangleCCW[] Triangles { get; }

	// Methods

	// RVA: 0x21DB7C0 Offset: 0x21D9DC0 VA: 0x1821DB7C0 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public TriangleCCW[] get_Triangles() { }

	// RVA: 0x21DB750 Offset: 0x21D9D50 VA: 0x1821DB750
	public bool IsHole(int x, int y) { }

	// RVA: 0x21DAEE0 Offset: 0x21D94E0 VA: 0x1821DAEE0
	public void Bake(int staticId) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
