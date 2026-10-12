// Namespace: Quantum
[Serializable]
public class Shape2DConfig // TypeDefIndex: 11712
{
	// Fields
	[DisplayName("Type")]
	public Shape2DType ShapeType; // 0x10
	[DrawIf("ShapeType", 2, 0, 3)]
	[DisplayName("Asset")]
	public AssetRefPolygonCollider PolygonCollider; // 0x18
	[DrawIf("ShapeType", 1, 0, 3)]
	[DisplayName("Radius")]
	public FP CircleRadius; // 0x20
	[DrawIf("ShapeType", 8, 0, 3)]
	[DisplayName("Extents")]
	public FP EdgeExtent; // 0x28
	[DrawIf("ShapeType", 4, 0, 3)]
	[DisplayName("Extents")]
	public FPVector2 BoxExtents; // 0x30
	[DisplayName("Center")]
	[DrawIf("ShapeType", 0, 1, 3)]
	[DrawIf("ShapeType", 16, 1, 3)]
	public FPVector2 PositionOffset; // 0x40
	[Degrees]
	[DrawIf("ShapeType", 1, 1, 3)]
	[DrawIf("ShapeType", 0, 1, 3)]
	[DrawIf("ShapeType", 16, 1, 3)]
	[DisplayName("Rotation")]
	public FP RotationOffset; // 0x50
	[DrawIf("ShapeType", 0, 1, 3)]
	[DrawIf("ShapeType", 16, 1, 3)]
	public ushort UserTag; // 0x58
	[DrawIf("ShapeType", 16, 0, 3)]
	[Tooltip("As for now, only persistent compound shapes are supported on the editor.")]
	[ReadOnly]
	public bool IsPersistent; // 0x5A
	[DrawIf("ShapeType", 16, 0, 3)]
	[DisplayName("Shapes")]
	public Shape2DConfig.CompoundShapeData2D[] CompoundShapes; // 0x60
	[HideInInspector]
	public bool IsSetFromSourceCollider; // 0x68

	// Methods

	// RVA: 0x221EFA0 Offset: 0x221D5A0 VA: 0x18221EFA0
	public Shape2D CreateShape(FrameBase f) { }

	// RVA: 0x221F3D0 Offset: 0x221D9D0 VA: 0x18221F3D0
	public void .ctor() { }
}
