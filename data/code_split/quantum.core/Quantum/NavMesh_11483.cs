// Namespace: Quantum
[Serializable]
public class NavMesh : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11483
{
	// Fields
	public string Name; // 0x20
	public AssetRefBinaryData DataAsset; // 0x28
	[Obsolete("Use DataAsset instead")]
	[HideInInspector]
	public string DataFilepath; // 0x30
	public int GridSizeX; // 0x38
	public int GridSizeY; // 0x3C
	public int GridNodeSize; // 0x40
	public FPVector2 WorldOffset; // 0x48
	public FP MinAgentRadius; // 0x58
	public NavMeshTriangle[] Triangles; // 0x60
	public NavMeshTriangleNode[] TrianglesGrid; // 0x68
	public NavMeshVertex[] Vertices; // 0x70
	public NavMeshBorderNode[] BorderGrid; // 0x78
	public NavMeshTriangleCenterGridNode[] TrianglesCenterGrid; // 0x80
	public NavMeshBorder[] Borders; // 0x88
	public NavMeshLink[] Links; // 0x90

	// Properties
	public int BorderCount { get; }

	// Methods

	// RVA: 0x21D6270 Offset: 0x21D4870 VA: 0x1821D6270 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	// RVA: 0x21D67B0 Offset: 0x21D4DB0 VA: 0x1821D67B0
	public int get_BorderCount() { }

	// RVA: 0x21D5A70 Offset: 0x21D4070 VA: 0x1821D5A70 Slot: 4
	public override void Loaded(IResourceManager assets, Native.Allocator allocator) { }

	// RVA: 0x21D45D0 Offset: 0x21D2BD0 VA: 0x1821D45D0
	internal int CalculateNodeGridIndex(FP positionX, FP positionZ) { }

	// RVA: 0x21D4620 Offset: 0x21D2C20 VA: 0x1821D4620
	internal void CalculateNodeGridPosition(FP positionX, FP positionZ, out int x, out int z) { }

	// RVA: 0x21D4670 Offset: 0x21D2C70 VA: 0x1821D4670
	public void ClampToGrid(ref FPVector3 position) { }

	// RVA: 0x21D5160 Offset: 0x21D3760 VA: 0x1821D5160
	public static long GetHeightAtTriangleRaw(FPVector3 p, FPVector3 normal, FPVector3 v0) { }

	// RVA: 0x21D4740 Offset: 0x21D2D40 VA: 0x1821D4740
	public bool FindClosestTriangle(FPVector3 sourcePosition, FP radius, NavMeshRegionMask regionMask, out int triangle, out FPVector3 closestPosition, MailboxSet8 mailbox) { }

	// RVA: 0x21D4E00 Offset: 0x21D3400 VA: 0x1821D4E00
	public int FindTriangle2D(FPVector3 position, NavMeshRegionMask regionMask, bool inclusive = False) { }

	// RVA: 0x21D5270 Offset: 0x21D3870 VA: 0x1821D5270
	public bool IsBorderActive(int borderIndex, NavMeshRegionMask regionMask) { }

	// RVA: 0x21D4700 Offset: 0x21D2D00 VA: 0x1821D4700
	public bool Contains(FPVector3 position, NavMeshRegionMask regionMask, bool inclusive = False) { }

	// RVA: 0x21D5380 Offset: 0x21D3980 VA: 0x1821D5380
	internal bool LineOfSight(FPVector3 positionStart, FPVector3 positionDestination, NavMeshRegionMask regionMask, int triangleStart = -1, int triangleDestination = -1, bool considerCost = False) { }

	// RVA: 0x21D5DF0 Offset: 0x21D43F0 VA: 0x1821D5DF0
	internal FPVector2 MovePositionIntoNavmesh(FPVector2 position, FPVector2 newPosition, FP correction, NavMeshRegionMask regionMask, MailboxSet8 mailbox) { }

	// RVA: 0x21D6330 Offset: 0x21D4930 VA: 0x1821D6330
	public void Serialize(ByteStream stream, bool write) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
