// Namespace: Quantum
public class TriangleMesh // TypeDefIndex: 11729
{
	// Fields
	private const int COORDINATE_OFFSET = 32768;
	private const int CELL_TRIANGLE_MAX_BITS = 16;
	private const int CELL_TRIANGLE_MAX = 65536;
	private FrameContext _context; // 0x10
	private uint* _buckets; // 0x18
	private TriangleMesh.Cell* _cells; // 0x20
	private int _cellSize; // 0x28
	private int _cellExtent; // 0x2C
	private FP _cellBroadRadius; // 0x30
	private uint _cellsFreeHead; // 0x38
	private uint _cellsFreeCount; // 0x3C
	private uint _cellsUsedCount; // 0x40
	private uint _cellsCapacity; // 0x44
	private TriangleMesh.Tri* _tris; // 0x48
	private int _trisFreeHead; // 0x50
	private int _trisUsedCount; // 0x54
	private int _trisCapacity; // 0x58
	private int _trisImmutableCount; // 0x5C
	private TriangleMesh.CellBounds _bounds; // 0x60
	private AssetGuid _map; // 0x78
	private bool _predicted; // 0x80
	private TriangleReference* _staticColliderReferences; // 0x88
	private int _staticColliderReferencesCapacity; // 0x90

	// Properties
	public int CellSize { get; }
	public int CellExtent { get; }
	public FP CellBroadRadius { get; }
	public int TriangleCount { get; }
	public int TriangleCapacity { get; }
	internal bool Predicted { set; }

	// Methods

	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public int get_CellSize() { }

	// RVA: 0x668D90 Offset: 0x667390 VA: 0x180668D90
	public int get_CellExtent() { }

	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public FP get_CellBroadRadius() { }

	// RVA: 0x73E010 Offset: 0x73C610 VA: 0x18073E010
	public int get_TriangleCount() { }

	// RVA: 0x693B20 Offset: 0x692120 VA: 0x180693B20
	public int get_TriangleCapacity() { }

	// RVA: 0x5DC950 Offset: 0x5DAF50 VA: 0x1805DC950
	internal void set_Predicted(bool value) { }

	// RVA: 0x222DFF0 Offset: 0x222C5F0 VA: 0x18222DFF0
	internal void .ctor(FrameContext context) { }

	// RVA: 0x222BD70 Offset: 0x222A370 VA: 0x18222BD70
	public void Initialize(int cellSize, uint cellsCapacity, int trianglesCapacity, int staticColliderCapacity) { }

	// RVA: 0x222BAE0 Offset: 0x222A0E0 VA: 0x18222BAE0
	public TriangleCCW* GetTriangle(int index) { }

	// RVA: 0x222DEB0 Offset: 0x222C4B0 VA: 0x18222DEB0
	public void ToCell(FPVector3 pos, out int x, out int y, out int z) { }

	// RVA: 0x222B4A0 Offset: 0x2229AA0 VA: 0x18222B4A0
	private ulong CellHash(int x, int y, int z) { }

	// RVA: 0x222B9F0 Offset: 0x2229FF0 VA: 0x18222B9F0
	internal TriangleMesh.CellBounds GetBounds(IntAABB aabb) { }

	// RVA: 0x222DF10 Offset: 0x222C510 VA: 0x18222DF10
	public bool TryGetTriangles(int x, int y, int z, out int* triangles, out int count) { }

	// RVA: 0x222B660 Offset: 0x2229C60 VA: 0x18222B660
	internal void EnableStaticColliderInternal(FrameBase f, int index) { }

	// RVA: 0x222C7B0 Offset: 0x222ADB0 VA: 0x18222C7B0
	public TriangleReference InsertMany(TriangleCCW[] tri) { }

	// RVA: 0x222C1F0 Offset: 0x222A7F0 VA: 0x18222C1F0
	private TriangleMesh.Tri* InsertInternal(ref TriangleCCW tri) { }

	// RVA: 0x222B830 Offset: 0x2229E30 VA: 0x18222B830
	private void ExpandCellsCapacity() { }

	// RVA: 0x222B4E0 Offset: 0x2229AE0 VA: 0x18222B4E0
	internal void Dispose() { }

	// RVA: 0x222C8E0 Offset: 0x222AEE0 VA: 0x18222C8E0
	internal void Serialize(FrameBase f, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x222B2A0 Offset: 0x22298A0 VA: 0x18222B2A0
	private int CalculateDefaultTriangleCapacityForMap(Map map) { }

	// RVA: 0x222C050 Offset: 0x222A650 VA: 0x18222C050
	private void InjectImmutableCollidersFromMap(Map map) { }

	// RVA: 0x222B270 Offset: 0x2229870 VA: 0x18222B270
	private static int BitsRequiredForNumber(uint n) { }

	// RVA: 0x222B270 Offset: 0x2229870 VA: 0x18222B270
	private static int BitsRequiredForNumber(int n) { }

	// RVA: 0x222BB20 Offset: 0x222A120 VA: 0x18222BB20
	internal void InitializeFromMap(FrameBase f, Map map) { }

	// RVA: 0x222C870 Offset: 0x222AE70 VA: 0x18222C870
	private void LockImmutable() { }
}
