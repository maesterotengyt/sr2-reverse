// Namespace: 
public class Navigation.PathFinder : IDisposable, Navigation.IPathFinderData // TypeDefIndex: 11648
{
	// Fields
	private Navigation.FunnelNode[] _funnelLeft; // 0x10
	private Navigation.FunnelNode[] _funnelRight; // 0x18
	private int _funnelIndex; // 0x20
	private Navigation.PathVertex[] _funnel; // 0x28
	private int _funneledPathSize; // 0x30
	private Navigation.ActiveHeap _open; // 0x38
	private Navigation.ActiveVertex** _active; // 0x40
	private int _activeSize; // 0x48
	private Navigation.ActiveVertex** _verticesBlocks; // 0x50
	private int _verticesBlocksCount; // 0x58
	private int _verticesCount; // 0x5C
	private byte* _closedSet; // 0x60
	private int _closedSetSize; // 0x68
	private int _rawPathSize; // 0x6C
	private Navigation.PathVertex[] _rawPath; // 0x70
	private readonly Navigation.RawPathAllocationStrategy _rawPathAllocationStrategy; // 0x78
	private FPVector3 pos_start; // 0x80
	private FPVector3 pos_end; // 0x98
	private int tri_start; // 0xB0
	private int tri_end; // 0xB4
	private Navigation.ActiveVertex* vertex_start; // 0xB8
	private Navigation.ActiveVertex* vertex_end; // 0xC0
	private bool pop_end; // 0xC8
	private bool find_done; // 0xC9
	private NavMesh _navmesh; // 0xD0
	private Native.Allocator _allocator; // 0xD8

	// Properties
	public int PathSize { get; }
	public Navigation.PathVertex[] Path { get; }

	// Methods

	// RVA: 0x5114B0 Offset: 0x50FAB0 VA: 0x1805114B0 Slot: 5
	public int get_PathSize() { }

	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0 Slot: 6
	public Navigation.PathVertex[] get_Path() { }

	// RVA: 0x21E42B0 Offset: 0x21E28B0 VA: 0x1821E42B0
	private void Funnel(FPVector3 start, FPVector3 end, NavMeshRegionMask regionMask, bool calculateNormals) { }

	// RVA: 0x21E2970 Offset: 0x21E0F70 VA: 0x1821E2970
	internal static int CleanupFunnel(Navigation.PathVertex[] funnel, int size) { }

	// RVA: 0x21E2940 Offset: 0x21E0F40 VA: 0x1821E2940
	internal static long CalculateTriangleArea(ref FPVector3 a, ref FPVector3 b, ref FPVector3 c) { }

	// RVA: 0x21E30F0 Offset: 0x21E16F0 VA: 0x1821E30F0
	private void FillFunneledPath(FPVector3 apex, ref int nextFunnelNode, int startFunnelIndex = 0) { }

	// RVA: 0x21E6540 Offset: 0x21E4B40 VA: 0x1821E6540
	public void .ctor(Native.Allocator allocator, int openNodesSize, int rawPathSize = 256, Navigation.RawPathAllocationStrategy rawPathAllocationStrategy = 0) { }

	// RVA: 0x21E6410 Offset: 0x21E4A10 VA: 0x1821E6410
	private void Resize(int size) { }

	// RVA: 0x21E64E0 Offset: 0x21E4AE0 VA: 0x1821E64E0
	public void SetNavMesh(NavMesh navmesh) { }

	// RVA: 0x21E2FC0 Offset: 0x21E15C0 VA: 0x1821E2FC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x21E3AA0 Offset: 0x21E20A0 VA: 0x1821E3AA0
	public Navigation.FindPathResult FindPath(FrameThreadSafe frame, FPVector3 start, FPVector3 end, bool automaticTargetCorrection, FP automaticTargetCorrectionRadius, NavMeshRegionMask regionMask, Navigation.PathQuality quality = 1, NavMesh navmesh) { }

	// RVA: 0x21E54C0 Offset: 0x21E3AC0 VA: 0x1821E54C0
	private bool PathFindComplete(Navigation.PathQuality quality, NavMeshRegionMask regionMask, FrameBase frame) { }

	// RVA: 0x21E53A0 Offset: 0x21E39A0 VA: 0x1821E53A0
	private bool PathAdd(FPVector3 point, int index) { }

	// RVA: 0x21E2BE0 Offset: 0x21E11E0 VA: 0x1821E2BE0
	private void CreateOrUpdateVertex(int triangleIndex, Navigation.ActiveVertex* current, Navigation.PathQuality quality, FrameBase frame, NavMesh navmesh) { }

	// RVA: 0x21E5180 Offset: 0x21E3780 VA: 0x1821E5180
	private Navigation.ActiveVertex* GetActiveVertexFromIndex(int index) { }

	// RVA: 0x21E5200 Offset: 0x21E3800 VA: 0x1821E5200
	private Navigation.ActiveVertex* GetNextActiveVertex(FrameBase frame) { }
}
