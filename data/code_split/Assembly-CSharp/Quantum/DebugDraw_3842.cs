// Namespace: Quantum
public static class DebugDraw // TypeDefIndex: 3842
{
	// Fields
	private static Queue<Draw.DebugRay> _rays; // 0x0
	private static Queue<Draw.DebugLine> _lines; // 0x8
	private static Queue<Draw.DebugCircle> _circles; // 0x10
	private static Queue<Draw.DebugSphere> _spheres; // 0x18
	private static Queue<Draw.DebugRectangle> _rectangles; // 0x20
	private static Queue<Draw.DebugBox> _boxes; // 0x28
	private static Dictionary<ColorRGBA, Material> _materials; // 0x30
	private static Draw.DebugRay[] _raysArray; // 0x38
	private static Draw.DebugLine[] _linesArray; // 0x40
	private static Draw.DebugCircle[] _circlesArray; // 0x48
	private static Draw.DebugSphere[] _spheresArray; // 0x50
	private static Draw.DebugRectangle[] _rectanglesArray; // 0x58
	private static Draw.DebugBox[] _boxesArray; // 0x60
	private static int _raysCount; // 0x68
	private static int _linesCount; // 0x6C
	private static int _circlesCount; // 0x70
	private static int _spheresCount; // 0x74
	private static int _rectanglesCount; // 0x78
	private static int _boxesCount; // 0x7C
	private static Mesh _solidSphere; // 0x80

	// Methods

	// RVA: 0x6595C0 Offset: 0x657BC0 VA: 0x1806595C0
	public static void Ray(Draw.DebugRay ray) { }

	// RVA: 0x659440 Offset: 0x657A40 VA: 0x180659440
	public static void Line(Draw.DebugLine line) { }

	// RVA: 0x656BE0 Offset: 0x6551E0 VA: 0x180656BE0
	public static void Circle(Draw.DebugCircle circle) { }

	// RVA: 0x6598C0 Offset: 0x657EC0 VA: 0x1806598C0
	public static void Sphere(Draw.DebugSphere sphere) { }

	// RVA: 0x659740 Offset: 0x657D40 VA: 0x180659740
	public static void Rectangle(Draw.DebugRectangle rectangle) { }

	// RVA: 0x656A40 Offset: 0x655040 VA: 0x180656A40
	public static void Box(Draw.DebugBox box) { }

	// RVA: 0x659000 Offset: 0x657600 VA: 0x180659000
	public static Material GetMaterial(ColorRGBA color) { }

	// RVA: 0x656D50 Offset: 0x655350 VA: 0x180656D50
	public static void Clear() { }

	// RVA: 0x659A30 Offset: 0x658030 VA: 0x180659A30
	public static void TakeAll() { }

	// RVA: 0x656F30 Offset: 0x655530 VA: 0x180656F30
	public static void DrawAll() { }

	// RVA: 0x658390 Offset: 0x656990 VA: 0x180658390
	private static void DrawRay(Draw.DebugRay ray) { }

	// RVA: 0x658250 Offset: 0x656850 VA: 0x180658250
	private static void DrawLine(Draw.DebugLine line) { }

	// RVA: 0x6592C0 Offset: 0x6578C0 VA: 0x1806592C0
	private static Mesh GetSphere() { }

	// RVA: 0x658C60 Offset: 0x657260 VA: 0x180658C60
	private static void DrawSphere(Draw.DebugSphere sphere) { }

	// RVA: 0x657F60 Offset: 0x656560 VA: 0x180657F60
	private static void DrawCircle(Draw.DebugCircle circle) { }

	// RVA: 0x6584D0 Offset: 0x656AD0 VA: 0x1806584D0
	private static void DrawRectangle(Draw.DebugRectangle rectangle) { }

	// RVA: 0x657560 Offset: 0x655B60 VA: 0x180657560
	private static void DrawBox(Draw.DebugBox box) { }

	// RVA: -1 Offset: -1
	private static int TakeAllFromQueueAndClearLocked<T>(Queue<T> queue, ref T[] result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB05C50 Offset: 0xB04250 VA: 0x180B05C50
	|-DebugDraw.TakeAllFromQueueAndClearLocked<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xB05730 Offset: 0xB03D30 VA: 0x180B05730
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugBox>
	|
	|-RVA: 0xB05900 Offset: 0xB03F00 VA: 0x180B05900
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugCircle>
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugSphere>
	|
	|-RVA: 0xB05AA0 Offset: 0xB040A0 VA: 0x180B05AA0
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugLine>
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugRay>
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugRectangle>
	*/

	// RVA: 0x659C10 Offset: 0x658210 VA: 0x180659C10
	private static void .cctor() { }
}
