// Namespace: BrainFailProductions.PolyFew.AsImpL.MathUtil
public class Vertex // TypeDefIndex: 4127
{
	// Fields
	private Vertex prevVertex; // 0x10
	private Vertex nextVertex; // 0x18
	private float triangleArea; // 0x20
	private bool triangleHasChanged; // 0x24
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <OriginalIndex>k__BackingField; // 0x34

	// Properties
	public Vector3 Position { get; set; }
	public int OriginalIndex { get; set; }
	public Vertex PreviousVertex { get; set; }
	public Vertex NextVertex { get; set; }
	public float TriangleArea { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6CE2E0 Offset: 0x6CC8E0 VA: 0x1806CE2E0
	public Vector3 get_Position() { }

	[CompilerGenerated]
	// RVA: 0x6CE460 Offset: 0x6CCA60 VA: 0x1806CE460
	private void set_Position(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x5061E0 Offset: 0x5047E0 VA: 0x1805061E0
	public int get_OriginalIndex() { }

	[CompilerGenerated]
	// RVA: 0x5061F0 Offset: 0x5047F0 VA: 0x1805061F0
	private void set_OriginalIndex(int value) { }

	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public Vertex get_PreviousVertex() { }

	// RVA: 0x6CE470 Offset: 0x6CCA70 VA: 0x1806CE470
	public void set_PreviousVertex(Vertex value) { }

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public Vertex get_NextVertex() { }

	// RVA: 0x6CE440 Offset: 0x6CCA40 VA: 0x1806CE440
	public void set_NextVertex(Vertex value) { }

	// RVA: 0x6CE300 Offset: 0x6CC900 VA: 0x1806CE300
	public float get_TriangleArea() { }

	// RVA: 0x6CE2A0 Offset: 0x6CC8A0 VA: 0x1806CE2A0
	public void .ctor(int originalIndex, Vector3 position) { }

	// RVA: 0x6CE1D0 Offset: 0x6CC7D0 VA: 0x1806CE1D0
	public Vector2 GetPosOnPlane(Vector3 planeNormal) { }

	// RVA: 0x6CE0A0 Offset: 0x6CC6A0 VA: 0x1806CE0A0
	private void ComputeTriangleArea() { }
}
