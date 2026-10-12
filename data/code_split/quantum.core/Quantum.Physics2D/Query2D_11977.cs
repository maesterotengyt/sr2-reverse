// Namespace: Quantum.Physics2D
internal struct Query2D // TypeDefIndex: 11977
{
	// Fields
	public PhysicsCommon.QueryType Type; // 0x0
	public QueryParameters2D Parameters; // 0x8
	public QueryOptions Options; // 0x78
	public int LayerMask; // 0x7C
	public int HitCollectionIndex; // 0x80
	public int EntryIndex; // 0x84
	public long VHeightRaw; // 0x88
	public long VPositionRaw; // 0x90
	public bool IsPartOfCompound; // 0x98
	public int NextInCompound; // 0x9C
}
