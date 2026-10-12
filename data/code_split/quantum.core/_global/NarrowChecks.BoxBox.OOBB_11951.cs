// Namespace: 
public struct NarrowChecks.BoxBox.OOBB // TypeDefIndex: 11951
{
	// Fields
	public FPVector2 UL; // 0x0
	public FPVector2 LL; // 0x10
	public FPVector2 UR; // 0x20
	public FPVector2 LR; // 0x30

	// Properties
	public FPVector2 Min { get; }
	public FPVector2 Max { get; }

	// Methods

	// RVA: 0xB72440 Offset: 0xB70A40 VA: 0x180B72440
	public FPVector2 get_Min() { }

	// RVA: 0x5EE1D0 Offset: 0x5EC7D0 VA: 0x1805EE1D0
	public FPVector2 get_Max() { }

	// RVA: 0x2201A90 Offset: 0x2200090 VA: 0x182201A90
	public bool InsideLocal(FPVector2 point) { }

	// RVA: 0x2201AC0 Offset: 0x22000C0 VA: 0x182201AC0
	internal FPVector2 NormalFromClosestFace(FPVector2 point) { }

	// RVA: 0x2201C00 Offset: 0x2200200 VA: 0x182201C00
	public void Set(FPVector2 extents) { }
}
