// Namespace: 
public static class NarrowChecks.BoxBox // TypeDefIndex: 11954
{
	// Methods

	// RVA: 0x21FD3D0 Offset: 0x21FB9D0 VA: 0x1821FD3D0
	public static bool Check(CollisionManifoldInfo2D* mInfo, bool detailedManifold) { }

	// RVA: 0x21FD670 Offset: 0x21FBC70 VA: 0x1821FD670
	private static bool Collision(NarrowChecks.BoxBox.Locals* locals, Entry2D* A, Entry2D* B) { }

	// RVA: 0x21FD4D0 Offset: 0x21FBAD0 VA: 0x1821FD4D0
	private static bool CollideOrdered(NarrowChecks.BoxBox.Locals* locals, Entry2D* A, Entry2D* B, bool flipped) { }

	// RVA: 0x21FD140 Offset: 0x21FB740 VA: 0x1821FD140
	private static void ChangeBase(NarrowChecks.BoxBox.OOBB* bShape, Entry2D* reference, Entry2D* target) { }

	// RVA: 0x21FDC80 Offset: 0x21FC280 VA: 0x1821FDC80
	private static bool Project(NarrowChecks.BoxBox.Locals* locals, FPVector2 axis, NarrowChecks.BoxBox.OOBB* other, bool flipped) { }

	// RVA: 0x21FD920 Offset: 0x21FBF20 VA: 0x1821FD920
	private static void FindContactPoint(NarrowChecks.BoxBox.Locals* locals, NarrowChecks.BoxBox.OOBB* a, NarrowChecks.BoxBox.OOBB* b, int flipped) { }

	// RVA: 0x21FDC20 Offset: 0x21FC220 VA: 0x1821FDC20
	private static bool Inside(FPVector2 point, NarrowChecks.BoxBox.OOBB* shape) { }
}
