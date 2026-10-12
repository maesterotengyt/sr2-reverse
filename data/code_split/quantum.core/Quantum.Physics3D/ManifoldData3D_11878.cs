// Namespace: Quantum.Physics3D
internal struct ManifoldData3D // TypeDefIndex: 11878
{
	// Fields
	public const int SIZE = 32;
	private ManifoldData3D.Flags _flags; // 0x0
	private int _entryIdxA; // 0x4
	private int _entryIdxB; // 0x8
	private int _triIdx; // 0xC
	public int NextInMesh; // 0x10
	public int BucketIndex; // 0x14
	public FP TimeOfImpact; // 0x18

	// Properties
	public int EntryIndexA { get; }
	public int EntryIndexB { get; }
	public int TriIndex { get; }
	public bool Ignore { get; set; }
	public bool IsDynamic { get; set; }
	public bool IsTrigger { get; set; }
	public bool UsesCcd { get; set; }

	// Methods

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40
	public int get_EntryIndexA() { }

	// RVA: 0xE03F60 Offset: 0xE02560 VA: 0x180E03F60
	public int get_EntryIndexB() { }

	// RVA: 0xB72460 Offset: 0xB70A60 VA: 0x180B72460
	public int get_TriIndex() { }

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

	// RVA: 0x2271D70 Offset: 0x2270370 VA: 0x182271D70
	public void SetEntries(Scene3D* scene, int entryIdxA, int entryIdxB, int triIdx = 0, bool updateCachedState = True) { }

	// RVA: 0x2242070 Offset: 0x2240670 VA: 0x182242070
	public void UpdateCachedState(Scene3D* scene) { }

	// RVA: 0x2271D50 Offset: 0x2270350 VA: 0x182271D50
	public Entry3D* GetEntryA(Scene3D* scene) { }

	// RVA: 0x2271D60 Offset: 0x2270360 VA: 0x182271D60
	public Entry3D* GetEntryB(Scene3D* scene) { }
}
