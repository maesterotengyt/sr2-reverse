// Namespace: 
public struct MapNavMeshBaker.Vector3Double // TypeDefIndex: 3830
{
	// Fields
	public double X; // 0x0
	public double Y; // 0x8
	public double Z; // 0x10

	// Methods

	// RVA: 0x66FBF0 Offset: 0x66E1F0 VA: 0x18066FBF0
	public void .ctor(double x, double y, double z) { }

	// RVA: 0x66FC20 Offset: 0x66E220 VA: 0x18066FC20
	public void .ctor(FPVector3 v) { }

	// RVA: 0x66FC00 Offset: 0x66E200 VA: 0x18066FC00
	public void .ctor(Vector3 v) { }

	// RVA: 0x66FCE0 Offset: 0x66E2E0 VA: 0x18066FCE0
	public static MapNavMeshBaker.Vector3Double op_Subtraction(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x66FC60 Offset: 0x66E260 VA: 0x18066FC60
	public static MapNavMeshBaker.Vector3Double op_Addition(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x66FCA0 Offset: 0x66E2A0 VA: 0x18066FCA0
	public static MapNavMeshBaker.Vector3Double op_Multiply(MapNavMeshBaker.Vector3Double a, double b) { }

	// RVA: 0x66FCC0 Offset: 0x66E2C0 VA: 0x18066FCC0
	public static MapNavMeshBaker.Vector3Double op_Multiply(double b, MapNavMeshBaker.Vector3Double a) { }

	// RVA: 0x66F440 Offset: 0x66DA40 VA: 0x18066F440
	public FPVector3 AsFPVector() { }

	// RVA: 0x66FB10 Offset: 0x66E110 VA: 0x18066FB10
	public double SqrMagnitude() { }

	// RVA: 0x66F9C0 Offset: 0x66DFC0 VA: 0x18066F9C0
	public void Normalize() { }

	// RVA: 0x66FB40 Offset: 0x66E140 VA: 0x18066FB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x66F990 Offset: 0x66DF90 VA: 0x18066F990
	public static double Dot(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x66F930 Offset: 0x66DF30 VA: 0x18066F930
	public static MapNavMeshBaker.Vector3Double Cross(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x66F4C0 Offset: 0x66DAC0 VA: 0x18066F4C0
	public static double ClosestDistanceToTriangle(MapNavMeshBaker.Vector3Double p, MapNavMeshBaker.Vector3Double v0, MapNavMeshBaker.Vector3Double v1, MapNavMeshBaker.Vector3Double v2, ref MapNavMeshBaker.Vector3Double closestPoint) { }
}
