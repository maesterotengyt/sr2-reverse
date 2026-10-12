// Namespace: 
public struct QueryParameters3D.ShapeCastParameters3D // TypeDefIndex: 11889
{
	// Fields
	public const int SIZE = 184;
	public const int OffsetFho = 0;
	private int _firstHitOnly; // 0x0
	public const int OffsetPosition = 8;
	public const int OffsetTransform = 8;
	public FPVector3 Start; // 0x8
	public const int OffsetRotation = 32;
	public FPQuaternion Rotation; // 0x20
	public const int OffsetTranslation = 64;
	public FPVector3 Translation; // 0x40
	public const int OffsetShape = 88;
	public Shape3D Shape; // 0x58

	// Properties
	public bool FirstHitOnly { get; }

	// Methods

	// RVA: 0x2213CF0 Offset: 0x22122F0 VA: 0x182213CF0
	public bool get_FirstHitOnly() { }
}
