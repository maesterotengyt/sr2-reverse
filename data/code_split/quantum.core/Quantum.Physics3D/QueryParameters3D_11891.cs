// Namespace: Quantum.Physics3D
internal struct QueryParameters3D // TypeDefIndex: 11891
{
	// Fields
	public const int SIZE = 184;
	[FieldOverlap(0)]
	public QueryParameters3D.ShapeOverlapParameters3D ShapeOverlap; // 0x0
	[FieldOverlap(0)]
	public QueryParameters3D.ShapeCastParameters3D ShapeCast; // 0x0
	[FieldOverlap(0)]
	public QueryParameters3D.LinecastParameters3D Linecast; // 0x0
	[FieldOverlap(0)]
	private int _firstHitOnly; // 0x0
	[FieldOverlap(0)]
	public Transform3D Transform; // 0x8
	[FieldOverlap(0)]
	public Shape3D Shape; // 0x58

	// Properties
	public bool FirstHitOnly { get; }

	// Methods

	// RVA: 0x2213CF0 Offset: 0x22122F0 VA: 0x182213CF0
	public bool get_FirstHitOnly() { }
}
