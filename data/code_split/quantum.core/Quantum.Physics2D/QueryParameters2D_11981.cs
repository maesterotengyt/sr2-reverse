// Namespace: Quantum.Physics2D
internal struct QueryParameters2D // TypeDefIndex: 11981
{
	// Fields
	public const int SIZE = 112;
	[FieldOverlap(0)]
	public QueryParameters2D.ShapeOverlapParameters2D ShapeOverlap; // 0x0
	[FieldOverlap(0)]
	public QueryParameters2D.ShapeCastParameters2D ShapeCast; // 0x0
	[FieldOverlap(0)]
	public QueryParameters2D.LinecastParameters2D Linecast; // 0x0
	[FieldOverlap(0)]
	private int _firstHitOnly; // 0x0
	[FieldOverlap(0)]
	public Transform2D Transform; // 0x8
	[FieldOverlap(0)]
	public Shape2D Shape; // 0x30

	// Properties
	public bool FirstHitOnly { get; }

	// Methods

	// RVA: 0x2213CF0 Offset: 0x22122F0 VA: 0x182213CF0
	public bool get_FirstHitOnly() { }
}
