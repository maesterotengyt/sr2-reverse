// Namespace: 
public struct Gjk2D.SimplexDataPointers2D // TypeDefIndex: 11933
{
	// Fields
	public int UsedCount; // 0x0
	public Gjk2D.SimplexData2D* Data; // 0x8
	[FixedBuffer(typeof(byte), 24)]
	public Gjk2D.SimplexDataPointers2D.<VertexPointers>e__FixedBuffer VertexPointers; // 0x10
	public FP* Lambdas; // 0x28

	// Methods

	// RVA: 0x227E730 Offset: 0x227CD30 VA: 0x18227E730
	public void .ctor(Gjk2D.SimplexData2D* simplex) { }

	// RVA: 0x227E730 Offset: 0x227CD30 VA: 0x18227E730
	public static void ResetPointers(Gjk2D.SimplexDataPointers2D* ptrs, Gjk2D.SimplexData2D* simplex) { }
}
