// Namespace: Quantum.Physics2D
internal struct CollisionManifold2D // TypeDefIndex: 11975
{
	// Fields
	public const int MAX_CONTACT_POINTS = 2;
	public const int SIZE = 120;
	internal const int MANIFOLD_DATA_OFFSET = 0;
	private ManifoldData2D _m; // 0x0
	private const int FIRST_INT_OFFSET = 24;
	private CollisionManifold2D.Flags _flags; // 0x1C
	private int _contactPointsCount; // 0x20
	private int _constraintDataIdx; // 0x24
	private const int FIRST_FP_OFFSET = 40;
	public FP Penetration; // 0x28
	public FP CombinedRestitution; // 0x30
	public FP CombinedStaticFriction; // 0x38
	public FP CombinedDynamicFriction; // 0x40
	private const int FIRST_VECTOR2_OFFSET = 72;
	public FPVector2 Normal; // 0x48
	private const int CONTACT_POINTS_OFFSET = 88;
	private const int CONTACT_POINTS_SIZE = 32;
	[FixedBuffer(typeof(byte), 32)]
	internal CollisionManifold2D.<_contactPoints>e__FixedBuffer _contactPoints; // 0x58

	// Properties
	public int EntryIndexA { get; }
	public int EntryIndexB { get; }
	public bool Ignore { get; set; }
	public bool IsDynamic { get; }
	public bool UsesCcd { get; }
	public FP TimeOfImpact { get; set; }
	public bool Solved { set; }
	public bool NormalInverted { get; set; }
	public int ContactPointsCount { get; }
	public int ConstraintDataIndex { get; set; }

	// Methods

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40
	public int get_EntryIndexA() { }

	// RVA: 0xE03F60 Offset: 0xE02560 VA: 0x180E03F60
	public int get_EntryIndexB() { }

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	public bool get_Ignore() { }

	// RVA: 0x2207790 Offset: 0x2205D90 VA: 0x182207790
	public void set_Ignore(bool value) { }

	// RVA: 0x2207760 Offset: 0x2205D60 VA: 0x182207760
	public bool get_IsDynamic() { }

	// RVA: 0x2207780 Offset: 0x2205D80 VA: 0x182207780
	public bool get_UsesCcd() { }

	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public FP get_TimeOfImpact() { }

	// RVA: 0x880DF0 Offset: 0x87F3F0 VA: 0x180880DF0
	public void set_TimeOfImpact(FP value) { }

	// RVA: 0x22077D0 Offset: 0x2205DD0 VA: 0x1822077D0
	public void set_Solved(bool value) { }

	// RVA: 0x2207770 Offset: 0x2205D70 VA: 0x182207770
	public bool get_NormalInverted() { }

	// RVA: 0x22077B0 Offset: 0x2205DB0 VA: 0x1822077B0
	public void set_NormalInverted(bool value) { }

	// RVA: 0x6677B0 Offset: 0x665DB0 VA: 0x1806677B0
	public int get_ContactPointsCount() { }

	// RVA: 0x682110 Offset: 0x680710 VA: 0x180682110
	public int get_ConstraintDataIndex() { }

	// RVA: 0x847EC0 Offset: 0x8464C0 VA: 0x180847EC0
	public void set_ConstraintDataIndex(int value) { }

	// RVA: 0x2207740 Offset: 0x2205D40 VA: 0x182207740
	public void SetEntries(Scene2D* scene, int entryIdxA, int entryIdxB, bool updateCachedState = True) { }

	// RVA: 0x2207720 Offset: 0x2205D20 VA: 0x182207720
	public Entry2D* GetEntryA(Scene2D* scene) { }

	// RVA: 0x2207730 Offset: 0x2205D30 VA: 0x182207730
	public Entry2D* GetEntryB(Scene2D* scene) { }

	// RVA: 0x22076F0 Offset: 0x2205CF0 VA: 0x1822076F0
	public static FPVector2 GetContactPoint(CollisionManifold2D* manifold, int index) { }

	// RVA: 0x2207680 Offset: 0x2205C80 VA: 0x182207680
	public static FPVector2 GetAverageContactPoint(CollisionManifold2D* manifold) { }

	// RVA: 0x2207650 Offset: 0x2205C50 VA: 0x182207650
	public static void AddContactPoint(CollisionManifold2D* manifold, ref FPVector2 contact) { }
}
