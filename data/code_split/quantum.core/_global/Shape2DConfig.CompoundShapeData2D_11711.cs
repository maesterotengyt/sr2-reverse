// Namespace: 
[Serializable]
public struct Shape2DConfig.CompoundShapeData2D // TypeDefIndex: 11711
{
	// Fields
	[DisplayName("Type")]
	public Shape2DType ShapeType; // 0x0
	[DrawIf("ShapeType", 2, 0, 3)]
	[DisplayName("Asset")]
	public AssetRefPolygonCollider PolygonCollider; // 0x8
	[DrawIf("ShapeType", 1, 0, 3)]
	[DisplayName("Radius")]
	public FP CircleRadius; // 0x10
	[DrawIf("ShapeType", 8, 0, 3)]
	[DisplayName("Extents")]
	public FP EdgeExtent; // 0x18
	[DrawIf("ShapeType", 4, 0, 3)]
	[DisplayName("Extents")]
	public FPVector2 BoxExtents; // 0x20
	[DisplayName("Center")]
	[DrawIf("ShapeType", 0, 1, 3)]
	[DrawIf("ShapeType", 16, 1, 3)]
	public FPVector2 PositionOffset; // 0x30
	[Degrees]
	[DrawIf("ShapeType", 1, 1, 3)]
	[DrawIf("ShapeType", 0, 1, 3)]
	[DrawIf("ShapeType", 16, 1, 3)]
	[DisplayName("Rotation")]
	public FP RotationOffset; // 0x40
	[DrawIf("ShapeType", 0, 1, 3)]
	[DrawIf("ShapeType", 16, 1, 3)]
	public ushort UserTag; // 0x48
	[HideInInspector]
	public bool IsSetFromSourceCollider; // 0x4A

	// Methods

	// RVA: 0x221ADC0 Offset: 0x22193C0 VA: 0x18221ADC0
	public Shape2D CreateShape(FrameBase f) { }
}
