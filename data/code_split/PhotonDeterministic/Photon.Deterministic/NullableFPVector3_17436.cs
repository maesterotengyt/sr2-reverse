// Namespace: Photon.Deterministic
[Serializable]
public struct NullableFPVector3 // TypeDefIndex: 17436
{
	// Fields
	public const int SIZE = 32;
	public long _hasValue; // 0x0
	public FPVector3 _value; // 0x8

	// Properties
	public bool HasValue { get; }
	public FPVector3 Value { get; }

	// Methods

	// RVA: 0x20AAF70 Offset: 0x20A9570 VA: 0x1820AAF70
	public bool get_HasValue() { }

	// RVA: 0x20AAF80 Offset: 0x20A9580 VA: 0x1820AAF80
	public FPVector3 get_Value() { }

	// RVA: 0x20AAFF0 Offset: 0x20A95F0 VA: 0x1820AAFF0
	public static NullableFPVector3 op_Implicit(FPVector3 v) { }

	// RVA: 0x20AAF10 Offset: 0x20A9510 VA: 0x1820AAF10 Slot: 2
	public override int GetHashCode() { }
}
