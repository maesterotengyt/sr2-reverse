// Namespace: Quantum
public struct GJKSettings // TypeDefIndex: 11669
{
	// Fields
	public const int SIZE = 24;
	internal short _simplexMinBitShift; // 0x0
	internal short _simplexMaxBitShift; // 0x2
	private int _shapeCastMaxIterations; // 0x4
	internal FP _shapeCastHardTolerance; // 0x8
	internal FP _shapeCastSoftTolerance; // 0x10

	// Properties
	public int SimplexMinBitShift { set; }
	public int SimplexMaxBitShift { set; }
	public int ShapeCastMaxIterations { get; set; }
	public FP ShapeCastHardTolerance { set; }
	public FP ShapeCastSoftTolerance { set; }

	// Methods

	// RVA: 0x221B360 Offset: 0x2219960 VA: 0x18221B360
	public void .ctor(PhysicsCommon.Config config) { }

	// RVA: 0x221B6C0 Offset: 0x2219CC0 VA: 0x18221B6C0
	public void set_SimplexMinBitShift(int value) { }

	// RVA: 0x221B650 Offset: 0x2219C50 VA: 0x18221B650
	public void set_SimplexMaxBitShift(int value) { }

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40
	public int get_ShapeCastMaxIterations() { }

	// RVA: 0x221B580 Offset: 0x2219B80 VA: 0x18221B580
	public void set_ShapeCastMaxIterations(int value) { }

	// RVA: 0x221B520 Offset: 0x2219B20 VA: 0x18221B520
	public void set_ShapeCastHardTolerance(FP value) { }

	// RVA: 0x221B5E0 Offset: 0x2219BE0 VA: 0x18221B5E0
	public void set_ShapeCastSoftTolerance(FP value) { }

	// RVA: 0x221B290 Offset: 0x2219890 VA: 0x18221B290
	public static void Serialize(GJKSettings* ptr, FrameSerializer serializer) { }
}
