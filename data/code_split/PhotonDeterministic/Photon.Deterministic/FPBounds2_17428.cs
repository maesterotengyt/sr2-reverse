// Namespace: Photon.Deterministic
[Serializable]
public struct FPBounds2 // TypeDefIndex: 17428
{
	// Fields
	public FPVector2 Center; // 0x0
	public FPVector2 Extents; // 0x10

	// Properties
	public FPVector2 Max { get; }
	public FPVector2 Min { get; }

	// Methods

	// RVA: 0x20A0B60 Offset: 0x209F160 VA: 0x1820A0B60
	public FPVector2 get_Max() { }

	// RVA: 0x20A0BA0 Offset: 0x209F1A0 VA: 0x1820A0BA0
	public FPVector2 get_Min() { }

	// RVA: 0x15C6020 Offset: 0x15C4620 VA: 0x1815C6020
	public void .ctor(FPVector2 center, FPVector2 extents) { }

	// RVA: 0x20A0A50 Offset: 0x209F050 VA: 0x1820A0A50
	public void Expand(FP amount) { }

	// RVA: 0x20A0AF0 Offset: 0x209F0F0 VA: 0x1820A0AF0
	public void SetMinMax(FPVector2 min, FPVector2 max) { }

	// RVA: 0x20A0950 Offset: 0x209EF50 VA: 0x1820A0950
	public void Encapsulate(FPVector2 point) { }

	// RVA: 0x20A0A90 Offset: 0x209F090 VA: 0x1820A0A90 Slot: 2
	public override int GetHashCode() { }
}
