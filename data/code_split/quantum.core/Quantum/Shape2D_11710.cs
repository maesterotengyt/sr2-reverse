// Namespace: Quantum
public struct Shape2D // TypeDefIndex: 11710
{
	// Fields
	public const int SIZE = 64;
	internal Shape2DType _type; // 0x0
	private byte _padding1; // 0x1
	public ushort UserTag; // 0x2
	private int _padding2; // 0x4
	[FieldOverlap(8)]
	public Transform2D LocalTransform; // 0x8
	[FieldOverlap(8)]
	public FPVector2 Centroid; // 0x8
	[FieldOverlap(8)]
	[PrintIf("_type", 16, 0)]
	public Shape2D.CompoundShape2D Compound; // 0x8
	private const int SHAPE_DATA = 32;
	[FieldOverlap(8)]
	public FP BroadRadius; // 0x20
	[FieldOverlap(8)]
	[PrintIf("_type", 1, 0)]
	public Shape2D.CircleShape Circle; // 0x20
	[FieldOverlap(8)]
	[PrintIf("_type", 4, 0)]
	public Shape2D.BoxShape Box; // 0x20
	[FieldOverlap(8)]
	[PrintIf("_type", 2, 0)]
	public Shape2D.PolygonShape Polygon; // 0x20
	[FieldOverlap(8)]
	[PrintIf("_type", 8, 0)]
	public Shape2D.EdgeShape Edge; // 0x20

	// Properties
	public Shape2DType Type { get; }

	// Methods

	// RVA: 0xE03DC0 Offset: 0xE023C0 VA: 0x180E03DC0
	public Shape2DType get_Type() { }

	// RVA: 0x221F7B0 Offset: 0x221DDB0 VA: 0x18221F7B0
	public static Shape2D CreateCircle(FP radius, FPVector2 posOffset) { }

	// RVA: 0x221F8C0 Offset: 0x221DEC0 VA: 0x18221F8C0
	public static Shape2D CreatePolygon(PolygonCollider asset, FPVector2 posOffset, FP rotOffset) { }

	// RVA: 0x221F6F0 Offset: 0x221DCF0 VA: 0x18221F6F0
	public static Shape2D CreateBox(FPVector2 extents, FPVector2 posOffset, FP rotOffset) { }

	// RVA: 0x221F800 Offset: 0x221DE00 VA: 0x18221F800
	public static Shape2D CreateEdge(FP extent, FPVector2 posOffset, FP rotOffset) { }

	// RVA: 0x221F870 Offset: 0x221DE70 VA: 0x18221F870
	public static Shape2D CreatePersistentCompound() { }

	// RVA: 0x221F3E0 Offset: 0x221D9E0 VA: 0x18221F3E0
	internal FP CalculateInertiaFactor(FrameBase f, Nullable<FPVector2> comOffset) { }

	// RVA: 0x221F950 Offset: 0x221DF50 VA: 0x18221F950
	internal FP GetArea(FrameBase frame) { }

	// RVA: 0x221FB10 Offset: 0x221E110 VA: 0x18221FB10
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x221FA00 Offset: 0x221E000 VA: 0x18221FA00 Slot: 2
	public override int GetHashCode() { }
}
