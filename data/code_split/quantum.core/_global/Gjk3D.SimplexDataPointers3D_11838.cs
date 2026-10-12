// Namespace: 
public struct Gjk3D.SimplexDataPointers3D // TypeDefIndex: 11838
{
	// Fields
	public int UsedCount; // 0x0
	public Gjk3D.SimplexData3D* Data; // 0x8
	[FixedBuffer(typeof(byte), 32)]
	public Gjk3D.SimplexDataPointers3D.<VertexPointers>e__FixedBuffer VertexPointers; // 0x10
	public FP* Lambdas; // 0x30

	// Methods

	// RVA: 0x2266DF0 Offset: 0x22653F0 VA: 0x182266DF0
	public void .ctor(Gjk3D.SimplexData3D* simplex) { }

	// RVA: 0x2266DF0 Offset: 0x22653F0 VA: 0x182266DF0
	public static void ResetPointers(Gjk3D.SimplexDataPointers3D* ptrs, Gjk3D.SimplexData3D* simplex) { }
}
