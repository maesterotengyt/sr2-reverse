// Namespace: Quantum
[Serializable]
public class Map : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11480
{
	// Fields
	[Tooltip("An optional generic asset reference that the map can be associated with.")]
	public AssetRef UserAsset; // 0x20
	[Tooltip("The Unity scene name is baked into the map. It's loaded automatically if Simulation.AutoLoadSceneFromMap is enabled.")]
	public string Scene; // 0x28
	[Tooltip("The Unity scene path is baked into the map for conveinience.")]
	public string ScenePath; // 0x30
	[Tooltip("The Unity scene guid is baked into the map for conveinience.")]
	public string SceneGuid; // 0x38
	[Header("Physics Settings")]
	[Tooltip("The physics scene size in the bucketing axis. The broad phase is clamped by a bounding box of all physics entries between -WorldSize/2 to WorldSize/2. It is therefore crucial to ensure the world is big enough to encompass all entities. If an entity is outside the world, it will cost you performance as it is added to either the first or last bucket. Everything outside the bounding box is considered to be at the world's edge, from the physics engine perspective, which will result in false collision candidates. In the non bucketing axis, the physics world is only limited by the value range of FP.UsableMin to FP.UsableMax.")]
	public int WorldSize; // 0x40
	[Tooltip("The amount of buckets used in the broad phase, which are resolved in parallel. Use a reasonable amount according to how many physics entries (colliders) you have. Too many buckets and the handling overhead increases without any performance gain because there are only few entries in each one; too few buckets and there will be an excessive amount of entries in each, slowing down the broad phase performance.")]
	public int BucketsCount; // 0x44
	[Tooltip("Regular queries (overlaps and raycasts) use a stabbing approach for checking as few entries as possible in the buckets subdivisions. Tweak the number in accordance with the expected amount of entries and regular queries you perform. Too many subdivisions will add overhead without performance, while too few will result in queries taking longer to resolve, because they will have to check too many entries.")]
	public int BucketsSubdivisions; // 0x48
	[Tooltip("Physics entries are put into buckets according to their position in the bucketing axis.")]
	public PhysicsCommon.BucketAxis BucketingAxis; // 0x4C
	[Tooltip("The queries in a bucket are sorted according to their position in the sorting axis.")]
	public PhysicsCommon.SortAxis SortingAxis; // 0x4D
	[Tooltip("Defines the size of the cells into which the 3D triangle soup is divided. This number should be adapted based on how dense the meshes' triangles density to get a reasonable amount of triangles per cell. For better visualization enable related fields in the QuantumEditorSettings asset's Collider gizmos section.This will affect the performance of both the broad phase and regular queries.Use the Task Profiler to analyse the performance and find the most suitable number for your game. ")]
	public int TriangleMeshCellSize; // 0x50
	[Tooltip("Binary 3D triangle data is saved on an addition Quantum asset.")]
	public AssetRefBinaryData StaticColliders3DTrianglesData; // 0x58
	[Obsolete("Added to allow backwards compatibility of the new triangle serialization code.")]
	[HideInInspector]
	public bool OptionalTriangleMetadataSerializationEnabled; // 0x60
	[Tooltip("If triangles metadata should be serialized (true) or recomputed (false)")]
	public bool SerializeTrianglesMetadata; // 0x61
	[Obsolete("Use StaticColliders3DTrianglesData instead")]
	[HideInInspector]
	public string StaticColliders3DTrianglesBinaryFile; // 0x68
	[Header("NavMesh Settings")]
	[Tooltip("Number of navmesh grid cells in x-dimension. Toggle debug rendering using Map.DrawGridMode.")]
	public int GridSizeX; // 0x70
	[Tooltip("Number of navmesh grid cells in y-dimension. Toggle debug rendering using Map.DrawGridMode.")]
	public int GridSizeY; // 0x74
	[Tooltip("The number of Unity units per navmesh grid cell. Must be multiple of 2.")]
	public int GridNodeSize; // 0x78
	[Space(8)]
	[Tooltip("The list not navmesh assets baked into this map.")]
	public AssetRefNavMesh[] NavMeshLinks; // 0x80
	[Tooltip("The list of navmesh region names baked into this map.")]
	public string[] Regions; // 0x88
	[Tooltip("All static 2D colliders baked into this map.")]
	public MapStaticCollider2D[] StaticColliders2D; // 0x90
	[Tooltip("All static 3D colliders baked into this map.")]
	public MapStaticCollider3D[] StaticColliders3D; // 0x98
	public EntityPrototypeContainer[] MapEntities; // 0xA0
	public SortedDictionary<int, TriangleCCW[]> StaticColliders3DTriangles; // 0xA8
	public Dictionary<string, NavMesh> NavMeshes; // 0xB0
	public Dictionary<string, int> RegionMap; // 0xB8

	// Properties
	public int WorldExtentX { get; }
	public int WorldExtentY { get; }
	public FPVector2 WorldOffset { get; }

	// Methods

	// RVA: 0x21D3DD0 Offset: 0x21D23D0 VA: 0x1821D3DD0 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	// RVA: 0x21D42A0 Offset: 0x21D28A0 VA: 0x1821D42A0
	public int get_WorldExtentX() { }

	// RVA: 0x21D42B0 Offset: 0x21D28B0 VA: 0x1821D42B0
	public int get_WorldExtentY() { }

	// RVA: 0x21D42C0 Offset: 0x21D28C0 VA: 0x1821D42C0
	public FPVector2 get_WorldOffset() { }

	// RVA: 0x21D3E90 Offset: 0x21D2490 VA: 0x1821D3E90
	public void SerializeStaticColliderTriangles(ByteStream stream, bool write) { }

	// RVA: 0x21D33C0 Offset: 0x21D19C0 VA: 0x1821D33C0 Slot: 5
	public override void Disposed(IResourceManager resourceManager, Native.Allocator allocator) { }

	// RVA: 0x21D38C0 Offset: 0x21D1EC0 VA: 0x1821D38C0 Slot: 4
	public override void Loaded(IResourceManager resourceManager, Native.Allocator allocator) { }

	// RVA: 0x21D35A0 Offset: 0x21D1BA0 VA: 0x1821D35A0
	private void InitNavMeshes(IResourceManager resourceManager) { }

	// RVA: 0x21D3520 Offset: 0x21D1B20 VA: 0x1821D3520
	public NavMesh GetNavMesh(string name) { }

	// RVA: 0x21D34D0 Offset: 0x21D1AD0 VA: 0x1821D34D0
	public void EnsurePhysicsWorldSizeInValidRange() { }

	// RVA: 0x21D4270 Offset: 0x21D2870 VA: 0x1821D4270
	public void .ctor() { }
}
