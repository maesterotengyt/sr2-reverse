// Namespace: Quantum
public struct Shape3D // TypeDefIndex: 11740
{
	// Fields
	public const int SIZE = 96;
	internal Shape3DType _type; // 0x0
	private byte _padding1; // 0x1
	public ushort UserTag; // 0x2
	private int _padding2; // 0x4
	[FieldOverlap(8)]
	public Transform3D LocalTransform; // 0x8
	[FieldOverlap(8)]
	public FPVector3 Centroid; // 0x8
	[FieldOverlap(8)]
	[PrintIf("_type", 16, 0)]
	public Shape3D.CompoundShape3D Compound; // 0x8
	private const int SHAPE_START = 64;
	[FieldOverlap(8)]
	public FP BroadRadius; // 0x40
	[FieldOverlap(8)]
	[PrintIf("_type", 4, 0)]
	public Shape3D.MeshShape Mesh; // 0x40
	[FieldOverlap(8)]
	[PrintIf("_type", 1, 0)]
	public Shape3D.SphereShape Sphere; // 0x40
	[FieldOverlap(8)]
	[PrintIf("_type", 2, 0)]
	public Shape3D.BoxShape Box; // 0x40
	[FieldOverlap(8)]
	[PrintIf("_type", 8, 0)]
	public Shape3D.TerrainShape Terrain; // 0x40

	// Properties
	public Shape3DType Type { get; }

	// Methods

	// RVA: 0xE03DC0 Offset: 0xE023C0 VA: 0x180E03DC0
	public Shape3DType get_Type() { }

	// RVA: 0x22292E0 Offset: 0x22278E0 VA: 0x1822292E0
	public static Shape3D CreateSphere(FP radius, Nullable<FPVector3> posOffset) { }

	// RVA: 0x2229000 Offset: 0x2227600 VA: 0x182229000
	public static Shape3D CreateBox(FPVector3 extents, Nullable<FPVector3> posOffset, Nullable<FPQuaternion> rotOffset) { }

	// RVA: 0x2229180 Offset: 0x2227780 VA: 0x182229180
	internal static Shape3D CreateMesh(int meshIndex, Nullable<FPVector3> posOffset, Nullable<FPQuaternion> rotOffset) { }

	// RVA: 0x2229290 Offset: 0x2227890 VA: 0x182229290
	public static Shape3D CreatePersistentCompound() { }

	// RVA: 0x22294B0 Offset: 0x2227AB0 VA: 0x1822294B0
	private FP GetVolume() { }

	// RVA: 0x2228B30 Offset: 0x2227130 VA: 0x182228B30
	internal FPVector3 CalculateInertiaTensorFactor(FrameBase f, FPVector3 com) { }

	// RVA: 0x2229520 Offset: 0x2227B20 VA: 0x182229520
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x22293B0 Offset: 0x22279B0 VA: 0x1822293B0 Slot: 2
	public override int GetHashCode() { }
}
