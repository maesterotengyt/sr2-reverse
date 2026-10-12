// Namespace: 
[Serializable]
public struct Shape3DConfig.CompoundShapeData3D // TypeDefIndex: 11741
{
	// Fields
	[DisplayName("Type")]
	public Shape3DType ShapeType; // 0x0
	[DrawIf("ShapeType", 1, 0, 3)]
	[DisplayName("Radius")]
	public FP SphereRadius; // 0x8
	[DrawIf("ShapeType", 3, 6, 3)]
	[DisplayName("Center")]
	public FPVector3 PositionOffset; // 0x10
	[DrawIf("ShapeType", 2, 0, 3)]
	[DisplayName("Extents")]
	public FPVector3 BoxExtents; // 0x28
	[Degrees]
	[DrawIf("ShapeType", 2, 0, 3)]
	[DisplayName("Rotation")]
	public FPVector3 RotationOffset; // 0x40
	[DrawIf("ShapeType", 3, 6, 3)]
	public ushort UserTag; // 0x58
	[HideInInspector]
	public bool IsSetFromSourceCollider; // 0x5A

	// Methods

	// RVA: 0x2223E30 Offset: 0x2222430 VA: 0x182223E30
	public Shape3D CreateShape(FrameBase f) { }
}
