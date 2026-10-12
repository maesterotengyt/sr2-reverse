// Namespace: Quantum
[Serializable]
public class Shape3DConfig // TypeDefIndex: 11742
{
	// Fields
	[DisplayName("Type")]
	public Shape3DType ShapeType; // 0x10
	[DrawIf("ShapeType", 1, 0, 3)]
	[DisplayName("Radius")]
	public FP SphereRadius; // 0x18
	[DrawIf("ShapeType", 3, 6, 3)]
	[DisplayName("Center")]
	public FPVector3 PositionOffset; // 0x20
	[DrawIf("ShapeType", 2, 0, 3)]
	[DisplayName("Extents")]
	public FPVector3 BoxExtents; // 0x38
	[Degrees]
	[DrawIf("ShapeType", 2, 0, 3)]
	[DisplayName("Rotation")]
	public FPVector3 RotationOffset; // 0x50
	[DrawIf("ShapeType", 3, 6, 3)]
	public ushort UserTag; // 0x68
	[DrawIf("ShapeType", 16, 0, 3)]
	[Tooltip("As for now, only persistent compound shapes are supported on the editor.")]
	[ReadOnly]
	public bool IsPersistent; // 0x6A
	[DrawIf("ShapeType", 16, 0, 3)]
	[DisplayName("Shapes")]
	public Shape3DConfig.CompoundShapeData3D[] CompoundShapes; // 0x70
	[HideInInspector]
	public bool IsSetFromSourceCollider; // 0x78

	// Methods

	// RVA: 0x2228650 Offset: 0x2226C50 VA: 0x182228650
	public Shape3D CreateShape(FrameBase f) { }

	// RVA: 0x2228B20 Offset: 0x2227120 VA: 0x182228B20
	public void .ctor() { }
}
