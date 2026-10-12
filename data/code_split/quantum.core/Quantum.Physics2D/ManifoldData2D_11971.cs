// Namespace: Quantum.Physics2D
internal struct ManifoldData2D // TypeDefIndex: 11971
{
	// Fields
	public const int SIZE = 24;
	private ManifoldData2D.Flags _flags; // 0x0
	private int _entryIdxA; // 0x4
	private int _entryIdxB; // 0x8
	public FP TimeOfImpact; // 0x10

	// Properties
	public int EntryIndexA { get; }
	public int EntryIndexB { get; }
	public bool Ignore { get; set; }
	public bool IsDynamic { get; set; }
	public bool IsTrigger { get; set; }
	public bool UsesCcd { get; set; }

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

	// RVA: 0x22119C0 Offset: 0x220FFC0 VA: 0x1822119C0
	private void set_IsDynamic(bool value) { }

	// RVA: 0x22119B0 Offset: 0x220FFB0 VA: 0x1822119B0
	public bool get_IsTrigger() { }

	// RVA: 0x22119E0 Offset: 0x220FFE0 VA: 0x1822119E0
	public void set_IsTrigger(bool value) { }

	// RVA: 0x2207780 Offset: 0x2205D80 VA: 0x182207780
	public bool get_UsesCcd() { }

	// RVA: 0x2211A00 Offset: 0x2210000 VA: 0x182211A00
	private void set_UsesCcd(bool value) { }

	// RVA: 0x2207740 Offset: 0x2205D40 VA: 0x182207740
	public void SetEntries(Scene2D* scene, int entryIdxA, int entryIdxB, bool updateCachedState = True) { }

	// RVA: 0x21EA590 Offset: 0x21E8B90 VA: 0x1821EA590
	public void UpdateCachedState(Scene2D* scene) { }

	// RVA: 0x2207720 Offset: 0x2205D20 VA: 0x182207720
	public Entry2D* GetEntryA(Scene2D* scene) { }

	// RVA: 0x2207730 Offset: 0x2205D30 VA: 0x182207730
	public Entry2D* GetEntryB(Scene2D* scene) { }
}
