// Namespace: Quantum.Physics3D
internal struct CollisionManifold3D // TypeDefIndex: 11882
{
	// Fields
	public const int MAX_CONTACT_POINTS = 4;
	public const int SIZE = 200;
	internal const int MANIFOLD_DATA_OFFSET = 0;
	private ManifoldData3D _m; // 0x0
	private const int FIRST_INT_OFFSET = 32;
	private CollisionManifold3D.Flags _flags; // 0x20
	private int _contactPointsCount; // 0x28
	private int _constraintDataIdx; // 0x2C
	private const int FIRST_FP_OFFSET = 48;
	public FP Penetration; // 0x30
	public FP CombinedRestitution; // 0x38
	public FP CombinedStaticFriction; // 0x40
	public FP CombinedDynamicFriction; // 0x48
	private const int FIRST_VECTOR3_OFFSET = 80;
	public FPVector3 Normal; // 0x50
	private const int CONTACT_POINTS_OFFSET = 104;
	private const int CONTACT_POINTS_SIZE = 96;
	[FixedBuffer(typeof(byte), 96)]
	internal CollisionManifold3D.<_contactPoints>e__FixedBuffer _contactPoints; // 0x68

	// Properties
	public int EntryIndexA { get; }
	public int EntryIndexB { get; }
	public int BucketIndex { get; set; }
	public int TriIndex { get; }
	public int NextInMesh { get; set; }
	public bool Ignore { get; set; }
	public bool IsDynamic { get; }
	public bool UsesCcd { get; }
	public FP TimeOfImpact { get; set; }
	public bool Solved { get; set; }
	public bool NormalInverted { get; set; }
	public int ContactPointsCount { get; }
	public int ConstraintDataIndex { get; set; }

	// Methods

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40
	public int get_EntryIndexA() { }

	// RVA: 0xE03F60 Offset: 0xE02560 VA: 0x180E03F60
	public int get_EntryIndexB() { }

	// RVA: 0x873B60 Offset: 0x872160 VA: 0x180873B60
	public int get_BucketIndex() { }

	// RVA: 0x873D00 Offset: 0x872300 VA: 0x180873D00
	public void set_BucketIndex(int value) { }

	// RVA: 0xB72460 Offset: 0xB70A60 VA: 0x180B72460
	public int get_TriIndex() { }

	// RVA: 0x502900 Offset: 0x500F00 VA: 0x180502900
	public int get_NextInMesh() { }

	// RVA: 0x520750 Offset: 0x51ED50 VA: 0x180520750
	public void set_NextInMesh(int value) { }

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	public bool get_Ignore() { }

	// RVA: 0x2207790 Offset: 0x2205D90 VA: 0x182207790
	public void set_Ignore(bool value) { }

	// RVA: 0x2207760 Offset: 0x2205D60 VA: 0x182207760
	public bool get_IsDynamic() { }

	// RVA: 0x2207780 Offset: 0x2205D80 VA: 0x182207780
	public bool get_UsesCcd() { }

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public FP get_TimeOfImpact() { }

	// RVA: 0x6569E0 Offset: 0x654FE0 VA: 0x1806569E0
	public void set_TimeOfImpact(FP value) { }

	// RVA: 0x2271DA0 Offset: 0x22703A0 VA: 0x182271DA0
	public bool get_Solved() { }

	// RVA: 0x2271DD0 Offset: 0x22703D0 VA: 0x182271DD0
	public void set_Solved(bool value) { }

	// RVA: 0x2271D90 Offset: 0x2270390 VA: 0x182271D90
	public bool get_NormalInverted() { }

	// RVA: 0x2271DB0 Offset: 0x22703B0 VA: 0x182271DB0
	public void set_NormalInverted(bool value) { }

	// RVA: 0x51AE40 Offset: 0x519440 VA: 0x18051AE40
	public int get_ContactPointsCount() { }

	// RVA: 0x668D90 Offset: 0x667390 VA: 0x180668D90
	public int get_ConstraintDataIndex() { }

	// RVA: 0x11DAC00 Offset: 0x11D9200 VA: 0x1811DAC00
	public void set_ConstraintDataIndex(int value) { }

	// RVA: 0x2271D70 Offset: 0x2270370 VA: 0x182271D70
	public void SetEntries(Scene3D* scene, int entryIdxA, int entryIdxB, int triIdx, bool updateCachedState = True) { }

	// RVA: 0x2271D50 Offset: 0x2270350 VA: 0x182271D50
	public Entry3D* GetEntryA(Scene3D* scene) { }

	// RVA: 0x2271D60 Offset: 0x2270360 VA: 0x182271D60
	public Entry3D* GetEntryB(Scene3D* scene) { }

	// RVA: 0x2271D10 Offset: 0x2270310 VA: 0x182271D10
	public static FPVector3 GetContactPoint(CollisionManifold3D* manifold, int index) { }

	// RVA: 0x2271C50 Offset: 0x2270250 VA: 0x182271C50
	public static FPVector3 GetAverageContactPoint(CollisionManifold3D* manifold) { }

	// RVA: 0x2271C10 Offset: 0x2270210 VA: 0x182271C10
	public static void AddContactPoint(CollisionManifold3D* manifold, ref FPVector3 contact) { }
}
