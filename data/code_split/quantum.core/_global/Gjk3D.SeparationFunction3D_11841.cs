// Namespace: 
private struct Gjk3D.SeparationFunction3D // TypeDefIndex: 11841
{
	// Fields
	private Gjk3D.SeparationFunction3D.ClosestFeatures _closestFeatures; // 0x0
	private Gjk3D.SeparationFunction3D.EntriesDynamicState _dynamicState; // 0x4
	private FPVector3 _separationAxis; // 0x8
	private CollisionManifoldInfo3D _mInfo; // 0x20
	private Entry3D* _entry; // 0x40
	private Entry3D* _faceEntry; // 0x48
	private FPVector3 _comPoint; // 0x50
	private FPVector3 _comOffsetPoint; // 0x68
	private FPVector3 _faceComPoint; // 0x80
	private FPVector3 _faceComOffsetPoint; // 0x98

	// Methods

	// RVA: 0x2266470 Offset: 0x2264A70 VA: 0x182266470
	public void Initialize(Gjk3D.SimplexDataPointers3D* ptrs, CollisionManifoldInfo3D* mInfo, FP deltaTime, int dtBitshift) { }

	// RVA: 0x2265A20 Offset: 0x2264020 VA: 0x182265A20
	public FP GetMinimumSeparation(FP deltaTime, int dtBitshift) { }

	// RVA: 0x2233D40 Offset: 0x2232340 VA: 0x182233D40
	public FP GetSeparation(FP deltaTime, int dtBitshift) { }
}
