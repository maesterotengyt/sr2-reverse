// Namespace: 
private struct Gjk2D.SeparationFunction2D // TypeDefIndex: 11935
{
	// Fields
	private Gjk2D.SeparationFunction2D.ClosestFeatures _closestFeatures; // 0x0
	private FPVector2 _separationAxis; // 0x8
	private Entry2D* _entry; // 0x18
	private Entry2D* _edgeEntry; // 0x20
	private FPVector2 _comPoint; // 0x28
	private FPVector2 _comOffsetPoint; // 0x38
	private FPVector2 _edgeComPoint; // 0x48
	private FPVector2 _edgeComOffsetPoint; // 0x58

	// Methods

	// RVA: 0x2277E00 Offset: 0x2276400 VA: 0x182277E00
	public void Initialize(Gjk2D.SimplexDataPointers2D* ptrs, Entry2D* entryA, Entry2D* entryB, FP deltaTime, int dtBitshift) { }

	// RVA: 0x227DD70 Offset: 0x227C370 VA: 0x18227DD70
	public FP GetMinimumSeparation(FP deltaTime, int dtBitshift) { }

	// RVA: 0x2277A50 Offset: 0x2276050 VA: 0x182277A50
	public FP GetSeparation(FP deltaTime, int dtBitshift) { }
}
