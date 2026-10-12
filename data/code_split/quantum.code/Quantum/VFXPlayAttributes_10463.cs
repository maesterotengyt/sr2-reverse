// Namespace: Quantum
[Serializable]
public struct VFXPlayAttributes // TypeDefIndex: 10463
{
	// Fields
	public bool KeepFinalPosition; // 0x0
	public bool OverridePosition; // 0x1
	[DrawIf("OverridePosition", 1, 0, 3)]
	public VFXVectorSource PositionSource; // 0x4
	[DrawIf("OverridePosition", 1, 0, 3)]
	public bool IsGlobalPosition; // 0x8
	[DrawIf("OverridePosition", 1, 0, 3)]
	public bool AddEntityTransformToPosition; // 0x9
	[DrawIf("PositionSource", 0, 0, 3)]
	[DrawIf("OverridePosition", 1, 0, 3)]
	public FPVector3 Position; // 0x10
	[DrawIf("PositionSource", 1, 0, 3)]
	[DrawIf("OverridePosition", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable PositionX; // 0x28
	[DrawIf("PositionSource", 1, 0, 3)]
	[DrawIf("OverridePosition", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable PositionY; // 0x30
	[DrawIf("PositionSource", 1, 0, 3)]
	[DrawIf("OverridePosition", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable PositionZ; // 0x38
	public bool OverrideRotation; // 0x40
	[DrawIf("OverrideRotation", 1, 0, 3)]
	public VFXVectorSource RotationSource; // 0x44
	[DrawIf("RotationSource", 0, 0, 3)]
	[DrawIf("OverrideRotation", 1, 0, 3)]
	public FPVector3 Rotation; // 0x48
	[DrawIf("RotationSource", 1, 0, 3)]
	[DrawIf("OverrideRotation", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable RotationX; // 0x60
	[DrawIf("RotationSource", 1, 0, 3)]
	[DrawIf("OverrideRotation", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable RotationY; // 0x68
	[DrawIf("RotationSource", 1, 0, 3)]
	[DrawIf("OverrideRotation", 1, 0, 3)]
	[DrawWithLabel]
	public EntityVariable RotationZ; // 0x70
	[DrawIf("OverrideRotation", 1, 0, 3)]
	public bool UseGroundNormalRotation; // 0x78
	public bool LookAtWorldCenter; // 0x79
	public bool LookAtCamera; // 0x7A
	public bool OverrideScale; // 0x7B
	[DrawIf("OverrideScale", 1, 0, 3)]
	public FPVector3 Scale; // 0x80
}
